namespace APAApp
{
    partial class APARegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APARegistrationForm));
            this.cancelButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.cvcTB = new System.Windows.Forms.TextBox();
            this.cardExpTB = new System.Windows.Forms.TextBox();
            this.cardInputTB = new System.Windows.Forms.TextBox();
            this.confirmPasswordTB = new System.Windows.Forms.TextBox();
            this.passwordInputTB = new System.Windows.Forms.TextBox();
            this.emailInputTB = new System.Windows.Forms.TextBox();
            this.phoneInputTB = new System.Windows.Forms.TextBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.zipInputTB = new System.Windows.Forms.TextBox();
            this.cityInputTB = new System.Windows.Forms.TextBox();
            this.address2InputTB = new System.Windows.Forms.TextBox();
            this.address1InputTB = new System.Windows.Forms.TextBox();
            this.lastNameInputTB = new System.Windows.Forms.TextBox();
            this.firstNameInputTB = new System.Windows.Forms.TextBox();
            this.cvcLabel = new System.Windows.Forms.Label();
            this.cardExpLabel = new System.Windows.Forms.Label();
            this.creditCardLabel = new System.Windows.Forms.Label();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.registrationStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(487, 207);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(119, 23);
            this.cancelButton.TabIndex = 88;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(357, 207);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(116, 23);
            this.registerButton.TabIndex = 87;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // cvcTB
            // 
            this.cvcTB.Location = new System.Drawing.Point(623, 168);
            this.cvcTB.Name = "cvcTB";
            this.cvcTB.Size = new System.Drawing.Size(49, 20);
            this.cvcTB.TabIndex = 86;
            // 
            // cardExpTB
            // 
            this.cardExpTB.Location = new System.Drawing.Point(523, 168);
            this.cardExpTB.Name = "cardExpTB";
            this.cardExpTB.Size = new System.Drawing.Size(57, 20);
            this.cardExpTB.TabIndex = 85;
            // 
            // cardInputTB
            // 
            this.cardInputTB.Location = new System.Drawing.Point(327, 168);
            this.cardInputTB.Name = "cardInputTB";
            this.cardInputTB.Size = new System.Drawing.Size(128, 20);
            this.cardInputTB.TabIndex = 84;
            // 
            // confirmPasswordTB
            // 
            this.confirmPasswordTB.Location = new System.Drawing.Point(540, 142);
            this.confirmPasswordTB.Name = "confirmPasswordTB";
            this.confirmPasswordTB.Size = new System.Drawing.Size(132, 20);
            this.confirmPasswordTB.TabIndex = 83;
            // 
            // passwordInputTB
            // 
            this.passwordInputTB.Location = new System.Drawing.Point(327, 142);
            this.passwordInputTB.Name = "passwordInputTB";
            this.passwordInputTB.Size = new System.Drawing.Size(110, 20);
            this.passwordInputTB.TabIndex = 82;
            // 
            // emailInputTB
            // 
            this.emailInputTB.Location = new System.Drawing.Point(525, 116);
            this.emailInputTB.Name = "emailInputTB";
            this.emailInputTB.Size = new System.Drawing.Size(147, 20);
            this.emailInputTB.TabIndex = 81;
            // 
            // phoneInputTB
            // 
            this.phoneInputTB.Location = new System.Drawing.Point(327, 116);
            this.phoneInputTB.Name = "phoneInputTB";
            this.phoneInputTB.Size = new System.Drawing.Size(151, 20);
            this.phoneInputTB.TabIndex = 80;
            // 
            // stateComboBox
            // 
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.stateComboBox.Location = new System.Drawing.Point(484, 90);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(47, 21);
            this.stateComboBox.TabIndex = 78;
            // 
            // zipInputTB
            // 
            this.zipInputTB.Location = new System.Drawing.Point(568, 90);
            this.zipInputTB.Name = "zipInputTB";
            this.zipInputTB.Size = new System.Drawing.Size(104, 20);
            this.zipInputTB.TabIndex = 79;
            // 
            // cityInputTB
            // 
            this.cityInputTB.Location = new System.Drawing.Point(327, 90);
            this.cityInputTB.Name = "cityInputTB";
            this.cityInputTB.Size = new System.Drawing.Size(110, 20);
            this.cityInputTB.TabIndex = 77;
            // 
            // address2InputTB
            // 
            this.address2InputTB.Location = new System.Drawing.Point(327, 64);
            this.address2InputTB.Name = "address2InputTB";
            this.address2InputTB.Size = new System.Drawing.Size(345, 20);
            this.address2InputTB.TabIndex = 76;
            // 
            // address1InputTB
            // 
            this.address1InputTB.Location = new System.Drawing.Point(327, 38);
            this.address1InputTB.Name = "address1InputTB";
            this.address1InputTB.Size = new System.Drawing.Size(345, 20);
            this.address1InputTB.TabIndex = 75;
            // 
            // lastNameInputTB
            // 
            this.lastNameInputTB.Location = new System.Drawing.Point(525, 12);
            this.lastNameInputTB.Name = "lastNameInputTB";
            this.lastNameInputTB.Size = new System.Drawing.Size(147, 20);
            this.lastNameInputTB.TabIndex = 74;
            // 
            // firstNameInputTB
            // 
            this.firstNameInputTB.Location = new System.Drawing.Point(327, 12);
            this.firstNameInputTB.Name = "firstNameInputTB";
            this.firstNameInputTB.Size = new System.Drawing.Size(128, 20);
            this.firstNameInputTB.TabIndex = 73;
            // 
            // cvcLabel
            // 
            this.cvcLabel.AutoSize = true;
            this.cvcLabel.Location = new System.Drawing.Point(586, 171);
            this.cvcLabel.Name = "cvcLabel";
            this.cvcLabel.Size = new System.Drawing.Size(31, 13);
            this.cvcLabel.TabIndex = 72;
            this.cvcLabel.Text = "CVC:";
            // 
            // cardExpLabel
            // 
            this.cardExpLabel.AutoSize = true;
            this.cardExpLabel.Location = new System.Drawing.Point(461, 171);
            this.cardExpLabel.Name = "cardExpLabel";
            this.cardExpLabel.Size = new System.Drawing.Size(56, 13);
            this.cardExpLabel.TabIndex = 71;
            this.cardExpLabel.Text = "Expiration:";
            // 
            // creditCardLabel
            // 
            this.creditCardLabel.AutoSize = true;
            this.creditCardLabel.Location = new System.Drawing.Point(261, 171);
            this.creditCardLabel.Name = "creditCardLabel";
            this.creditCardLabel.Size = new System.Drawing.Size(62, 13);
            this.creditCardLabel.TabIndex = 70;
            this.creditCardLabel.Text = "Credit Card:";
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(443, 145);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(94, 13);
            this.confirmPasswordLabel.TabIndex = 69;
            this.confirmPasswordLabel.Text = "Confirm Password:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(265, 145);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 68;
            this.passwordLabel.Text = "Password:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(484, 119);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 67;
            this.emailLabel.Text = "Email:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(280, 119);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(41, 13);
            this.phoneLabel.TabIndex = 66;
            this.phoneLabel.Text = "Phone:";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(537, 93);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(25, 13);
            this.zipLabel.TabIndex = 65;
            this.zipLabel.Text = "Zip:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(443, 93);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(35, 13);
            this.stateLabel.TabIndex = 64;
            this.stateLabel.Text = "State:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(294, 93);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 63;
            this.cityLabel.Text = "City:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(273, 41);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 13);
            this.addressLabel.TabIndex = 62;
            this.addressLabel.Text = "Address:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(461, 15);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 61;
            this.lastNameLabel.Text = "LastName:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(261, 15);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 60;
            this.firstNameLabel.Text = "First Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 182);
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrationStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 243);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(688, 22);
            this.statusStrip1.TabIndex = 90;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // registrationStatusLabel
            // 
            this.registrationStatusLabel.Name = "registrationStatusLabel";
            this.registrationStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // APARegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 265);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.cvcTB);
            this.Controls.Add(this.cardExpTB);
            this.Controls.Add(this.cardInputTB);
            this.Controls.Add(this.confirmPasswordTB);
            this.Controls.Add(this.passwordInputTB);
            this.Controls.Add(this.emailInputTB);
            this.Controls.Add(this.phoneInputTB);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.zipInputTB);
            this.Controls.Add(this.cityInputTB);
            this.Controls.Add(this.address2InputTB);
            this.Controls.Add(this.address1InputTB);
            this.Controls.Add(this.lastNameInputTB);
            this.Controls.Add(this.firstNameInputTB);
            this.Controls.Add(this.cvcLabel);
            this.Controls.Add(this.cardExpLabel);
            this.Controls.Add(this.creditCardLabel);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "APARegistrationForm";
            this.Text = "APA Registration";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox cvcTB;
        private System.Windows.Forms.TextBox cardExpTB;
        private System.Windows.Forms.TextBox cardInputTB;
        private System.Windows.Forms.TextBox confirmPasswordTB;
        private System.Windows.Forms.TextBox passwordInputTB;
        private System.Windows.Forms.TextBox emailInputTB;
        private System.Windows.Forms.TextBox phoneInputTB;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.TextBox zipInputTB;
        private System.Windows.Forms.TextBox cityInputTB;
        private System.Windows.Forms.TextBox address2InputTB;
        private System.Windows.Forms.TextBox address1InputTB;
        private System.Windows.Forms.TextBox lastNameInputTB;
        private System.Windows.Forms.TextBox firstNameInputTB;
        private System.Windows.Forms.Label cvcLabel;
        private System.Windows.Forms.Label cardExpLabel;
        private System.Windows.Forms.Label creditCardLabel;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel registrationStatusLabel;
    }
}