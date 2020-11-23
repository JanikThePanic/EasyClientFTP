
namespace EasyClientFTP
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
            this.SelectEntryLabel = new System.Windows.Forms.Label();
            this.EntriesList = new System.Windows.Forms.ListBox();
            this.CreateEntryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectEntryLabel
            // 
            this.SelectEntryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SelectEntryLabel.AutoSize = true;
            this.SelectEntryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.SelectEntryLabel.Location = new System.Drawing.Point(177, 50);
            this.SelectEntryLabel.Name = "SelectEntryLabel";
            this.SelectEntryLabel.Size = new System.Drawing.Size(96, 17);
            this.SelectEntryLabel.TabIndex = 0;
            this.SelectEntryLabel.Text = "Select Entry";
            this.SelectEntryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EntriesList
            // 
            this.EntriesList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.EntriesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EntriesList.FormattingEnabled = true;
            this.EntriesList.Location = new System.Drawing.Point(125, 85);
            this.EntriesList.MaximumSize = new System.Drawing.Size(200, 41);
            this.EntriesList.MinimumSize = new System.Drawing.Size(200, 41);
            this.EntriesList.Name = "EntriesList";
            this.EntriesList.Size = new System.Drawing.Size(200, 41);
            this.EntriesList.TabIndex = 1;
            this.EntriesList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.EntriesList_MouseDoubleClick);
            // 
            // CreateEntryButton
            // 
            this.CreateEntryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CreateEntryButton.AutoSize = true;
            this.CreateEntryButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateEntryButton.Location = new System.Drawing.Point(185, 145);
            this.CreateEntryButton.Name = "CreateEntryButton";
            this.CreateEntryButton.Size = new System.Drawing.Size(75, 23);
            this.CreateEntryButton.TabIndex = 2;
            this.CreateEntryButton.Text = "Create Entry";
            this.CreateEntryButton.UseVisualStyleBackColor = true;
            this.CreateEntryButton.Click += new System.EventHandler(this.CreateEntryButton_Click);
            // 
            // SelectEntryForm
            // 
            this.AcceptButton = this.CreateEntryButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 186);
            this.Controls.Add(this.CreateEntryButton);
            this.Controls.Add(this.EntriesList);
            this.Controls.Add(this.SelectEntryLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SelectEntryForm";
            this.Text = "Select Entry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectEntryForm_FormClosing);
            this.Load += new System.EventHandler(this.SelectEntryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectEntryLabel;
        private System.Windows.Forms.ListBox EntriesList;
        private System.Windows.Forms.Button CreateEntryButton;
    }
}

