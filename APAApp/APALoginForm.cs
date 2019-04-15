using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace APAApp
{
    public partial class APALoginForm : Form
    {
        private APA.APADataEntities data;

        public APALoginForm()
        {
            InitializeComponent();
        }

        private void forgotLoginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This feature is currently under development", "Under Development",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (APARegistrationForm register = new APARegistrationForm())
            {
                Hide();
                register.ShowDialog(this);
            }
            Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            using (data = new APA.APADataEntities())
            {
                //query for player credentials
                data.Players.Load();
                var player = data.Players
                    .Select(p => new { p.PlayerEmail, p.PlayerPassword, p.PlayerFirstName, p.PlayerLastName, p.Status });

                //query for division rep credentials
                data.DivisionReps.Load();
                var divRep = data.DivisionReps
                    .Select(dr => new { dr.DivRepEmail, dr.DivRepPassword, dr.DivRepFirstName, dr.DivRepLastName });

                dynamic validPlayer = null;
                dynamic validDivRep = null;
                string firstName = null;
                string lastName = null;
                string status = null;

                //query player's table to be able to validate user's email and password
                foreach (var p in player)
                {
                    if (p.PlayerEmail == loginEmailTB.Text && p.PlayerPassword == loginPasswordTB.Text)
                    {
                        validPlayer = p;
                        firstName = p.PlayerFirstName;
                        lastName = p.PlayerLastName;
                        status = p.Status;
                        break;
                    }
                }

                //query division rep table to be able to validate email and password
                foreach (var dr in divRep)
                {
                    if (dr.DivRepEmail == loginEmailTB.Text && dr.DivRepPassword == loginPasswordTB.Text)
                    {
                        validDivRep = dr;
                        firstName = dr.DivRepFirstName;
                        lastName = dr.DivRepLastName;
                        break;
                    }
                }

                //validate user logging in
                if (loginEmailTB.Text.ToLower() == "admin" && loginPasswordTB.Text.ToLower() == "password")
                {
                    //send user to admin form
                    using (APAAdminForm admin = new APAAdminForm())
                    {
                        Hide();
                        admin.ShowDialog(this);
                    }
                    Show();
                }
                else if (validPlayer != null)
                {
                    if (status == "Player")
                    {
                        //send user to player form
                        using (APAPlayerForm apaPlayer = new APAPlayerForm(validPlayer))
                        {
                            Hide();
                            apaPlayer.ShowDialog(this);
                        }
                        Show();
                    }
                    else if (status == "Captain")
                    {
                        //send user to captain form
                        using (APACaptainForm apaCaptain = new APACaptainForm(validPlayer))
                        {
                            Hide();
                            apaCaptain.ShowDialog(this);
                        }
                        Show();
                    }
                }
                else if (validDivRep != null)
                {
                    //send user to division rep form
                    using (APADivRepForm repForm = new APADivRepForm(validDivRep))
                    {
                        Hide();
                        repForm.ShowDialog(this);
                    }
                    Show();
                }
                else
                {
                    MessageBox.Show("Invalid Email and/or Password. Please try again.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loginEmailTB.Focus();
                }

                loginEmailTB.Clear();
                loginPasswordTB.Clear();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
