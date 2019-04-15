namespace APAApp
{
    partial class APADivRepForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APADivRepForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisionInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captainsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomeTB = new System.Windows.Forms.TextBox();
            this.divRepTC = new System.Windows.Forms.TabControl();
            this.personalInfoTab = new System.Windows.Forms.TabPage();
            this.updateInfoButton = new System.Windows.Forms.Button();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.divNumTB = new System.Windows.Forms.TextBox();
            this.divNumLabel = new System.Windows.Forms.Label();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.divTeamsTab = new System.Windows.Forms.TabPage();
            this.deleteTeamButton = new System.Windows.Forms.Button();
            this.updateTeamButton = new System.Windows.Forms.Button();
            this.teamDataGridView = new System.Windows.Forms.DataGridView();
            this.TeamNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.divTeamsTB = new System.Windows.Forms.TextBox();
            this.divPlayersTab = new System.Windows.Forms.TabPage();
            this.divPlayersTB = new System.Windows.Forms.TextBox();
            this.playerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.divCaptainsTab = new System.Windows.Forms.TabPage();
            this.divCaptainTB = new System.Windows.Forms.TextBox();
            this.divCaptainDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.divRepStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.divRepTC.SuspendLayout();
            this.personalInfoTab.SuspendLayout();
            this.divTeamsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            this.divPlayersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            this.divCaptainsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.divCaptainDataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(909, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "divRepMenuStrip";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalInfoToolStripMenuItem,
            this.divisionInfoToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // personalInfoToolStripMenuItem
            // 
            this.personalInfoToolStripMenuItem.Name = "personalInfoToolStripMenuItem";
            this.personalInfoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.personalInfoToolStripMenuItem.Text = "Personal Info";
            this.personalInfoToolStripMenuItem.Click += new System.EventHandler(this.personalInfoToolStripMenuItem_Click);
            // 
            // divisionInfoToolStripMenuItem
            // 
            this.divisionInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamsToolStripMenuItem,
            this.playersToolStripMenuItem,
            this.captainsToolStripMenuItem});
            this.divisionInfoToolStripMenuItem.Name = "divisionInfoToolStripMenuItem";
            this.divisionInfoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.divisionInfoToolStripMenuItem.Text = "Division Info";
            // 
            // teamsToolStripMenuItem
            // 
            this.teamsToolStripMenuItem.Name = "teamsToolStripMenuItem";
            this.teamsToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.teamsToolStripMenuItem.Text = "Teams";
            this.teamsToolStripMenuItem.Click += new System.EventHandler(this.teamsToolStripMenuItem_Click);
            // 
            // playersToolStripMenuItem
            // 
            this.playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            this.playersToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.playersToolStripMenuItem.Text = "Players";
            this.playersToolStripMenuItem.Click += new System.EventHandler(this.playersToolStripMenuItem_Click);
            // 
            // captainsToolStripMenuItem
            // 
            this.captainsToolStripMenuItem.Name = "captainsToolStripMenuItem";
            this.captainsToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.captainsToolStripMenuItem.Text = "Captains";
            this.captainsToolStripMenuItem.Click += new System.EventHandler(this.captainsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // welcomeTB
            // 
            this.welcomeTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.welcomeTB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeTB.Location = new System.Drawing.Point(12, 27);
            this.welcomeTB.Name = "welcomeTB";
            this.welcomeTB.ReadOnly = true;
            this.welcomeTB.Size = new System.Drawing.Size(469, 28);
            this.welcomeTB.TabIndex = 3;
            this.welcomeTB.TabStop = false;
            // 
            // divRepTC
            // 
            this.divRepTC.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.divRepTC.Controls.Add(this.personalInfoTab);
            this.divRepTC.Controls.Add(this.divTeamsTab);
            this.divRepTC.Controls.Add(this.divPlayersTab);
            this.divRepTC.Controls.Add(this.divCaptainsTab);
            this.divRepTC.Location = new System.Drawing.Point(0, 61);
            this.divRepTC.Name = "divRepTC";
            this.divRepTC.SelectedIndex = 0;
            this.divRepTC.Size = new System.Drawing.Size(903, 364);
            this.divRepTC.TabIndex = 4;
            // 
            // personalInfoTab
            // 
            this.personalInfoTab.Controls.Add(this.updateInfoButton);
            this.personalInfoTab.Controls.Add(this.passwordTB);
            this.personalInfoTab.Controls.Add(this.passwordLabel);
            this.personalInfoTab.Controls.Add(this.divNumTB);
            this.personalInfoTab.Controls.Add(this.divNumLabel);
            this.personalInfoTab.Controls.Add(this.emailTB);
            this.personalInfoTab.Controls.Add(this.emailLabel);
            this.personalInfoTab.Controls.Add(this.phoneTB);
            this.personalInfoTab.Controls.Add(this.phoneLabel);
            this.personalInfoTab.Controls.Add(this.lastNameTB);
            this.personalInfoTab.Controls.Add(this.lastNameLabel);
            this.personalInfoTab.Controls.Add(this.firstNameTB);
            this.personalInfoTab.Controls.Add(this.firstNameLabel);
            this.personalInfoTab.Location = new System.Drawing.Point(4, 25);
            this.personalInfoTab.Name = "personalInfoTab";
            this.personalInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.personalInfoTab.Size = new System.Drawing.Size(895, 335);
            this.personalInfoTab.TabIndex = 1;
            this.personalInfoTab.Text = "Personal Info";
            this.personalInfoTab.UseVisualStyleBackColor = true;
            // 
            // updateInfoButton
            // 
            this.updateInfoButton.Location = new System.Drawing.Point(288, 71);
            this.updateInfoButton.Name = "updateInfoButton";
            this.updateInfoButton.Size = new System.Drawing.Size(88, 23);
            this.updateInfoButton.TabIndex = 12;
            this.updateInfoButton.Text = "Update Info";
            this.updateInfoButton.UseVisualStyleBackColor = true;
            this.updateInfoButton.Click += new System.EventHandler(this.updateInfoButton_Click);
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(101, 126);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(151, 20);
            this.passwordTB.TabIndex = 11;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(39, 129);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Password:";
            // 
            // divNumTB
            // 
            this.divNumTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.divNumTB.Location = new System.Drawing.Point(101, 152);
            this.divNumTB.Name = "divNumTB";
            this.divNumTB.ReadOnly = true;
            this.divNumTB.Size = new System.Drawing.Size(59, 13);
            this.divNumTB.TabIndex = 9;
            // 
            // divNumLabel
            // 
            this.divNumLabel.AutoSize = true;
            this.divNumLabel.Location = new System.Drawing.Point(8, 152);
            this.divNumLabel.Name = "divNumLabel";
            this.divNumLabel.Size = new System.Drawing.Size(87, 13);
            this.divNumLabel.TabIndex = 8;
            this.divNumLabel.Text = "Division Number:";
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(101, 99);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(151, 20);
            this.emailTB.TabIndex = 7;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(60, 102);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email:";
            // 
            // phoneTB
            // 
            this.phoneTB.Location = new System.Drawing.Point(101, 73);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(151, 20);
            this.phoneTB.TabIndex = 5;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(54, 76);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(41, 13);
            this.phoneLabel.TabIndex = 4;
            this.phoneLabel.Text = "Phone:";
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(101, 47);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(151, 20);
            this.lastNameTB.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(34, 50);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(101, 21);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(151, 20);
            this.firstNameTB.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(35, 24);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            // 
            // divTeamsTab
            // 
            this.divTeamsTab.Controls.Add(this.deleteTeamButton);
            this.divTeamsTab.Controls.Add(this.updateTeamButton);
            this.divTeamsTab.Controls.Add(this.teamDataGridView);
            this.divTeamsTab.Controls.Add(this.divTeamsTB);
            this.divTeamsTab.Location = new System.Drawing.Point(4, 25);
            this.divTeamsTab.Name = "divTeamsTab";
            this.divTeamsTab.Padding = new System.Windows.Forms.Padding(3);
            this.divTeamsTab.Size = new System.Drawing.Size(895, 335);
            this.divTeamsTab.TabIndex = 2;
            this.divTeamsTab.Text = "Teams";
            this.divTeamsTab.UseVisualStyleBackColor = true;
            this.divTeamsTab.Click += new System.EventHandler(this.teamsToolStripMenuItem_Click);
            // 
            // deleteTeamButton
            // 
            this.deleteTeamButton.Location = new System.Drawing.Point(537, 136);
            this.deleteTeamButton.Name = "deleteTeamButton";
            this.deleteTeamButton.Size = new System.Drawing.Size(110, 23);
            this.deleteTeamButton.TabIndex = 3;
            this.deleteTeamButton.Text = "Delete Team";
            this.deleteTeamButton.UseVisualStyleBackColor = true;
            this.deleteTeamButton.Click += new System.EventHandler(this.deleteTeamButton_Click);
            // 
            // updateTeamButton
            // 
            this.updateTeamButton.Location = new System.Drawing.Point(537, 107);
            this.updateTeamButton.Name = "updateTeamButton";
            this.updateTeamButton.Size = new System.Drawing.Size(110, 23);
            this.updateTeamButton.TabIndex = 2;
            this.updateTeamButton.Text = "Update Team";
            this.updateTeamButton.UseVisualStyleBackColor = true;
            this.updateTeamButton.Click += new System.EventHandler(this.updateTeamButton_Click);
            // 
            // teamDataGridView
            // 
            this.teamDataGridView.AllowUserToOrderColumns = true;
            this.teamDataGridView.AutoGenerateColumns = false;
            this.teamDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeamNumber,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.teamDataGridView.DataSource = this.teamBindingSource;
            this.teamDataGridView.Location = new System.Drawing.Point(6, 41);
            this.teamDataGridView.Name = "teamDataGridView";
            this.teamDataGridView.Size = new System.Drawing.Size(494, 228);
            this.teamDataGridView.TabIndex = 1;
            // 
            // TeamNumber
            // 
            this.TeamNumber.DataPropertyName = "TeamNumber";
            this.TeamNumber.HeaderText = "TeamNumber";
            this.TeamNumber.Name = "TeamNumber";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TeamName";
            this.dataGridViewTextBoxColumn2.HeaderText = "TeamName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TeamLocation";
            this.dataGridViewTextBoxColumn3.HeaderText = "TeamLocation";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TeamPoints";
            this.dataGridViewTextBoxColumn4.HeaderText = "TeamPoints";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataSource = typeof(APA.Team);
            // 
            // divTeamsTB
            // 
            this.divTeamsTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.divTeamsTB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divTeamsTB.Location = new System.Drawing.Point(9, 7);
            this.divTeamsTB.Name = "divTeamsTB";
            this.divTeamsTB.ReadOnly = true;
            this.divTeamsTB.Size = new System.Drawing.Size(491, 28);
            this.divTeamsTB.TabIndex = 0;
            this.divTeamsTB.Text = "Teams In Your Division";
            this.divTeamsTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // divPlayersTab
            // 
            this.divPlayersTab.Controls.Add(this.divPlayersTB);
            this.divPlayersTab.Controls.Add(this.playerDataGridView);
            this.divPlayersTab.Location = new System.Drawing.Point(4, 25);
            this.divPlayersTab.Name = "divPlayersTab";
            this.divPlayersTab.Padding = new System.Windows.Forms.Padding(3);
            this.divPlayersTab.Size = new System.Drawing.Size(895, 335);
            this.divPlayersTab.TabIndex = 3;
            this.divPlayersTab.Text = "Players";
            this.divPlayersTab.UseVisualStyleBackColor = true;
            // 
            // divPlayersTB
            // 
            this.divPlayersTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.divPlayersTB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divPlayersTB.Location = new System.Drawing.Point(6, 6);
            this.divPlayersTB.Name = "divPlayersTB";
            this.divPlayersTB.ReadOnly = true;
            this.divPlayersTB.Size = new System.Drawing.Size(881, 28);
            this.divPlayersTB.TabIndex = 1;
            this.divPlayersTB.Text = "Players In Your Division";
            this.divPlayersTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // playerDataGridView
            // 
            this.playerDataGridView.AllowUserToAddRows = false;
            this.playerDataGridView.AllowUserToOrderColumns = true;
            this.playerDataGridView.AutoGenerateColumns = false;
            this.playerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.playerDataGridView.DataSource = this.playerBindingSource;
            this.playerDataGridView.Location = new System.Drawing.Point(6, 40);
            this.playerDataGridView.Name = "playerDataGridView";
            this.playerDataGridView.Size = new System.Drawing.Size(881, 271);
            this.playerDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PlayerNumber";
            this.dataGridViewTextBoxColumn5.HeaderText = "PlayerNumber";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PlayerFirstName";
            this.dataGridViewTextBoxColumn6.HeaderText = "PlayerFirstName";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PlayerLastName";
            this.dataGridViewTextBoxColumn7.HeaderText = "PlayerLastName";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SkillLevel";
            this.dataGridViewTextBoxColumn8.HeaderText = "SkillLevel";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "MatchesPlayed";
            this.dataGridViewTextBoxColumn9.HeaderText = "MatchesPlayed";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "PlayerTeamNumber";
            this.dataGridViewTextBoxColumn11.HeaderText = "PlayerTeamNumber";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "PlayerPhone";
            this.dataGridViewTextBoxColumn16.HeaderText = "PlayerPhone";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "PlayerEmail";
            this.dataGridViewTextBoxColumn17.HeaderText = "PlayerEmail";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(APA.Player);
            // 
            // divCaptainsTab
            // 
            this.divCaptainsTab.Controls.Add(this.divCaptainTB);
            this.divCaptainsTab.Controls.Add(this.divCaptainDataGridView);
            this.divCaptainsTab.Location = new System.Drawing.Point(4, 25);
            this.divCaptainsTab.Name = "divCaptainsTab";
            this.divCaptainsTab.Padding = new System.Windows.Forms.Padding(3);
            this.divCaptainsTab.Size = new System.Drawing.Size(895, 335);
            this.divCaptainsTab.TabIndex = 4;
            this.divCaptainsTab.Text = "Captains";
            this.divCaptainsTab.UseVisualStyleBackColor = true;
            // 
            // divCaptainTB
            // 
            this.divCaptainTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.divCaptainTB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divCaptainTB.Location = new System.Drawing.Point(6, 6);
            this.divCaptainTB.Name = "divCaptainTB";
            this.divCaptainTB.ReadOnly = true;
            this.divCaptainTB.Size = new System.Drawing.Size(881, 28);
            this.divCaptainTB.TabIndex = 2;
            this.divCaptainTB.Text = "Team Captains In Your Division";
            this.divCaptainTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // divCaptainDataGridView
            // 
            this.divCaptainDataGridView.AllowUserToAddRows = false;
            this.divCaptainDataGridView.AllowUserToOrderColumns = true;
            this.divCaptainDataGridView.AutoGenerateColumns = false;
            this.divCaptainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.divCaptainDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25});
            this.divCaptainDataGridView.DataSource = this.playerBindingSource;
            this.divCaptainDataGridView.Location = new System.Drawing.Point(8, 40);
            this.divCaptainDataGridView.Name = "divCaptainDataGridView";
            this.divCaptainDataGridView.Size = new System.Drawing.Size(881, 256);
            this.divCaptainDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PlayerNumber";
            this.dataGridViewTextBoxColumn10.HeaderText = "PlayerNumber";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "PlayerFirstName";
            this.dataGridViewTextBoxColumn12.HeaderText = "PlayerFirstName";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "PlayerLastName";
            this.dataGridViewTextBoxColumn13.HeaderText = "PlayerLastName";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "SkillLevel";
            this.dataGridViewTextBoxColumn14.HeaderText = "SkillLevel";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "MatchesPlayed";
            this.dataGridViewTextBoxColumn15.HeaderText = "MatchesPlayed";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "PlayerTeamNumber";
            this.dataGridViewTextBoxColumn19.HeaderText = "PlayerTeamNumber";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "PlayerPhone";
            this.dataGridViewTextBoxColumn24.HeaderText = "PlayerPhone";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "PlayerEmail";
            this.dataGridViewTextBoxColumn25.HeaderText = "PlayerEmail";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.divRepStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(909, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // divRepStatusLabel
            // 
            this.divRepStatusLabel.Name = "divRepStatusLabel";
            this.divRepStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // APADivRepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.divRepTC);
            this.Controls.Add(this.welcomeTB);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "APADivRepForm";
            this.Text = "APA Division Rep";
            this.Load += new System.EventHandler(this.APADivRepForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.divRepTC.ResumeLayout(false);
            this.personalInfoTab.ResumeLayout(false);
            this.personalInfoTab.PerformLayout();
            this.divTeamsTab.ResumeLayout(false);
            this.divTeamsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            this.divPlayersTab.ResumeLayout(false);
            this.divPlayersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            this.divCaptainsTab.ResumeLayout(false);
            this.divCaptainsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.divCaptainDataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox welcomeTB;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisionInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem captainsToolStripMenuItem;
        private System.Windows.Forms.TabControl divRepTC;
        private System.Windows.Forms.TabPage personalInfoTab;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox divNumTB;
        private System.Windows.Forms.Label divNumLabel;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TabPage divTeamsTab;
        private System.Windows.Forms.TextBox divTeamsTB;
        private System.Windows.Forms.DataGridView teamDataGridView;
        private System.Windows.Forms.BindingSource teamBindingSource;
        private System.Windows.Forms.TabPage divPlayersTab;
        private System.Windows.Forms.TextBox divPlayersTB;
        private System.Windows.Forms.DataGridView playerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private System.Windows.Forms.TabPage divCaptainsTab;
        private System.Windows.Forms.TextBox divCaptainTB;
        private System.Windows.Forms.DataGridView divCaptainDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button updateInfoButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel divRepStatusLabel;
        private System.Windows.Forms.Button deleteTeamButton;
        private System.Windows.Forms.Button updateTeamButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}