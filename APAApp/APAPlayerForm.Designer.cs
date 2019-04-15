namespace APAApp
{
    partial class APAPlayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APAPlayerForm));
            this.welcomeTB = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.teamNumberLabel = new System.Windows.Forms.Label();
            this.divNumberLabel = new System.Windows.Forms.Label();
            this.playerNumberLabel = new System.Windows.Forms.Label();
            this.cardNumberLabel = new System.Windows.Forms.Label();
            this.cardExpLabel = new System.Windows.Forms.Label();
            this.cvcLabel = new System.Windows.Forms.Label();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.cityTB = new System.Windows.Forms.TextBox();
            this.stateTB = new System.Windows.Forms.TextBox();
            this.zipTB = new System.Windows.Forms.TextBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.personalInfoGB = new System.Windows.Forms.GroupBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.paymentInfoGB = new System.Windows.Forms.GroupBox();
            this.cvcTB = new System.Windows.Forms.TextBox();
            this.cardExpTB = new System.Windows.Forms.TextBox();
            this.cardNumberTB = new System.Windows.Forms.TextBox();
            this.leagueInfoGB = new System.Windows.Forms.GroupBox();
            this.divRepPhoneTB = new System.Windows.Forms.TextBox();
            this.divRepPhoneLabel = new System.Windows.Forms.Label();
            this.divRepTB = new System.Windows.Forms.TextBox();
            this.divRepLabel = new System.Windows.Forms.Label();
            this.playerNumberTB = new System.Windows.Forms.TextBox();
            this.divisionTB = new System.Windows.Forms.TextBox();
            this.skillTB = new System.Windows.Forms.TextBox();
            this.skillLabel = new System.Windows.Forms.Label();
            this.teamTB = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.statusTB = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.matchesPlayedTB = new System.Windows.Forms.TextBox();
            this.matchesPlayedLabel = new System.Windows.Forms.Label();
            this.teamNumberTB = new System.Windows.Forms.TextBox();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.teamInfoGB = new System.Windows.Forms.GroupBox();
            this.captainPhoneTB = new System.Windows.Forms.TextBox();
            this.captainPhoneLabel = new System.Windows.Forms.Label();
            this.teamCaptainTB = new System.Windows.Forms.TextBox();
            this.teamCaptainLabel = new System.Windows.Forms.Label();
            this.teamLocationTB = new System.Windows.Forms.TextBox();
            this.teamLocationLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.playerStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.personalInfoGB.SuspendLayout();
            this.paymentInfoGB.SuspendLayout();
            this.leagueInfoGB.SuspendLayout();
            this.teamInfoGB.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeTB
            // 
            this.welcomeTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.welcomeTB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeTB.Location = new System.Drawing.Point(12, 27);
            this.welcomeTB.Name = "welcomeTB";
            this.welcomeTB.ReadOnly = true;
            this.welcomeTB.Size = new System.Drawing.Size(469, 28);
            this.welcomeTB.TabIndex = 1;
            this.welcomeTB.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(318, 281);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(741, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "playerMenuStrip";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(15, 34);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 13);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.Text = "Address:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(34, 60);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 4;
            this.cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(213, 60);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(35, 13);
            this.stateLabel.TabIndex = 5;
            this.stateLabel.Text = "State:";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(307, 60);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(25, 13);
            this.zipLabel.TabIndex = 6;
            this.zipLabel.Text = "Zip:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(22, 86);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(41, 13);
            this.phoneLabel.TabIndex = 7;
            this.phoneLabel.Text = "Phone:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(188, 86);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "Email:";
            // 
            // teamNumberLabel
            // 
            this.teamNumberLabel.AutoSize = true;
            this.teamNumberLabel.Location = new System.Drawing.Point(6, 27);
            this.teamNumberLabel.Name = "teamNumberLabel";
            this.teamNumberLabel.Size = new System.Drawing.Size(77, 13);
            this.teamNumberLabel.TabIndex = 9;
            this.teamNumberLabel.Text = "Team Number:";
            // 
            // divNumberLabel
            // 
            this.divNumberLabel.AutoSize = true;
            this.divNumberLabel.Location = new System.Drawing.Point(6, 72);
            this.divNumberLabel.Name = "divNumberLabel";
            this.divNumberLabel.Size = new System.Drawing.Size(87, 13);
            this.divNumberLabel.TabIndex = 10;
            this.divNumberLabel.Text = "Division Number:";
            // 
            // playerNumberLabel
            // 
            this.playerNumberLabel.AutoSize = true;
            this.playerNumberLabel.Location = new System.Drawing.Point(6, 27);
            this.playerNumberLabel.Name = "playerNumberLabel";
            this.playerNumberLabel.Size = new System.Drawing.Size(79, 13);
            this.playerNumberLabel.TabIndex = 11;
            this.playerNumberLabel.Text = "Player Number:";
            // 
            // cardNumberLabel
            // 
            this.cardNumberLabel.AutoSize = true;
            this.cardNumberLabel.Location = new System.Drawing.Point(6, 38);
            this.cardNumberLabel.Name = "cardNumberLabel";
            this.cardNumberLabel.Size = new System.Drawing.Size(62, 13);
            this.cardNumberLabel.TabIndex = 12;
            this.cardNumberLabel.Text = "Credit Card:";
            // 
            // cardExpLabel
            // 
            this.cardExpLabel.AutoSize = true;
            this.cardExpLabel.Location = new System.Drawing.Point(11, 64);
            this.cardExpLabel.Name = "cardExpLabel";
            this.cardExpLabel.Size = new System.Drawing.Size(57, 13);
            this.cardExpLabel.TabIndex = 13;
            this.cardExpLabel.Text = "Exp. Date:";
            // 
            // cvcLabel
            // 
            this.cvcLabel.AutoSize = true;
            this.cvcLabel.Location = new System.Drawing.Point(160, 64);
            this.cvcLabel.Name = "cvcLabel";
            this.cvcLabel.Size = new System.Drawing.Size(31, 13);
            this.cvcLabel.TabIndex = 14;
            this.cvcLabel.Text = "CVC:";
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(69, 31);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(341, 20);
            this.addressTB.TabIndex = 15;
            // 
            // cityTB
            // 
            this.cityTB.Location = new System.Drawing.Point(69, 57);
            this.cityTB.Name = "cityTB";
            this.cityTB.Size = new System.Drawing.Size(138, 20);
            this.cityTB.TabIndex = 16;
            // 
            // stateTB
            // 
            this.stateTB.Location = new System.Drawing.Point(254, 57);
            this.stateTB.Name = "stateTB";
            this.stateTB.Size = new System.Drawing.Size(47, 20);
            this.stateTB.TabIndex = 17;
            // 
            // zipTB
            // 
            this.zipTB.Location = new System.Drawing.Point(338, 57);
            this.zipTB.Name = "zipTB";
            this.zipTB.Size = new System.Drawing.Size(72, 20);
            this.zipTB.TabIndex = 18;
            // 
            // phoneTB
            // 
            this.phoneTB.Location = new System.Drawing.Point(69, 83);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(113, 20);
            this.phoneTB.TabIndex = 19;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(229, 83);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(181, 20);
            this.emailTB.TabIndex = 20;
            // 
            // personalInfoGB
            // 
            this.personalInfoGB.Controls.Add(this.passwordTB);
            this.personalInfoGB.Controls.Add(this.passwordLabel);
            this.personalInfoGB.Controls.Add(this.stateTB);
            this.personalInfoGB.Controls.Add(this.emailTB);
            this.personalInfoGB.Controls.Add(this.addressLabel);
            this.personalInfoGB.Controls.Add(this.cityLabel);
            this.personalInfoGB.Controls.Add(this.phoneLabel);
            this.personalInfoGB.Controls.Add(this.phoneTB);
            this.personalInfoGB.Controls.Add(this.addressTB);
            this.personalInfoGB.Controls.Add(this.cityTB);
            this.personalInfoGB.Controls.Add(this.stateLabel);
            this.personalInfoGB.Controls.Add(this.zipTB);
            this.personalInfoGB.Controls.Add(this.zipLabel);
            this.personalInfoGB.Controls.Add(this.emailLabel);
            this.personalInfoGB.Location = new System.Drawing.Point(13, 62);
            this.personalInfoGB.Name = "personalInfoGB";
            this.personalInfoGB.Size = new System.Drawing.Size(427, 138);
            this.personalInfoGB.TabIndex = 21;
            this.personalInfoGB.TabStop = false;
            this.personalInfoGB.Text = "Personal Information";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(68, 109);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(139, 20);
            this.passwordTB.TabIndex = 22;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(6, 112);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 21;
            this.passwordLabel.Text = "Password:";
            // 
            // paymentInfoGB
            // 
            this.paymentInfoGB.Controls.Add(this.cvcTB);
            this.paymentInfoGB.Controls.Add(this.cardExpTB);
            this.paymentInfoGB.Controls.Add(this.cardNumberTB);
            this.paymentInfoGB.Controls.Add(this.cvcLabel);
            this.paymentInfoGB.Controls.Add(this.cardNumberLabel);
            this.paymentInfoGB.Controls.Add(this.cardExpLabel);
            this.paymentInfoGB.Location = new System.Drawing.Point(446, 62);
            this.paymentInfoGB.Name = "paymentInfoGB";
            this.paymentInfoGB.Size = new System.Drawing.Size(283, 138);
            this.paymentInfoGB.TabIndex = 22;
            this.paymentInfoGB.TabStop = false;
            this.paymentInfoGB.Text = "Payment Information";
            // 
            // cvcTB
            // 
            this.cvcTB.Location = new System.Drawing.Point(197, 61);
            this.cvcTB.Name = "cvcTB";
            this.cvcTB.Size = new System.Drawing.Size(73, 20);
            this.cvcTB.TabIndex = 15;
            // 
            // cardExpTB
            // 
            this.cardExpTB.Location = new System.Drawing.Point(74, 61);
            this.cardExpTB.Name = "cardExpTB";
            this.cardExpTB.Size = new System.Drawing.Size(79, 20);
            this.cardExpTB.TabIndex = 14;
            // 
            // cardNumberTB
            // 
            this.cardNumberTB.Location = new System.Drawing.Point(74, 35);
            this.cardNumberTB.Name = "cardNumberTB";
            this.cardNumberTB.Size = new System.Drawing.Size(196, 20);
            this.cardNumberTB.TabIndex = 13;
            // 
            // leagueInfoGB
            // 
            this.leagueInfoGB.Controls.Add(this.divRepPhoneTB);
            this.leagueInfoGB.Controls.Add(this.divRepPhoneLabel);
            this.leagueInfoGB.Controls.Add(this.divRepTB);
            this.leagueInfoGB.Controls.Add(this.divRepLabel);
            this.leagueInfoGB.Controls.Add(this.playerNumberTB);
            this.leagueInfoGB.Controls.Add(this.divisionTB);
            this.leagueInfoGB.Controls.Add(this.playerNumberLabel);
            this.leagueInfoGB.Controls.Add(this.skillTB);
            this.leagueInfoGB.Controls.Add(this.divNumberLabel);
            this.leagueInfoGB.Controls.Add(this.skillLabel);
            this.leagueInfoGB.Location = new System.Drawing.Point(12, 206);
            this.leagueInfoGB.Name = "leagueInfoGB";
            this.leagueInfoGB.Size = new System.Drawing.Size(249, 161);
            this.leagueInfoGB.TabIndex = 23;
            this.leagueInfoGB.TabStop = false;
            this.leagueInfoGB.Text = "League Information";
            // 
            // divRepPhoneTB
            // 
            this.divRepPhoneTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.divRepPhoneTB.Location = new System.Drawing.Point(118, 118);
            this.divRepPhoneTB.Name = "divRepPhoneTB";
            this.divRepPhoneTB.ReadOnly = true;
            this.divRepPhoneTB.Size = new System.Drawing.Size(115, 13);
            this.divRepPhoneTB.TabIndex = 34;
            // 
            // divRepPhoneLabel
            // 
            this.divRepPhoneLabel.AutoSize = true;
            this.divRepPhoneLabel.Location = new System.Drawing.Point(7, 118);
            this.divRepPhoneLabel.Name = "divRepPhoneLabel";
            this.divRepPhoneLabel.Size = new System.Drawing.Size(104, 13);
            this.divRepPhoneLabel.TabIndex = 33;
            this.divRepPhoneLabel.Text = "Division Rep Phone:";
            // 
            // divRepTB
            // 
            this.divRepTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.divRepTB.Location = new System.Drawing.Point(83, 96);
            this.divRepTB.Name = "divRepTB";
            this.divRepTB.ReadOnly = true;
            this.divRepTB.Size = new System.Drawing.Size(150, 13);
            this.divRepTB.TabIndex = 33;
            // 
            // divRepLabel
            // 
            this.divRepLabel.AutoSize = true;
            this.divRepLabel.Location = new System.Drawing.Point(7, 96);
            this.divRepLabel.Name = "divRepLabel";
            this.divRepLabel.Size = new System.Drawing.Size(70, 13);
            this.divRepLabel.TabIndex = 30;
            this.divRepLabel.Text = "Division Rep:";
            // 
            // playerNumberTB
            // 
            this.playerNumberTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerNumberTB.Location = new System.Drawing.Point(91, 27);
            this.playerNumberTB.Name = "playerNumberTB";
            this.playerNumberTB.ReadOnly = true;
            this.playerNumberTB.Size = new System.Drawing.Size(79, 13);
            this.playerNumberTB.TabIndex = 29;
            // 
            // divisionTB
            // 
            this.divisionTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.divisionTB.Location = new System.Drawing.Point(99, 72);
            this.divisionTB.Name = "divisionTB";
            this.divisionTB.ReadOnly = true;
            this.divisionTB.Size = new System.Drawing.Size(75, 13);
            this.divisionTB.TabIndex = 28;
            // 
            // skillTB
            // 
            this.skillTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skillTB.Location = new System.Drawing.Point(70, 50);
            this.skillTB.Name = "skillTB";
            this.skillTB.ReadOnly = true;
            this.skillTB.Size = new System.Drawing.Size(34, 13);
            this.skillTB.TabIndex = 25;
            // 
            // skillLabel
            // 
            this.skillLabel.AutoSize = true;
            this.skillLabel.Location = new System.Drawing.Point(7, 50);
            this.skillLabel.Name = "skillLabel";
            this.skillLabel.Size = new System.Drawing.Size(58, 13);
            this.skillLabel.TabIndex = 24;
            this.skillLabel.Text = "Skill Level:";
            // 
            // teamTB
            // 
            this.teamTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.teamTB.Location = new System.Drawing.Point(80, 46);
            this.teamTB.Name = "teamTB";
            this.teamTB.ReadOnly = true;
            this.teamTB.Size = new System.Drawing.Size(163, 13);
            this.teamTB.TabIndex = 32;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Location = new System.Drawing.Point(6, 46);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(68, 13);
            this.teamNameLabel.TabIndex = 31;
            this.teamNameLabel.Text = "Team Name:";
            // 
            // statusTB
            // 
            this.statusTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusTB.Location = new System.Drawing.Point(51, 82);
            this.statusTB.Name = "statusTB";
            this.statusTB.ReadOnly = true;
            this.statusTB.Size = new System.Drawing.Size(100, 13);
            this.statusTB.TabIndex = 30;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(6, 82);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(40, 13);
            this.statusLabel.TabIndex = 24;
            this.statusLabel.Text = "Status:";
            // 
            // matchesPlayedTB
            // 
            this.matchesPlayedTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matchesPlayedTB.Location = new System.Drawing.Point(98, 101);
            this.matchesPlayedTB.Name = "matchesPlayedTB";
            this.matchesPlayedTB.ReadOnly = true;
            this.matchesPlayedTB.Size = new System.Drawing.Size(64, 13);
            this.matchesPlayedTB.TabIndex = 27;
            // 
            // matchesPlayedLabel
            // 
            this.matchesPlayedLabel.AutoSize = true;
            this.matchesPlayedLabel.Location = new System.Drawing.Point(6, 101);
            this.matchesPlayedLabel.Name = "matchesPlayedLabel";
            this.matchesPlayedLabel.Size = new System.Drawing.Size(86, 13);
            this.matchesPlayedLabel.TabIndex = 25;
            this.matchesPlayedLabel.Text = "Matches Played:";
            // 
            // teamNumberTB
            // 
            this.teamNumberTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.teamNumberTB.Location = new System.Drawing.Point(89, 27);
            this.teamNumberTB.Name = "teamNumberTB";
            this.teamNumberTB.ReadOnly = true;
            this.teamNumberTB.Size = new System.Drawing.Size(47, 13);
            this.teamNumberTB.TabIndex = 26;
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(302, 252);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(104, 23);
            this.saveChangesButton.TabIndex = 24;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // teamInfoGB
            // 
            this.teamInfoGB.Controls.Add(this.captainPhoneTB);
            this.teamInfoGB.Controls.Add(this.captainPhoneLabel);
            this.teamInfoGB.Controls.Add(this.teamCaptainTB);
            this.teamInfoGB.Controls.Add(this.teamCaptainLabel);
            this.teamInfoGB.Controls.Add(this.teamLocationTB);
            this.teamInfoGB.Controls.Add(this.teamLocationLabel);
            this.teamInfoGB.Controls.Add(this.teamNumberLabel);
            this.teamInfoGB.Controls.Add(this.teamTB);
            this.teamInfoGB.Controls.Add(this.teamNumberTB);
            this.teamInfoGB.Controls.Add(this.matchesPlayedLabel);
            this.teamInfoGB.Controls.Add(this.teamNameLabel);
            this.teamInfoGB.Controls.Add(this.matchesPlayedTB);
            this.teamInfoGB.Controls.Add(this.statusLabel);
            this.teamInfoGB.Controls.Add(this.statusTB);
            this.teamInfoGB.Location = new System.Drawing.Point(446, 206);
            this.teamInfoGB.Name = "teamInfoGB";
            this.teamInfoGB.Size = new System.Drawing.Size(283, 161);
            this.teamInfoGB.TabIndex = 33;
            this.teamInfoGB.TabStop = false;
            this.teamInfoGB.Text = "Team Information";
            // 
            // captainPhoneTB
            // 
            this.captainPhoneTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.captainPhoneTB.Location = new System.Drawing.Point(122, 139);
            this.captainPhoneTB.Name = "captainPhoneTB";
            this.captainPhoneTB.ReadOnly = true;
            this.captainPhoneTB.Size = new System.Drawing.Size(100, 13);
            this.captainPhoneTB.TabIndex = 38;
            // 
            // captainPhoneLabel
            // 
            this.captainPhoneLabel.AutoSize = true;
            this.captainPhoneLabel.Location = new System.Drawing.Point(6, 139);
            this.captainPhoneLabel.Name = "captainPhoneLabel";
            this.captainPhoneLabel.Size = new System.Drawing.Size(110, 13);
            this.captainPhoneLabel.TabIndex = 37;
            this.captainPhoneLabel.Text = "Team Captain Phone:";
            // 
            // teamCaptainTB
            // 
            this.teamCaptainTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.teamCaptainTB.Location = new System.Drawing.Point(88, 120);
            this.teamCaptainTB.Name = "teamCaptainTB";
            this.teamCaptainTB.ReadOnly = true;
            this.teamCaptainTB.Size = new System.Drawing.Size(155, 13);
            this.teamCaptainTB.TabIndex = 36;
            // 
            // teamCaptainLabel
            // 
            this.teamCaptainLabel.AutoSize = true;
            this.teamCaptainLabel.Location = new System.Drawing.Point(6, 120);
            this.teamCaptainLabel.Name = "teamCaptainLabel";
            this.teamCaptainLabel.Size = new System.Drawing.Size(76, 13);
            this.teamCaptainLabel.TabIndex = 35;
            this.teamCaptainLabel.Text = "Team Captain:";
            // 
            // teamLocationTB
            // 
            this.teamLocationTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.teamLocationTB.Location = new System.Drawing.Point(93, 65);
            this.teamLocationTB.Name = "teamLocationTB";
            this.teamLocationTB.ReadOnly = true;
            this.teamLocationTB.Size = new System.Drawing.Size(177, 13);
            this.teamLocationTB.TabIndex = 34;
            // 
            // teamLocationLabel
            // 
            this.teamLocationLabel.AutoSize = true;
            this.teamLocationLabel.Location = new System.Drawing.Point(6, 65);
            this.teamLocationLabel.Name = "teamLocationLabel";
            this.teamLocationLabel.Size = new System.Drawing.Size(81, 13);
            this.teamLocationLabel.TabIndex = 33;
            this.teamLocationLabel.Text = "Team Location:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 382);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(741, 22);
            this.statusStrip1.TabIndex = 34;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // playerStatusLabel
            // 
            this.playerStatusLabel.Name = "playerStatusLabel";
            this.playerStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // APAPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 404);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.teamInfoGB);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.leagueInfoGB);
            this.Controls.Add(this.paymentInfoGB);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.personalInfoGB);
            this.Controls.Add(this.welcomeTB);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "APAPlayerForm";
            this.Text = "APA Player";
            this.Load += new System.EventHandler(this.APAPlayerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.personalInfoGB.ResumeLayout(false);
            this.personalInfoGB.PerformLayout();
            this.paymentInfoGB.ResumeLayout(false);
            this.paymentInfoGB.PerformLayout();
            this.leagueInfoGB.ResumeLayout(false);
            this.leagueInfoGB.PerformLayout();
            this.teamInfoGB.ResumeLayout(false);
            this.teamInfoGB.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox welcomeTB;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label teamNumberLabel;
        private System.Windows.Forms.Label divNumberLabel;
        private System.Windows.Forms.Label playerNumberLabel;
        private System.Windows.Forms.Label cardNumberLabel;
        private System.Windows.Forms.Label cardExpLabel;
        private System.Windows.Forms.Label cvcLabel;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.TextBox cityTB;
        private System.Windows.Forms.TextBox stateTB;
        private System.Windows.Forms.TextBox zipTB;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.GroupBox personalInfoGB;
        private System.Windows.Forms.GroupBox paymentInfoGB;
        private System.Windows.Forms.TextBox cvcTB;
        private System.Windows.Forms.TextBox cardExpTB;
        private System.Windows.Forms.TextBox cardNumberTB;
        private System.Windows.Forms.GroupBox leagueInfoGB;
        private System.Windows.Forms.TextBox playerNumberTB;
        private System.Windows.Forms.TextBox divisionTB;
        private System.Windows.Forms.TextBox matchesPlayedTB;
        private System.Windows.Forms.Label matchesPlayedLabel;
        private System.Windows.Forms.TextBox teamNumberTB;
        private System.Windows.Forms.TextBox skillTB;
        private System.Windows.Forms.Label skillLabel;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox statusTB;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.TextBox teamTB;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.TextBox divRepPhoneTB;
        private System.Windows.Forms.Label divRepPhoneLabel;
        private System.Windows.Forms.TextBox divRepTB;
        private System.Windows.Forms.Label divRepLabel;
        private System.Windows.Forms.GroupBox teamInfoGB;
        private System.Windows.Forms.TextBox captainPhoneTB;
        private System.Windows.Forms.Label captainPhoneLabel;
        private System.Windows.Forms.TextBox teamCaptainTB;
        private System.Windows.Forms.Label teamCaptainLabel;
        private System.Windows.Forms.TextBox teamLocationTB;
        private System.Windows.Forms.Label teamLocationLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel playerStatusLabel;
    }
}