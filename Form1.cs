using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private XDocument currentXmlFile = new XDocument();

        private string currentFilePath = "";

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

            currentXmlFile = XDocument.Parse(xmlText);

            currentXmlFile.Element("Pay").Add(
                new XAttribute("salary_sum",
                currentXmlFile.Element("Pay")
                .Elements("item")
                .Sum(salary => Convert.ToDouble(salary.Attribute("amount").Value.Replace(".", ",")))
                )
            );

            previewBox.Text = currentXmlFile.ToString();
        }

        private void OnXsltFileOk(object sender, CancelEventArgs e)
        {
            string xsltFilePath = openXSLTFile.FileName;

            xsltPath.Text = xsltFilePath;

            string xsltText = File.ReadAllText(xsltFilePath, Encoding.UTF8);

            currentXmlFile = XDocument.Parse(xsltText);
            previewBox.Text = currentXmlFile.ToString();
        }

        private void OnXmlSaveFileOk(object sender, CancelEventArgs e)
        {
            currentXmlFile.Save(saveXmlExport.FileName);
            
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

            currentXmlFile = XDocument.Parse(xmlString);

            SummarizeSalaries();

            previewBox.Text = currentXmlFile.ToString();
        }

        private void SummarizeSalaries()
        {
            List<XElement> employeesXml = currentXmlFile.Element("Employees").Elements("Employee").ToList();
            foreach (XElement employee in employeesXml )
            {
                double salarySum = 0;

                Console.WriteLine(employee.ToString());

                salarySum += employee.Elements("Salary").Sum(salary => 
                    Convert.ToDouble(salary.Attribute("amount").Value.Replace(".", ",")));

                employee.Add(new XAttribute("salary", salarySum));
            }
          
        }

        private void saveTransformedXML(object sender, EventArgs e)
        {
            saveXmlExport.ShowDialog();
        }
    }
}
