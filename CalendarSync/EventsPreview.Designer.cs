namespace Gui
{
    partial class EventsPreview
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
            this.dgvEventsPreview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventsPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEventsPreview
            // 
            this.dgvEventsPreview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEventsPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventsPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEventsPreview.Location = new System.Drawing.Point(0, 0);
            this.dgvEventsPreview.Name = "dgvEventsPreview";
            this.dgvEventsPreview.ReadOnly = true;
            this.dgvEventsPreview.Size = new System.Drawing.Size(636, 555);
            this.dgvEventsPreview.TabIndex = 0;
            // 
            // EventsPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 555);
            this.Controls.Add(this.dgvEventsPreview);
            this.Name = "EventsPreview";
            this.Text = "Events Preview";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventsPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEventsPreview;
    }
}