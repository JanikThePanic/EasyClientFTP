
namespace EasyClientFTP_GUI
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
            // CreateEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
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
    }
}