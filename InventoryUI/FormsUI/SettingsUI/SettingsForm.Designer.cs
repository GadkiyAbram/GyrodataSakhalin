namespace InventoryUI.FormsUI.SettingsUI
{
    partial class SettingsForm
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
            this.authGroupBox = new System.Windows.Forms.GroupBox();
            this.getTokenButton = new System.Windows.Forms.Button();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.tokenFromSettingsButton = new System.Windows.Forms.Button();
            this.tokenFromSettingsText = new System.Windows.Forms.RichTextBox();
            this.UrlPortBox = new System.Windows.Forms.GroupBox();
            this.saveUrlPortButton = new System.Windows.Forms.Button();
            this.portText = new System.Windows.Forms.TextBox();
            this.urlText = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.Label();
            this.authGroupBox.SuspendLayout();
            this.UrlPortBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // authGroupBox
            // 
            this.authGroupBox.Controls.Add(this.getTokenButton);
            this.authGroupBox.Controls.Add(this.passwordText);
            this.authGroupBox.Controls.Add(this.usernameText);
            this.authGroupBox.Controls.Add(this.passwordLabel);
            this.authGroupBox.Controls.Add(this.usernameLabel);
            this.authGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authGroupBox.Location = new System.Drawing.Point(9, 150);
            this.authGroupBox.Name = "authGroupBox";
            this.authGroupBox.Size = new System.Drawing.Size(284, 145);
            this.authGroupBox.TabIndex = 0;
            this.authGroupBox.TabStop = false;
            this.authGroupBox.Text = "Request Token";
            // 
            // getTokenButton
            // 
            this.getTokenButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.getTokenButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.getTokenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.getTokenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getTokenButton.Location = new System.Drawing.Point(6, 104);
            this.getTokenButton.Name = "getTokenButton";
            this.getTokenButton.Size = new System.Drawing.Size(259, 31);
            this.getTokenButton.TabIndex = 5;
            this.getTokenButton.Text = "GET TOKEN";
            this.getTokenButton.UseVisualStyleBackColor = false;
            this.getTokenButton.Click += new System.EventHandler(this.getTokenButton_Click);
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(114, 61);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(155, 29);
            this.passwordText.TabIndex = 3;
            this.passwordText.Text = "pass1";
            this.passwordText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(114, 25);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(155, 29);
            this.usernameText.TabIndex = 2;
            this.usernameText.Text = "user1";
            this.usernameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(6, 64);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(77, 21);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(6, 28);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(81, 21);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // tokenFromSettingsButton
            // 
            this.tokenFromSettingsButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tokenFromSettingsButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.tokenFromSettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.tokenFromSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tokenFromSettingsButton.Location = new System.Drawing.Point(9, 422);
            this.tokenFromSettingsButton.Name = "tokenFromSettingsButton";
            this.tokenFromSettingsButton.Size = new System.Drawing.Size(283, 39);
            this.tokenFromSettingsButton.TabIndex = 7;
            this.tokenFromSettingsButton.Text = "GET TOKEN FROM SETTINGS";
            this.tokenFromSettingsButton.UseVisualStyleBackColor = false;
            this.tokenFromSettingsButton.Click += new System.EventHandler(this.tokenFromSettingsButton_Click);
            // 
            // tokenFromSettingsText
            // 
            this.tokenFromSettingsText.Location = new System.Drawing.Point(9, 301);
            this.tokenFromSettingsText.Name = "tokenFromSettingsText";
            this.tokenFromSettingsText.Size = new System.Drawing.Size(283, 115);
            this.tokenFromSettingsText.TabIndex = 7;
            this.tokenFromSettingsText.Text = "";
            // 
            // UrlPortBox
            // 
            this.UrlPortBox.Controls.Add(this.saveUrlPortButton);
            this.UrlPortBox.Controls.Add(this.portText);
            this.UrlPortBox.Controls.Add(this.urlText);
            this.UrlPortBox.Controls.Add(this.portLabel);
            this.UrlPortBox.Controls.Add(this.urlLabel);
            this.UrlPortBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrlPortBox.Location = new System.Drawing.Point(12, 12);
            this.UrlPortBox.Name = "UrlPortBox";
            this.UrlPortBox.Size = new System.Drawing.Size(281, 139);
            this.UrlPortBox.TabIndex = 6;
            this.UrlPortBox.TabStop = false;
            this.UrlPortBox.Text = "URL/Port";
            // 
            // saveUrlPortButton
            // 
            this.saveUrlPortButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveUrlPortButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.saveUrlPortButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.saveUrlPortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveUrlPortButton.Location = new System.Drawing.Point(10, 96);
            this.saveUrlPortButton.Name = "saveUrlPortButton";
            this.saveUrlPortButton.Size = new System.Drawing.Size(259, 31);
            this.saveUrlPortButton.TabIndex = 5;
            this.saveUrlPortButton.Text = "SAVE";
            this.saveUrlPortButton.UseVisualStyleBackColor = false;
            this.saveUrlPortButton.Click += new System.EventHandler(this.saveUrlPortButton_Click);
            // 
            // portText
            // 
            this.portText.Location = new System.Drawing.Point(69, 60);
            this.portText.Name = "portText";
            this.portText.Size = new System.Drawing.Size(200, 29);
            this.portText.TabIndex = 3;
            this.portText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // urlText
            // 
            this.urlText.Location = new System.Drawing.Point(69, 25);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(200, 29);
            this.urlText.TabIndex = 2;
            this.urlText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portLabel.Location = new System.Drawing.Point(6, 63);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(39, 21);
            this.portLabel.TabIndex = 1;
            this.portLabel.Text = "Port";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlLabel.Location = new System.Drawing.Point(6, 28);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(39, 21);
            this.urlLabel.TabIndex = 0;
            this.urlLabel.Text = "URL";
            // 
            // ExtrasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 473);
            this.Controls.Add(this.UrlPortBox);
            this.Controls.Add(this.tokenFromSettingsText);
            this.Controls.Add(this.tokenFromSettingsButton);
            this.Controls.Add(this.authGroupBox);
            this.Name = "ExtrasForm";
            this.Text = "Extras";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExtrasForm_FormClosed);
            this.authGroupBox.ResumeLayout(false);
            this.authGroupBox.PerformLayout();
            this.UrlPortBox.ResumeLayout(false);
            this.UrlPortBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox authGroupBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button getTokenButton;
        private System.Windows.Forms.Button tokenFromSettingsButton;
        private System.Windows.Forms.RichTextBox tokenFromSettingsText;
        private System.Windows.Forms.GroupBox UrlPortBox;
        private System.Windows.Forms.Button saveUrlPortButton;
        private System.Windows.Forms.TextBox portText;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label urlLabel;
    }
}