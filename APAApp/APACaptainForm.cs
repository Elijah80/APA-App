using System;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using APA;

namespace APAApp
{
    public partial class APACaptainForm : Form
    {
        //objects needed to display correct info for the user that logged in
        private readonly string pEmail;
        private APADataEntities data = new APADataEntities();
        private APAPlayerInfo playerInfo;
        private APADivRepInfo divRepInfo;
        private APATeamInfo teamInfo;

        public APACaptainForm(dynamic captain)
        {
            InitializeComponent();
            pEmail = captain.PlayerEmail;
        }

        private void APACaptainForm_Load(object sender, EventArgs e)
        {
            //pass the email to APAPlayerInfo class and initialize playerInfo object
            //with the info based on the matching email
            playerInfo = new APAPlayerInfo(pEmail);            

            //Assign text to welcomeTB text box to personalize the form for the user
            welcomeTB.Text = "Welcome " + playerInfo.FirstName + " " + playerInfo.LastName + "!";

            //set attributes of tabPage so that tabs do not show
            Size itemSize = new Size(0, 1);
            captainFormTC.ItemSize = itemSize;
            captainFormTC.Multiline = true;
            captainFormTC.SizeMode = TabSizeMode.Fixed;

            //hide group boxes and tab pages so the user starts with an empty page
            personalInfoGB.Hide();
            paymentInfoGB.Hide();
            personalInfoTab.Hide();
            divisionInfoTab.Hide();
            teamInfoTab.Hide();
            newPlayersTab.Hide();
            updateButton.Hide();
            addButton.Hide();
            deleteButton.Hide();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        //event handler for when the user clicks on profile under view on the menu strip
        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            captainStatusLabel.Text = null;

            //show correct tabPage and buttons and groupboxes
            personalInfoTab.Show();
            updateButton.Show();
            personalInfoGB.Show();
            paymentInfoGB.Show();

            //assign values to textboxes with values from playerInfo object
            addressTB.Text = playerInfo.Address;
            cityTB.Text = playerInfo.City;
            stateTB.Text = playerInfo.State;
            zipTB.Text = playerInfo.Zip;
            phoneTB.Text = playerInfo.Phone;
            emailTB.Text = playerInfo.Email;
            passwordTB.Text = playerInfo.Password;
            statusTB.Text = playerInfo.Status;
            matchesPlayedTB.Text = playerInfo.MatchesPlayed.ToString();
            cardNumberTB.Text = playerInfo.CardNumber;
            cardExpTB.Text = playerInfo.ExpDate;
            cvcTB.Text = playerInfo.CVC;
        }

        //even handler for when the user clicks on division info under view on the menu strip
        private void leagueInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            captainStatusLabel.Text = null;

            //pass the division number from the playerInfo object to APADivRepInfo class and
            //assign the values to divRepInfo object
            divRepInfo = new APADivRepInfo(playerInfo.DivNumber);

            //hide any open tab pages
            personalInfoTab.Hide();
            teamInfoTab.Hide();
            newPlayersTab.Hide();

            //show the divisionInfoTab page
            divisionInfoTab.Show();

            //assign values to textBoxes using values from playerInfo object and divRepInfo object
            playerNumberTB.Text = playerInfo.PlayerNumber.ToString();
            skillTB.Text = playerInfo.SkillLevel.ToString();
            divisionTB.Text = playerInfo.DivNumber.ToString();
            divRepTB.Text = divRepInfo.FirstName + " " + divRepInfo.LastName;
            divRepPhoneTB.Text = divRepInfo.Phone;
        }

        //event handler for when the user clicks on team info under view on the menu strip
        private void teamInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            captainStatusLabel.Text = null;

            //pass a int parsed value made of the DivNumber and TeamNumber from playerInfo object so that the
            //correct team info can be assigned to the teamInfo object
            teamInfo = new APATeamInfo(int.Parse(playerInfo.DivNumber.ToString() + "0" + playerInfo.TeamNumber.ToString()));

            //hide any open tabs
            personalInfoTab.Hide();
            divisionInfoTab.Hide();
            newPlayersTab.Hide();

            //show teamInfo tab and deleteButton
            teamInfoTab.Show();
            deleteButton.Show();

            //assign values to textboxes using values from playerInfo and teamInfo objects
            teamNumberTB.Text = playerInfo.TeamNumber.ToString();
            teamTB.Text = teamInfo.Name;
            teamLocationTB.Text = teamInfo.Location;
            teamPointsTB.Text = teamInfo.Points.ToString();

            //invoke method to display current players in rosterGridView
            LoadCurrentPlayers();
        }

        //event handler for when the user clicks new players on the toolstripmenu
        private void newPlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            captainStatusLabel.Text = null;

            //hide any open tabs
            personalInfoTab.Hide();
            divisionInfoTab.Hide();
            teamInfoTab.Hide();

            //show newPlayers tab page and add button
            newPlayersTab.Show();
            addButton.Show();

            //invoke method to display new players in newPlayersGridView
            LoadNewPlayers();
        }

        //event handler for when the user clicks on keep score on the menu strip
        private void keepScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //send user to the form to keep score
            using(APA8BallScoresheetForm scoreSheet = new APA8BallScoresheetForm())
            {
                Hide();
                scoreSheet.ShowDialog(this);
            }
            Show();
            //MessageBox.Show("Scoring is currently under development", "Under Development",
                //MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //event handler when user clicks on the update button
        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //load the players table to declare and initialize a Player object with the
                //current user
                data.Players.Load();
                Player user = data.Players.Local.Where(u => u.PlayerEmail == pEmail).SingleOrDefault();

                //assign new values from text boxes to values in the database
                user.Address = addressTB.Text;
                user.City = cityTB.Text;
                user.State = stateTB.Text;
                user.Zip = zipTB.Text;
                user.PlayerPhone = phoneTB.Text;
                user.PlayerEmail = emailTB.Text;
                user.PlayerPassword = passwordTB.Text;
                user.CardNumber = cardNumberTB.Text;
                user.CardExpDate = cardExpTB.Text;
                user.CVC = cvcTB.Text;

                //database checks for any modified values in the database and changes those values
                //and then save the changes made to the database
                data.Entry(user).State = EntityState.Modified;
                data.SaveChanges();
                captainStatusLabel.Text = "Changes updated successfully";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //event handler for when the user clicks the add button
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                //load the players table using data Entity oject
                data.Players.Load();

                //get the row number of the selected row in newPlayersGridView
                int rowIndex = newPlayersGridView.SelectedCells[0].RowIndex;

                //assign the information from the selected row to the DataGridViewRow row object
                DataGridViewRow row = newPlayersGridView.Rows[rowIndex];

                //parse the value of the value in the cell from the PlayerNumber column and assign to pNum
                int.TryParse(row.Cells["PlayerNumber"].Value.ToString(), out int pNum);

                if (pNum != -1)
                {
                    //assign the values of the local database where the PlayerNumber matches the single or default value of pNum
                    //and assign the values to the newPlayer object of the Player class from APADataEntities
                    Player newPlayer = data.Players.Local.Where(n => n.PlayerNumber == pNum).SingleOrDefault();

                    //assign new values from the grid view to the values in the database
                    newPlayer.PlayerTeamNumber = playerInfo.TeamNumber;
                    newPlayer.PlayerDivNumber = playerInfo.DivNumber;

                    //check the database for any modifications to the data Entity and apply the
                    //changes to the data Entity and then save the changes to the data Entity
                    data.Entry(newPlayer).State = EntityState.Modified;
                    data.SaveChanges();

                    //invoke the method to refresh the view of the newPlayersGridView
                    LoadNewPlayers();

                    captainStatusLabel.Text = "Player added successfully";
                }
                else
                    MessageBox.Show("Player number is invalid or that player number does not exist",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //event handler for when the user clicks the delete button
        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                //load the players table using data Entity oject
                data.Players.Load();

                //get the row number of the selected row in newPlayersGridView
                int rowIndex = rosterGridView.SelectedCells[0].RowIndex;

                //assign the information from the selected row to the DataGridViewRow row object
                DataGridViewRow row = rosterGridView.Rows[rowIndex];

                //parse the value of the value in the cell from the pNumber column and assign to pNum
                int.TryParse(row.Cells["pNumber"].Value.ToString(), out int pNum);

                if (pNum != -1)
                {
                    //assign the values of the local database where the PlayerNumber matches the single or default value of pNum
                    //and assign the values to the oldPlayer object of the Player class from APADataEntities
                    Player oldPlayer = data.Players.Local.Where(n => n.PlayerNumber == pNum).SingleOrDefault();

                    //assign PlayerTeamNumber of oldPlayer object with a new value
                    oldPlayer.PlayerTeamNumber = 0;

                    //check the database for any modifications to the data Entity and apply the
                    //changes to the data Entity and then save the changes to the data Entity
                    data.Entry(oldPlayer).State = EntityState.Modified;
                    data.SaveChanges();

                    //invoke the method to refresh the view of the rosterPlayersGridView
                    LoadCurrentPlayers();

                    captainStatusLabel.Text = "Player removed successfully";
                }
                else
                    MessageBox.Show("Player number is invalid or that player number does not exist",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //method to load data from the database and query the Players table based off of
        //TeamNumber and Status conditions and then assign the values to the data source 
        //of the data grid view
        private void LoadCurrentPlayers()
        {
            data.Players.Load();
            playerBindingSource.DataSource = data.Players.Local.ToBindingList()
                .Where(p => p.PlayerTeamNumber == playerInfo.TeamNumber && p.Status == "Player");
            rosterGridView.DataSource = playerBindingSource;
        }

        //method to load data from the database and query the Players table based off of 
        //State and then assign the values to the data source of the data grid view
        private void LoadNewPlayers()
        {
            data.Players.Load();
            playerBindingSource.DataSource = data.Players.Local.ToBindingList()
                .Where(p => p.PlayerTeamNumber == 0 && p.State == playerInfo.State);
            rosterGridView.DataSource = playerBindingSource;
        }
    }
}
