namespace InventoryUI
{
    partial class GwdGyroEquipmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GwdGyroEquipmentForm));
            this.gwdGyroGridView = new System.Windows.Forms.DataGridView();
            this.AddNewItemLink = new System.Windows.Forms.LinkLabel();
            this.refreshButton = new System.Windows.Forms.Button();
            this.searchItemText = new System.Windows.Forms.TextBox();
            this.searchItemComboBox = new System.Windows.Forms.ComboBox();
            this.checkItemLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gwdGyroGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gwdGyroGridView
            // 
            this.gwdGyroGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gwdGyroGridView.BackgroundColor = System.Drawing.Color.White;
            this.gwdGyroGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gwdGyroGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gwdGyroGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gwdGyroGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.gwdGyroGridView.Location = new System.Drawing.Point(10, 47);
            this.gwdGyroGridView.Name = "gwdGyroGridView";
            this.gwdGyroGridView.Size = new System.Drawing.Size(780, 391);
            this.gwdGyroGridView.TabIndex = 0;
            // 
            // AddNewItemLink
            // 
            this.AddNewItemLink.AutoSize = true;
            this.AddNewItemLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewItemLink.LinkColor = System.Drawing.Color.DimGray;
            this.AddNewItemLink.Location = new System.Drawing.Point(13, 13);
            this.AddNewItemLink.Name = "AddNewItemLink";
            this.AddNewItemLink.Size = new System.Drawing.Size(109, 21);
            this.AddNewItemLink.TabIndex = 1;
            this.AddNewItemLink.TabStop = true;
            this.AddNewItemLink.Text = "Add New Item";
            this.AddNewItemLink.VisitedLinkColor = System.Drawing.Color.DimGray;
            this.AddNewItemLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddNewItemLink_LinkClicked);
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.BackColor = System.Drawing.SystemColors.Control;
            this.refreshButton.FlatAppearance.BorderSize = 0;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.Location = new System.Drawing.Point(761, 9);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(28, 32);
            this.refreshButton.TabIndex = 24;
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // searchItemText
            // 
            this.searchItemText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchItemText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchItemText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchItemText.Location = new System.Drawing.Point(636, 13);
            this.searchItemText.Name = "searchItemText";
            this.searchItemText.Size = new System.Drawing.Size(119, 22);
            this.searchItemText.TabIndex = 25;
            // 
            // searchItemComboBox
            // 
            this.searchItemComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchItemComboBox.BackColor = System.Drawing.Color.White;
            this.searchItemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchItemComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchItemComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchItemComboBox.FormattingEnabled = true;
            this.searchItemComboBox.Items.AddRange(new object[] {
            "Item",
            "Asset",
            "CCD",
            "Invoice"});
            this.searchItemComboBox.Location = new System.Drawing.Point(509, 12);
            this.searchItemComboBox.Name = "searchItemComboBox";
            this.searchItemComboBox.Size = new System.Drawing.Size(121, 24);
            this.searchItemComboBox.TabIndex = 26;
            // 
            // checkItemLink
            // 
            this.checkItemLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkItemLink.AutoSize = true;
            this.checkItemLink.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkItemLink.LinkColor = System.Drawing.Color.DimGray;
            this.checkItemLink.Location = new System.Drawing.Point(439, 16);
            this.checkItemLink.Name = "checkItemLink";
            this.checkItemLink.Size = new System.Drawing.Size(64, 19);
            this.checkItemLink.TabIndex = 27;
            this.checkItemLink.TabStop = true;
            this.checkItemLink.Text = "Edit Item";
            this.checkItemLink.VisitedLinkColor = System.Drawing.Color.DimGray;
            this.checkItemLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.checkItemLink_LinkClicked);
            // 
            // GwdGyroEquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkItemLink);
            this.Controls.Add(this.searchItemComboBox);
            this.Controls.Add(this.searchItemText);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.AddNewItemLink);
            this.Controls.Add(this.gwdGyroGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GwdGyroEquipmentForm";
            this.Text = "GWD / GYRO Equipment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GwdGyroEquipmentForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.gwdGyroGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gwdGyroGridView;
        private System.Windows.Forms.LinkLabel AddNewItemLink;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox searchItemText;
        private System.Windows.Forms.ComboBox searchItemComboBox;
        private System.Windows.Forms.LinkLabel checkItemLink;
    }
}