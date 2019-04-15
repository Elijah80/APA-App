using APA;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace APAApp
{
    public partial class APARegistrationForm : Form
    {
        APADataEntities data;

        public APARegistrationForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            //add new player to database
            using (data = new APADataEntities())
            {
                bool validEmail = Regex.IsMatch(emailInputTB.Text,
                    @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]" +
                    @"*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
                try
                {       

                    if (passwordInputTB.Text != confirmPasswordTB.Text)
                    {
                        passwordInputTB.Clear();
                        confirmPasswordTB.Clear();
                        MessageBox.Show("Passwords do no match. Please try again.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        passwordInputTB.Focus();
                    }
                    else if (!validEmail)
                    {
                        emailInputTB.Clear();
                        MessageBox.Show("Please enter a valid email", "Invalid Email",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        emailInputTB.Focus();
                    }
                    else
                    {
                        Player player = new Player()
                        {
                            PlayerFirstName = firstNameInputTB.Text,
                            PlayerLastName = lastNameInputTB.Text,
                            Address = address1InputTB.Text + ", " +
                                address2InputTB.Text,

                            City = cityInputTB.Text,
                            State = stateComboBox.Text,
                            Zip = zipInputTB.Text,
                            PlayerPhone = phoneInputTB.Text,
                            PlayerEmail = emailInputTB.Text,
                            CardNumber = cardInputTB.Text,
                            CardExpDate = cardExpTB.Text,
                            CVC = cvcTB.Text,
                            PlayerDivNumber = 000,
                            MatchesPlayed = 0,
                            PlayerNumber = NewPlayerNumber(),
                            PlayerPassword = confirmPasswordTB.Text,
                            SkillLevel = 3,
                            Status = "Player",
                            PlayerTeamNumber = 00
                        };

                        data.Players.Add(player);
                        data.SaveChanges();

                        registrationStatusLabel.Text = "Successfully registered";

                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private int NewPlayerNumber()
        {
            int maxNumber = data.Players.Max(num => num.PlayerNumber);

            return maxNumber + 1;
        }
    }
}
