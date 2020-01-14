namespace InventoryUI
{
    partial class ErrorForm
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
            this.ErrorsToCorrectLabel = new System.Windows.Forms.Label();
            this.ErrorsDescription = new System.Windows.Forms.Label();
            this.OkToCorrectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ErrorsToCorrectLabel
            // 
            this.ErrorsToCorrectLabel.AutoSize = true;
            this.ErrorsToCorrectLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorsToCorrectLabel.Location = new System.Drawing.Point(12, 9);
            this.ErrorsToCorrectLabel.Name = "ErrorsToCorrectLabel";
            this.ErrorsToCorrectLabel.Size = new System.Drawing.Size(204, 21);
            this.ErrorsToCorrectLabel.TabIndex = 1;
            this.ErrorsToCorrectLabel.Text = "Please correct the following:";
            // 
            // ErrorsDescription
            // 
            this.ErrorsDescription.AutoSize = true;
            this.ErrorsDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorsDescription.Location = new System.Drawing.Point(13, 40);
            this.ErrorsDescription.Name = "ErrorsDescription";
            this.ErrorsDescription.Size = new System.Drawing.Size(0, 17);
            this.ErrorsDescription.TabIndex = 2;
            // 
            // OkToCorrectButton
            // 
            this.OkToCorrectButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OkToCorrectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkToCorrectButton.Location = new System.Drawing.Point(12, 183);
            this.OkToCorrectButton.Name = "OkToCorrectButton";
            this.OkToCorrectButton.Size = new System.Drawing.Size(239, 39);
            this.OkToCorrectButton.TabIndex = 24;
            this.OkToCorrectButton.Text = "OK";
            this.OkToCorrectButton.UseVisualStyleBackColor = false;
            this.OkToCorrectButton.Click += new System.EventHandler(this.OkToCorrectButton_Click);
            // 
            // ErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 234);
            this.Controls.Add(this.OkToCorrectButton);
            this.Controls.Add(this.ErrorsDescription);
            this.Controls.Add(this.ErrorsToCorrectLabel);
            this.Name = "ErrorForm";
            this.Text = "ErrorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ErrorsToCorrectLabel;
        private System.Windows.Forms.Label ErrorsDescription;
        private System.Windows.Forms.Button OkToCorrectButton;
    }
}