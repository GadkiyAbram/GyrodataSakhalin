namespace InventoryUI.FormsUI.JobsUIs
{
    partial class JobsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobsForm));
            this.jobsGridView = new System.Windows.Forms.DataGridView();
            this.AddNewJobLink = new System.Windows.Forms.LinkLabel();
            this.editJobsLink = new System.Windows.Forms.LinkLabel();
            this.searchJobComboBox = new System.Windows.Forms.ComboBox();
            this.searchJobText = new System.Windows.Forms.TextBox();
            this.refreshJobButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.jobsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // jobsGridView
            // 
            this.jobsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jobsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.jobsGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jobsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.jobsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.jobsGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.jobsGridView.GridColor = System.Drawing.Color.White;
            this.jobsGridView.Location = new System.Drawing.Point(8, 47);
            this.jobsGridView.Name = "jobsGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.jobsGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.jobsGridView.Size = new System.Drawing.Size(780, 392);
            this.jobsGridView.TabIndex = 1;
            // 
            // AddNewJobLink
            // 
            this.AddNewJobLink.AutoSize = true;
            this.AddNewJobLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewJobLink.LinkColor = System.Drawing.Color.DimGray;
            this.AddNewJobLink.Location = new System.Drawing.Point(12, 9);
            this.AddNewJobLink.Name = "AddNewJobLink";
            this.AddNewJobLink.Size = new System.Drawing.Size(102, 21);
            this.AddNewJobLink.TabIndex = 2;
            this.AddNewJobLink.TabStop = true;
            this.AddNewJobLink.Text = "Add New Job";
            this.AddNewJobLink.VisitedLinkColor = System.Drawing.Color.DimGray;
            this.AddNewJobLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddNewJobLink_LinkClicked);
            // 
            // editJobsLink
            // 
            this.editJobsLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editJobsLink.AutoSize = true;
            this.editJobsLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editJobsLink.LinkColor = System.Drawing.Color.DimGray;
            this.editJobsLink.Location = new System.Drawing.Point(430, 11);
            this.editJobsLink.Name = "editJobsLink";
            this.editJobsLink.Size = new System.Drawing.Size(71, 21);
            this.editJobsLink.TabIndex = 3;
            this.editJobsLink.TabStop = true;
            this.editJobsLink.Text = "Edit Jobs";
            this.editJobsLink.VisitedLinkColor = System.Drawing.Color.DimGray;
            this.editJobsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.editJobsLink_LinkClicked);
            // 
            // searchJobComboBox
            // 
            this.searchJobComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchJobComboBox.BackColor = System.Drawing.Color.White;
            this.searchJobComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchJobComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchJobComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchJobComboBox.FormattingEnabled = true;
            this.searchJobComboBox.Items.AddRange(new object[] {
            "Job Number",
            "GDP Sections",
            "Modem",
            "Bullplug",
            "Battery"});
            this.searchJobComboBox.Location = new System.Drawing.Point(507, 11);
            this.searchJobComboBox.Name = "searchJobComboBox";
            this.searchJobComboBox.Size = new System.Drawing.Size(121, 24);
            this.searchJobComboBox.TabIndex = 29;
            // 
            // searchJobText
            // 
            this.searchJobText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchJobText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchJobText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchJobText.Location = new System.Drawing.Point(634, 12);
            this.searchJobText.Name = "searchJobText";
            this.searchJobText.Size = new System.Drawing.Size(119, 22);
            this.searchJobText.TabIndex = 28;
            // 
            // refreshJobButton
            // 
            this.refreshJobButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshJobButton.BackColor = System.Drawing.SystemColors.Control;
            this.refreshJobButton.FlatAppearance.BorderSize = 0;
            this.refreshJobButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshJobButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.refreshJobButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshJobButton.Image")));
            this.refreshJobButton.Location = new System.Drawing.Point(759, 8);
            this.refreshJobButton.Name = "refreshJobButton";
            this.refreshJobButton.Size = new System.Drawing.Size(28, 32);
            this.refreshJobButton.TabIndex = 27;
            this.refreshJobButton.UseVisualStyleBackColor = false;
            this.refreshJobButton.Click += new System.EventHandler(this.refreshJobButton_Click);
            // 
            // JobsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.searchJobComboBox);
            this.Controls.Add(this.searchJobText);
            this.Controls.Add(this.refreshJobButton);
            this.Controls.Add(this.editJobsLink);
            this.Controls.Add(this.AddNewJobLink);
            this.Controls.Add(this.jobsGridView);
            this.Name = "JobsForm";
            this.Text = "Jobs Form";
            ((System.ComponentModel.ISupportInitialize)(this.jobsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView jobsGridView;
        private System.Windows.Forms.LinkLabel AddNewJobLink;
        private System.Windows.Forms.LinkLabel editJobsLink;
        private System.Windows.Forms.ComboBox searchJobComboBox;
        private System.Windows.Forms.TextBox searchJobText;
        private System.Windows.Forms.Button refreshJobButton;
    }
}