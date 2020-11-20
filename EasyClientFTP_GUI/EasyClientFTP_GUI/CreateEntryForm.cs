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
    public partial class CreateEntryForm : Form
    {
        public CreateEntryForm()
        {
            InitializeComponent();
            
            for (int i = 0; i < 5; i++)
            {
                TextBox textInput = new TextBox();
                textInput.Text = (SelectEntryForm.EntryType).ToString();
                textInput.Name = (i + 1).ToString();
                textInput.Size = new Size(35, 35);
                textInput.Location = new Point(40, 40 * (i + 1));
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
    }
}
