using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Xml;

namespace EasyClientFTP
{
    class XMLHandel
    {
        public static void AddToXML(string localDest, string nodeName, string[] elementNames)
        {
            // will keep the elementNames and Textbox count in sync
            int textboxCount = 0;

            // make new xmlDocument obejct and load it
            XmlDocument doc = new XmlDocument();
            doc.Load(localDest);

            // add parent element
            XmlNode addedNode = doc.CreateElement(nodeName);

            // pull all the textboxes from the CreateEntryForm
            foreach (Control pulledControl in Form.ActiveForm.Controls)
            {
                // make sure the control is a textbox
                if (pulledControl is TextBox)
                {
                    // create an element with the name of the current input textbox
                    XmlNode pleaseAppend = doc.CreateElement(elementNames[textboxCount]);

                    // if its the last textbox, i allow html to be entered so i can make new line and line breaks
                    // i only need this for janik.codes/thoughts, which has the nodeName of entry
                    if (textboxCount == elementNames.Length - 1 && nodeName == "entry")
                    {
                        // make cdata node
                        XmlCDataSection CData = doc.CreateCDataSection(pulledControl.Text);
                        // appened this element
                        pleaseAppend.AppendChild(CData);
                    }
                    else
                    {
                        // if not the last, just set it to text inside textbox
                        pleaseAppend.InnerText = pulledControl.Text;
                    }

                    // appened the element
                    addedNode.AppendChild(pleaseAppend);
                    // boost the count to keep the elements and textboxs insync
                    textboxCount++;
                }
            }

            // now appened the parent element to the doc and save it
            doc.DocumentElement.AppendChild(addedNode);
            doc.Save(localDest);
        }
    }
}
