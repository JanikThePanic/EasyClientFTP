using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;

namespace EasyClientFTP
{
    public partial class CreateEntryForm : Form
    {
        string hostName;
        int portNum;
        string userName;
        string password;

        public CreateEntryForm()
        {
            // varibles that will hold the information on how many textboxs are need and their innerText
            string[] inputDetails = { "" };
            string fileEditing;

            // code said let there be light
            InitializeComponent();

            // write select entry type ontop
            this.EntryTypeLabel.Text = "Entry Type: " + SelectEntryForm.EntryType.ToString();

            // will change amount of textboxs and their properties based on the entry type, this will later be made to be saved in the app settings but for no this will do.
            if (SelectEntryForm.EntryType == "janik.codes")
            {
                inputDetails = new string[] { "title", "image", "type", "date", "rating", "published", "Creator", "thought" };
                fileEditing = "ftp://https://thejanik.000webhostapp.com/thoughts.xml";
            }
            else if (SelectEntryForm.EntryType == "repository.tools")
            {
                inputDetails = new string[] { "title", "link", "description", "catagory" };
                fileEditing = "ftp://https://thejanik.000webhostapp.com/entries.xml";
            }

            // add amount of text boxes based on entry type
            for (int i = 0; i < inputDetails.Length; i++)
            {
                // create textboxs for nessary inputs
                TextBox textInput = new TextBox();
                // placeholder 
                string innerText = char.ToUpper(inputDetails[i][0]) + inputDetails[i].Substring(1);
                textInput.ForeColor = System.Drawing.Color.Gray;
                textInput.Text = innerText;
                // make it multiline
                // textInput.Multiline = true;
                // the objects name
                textInput.Name = inputDetails[i]+"Input";
                // textboxes size and location on the form
                textInput.Size = new Size(593, 18);
                textInput.Location = new Point(24, 50 + 30 * i);

                // place holder code
                // when user clicks into textbox
                textInput.GotFocus += (s, e) =>
                {
                    if (textInput.Text == innerText)
                    {
                        textInput.ForeColor = Color.Black;
                        textInput.Text = "";
                    }
                };
                // when user goes out of textbox
                textInput.LostFocus += (s, e) =>
                {
                    if (string.IsNullOrEmpty(textInput.Text))
                    {
                        textInput.ForeColor = Color.Gray;
                        textInput.Text = innerText;
                    }
                };

                // if enter is pressed it will do .GotFocus which would clear the textbox, so lets not have that
                textInput.KeyDown += (s, e) =>
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        SendKeys.Send("{TAB}");
                        e.SuppressKeyPress = true;
                    }
                };

                Controls.Add(textInput);

            }
        }

        private void CreateEntryForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateEntryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AddFTPKeyButton_Click(object sender, EventArgs e)
        {
            // create addentrykey form and snape some reulsts outa that
            AddFTPKeyForm nextForm = new AddFTPKeyForm();
            if (nextForm.ShowDialog(this) == DialogResult.OK)
            {
                hostName = nextForm.hostName;
                portNum = nextForm.portNum;
                userName = nextForm.username;
                password = nextForm.password;
            }
            nextForm.Dispose();

            // display the ftp details
            string newLine = Environment.NewLine;
            this.FTPDetails.Text = "Host:" + newLine + hostName + newLine + newLine + "Port:" + newLine +portNum;
        }

        private void AddEntryButton_Click(object sender, EventArgs e)
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
            }
            else if (hostName == null)
            {
                // no ftp credentials were provided
                MessageBox.Show("Please Add FTP Key.");
            }
            else
            {
                // not all filled
                MessageBox.Show("Please Fill All Textboxes.");
            }
        }
    }
}
