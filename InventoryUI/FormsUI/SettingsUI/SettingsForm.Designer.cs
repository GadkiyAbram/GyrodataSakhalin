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
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.UrlTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.authGroupBox.SuspendLayout();
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
            this.authGroupBox.Location = new System.Drawing.Point(9, 12);
            this.authGroupBox.Name = "authGroupBox";
            this.authGroupBox.Size = new System.Drawing.Size(284, 145);
            this.authGroupBox.TabIndex = 0;
            this.authGroupBox.TabStop = false;
            this.authGroupBox.Text = "Authorize";
            // 
            // getTokenButton
            // 
            this.getTokenButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.getTokenButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.getTokenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.getTokenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getTokenButton.Location = new System.Drawing.Point(6, 104);
            this.getTokenButton.Name = "getTokenButton";
            this.getTokenButton.Size = new System.Drawing.Size(263, 31);
            this.getTokenButton.TabIndex = 5;
            this.getTokenButton.Text = "SIGN IN";
            this.getTokenButton.UseVisualStyleBackColor = false;
            this.getTokenButton.Click += new System.EventHandler(this.getTokenButton_Click);
            // 
            // passwordText
            // 
            this.passwordText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.passwordText.Location = new System.Drawing.Point(114, 61);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(155, 25);
            this.passwordText.TabIndex = 3;
            this.passwordText.Text = "12341234";
            this.passwordText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordText.UseSystemPasswordChar = true;
            // 
            // usernameText
            // 
            this.usernameText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.usernameText.Location = new System.Drawing.Point(114, 25);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(155, 25);
            this.usernameText.TabIndex = 2;
            this.usernameText.Text = "admin@admin.com";
            this.usernameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(6, 64);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(76, 21);
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
            // PortTextBox
            // 
            this.PortTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PortTextBox.Location = new System.Drawing.Point(138, 199);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(155, 25);
            this.PortTextBox.TabIndex = 9;
            this.PortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.UrlTextBox.Location = new System.Drawing.Point(138, 163);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(155, 25);
            this.UrlTextBox.TabIndex = 8;
            this.UrlTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "PORT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "URL";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(9, 253);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 473);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.UrlTextBox);
            this.Controls.Add(this.tokenFromSettingsText);
            this.Controls.Add(this.tokenFromSettingsButton);
            this.Controls.Add(this.authGroupBox);
            this.Name = "SettingsForm";
            this.Text = "Extras";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExtrasForm_FormClosed);
            this.authGroupBox.ResumeLayout(false);
            this.authGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.TextBox UrlTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
    }
}