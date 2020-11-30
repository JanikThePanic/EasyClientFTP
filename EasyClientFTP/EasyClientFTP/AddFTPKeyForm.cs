using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyClientFTP
{
    public partial class AddFTPKeyForm : Form
    {
        // varibles to hold all the jazz
        public string username { get; set; }
        public string password { get; set; }

        public AddFTPKeyForm()
        {
            InitializeComponent();

            // enter acts as tab nad adds plaholder
            // runs through all textboxes
            foreach (Control pulledControl in this.Controls)
            {
                // makes enter work as tab
                if (pulledControl is TextBox)
                {
                    pulledControl.KeyDown += (s, e) =>
                    {
                        if (e.KeyCode == Keys.Enter)
                        {
                            SendKeys.Send("{TAB}");
                            e.SuppressKeyPress = true;
                        }
                    };

                    // place holder code
                    string innerText = pulledControl.Name.Substring(0, pulledControl.Name.Length - 7);
                    pulledControl.Text = innerText;
                    pulledControl.ForeColor = Color.Gray;

                    // when user clicks into textbox
                    pulledControl.GotFocus += (s, e) =>
                    {
                        if (pulledControl.Text == innerText)
                        {
                            pulledControl.ForeColor = Color.Black;
                            pulledControl.Text = "";
                        }
                    };
                    // when user goes out of textbox
                    pulledControl.LostFocus += (s, e) =>
                    {
                        if (string.IsNullOrEmpty(pulledControl.Text))
                        {
                            pulledControl.ForeColor = Color.Gray;
                            pulledControl.Text = innerText;
                        }
                    };
                }
            }
        }

        private void AddFTPKeyForm_Load(object sender, EventArgs e)
        {
            
        }
        private void AddFTPKeyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void UseFTPKeyButton_Click(object sender, EventArgs e)
        {
            // bool to determin if all boxes are filled
            bool allFilled = true;

            foreach (Control pulledControl in this.Controls)
            {
                if (pulledControl is TextBox)
                {
                    if (pulledControl.ForeColor != Color.Black)
                    {
                        allFilled = false;
                    }
                }
            }

            if (allFilled)
            {
                // all boxes filled
                username = this.UserNameTextbox.Text;
                password = this.PasswordTextbox.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                // not
                MessageBox.Show("Please Fill All Textboxes.");
            }
        }
    }
}
