using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using APA;

namespace APAApp
{
    public partial class APAPlayerForm : Form
    {
        //objects needed to display correct info for the user that logged in
        private readonly string pEmail;
        private APADataEntities data = new APADataEntities();
        private APAPlayerInfo playerInfo;
        private APAPlayerInfo captainInfo;
        private APATeamInfo teamInfo;
        private APADivRepInfo divRepInfo;

        public APAPlayerForm(dynamic player)
        {
            InitializeComponent();
            pEmail = player.PlayerEmail;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }        

        //personalize form for the user and hide group boxes and buttons
        private void APAPlayerForm_Load(object sender, EventArgs e)
        {
            playerInfo = new APAPlayerInfo(pEmail);
            welcomeTB.Text = "Welcome " + playerInfo.FirstName + " " + playerInfo.LastName + "!";
            personalInfoGB.Hide();
            paymentInfoGB.Hide();
            leagueInfoGB.Hide();
            teamInfoGB.Hide();
            saveChangesButton.Hide();
            closeButton.Hide();
            playerStatusLabel.Text = null;
        }

        //upon clicking profile under view in the menu, show all group boxes and buttons
        //along with corresponding info
        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personalInfoGB.Show();
            paymentInfoGB.Show();
            leagueInfoGB.Show();
            teamInfoGB.Show();
            saveChangesButton.Show();
            closeButton.Show();

            //initialize objects to get info to be properly displayed
            teamInfo = new APATeamInfo(int.Parse(playerInfo.DivNumber.ToString() + "0" + playerInfo.TeamNumber.ToString()));
            divRepInfo = new APADivRepInfo(playerInfo.DivNumber);
            captainInfo = new APAPlayerInfo(playerInfo.TeamNumber);

            //assign values to all text boxes using objects
            addressTB.Text = playerInfo.Address;
            cityTB.Text = playerInfo.City;
            stateTB.Text = playerInfo.State;
            zipTB.Text = playerInfo.Zip;
            phoneTB.Text = playerInfo.Phone;
            emailTB.Text = playerInfo.Email;
            passwordTB.Text = playerInfo.Password;
            cardNumberTB.Text = playerInfo.CardNumber;
            cvcTB.Text = playerInfo.CVC;
            cardExpTB.Text = playerInfo.ExpDate;
            skillTB.Text = playerInfo.SkillLevel.ToString();
            matchesPlayedTB.Text = playerInfo.MatchesPlayed.ToString();
            divisionTB.Text = playerInfo.DivNumber.ToString();
            playerNumberTB.Text = playerInfo.PlayerNumber.ToString();
            statusTB.Text = playerInfo.Status;
            teamNumberTB.Text = playerInfo.TeamNumber.ToString();
            teamTB.Text = teamInfo.Name;
            teamLocationTB.Text = teamInfo.Location;
            divRepTB.Text = divRepInfo.FirstName + " " + divRepInfo.LastName;
            divRepPhoneTB.Text = divRepInfo.Phone;
            teamCaptainTB.Text = captainInfo.FirstName + " " + captainInfo.LastName;
            captainPhoneTB.Text = captainInfo.Phone;
        }

        //save changes to database if user updates anything in their personal information
        private void saveChangesButton_Click(object sender, EventArgs e)
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

                playerStatusLabel.Text = "Profile updated sucessfully";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }            
        }
    }
}
