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
        // deatils on username and password
        string userName;
        string password;
        // file being edited
        string fileEditing;
        // name of node in the xml file being edited
        string nodeName;
        // varibles that will hold the information on how many textboxs are need and their innerText
        string[] inputDetails = { "" };

        public CreateEntryForm()
        {
            // code said let there be light
            InitializeComponent();

            // write selected entry type ontop
            this.EntryTypeLabel.Text = "Entry Type: " + SelectEntryForm.EntryType.ToString();

            // will change amount of textboxs and their properties based on the entry type
            // this will later be made to be saved in the app settings but for no this will do.
            if (SelectEntryForm.EntryType == "janik.codes/thoughts")
            {
                nodeName = "entry";
                inputDetails = new string[] { "title", "image", "type", "date", "rating", "published", "creator", "thought" };
                fileEditing = "ftp://files.000webhost.com/public_html/thoughts.xml";
            }
            else if (SelectEntryForm.EntryType == "repository.tools")
            {
                nodeName = "resource";
                inputDetails = new string[] { "title", "link", "catagory", "description" };
                fileEditing = "ftp://files.000webhost.com/public_html/entries.xml";
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

                // textboxes size on the form
                // if uits the last textbox, it gets expanded till the border
                if (i == inputDetails.Length - 1)
                {
                    textInput.Multiline = true;
                    // math to fill the rest of the form, afterall, the last textbox is often for a paragraph
                    textInput.Size = new Size(593, 500 - 78 - (30 * (i + 1)));
                }
                else
                {
                    textInput.Size = new Size(593, 18);
                }
                // location of textbox
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

        private void EnterUserDetailsButton_Click(object sender, EventArgs e)
        {
            // create addentrykey form and snape some reulsts outa that
            AddFTPKeyForm nextForm = new AddFTPKeyForm();
            if (nextForm.ShowDialog(this) == DialogResult.OK)
            {
                userName = nextForm.username;
                password = nextForm.password;

                // display the ftp details
                string newLine = Environment.NewLine;
                this.FTPDetails.Text = "User:" + newLine + userName + newLine + newLine + "Password:" + newLine + "*****";
            }
            nextForm.Dispose();
        }

        private void AddEntryButton_Click(object sender, EventArgs e)
        {
            // name of xml file we're make locally
            string localName;

            // bool to determin if all boxes are filled
            bool allFilled = true;

            // runs through all textboxes, if one is not black(color of filled textbox) then ones not full
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

            if (allFilled && userName != null)
            {
                // all boxes filled

                // make name for localfile
                localName = "BackedUpFile_" + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss") + ".xml";
                // creates name for file and its local desitionation
                string localDest = @"C:\Users\Jahangir Abdullayev\Documents\ServerBackups\" + localName;

                // begin ftp connection and if succesful
                if (FTPHandel.FTPDownloadFile(userName, password, fileEditing, localDest))
                {
                    // edit xml file to add current entry
                    XMLHandel.AddToXML(localDest, nodeName, inputDetails);
                    // upload to server
                    FTPHandel.FTPUploadFile(userName, password, fileEditing, localDest);
                    MessageBox.Show("Transaction Complete");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password.");
                }
            }
            else if (userName == null)
            {
                // no ftp credentials were provided
                MessageBox.Show("Please Enter FTP User Details.");
            }
            else
            {
                // not all filled
                MessageBox.Show("Please Fill All Textboxes.");
            }
        }
    }
}
