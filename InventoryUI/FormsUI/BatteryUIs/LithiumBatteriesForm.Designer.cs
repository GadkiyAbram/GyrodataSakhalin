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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LithiumBatteriesForm));
            this.AddNewIBatteryLink = new System.Windows.Forms.LinkLabel();
            this.batteriesGridView = new System.Windows.Forms.DataGridView();
            this.searchBatteryComboBox = new System.Windows.Forms.ComboBox();
            this.searchBatteryText = new System.Windows.Forms.TextBox();
            this.refreshbatteryButton = new System.Windows.Forms.Button();
            this.AddNewBatteryLink = new System.Windows.Forms.LinkLabel();
            this.editBatteryLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.batteriesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddNewIBatteryLink
            // 
            this.AddNewIBatteryLink.AutoSize = true;
            this.AddNewIBatteryLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewIBatteryLink.LinkColor = System.Drawing.Color.DimGray;
            this.AddNewIBatteryLink.Location = new System.Drawing.Point(12, -21);
            this.AddNewIBatteryLink.Name = "AddNewIBatteryLink";
            this.AddNewIBatteryLink.Size = new System.Drawing.Size(127, 21);
            this.AddNewIBatteryLink.TabIndex = 2;
            this.AddNewIBatteryLink.TabStop = true;
            this.AddNewIBatteryLink.Text = "Add New Battery";
            this.AddNewIBatteryLink.VisitedLinkColor = System.Drawing.Color.DimGray;
            // 
            // batteriesGridView
            // 
            this.batteriesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.batteriesGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.batteriesGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.batteriesGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.batteriesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.batteriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.batteriesGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.batteriesGridView.Location = new System.Drawing.Point(8, 39);
            this.batteriesGridView.Name = "batteriesGridView";
            this.batteriesGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.batteriesGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.batteriesGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
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
            this.searchBatteryComboBox.Location = new System.Drawing.Point(508, 5);
            this.searchBatteryComboBox.Name = "searchBatteryComboBox";
            this.searchBatteryComboBox.Size = new System.Drawing.Size(121, 24);
            this.searchBatteryComboBox.TabIndex = 29;
            // 
            // searchBatteryText
            // 
            this.searchBatteryText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBatteryText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBatteryText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBatteryText.Location = new System.Drawing.Point(635, 5);
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
            this.refreshbatteryButton.Location = new System.Drawing.Point(760, 1);
            this.refreshbatteryButton.Name = "refreshbatteryButton";
            this.refreshbatteryButton.Size = new System.Drawing.Size(28, 32);
            this.refreshbatteryButton.TabIndex = 27;
            this.refreshbatteryButton.UseVisualStyleBackColor = false;
            this.refreshbatteryButton.Click += new System.EventHandler(this.refreshbatteryButton_Click);
            // 
            // AddNewBatteryLink
            // 
            this.AddNewBatteryLink.AutoSize = true;
            this.AddNewBatteryLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewBatteryLink.LinkColor = System.Drawing.Color.DimGray;
            this.AddNewBatteryLink.Location = new System.Drawing.Point(4, 6);
            this.AddNewBatteryLink.Name = "AddNewBatteryLink";
            this.AddNewBatteryLink.Size = new System.Drawing.Size(127, 21);
            this.AddNewBatteryLink.TabIndex = 30;
            this.AddNewBatteryLink.TabStop = true;
            this.AddNewBatteryLink.Text = "Add New Battery";
            this.AddNewBatteryLink.VisitedLinkColor = System.Drawing.Color.DimGray;
            this.AddNewBatteryLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddNewBatteryLink_LinkClicked);
            // 
            // editBatteryLink
            // 
            this.editBatteryLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editBatteryLink.AutoSize = true;
            this.editBatteryLink.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.editBatteryLink.LinkColor = System.Drawing.Color.DimGray;
            this.editBatteryLink.Location = new System.Drawing.Point(422, 7);
            this.editBatteryLink.Name = "editBatteryLink";
            this.editBatteryLink.Size = new System.Drawing.Size(80, 19);
            this.editBatteryLink.TabIndex = 31;
            this.editBatteryLink.TabStop = true;
            this.editBatteryLink.Text = "Edit Battery";
            this.editBatteryLink.VisitedLinkColor = System.Drawing.Color.DimGray;
            this.editBatteryLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.editBatteryLink_LinkClicked);
            // 
            // LithiumBatteriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.editBatteryLink);
            this.Controls.Add(this.AddNewBatteryLink);
            this.Controls.Add(this.searchBatteryComboBox);
            this.Controls.Add(this.searchBatteryText);
            this.Controls.Add(this.refreshbatteryButton);
            this.Controls.Add(this.batteriesGridView);
            this.Name = "LithiumBatteriesForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Text = "Lithium Batteries";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LithiumBatteriesForm_FormClosed);
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
        private System.Windows.Forms.LinkLabel AddNewBatteryLink;
        private System.Windows.Forms.LinkLabel editBatteryLink;
    }
}