
namespace EasyClientFTP
{
    partial class AddFTPKeyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFTPKeyForm));
            this.HostNameTextbox = new System.Windows.Forms.TextBox();
            this.UserNameTextbox = new System.Windows.Forms.TextBox();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.UseFTPKeyButton = new System.Windows.Forms.Button();
            this.PortNumTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HostNameTextbox
            // 
            this.HostNameTextbox.Location = new System.Drawing.Point(30, 18);
            this.HostNameTextbox.Name = "HostNameTextbox";
            this.HostNameTextbox.Size = new System.Drawing.Size(220, 20);
            this.HostNameTextbox.TabIndex = 1;
            // 
            // UserNameTextbox
            // 
            this.UserNameTextbox.Location = new System.Drawing.Point(30, 44);
            this.UserNameTextbox.Name = "UserNameTextbox";
            this.UserNameTextbox.Size = new System.Drawing.Size(323, 20);
            this.UserNameTextbox.TabIndex = 3;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(30, 70);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(323, 20);
            this.PasswordTextbox.TabIndex = 4;
            // 
            // UseFTPKeyButton
            // 
            this.UseFTPKeyButton.Location = new System.Drawing.Point(30, 96);
            this.UseFTPKeyButton.Name = "UseFTPKeyButton";
            this.UseFTPKeyButton.Size = new System.Drawing.Size(323, 23);
            this.UseFTPKeyButton.TabIndex = 5;
            this.UseFTPKeyButton.Text = "Use FTP Key";
            this.UseFTPKeyButton.UseVisualStyleBackColor = true;
            this.UseFTPKeyButton.Click += new System.EventHandler(this.UseFTPKeyButton_Click);
            // 
            // PortNumTextbox
            // 
            this.PortNumTextbox.Location = new System.Drawing.Point(263, 18);
            this.PortNumTextbox.Name = "PortNumTextbox";
            this.PortNumTextbox.Size = new System.Drawing.Size(90, 20);
            this.PortNumTextbox.TabIndex = 2;
            this.PortNumTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PortNumTextbox_KeyPress);
            // 
            // AddFTPKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 132);
            this.Controls.Add(this.PortNumTextbox);
            this.Controls.Add(this.UseFTPKeyButton);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.UserNameTextbox);
            this.Controls.Add(this.HostNameTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddFTPKeyForm";
            this.Text = "Add FTP Key";
            this.Load += new System.EventHandler(this.AddFTPKeyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HostNameTextbox;
        private System.Windows.Forms.TextBox UserNameTextbox;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.Button UseFTPKeyButton;
        private System.Windows.Forms.TextBox PortNumTextbox;
    }
}