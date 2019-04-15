namespace APAApp
{
    partial class APALoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APALoginForm));
            this.cancelButton = new System.Windows.Forms.Button();
            this.registerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.forgotLoginLinkLabel = new System.Windows.Forms.LinkLabel();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginPasswordTB = new System.Windows.Forms.TextBox();
            this.loginEmailTB = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.logoPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(263, 66);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 26;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // registerLinkLabel
            // 
            this.registerLinkLabel.AutoSize = true;
            this.registerLinkLabel.Location = new System.Drawing.Point(10, 76);
            this.registerLinkLabel.Name = "registerLinkLabel";
            this.registerLinkLabel.Size = new System.Drawing.Size(88, 13);
            this.registerLinkLabel.TabIndex = 25;
            this.registerLinkLabel.TabStop = true;
            this.registerLinkLabel.Text = "Need to register?";
            this.registerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLinkLabel_LinkClicked);
            // 
            // forgotLoginLinkLabel
            // 
            this.forgotLoginLinkLabel.AutoSize = true;
            this.forgotLoginLinkLabel.Location = new System.Drawing.Point(10, 63);
            this.forgotLoginLinkLabel.Name = "forgotLoginLinkLabel";
            this.forgotLoginLinkLabel.Size = new System.Drawing.Size(120, 13);
            this.forgotLoginLinkLabel.TabIndex = 24;
            this.forgotLoginLinkLabel.TabStop = true;
            this.forgotLoginLinkLabel.Text = "Forgot email/password?";
            this.forgotLoginLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotLoginLinkLabel_LinkClicked);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(182, 66);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 23;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginPasswordTB
            // 
            this.loginPasswordTB.Location = new System.Drawing.Point(182, 40);
            this.loginPasswordTB.Name = "loginPasswordTB";
            this.loginPasswordTB.PasswordChar = '*';
            this.loginPasswordTB.Size = new System.Drawing.Size(156, 20);
            this.loginPasswordTB.TabIndex = 22;
            // 
            // loginEmailTB
            // 
            this.loginEmailTB.Location = new System.Drawing.Point(182, 14);
            this.loginEmailTB.Name = "loginEmailTB";
            this.loginEmailTB.Size = new System.Drawing.Size(156, 20);
            this.loginEmailTB.TabIndex = 21;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(120, 43);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 20;
            this.passwordLabel.Text = "Password:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(141, 17);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 19;
            this.emailLabel.Text = "Email:";
            // 
            // logoPicBox
            // 
            this.logoPicBox.Image = global::APAApp.Properties.Resources.smallerapa;
            this.logoPicBox.Location = new System.Drawing.Point(13, 10);
            this.logoPicBox.Name = "logoPicBox";
            this.logoPicBox.Size = new System.Drawing.Size(76, 50);
            this.logoPicBox.TabIndex = 18;
            this.logoPicBox.TabStop = false;
            // 
            // APALoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 116);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.registerLinkLabel);
            this.Controls.Add(this.forgotLoginLinkLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.loginPasswordTB);
            this.Controls.Add(this.loginEmailTB);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.logoPicBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "APALoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APA Login";
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.LinkLabel registerLinkLabel;
        private System.Windows.Forms.LinkLabel forgotLoginLinkLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox loginPasswordTB;
        private System.Windows.Forms.TextBox loginEmailTB;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.PictureBox logoPicBox;
    }
}

