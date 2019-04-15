using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using APA;

namespace APAApp
{
    public partial class APADivRepForm : Form
    {
        //object, variable and Entity declaration
        private readonly string drEmail;
        APADivRepInfo divRepInfo;
        APADataEntities data = new APADataEntities();

        public APADivRepForm(dynamic divRep)
        {
            InitializeComponent();
            drEmail = divRep.DivRepEmail;
        }

        private void APADivRepForm_Load(object sender, EventArgs e)
        {
            //pass the email to APADivRepInfo class and initialize divRepInfo object
            //with the info based on the matching email
            divRepInfo = new APADivRepInfo(drEmail);

            //assign found value of divRepInfo first name and last name to welcome text to personalize
            //the form for the user
            welcomeTB.Text = "Welcome " + divRepInfo.FirstName + " " + divRepInfo.LastName + "!";

            //set attributes of tabPage so that tabs do not show
            Size itemSize = new Size(0, 1);
            divRepTC.ItemSize = itemSize;
            divRepTC.Multiline = true;
            divRepTC.SizeMode = TabSizeMode.Fixed;

            //hide tab control upon form load
            divRepTC.Hide();

        }

        //event handler for when the user clicks on personal info under view on the menu
        private void personalInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //show tab control and personalInfoTab
            divRepTC.Show();
            personalInfoTab.Show();
            divRepStatusLabel.Text = null;

            //assign values to text boxes based on information in divRepInfo object
            firstNameTB.Text = divRepInfo.FirstName;
            lastNameTB.Text = divRepInfo.LastName;
            phoneTB.Text = divRepInfo.Phone;
            emailTB.Text = divRepInfo.Email;
            passwordTB.Text = divRepInfo.Password;
            divNumTB.Text = divRepInfo.DivNumber.ToString();
        }

        //event handler for when the user clicks on teams under division info under
        //view on the menu
        private void teamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hide all tabs irrelevant to the teams tab to ensure that the teams tabPage
            //will be the one to display
            personalInfoTab.Hide();
            divPlayersTab.Hide();
            divCaptainsTab.Hide();
            divRepStatusLabel.Text = null;

            divRepTC.Show();
            divTeamsTab.Show();

            GetDivisionTeams();            
        }

        //event handler for when the user clicks on players under division info under
        //view on the menu
        private void playersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hide all tabs irrelevant to the players tab to ensure that the players tabPage
            //will be the one to display
            personalInfoTab.Hide();
            divTeamsTab.Hide();
            divCaptainsTab.Hide();
            divRepStatusLabel.Text = null;

            divRepTC.Show();
            divPlayersTab.Show();

            //load players table using data entity and query data to get the correct players
            //to display in the playerDatGridView
            data.Players.Load();
            playerBindingSource.DataSource = data.Players.Local.ToBindingList()
                .Where(p => p.PlayerDivNumber == divRepInfo.DivNumber && p.Status == "Player");
            playerDataGridView.DataSource = playerBindingSource;
        }

        //event handler for when the user clicks on captains under division info under
        //view on the menu
        private void captainsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hid all tabs irrelevant to the captains tab to ensure that the captains tabPage
            //will be the one to display
            personalInfoTab.Hide();
            divTeamsTab.Hide();
            divPlayersTab.Hide();
            divRepStatusLabel.Text = null;

            divRepTC.Show();
            divCaptainsTab.Show();

            //reload the players table using data entity to get perform a new query to get the
            //correct captains to display in the divCaptainDataGridView
            data.Players.Load();
            playerBindingSource.DataSource = data.Players.Local.ToBindingList()
                .Where(p => p.PlayerDivNumber == divRepInfo.DivNumber && p.Status == "Captain");
            divCaptainDataGridView.DataSource = playerBindingSource;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //event handler for when the user clicks on the update button that will update
        //their information in the database based on the values in the text boxes
        private void updateInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                //load division reps table to declare as well as declare and initialize a DivisionRep 
                //object with the current user
                data.DivisionReps.Load();
                DivisionRep dr = data.DivisionReps.Local.Where(d => d.DivRepEmail == drEmail).SingleOrDefault();

                //assign new values in local database with values from text boxes
                dr.DivRepEmail = emailTB.Text;
                dr.DivRepFirstName = firstNameTB.Text;
                dr.DivRepLastName = lastNameTB.Text;
                dr.DivRepPassword = passwordTB.Text;
                dr.DivRepPhone = phoneTB.Text;

                //database checks for any modified values in the database and changes those values
                //and then save the changes made to the database
                data.Entry(dr).State = EntityState.Modified;
                data.SaveChanges();

                //display a message in the status strip to inform that changes were successful
                divRepStatusLabel.Text = "Changes updated successfully";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                divRepStatusLabel.Text = "Changes were not made";
            }
        }

        //event handler for when the user clicks on the update team button that will update
        //team information in the database
        private void updateTeamButton_Click(object sender, EventArgs e)
        {
            try
            {
                //save changes to the local database
                data.SaveChanges();

                divRepStatusLabel.Text = "Team Information updated successfully";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                divRepStatusLabel.Text = "Team Information was not updated";
            }
        }

        //event handler for when the user clicks on the delete button after the user
        //as selected the row for the team the user wants to delete
        private void deleteTeamButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected row or rows?", "Are you sure?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in teamDataGridView.SelectedRows)
                    {
                        teamDataGridView.Rows.RemoveAt(row.Index);
                    }

                    data.SaveChanges();
                    divRepStatusLabel.Text = "Team successfully deleted";
                }
                else
                    teamDataGridView.ClearSelection();
            }
            catch (Exception)
            {
                MessageBox.Show("You must have at least one row selected to be able to delete.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        //method to display teams in the grid view
        private void GetDivisionTeams()
        {
            //load teams table using data entity and query data to get the correct teams
            //to display in the teamDataGridView
            data.Teams.Load();
            teamBindingSource.DataSource = data.Teams.Local.ToBindingList()
                .Where(t => t.TeamNumber / 100 == divRepInfo.DivNumber);
            teamDataGridView.DataSource = teamBindingSource;
        }
    }
}
