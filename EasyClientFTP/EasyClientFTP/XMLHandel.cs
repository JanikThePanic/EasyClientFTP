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
            foreach (Control pulledControl in CreateEntryForm.ActiveForm.Controls)
            {
                if (pulledControl is TextBox)
                {
                    XmlNode pleaseAppened = doc.CreateElement(elementNames[textboxCount]);
                    pleaseAppened.InnerText = pulledControl.Text;
                    addedNode.AppendChild(pleaseAppened);
                    textboxCount++;
                }
            }

            // now appened the parent element to the doc and save it
            doc.DocumentElement.AppendChild(addedNode);
            doc.Save(localDest);
        }
    }
}
