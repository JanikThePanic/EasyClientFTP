using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyClientFTP_GUI
{
    public partial class SelectEntryForm : Form
    {
        // will hold the entrytype we want
        public static string EntryType = "";

        public SelectEntryForm()
        {
            InitializeComponent();
        }

        private void SelectEntryForm_Load(object sender, EventArgs e)
        {
            // for loop to pull in entry types
            string[] EntryTypesAvailable = { "repository.tools", "janik.codes" };

            foreach (string i in EntryTypesAvailable)
            {
                this.EntriesList.Items.Add(i);
            }

        }

        private void CreateEntryButton_Click(object sender, EventArgs e)
        {
            if (this.EntriesList.GetItemText(EntriesList.SelectedItem).ToString() != "")
            {
                EntryType = this.EntriesList.GetItemText(EntriesList.SelectedItem).ToString();
                CreateEntryForm ScndForm = new CreateEntryForm();
                ScndForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Select an Entry Type.");
            }
        }

        private void SelectEntryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
