
namespace EasyClientFTP
{
    partial class CreateEntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEntryForm));
            this.EntryTypeLabel = new System.Windows.Forms.Label();
            this.AddFTPKeyButton = new System.Windows.Forms.Button();
            this.AddEntryButton = new System.Windows.Forms.Button();
            this.FTPDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EntryTypeLabel
            // 
            this.EntryTypeLabel.AutoSize = true;
            this.EntryTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryTypeLabel.Location = new System.Drawing.Point(21, 21);
            this.EntryTypeLabel.Name = "EntryTypeLabel";
            this.EntryTypeLabel.Size = new System.Drawing.Size(0, 13);
            this.EntryTypeLabel.TabIndex = 0;
            // 
            // AddFTPKeyButton
            // 
            this.AddFTPKeyButton.Location = new System.Drawing.Point(644, 50);
            this.AddFTPKeyButton.Name = "AddFTPKeyButton";
            this.AddFTPKeyButton.Size = new System.Drawing.Size(113, 23);
            this.AddFTPKeyButton.TabIndex = 1;
            this.AddFTPKeyButton.Text = "Add FTP Key";
            this.AddFTPKeyButton.UseVisualStyleBackColor = true;
            this.AddFTPKeyButton.Click += new System.EventHandler(this.AddFTPKeyButton_Click);
            // 
            // AddEntryButton
            // 
            this.AddEntryButton.Location = new System.Drawing.Point(644, 79);
            this.AddEntryButton.Name = "AddEntryButton";
            this.AddEntryButton.Size = new System.Drawing.Size(113, 23);
            this.AddEntryButton.TabIndex = 2;
            this.AddEntryButton.Text = "Add Entry";
            this.AddEntryButton.UseVisualStyleBackColor = true;
            this.AddEntryButton.Click += new System.EventHandler(this.AddEntryButton_Click);
            // 
            // FTPDetails
            // 
            this.FTPDetails.Location = new System.Drawing.Point(641, 115);
            this.FTPDetails.Name = "FTPDetails";
            this.FTPDetails.Size = new System.Drawing.Size(116, 337);
            this.FTPDetails.TabIndex = 4;
            // 
            // CreateEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.FTPDetails);
            this.Controls.Add(this.AddEntryButton);
            this.Controls.Add(this.AddFTPKeyButton);
            this.Controls.Add(this.EntryTypeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateEntryForm";
            this.Text = "Create Entry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateEntryForm_FormClosing);
            this.Load += new System.EventHandler(this.CreateEntryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EntryTypeLabel;
        private System.Windows.Forms.Button AddFTPKeyButton;
        private System.Windows.Forms.Button AddEntryButton;
        private System.Windows.Forms.Label FTPDetails;
    }
}