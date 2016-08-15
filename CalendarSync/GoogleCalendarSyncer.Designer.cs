namespace Gui
{
    partial class GoogleCalendarSyncer
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
            this.btnGetCalendars = new System.Windows.Forms.Button();
            this.dgvFromCalendars = new System.Windows.Forms.DataGridView();
            this.tbSearchFilter = new System.Windows.Forms.TextBox();
            this.dgvToCalendars = new System.Windows.Forms.DataGridView();
            this.btnCopyEvents = new System.Windows.Forms.Button();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tbReplace = new System.Windows.Forms.TextBox();
            this.lblReplace = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFromCalendars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToCalendars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetCalendars
            // 
            this.btnGetCalendars.Location = new System.Drawing.Point(13, 13);
            this.btnGetCalendars.Name = "btnGetCalendars";
            this.btnGetCalendars.Size = new System.Drawing.Size(101, 23);
            this.btnGetCalendars.TabIndex = 0;
            this.btnGetCalendars.Text = "Get Calendars";
            this.btnGetCalendars.UseVisualStyleBackColor = true;
            this.btnGetCalendars.Click += new System.EventHandler(this.btnGetCalendars_Click);
            // 
            // dgvFromCalendars
            // 
            this.dgvFromCalendars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFromCalendars.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFromCalendars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFromCalendars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFromCalendars.Location = new System.Drawing.Point(0, 0);
            this.dgvFromCalendars.MultiSelect = false;
            this.dgvFromCalendars.Name = "dgvFromCalendars";
            this.dgvFromCalendars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFromCalendars.Size = new System.Drawing.Size(434, 550);
            this.dgvFromCalendars.TabIndex = 1;
            this.dgvFromCalendars.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFromCalendars_CellDoubleClick);
            // 
            // tbSearchFilter
            // 
            this.tbSearchFilter.Enabled = false;
            this.tbSearchFilter.Location = new System.Drawing.Point(584, 12);
            this.tbSearchFilter.Name = "tbSearchFilter";
            this.tbSearchFilter.Size = new System.Drawing.Size(106, 20);
            this.tbSearchFilter.TabIndex = 2;
            // 
            // dgvToCalendars
            // 
            this.dgvToCalendars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvToCalendars.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvToCalendars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToCalendars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvToCalendars.Location = new System.Drawing.Point(0, 0);
            this.dgvToCalendars.MultiSelect = false;
            this.dgvToCalendars.Name = "dgvToCalendars";
            this.dgvToCalendars.ReadOnly = true;
            this.dgvToCalendars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvToCalendars.Size = new System.Drawing.Size(506, 550);
            this.dgvToCalendars.TabIndex = 3;
            // 
            // btnCopyEvents
            // 
            this.btnCopyEvents.Enabled = false;
            this.btnCopyEvents.Location = new System.Drawing.Point(120, 13);
            this.btnCopyEvents.Name = "btnCopyEvents";
            this.btnCopyEvents.Size = new System.Drawing.Size(86, 23);
            this.btnCopyEvents.TabIndex = 4;
            this.btnCopyEvents.Text = "Copy Events";
            this.btnCopyEvents.UseVisualStyleBackColor = true;
            this.btnCopyEvents.Click += new System.EventHandler(this.btnCopyEvents_Click);
            // 
            // endDate
            // 
            this.endDate.Enabled = false;
            this.endDate.Location = new System.Drawing.Point(757, 38);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 20);
            this.endDate.TabIndex = 5;
            // 
            // startDate
            // 
            this.startDate.Enabled = false;
            this.startDate.Location = new System.Drawing.Point(757, 12);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 20);
            this.startDate.TabIndex = 6;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvFromCalendars);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvToCalendars);
            this.splitContainer1.Size = new System.Drawing.Size(944, 550);
            this.splitContainer1.SplitterDistance = 434;
            this.splitContainer1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(13, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 550);
            this.panel1.TabIndex = 8;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(518, 15);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(60, 13);
            this.lblFilter.TabIndex = 9;
            this.lblFilter.Text = "Event Filter";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(696, 15);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblStartDate.TabIndex = 10;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(696, 42);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(52, 13);
            this.lblEndDate.TabIndex = 11;
            this.lblEndDate.Text = "End Date";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 617);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(145, 13);
            this.lblInfo.TabIndex = 12;
            this.lblInfo.Text = "Click \'Get Calendars\' to begin";
            // 
            // tbReplace
            // 
            this.tbReplace.Enabled = false;
            this.tbReplace.Location = new System.Drawing.Point(584, 38);
            this.tbReplace.Name = "tbReplace";
            this.tbReplace.Size = new System.Drawing.Size(106, 20);
            this.tbReplace.TabIndex = 13;
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Location = new System.Drawing.Point(457, 41);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(121, 13);
            this.lblReplace.TabIndex = 15;
            this.lblReplace.Text = "Replace Filter Text With";
            // 
            // GoogleCalendarSyncer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 639);
            this.Controls.Add(this.lblReplace);
            this.Controls.Add(this.tbReplace);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.btnCopyEvents);
            this.Controls.Add(this.tbSearchFilter);
            this.Controls.Add(this.btnGetCalendars);
            this.Name = "GoogleCalendarSyncer";
            this.Text = "Google Calendar Syncer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFromCalendars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToCalendars)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetCalendars;
        private System.Windows.Forms.DataGridView dgvFromCalendars;
        private System.Windows.Forms.TextBox tbSearchFilter;
        private System.Windows.Forms.DataGridView dgvToCalendars;
        private System.Windows.Forms.Button btnCopyEvents;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox tbReplace;
        private System.Windows.Forms.Label lblReplace;
    }
}

