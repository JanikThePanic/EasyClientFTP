
namespace EasyClientFTP_GUI
{
    partial class SelectEntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectEntryForm));
            this.SelectEntry = new System.Windows.Forms.Label();
            this.EntriesList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // SelectEntry
            // 
            this.SelectEntry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectEntry.AutoSize = true;
            this.SelectEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.SelectEntry.Location = new System.Drawing.Point(177, 50);
            this.SelectEntry.Name = "SelectEntry";
            this.SelectEntry.Size = new System.Drawing.Size(96, 17);
            this.SelectEntry.TabIndex = 0;
            this.SelectEntry.Text = "Select Entry";
            this.SelectEntry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EntriesList
            // 
            this.EntriesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EntriesList.FormattingEnabled = true;
            this.EntriesList.Location = new System.Drawing.Point(125, 90);
            this.EntriesList.Name = "EntriesList";
            this.EntriesList.Size = new System.Drawing.Size(200, 41);
            this.EntriesList.TabIndex = 1;
            // 
            // SelectEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 186);
            this.Controls.Add(this.EntriesList);
            this.Controls.Add(this.SelectEntry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectEntryForm";
            this.Text = "Select Entry";
            this.Load += new System.EventHandler(this.SelectEntryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectEntry;
        private System.Windows.Forms.ListBox EntriesList;
    }
}

