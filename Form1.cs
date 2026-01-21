using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ParserApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void OnXmlFileOk(object sender, CancelEventArgs e)
        {

        }

        private void OnXsltFileOk(object sender, CancelEventArgs e)
        {

        }

        private void readXML_Click(object sender, EventArgs e)
        {
            if (openXMLFile.ShowDialog() == DialogResult.Cancel)
                return;

            string xmlFilePath = openXMLFile.FileName;

            xmlPath.Text = xmlFilePath;

            string xmlText = File.ReadAllText(xmlFilePath, Encoding.UTF8);

            XDocument xDocument = XDocument.Parse(xmlText);
            previewBox.Text = xDocument.ToString();
        }

        private void readXSLT_Click(object sender, EventArgs e)
        {
            if (openXSLTFile.ShowDialog() == DialogResult.Cancel)
                return;

            string xsltFilePath = openXSLTFile.FileName;

            xsltPath.Text = xsltFilePath;

            string xsltText = File.ReadAllText(xsltFilePath, Encoding.UTF8);

            XDocument xDocument = XDocument.Parse(xsltText);
            previewBox.Text = xDocument.ToString();
        }
    }
}
