using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace ParserApp
{
    public partial class Form1 : Form
    {
        private XDocument newXmlFile = new XDocument();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void OnXmlFileOk(object sender, CancelEventArgs e)
        {
            string xmlFilePath = openXMLFile.FileName;

            xmlPath.Text = xmlFilePath;

            string xmlText = File.ReadAllText(xmlFilePath, Encoding.UTF8);

            XDocument xDocument = XDocument.Parse(xmlText);
            previewBox.Text = xDocument.ToString();
        }

        private void OnXsltFileOk(object sender, CancelEventArgs e)
        {
            string xsltFilePath = openXSLTFile.FileName;

            xsltPath.Text = xsltFilePath;

            string xsltText = File.ReadAllText(xsltFilePath, Encoding.UTF8);

            XDocument xDocument = XDocument.Parse(xsltText);
            previewBox.Text = xDocument.ToString();
        }

        private void OnXmlSaveFileOk(object sender, CancelEventArgs e)
        {
            newXmlFile.Save(saveXmlExport.FileName);
            
        }

        private void readXML_Click(object sender, EventArgs e)
        {
            openXMLFile.ShowDialog();
        }

        private void readXSLT_Click(object sender, EventArgs e)
        {
            openXSLTFile.ShowDialog();

        }

        private void exportTransformedXML(object sender, EventArgs e)
        {
            XPathDocument xPathDoc = new XPathDocument(openXMLFile.FileName);
            XslCompiledTransform myXslTrans = new XslCompiledTransform();
            myXslTrans.Load(openXSLTFile.FileName);
            StringWriter strWriter = new StringWriter();
            XmlTextWriter myWriter = new XmlTextWriter(strWriter);

            myXslTrans.Transform(xPathDoc, null, myWriter);

            myWriter.Flush();
            //Return text from string writer...

            string xmlString = strWriter.ToString();
            //close the Objects
            myWriter.Close();
            strWriter.Close();

            newXmlFile = XDocument.Parse(xmlString);
            previewBox.Text = newXmlFile.ToString();
        }


        private void saveTransformedXML(object sender, EventArgs e)
        {
            saveXmlExport.ShowDialog();
        }
    }
}
