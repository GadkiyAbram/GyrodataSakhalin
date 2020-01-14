namespace InventoryUI
{
    partial class LithiumBatteriesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LithiumBatteriesForm));
            this.AddNewIBatteryLink = new System.Windows.Forms.LinkLabel();
            this.batteriesGridView = new System.Windows.Forms.DataGridView();
            this.searchBatteryComboBox = new System.Windows.Forms.ComboBox();
            this.searchBatteryText = new System.Windows.Forms.TextBox();
            this.refreshbatteryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.batteriesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddNewIBatteryLink
            // 
            this.AddNewIBatteryLink.AutoSize = true;
            this.AddNewIBatteryLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewIBatteryLink.LinkColor = System.Drawing.Color.DimGray;
            this.AddNewIBatteryLink.Location = new System.Drawing.Point(12, 9);
            this.AddNewIBatteryLink.Name = "AddNewIBatteryLink";
            this.AddNewIBatteryLink.Size = new System.Drawing.Size(127, 21);
            this.AddNewIBatteryLink.TabIndex = 2;
            this.AddNewIBatteryLink.TabStop = true;
            this.AddNewIBatteryLink.Text = "Add New Battery";
            this.AddNewIBatteryLink.VisitedLinkColor = System.Drawing.Color.DimGray;
            this.AddNewIBatteryLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddNewIBatteryLink_LinkClicked);
            // 
            // batteriesGridView
            // 
            this.batteriesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.batteriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.batteriesGridView.Location = new System.Drawing.Point(8, 47);
            this.batteriesGridView.Name = "batteriesGridView";
            this.batteriesGridView.Size = new System.Drawing.Size(780, 391);
            this.batteriesGridView.TabIndex = 3;
            // 
            // searchBatteryComboBox
            // 
            this.searchBatteryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBatteryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBatteryComboBox.FormattingEnabled = true;
            this.searchBatteryComboBox.Items.AddRange(new object[] {
            "Serial 1",
            "Status",
            "CCD",
            "Invoice"});
            this.searchBatteryComboBox.Location = new System.Drawing.Point(509, 17);
            this.searchBatteryComboBox.Name = "searchBatteryComboBox";
            this.searchBatteryComboBox.Size = new System.Drawing.Size(121, 24);
            this.searchBatteryComboBox.TabIndex = 29;
            // 
            // searchBatteryText
            // 
            this.searchBatteryText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBatteryText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBatteryText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBatteryText.Location = new System.Drawing.Point(636, 18);
            this.searchBatteryText.Name = "searchBatteryText";
            this.searchBatteryText.Size = new System.Drawing.Size(119, 22);
            this.searchBatteryText.TabIndex = 28;
            // 
            // refreshbatteryButton
            // 
            this.refreshbatteryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshbatteryButton.BackColor = System.Drawing.SystemColors.Control;
            this.refreshbatteryButton.FlatAppearance.BorderSize = 0;
            this.refreshbatteryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshbatteryButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.refreshbatteryButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshbatteryButton.Image")));
            this.refreshbatteryButton.Location = new System.Drawing.Point(761, 14);
            this.refreshbatteryButton.Name = "refreshbatteryButton";
            this.refreshbatteryButton.Size = new System.Drawing.Size(28, 32);
            this.refreshbatteryButton.TabIndex = 27;
            this.refreshbatteryButton.UseVisualStyleBackColor = false;
            this.refreshbatteryButton.Click += new System.EventHandler(this.refreshbatteryButton_Click);
            // 
            // LithiumBatteriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchBatteryComboBox);
            this.Controls.Add(this.searchBatteryText);
            this.Controls.Add(this.refreshbatteryButton);
            this.Controls.Add(this.batteriesGridView);
            this.Controls.Add(this.AddNewIBatteryLink);
            this.Name = "LithiumBatteriesForm";
            this.Text = "Lithium Batteries";
            ((System.ComponentModel.ISupportInitialize)(this.batteriesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel AddNewIBatteryLink;
        private System.Windows.Forms.DataGridView batteriesGridView;
        private System.Windows.Forms.ComboBox searchBatteryComboBox;
        private System.Windows.Forms.TextBox searchBatteryText;
        private System.Windows.Forms.Button refreshbatteryButton;
    }
}