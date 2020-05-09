namespace InventoryUI
{
    partial class InventoryViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryViewerForm));
            this.GyrodataSakhalinLabel = new System.Windows.Forms.Label();
            this.gwdGyroEquipmentButton = new System.Windows.Forms.Button();
            this.jobInformationButton = new System.Windows.Forms.Button();
            this.lithiumBatteriesButton = new System.Windows.Forms.Button();
            this.extrasButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GyrodataSakhalinLabel
            // 
            this.GyrodataSakhalinLabel.AutoSize = true;
            this.GyrodataSakhalinLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GyrodataSakhalinLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GyrodataSakhalinLabel.ForeColor = System.Drawing.Color.DimGray;
            this.GyrodataSakhalinLabel.Location = new System.Drawing.Point(9, 6);
            this.GyrodataSakhalinLabel.Name = "GyrodataSakhalinLabel";
            this.GyrodataSakhalinLabel.Size = new System.Drawing.Size(273, 30);
            this.GyrodataSakhalinLabel.TabIndex = 0;
            this.GyrodataSakhalinLabel.Text = "Gyrodata Sakhalin Inventory";
            // 
            // gwdGyroEquipmentButton
            // 
            this.gwdGyroEquipmentButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gwdGyroEquipmentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.gwdGyroEquipmentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.gwdGyroEquipmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gwdGyroEquipmentButton.Location = new System.Drawing.Point(12, 54);
            this.gwdGyroEquipmentButton.Name = "gwdGyroEquipmentButton";
            this.gwdGyroEquipmentButton.Size = new System.Drawing.Size(281, 39);
            this.gwdGyroEquipmentButton.TabIndex = 1;
            this.gwdGyroEquipmentButton.Text = "GWD / GYRO EQUIPMENT";
            this.gwdGyroEquipmentButton.UseVisualStyleBackColor = false;
            this.gwdGyroEquipmentButton.Click += new System.EventHandler(this.gwdGyroEquipmentButton_Click);
            // 
            // jobInformationButton
            // 
            this.jobInformationButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jobInformationButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.jobInformationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.jobInformationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jobInformationButton.Location = new System.Drawing.Point(12, 99);
            this.jobInformationButton.Name = "jobInformationButton";
            this.jobInformationButton.Size = new System.Drawing.Size(281, 39);
            this.jobInformationButton.TabIndex = 2;
            this.jobInformationButton.Text = "JOBS INFORMATION";
            this.jobInformationButton.UseVisualStyleBackColor = false;
            this.jobInformationButton.Click += new System.EventHandler(this.jobInformationButton_Click);
            // 
            // lithiumBatteriesButton
            // 
            this.lithiumBatteriesButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lithiumBatteriesButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.lithiumBatteriesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.lithiumBatteriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lithiumBatteriesButton.Location = new System.Drawing.Point(12, 144);
            this.lithiumBatteriesButton.Name = "lithiumBatteriesButton";
            this.lithiumBatteriesButton.Size = new System.Drawing.Size(281, 39);
            this.lithiumBatteriesButton.TabIndex = 3;
            this.lithiumBatteriesButton.Text = "LITHIUM BATTERIES";
            this.lithiumBatteriesButton.UseVisualStyleBackColor = false;
            this.lithiumBatteriesButton.Click += new System.EventHandler(this.lithiumBatteriesButton_Click);
            // 
            // extrasButton
            // 
            this.extrasButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.extrasButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.extrasButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.extrasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extrasButton.Location = new System.Drawing.Point(12, 189);
            this.extrasButton.Name = "extrasButton";
            this.extrasButton.Size = new System.Drawing.Size(281, 39);
            this.extrasButton.TabIndex = 4;
            this.extrasButton.Text = "SETTINGS";
            this.extrasButton.UseVisualStyleBackColor = false;
            this.extrasButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(12, 305);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(281, 39);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // InventoryViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(305, 356);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.extrasButton);
            this.Controls.Add(this.lithiumBatteriesButton);
            this.Controls.Add(this.jobInformationButton);
            this.Controls.Add(this.gwdGyroEquipmentButton);
            this.Controls.Add(this.GyrodataSakhalinLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "InventoryViewerForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Text = "Sakhalin Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GyrodataSakhalinLabel;
        private System.Windows.Forms.Button gwdGyroEquipmentButton;
        private System.Windows.Forms.Button jobInformationButton;
        private System.Windows.Forms.Button lithiumBatteriesButton;
        private System.Windows.Forms.Button extrasButton;
        private System.Windows.Forms.Button exitButton;
    }
}

