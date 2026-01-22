using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private XDocument currentXmlFile = new XDocument();

        private TextBox currentWorkArea;

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

            UpdateInitialData(currentXmlFile);

            xmlDataPreview.Text = currentXmlFile.ToString();

            textTabs.SelectedIndex = 0;
        }

        private void UpdateInitialData(XDocument initialDataFile)
        {
            initialDataFile.Element("Pay").Add(
                    new XAttribute("salary_sum",
                    initialDataFile.Element("Pay")
                    .Elements("item")
                    .Sum(salary => Convert.ToDouble(salary.Attribute("amount").Value.Replace(".", ",")))
                    )
                );
        }

        private void OnXsltFileOk(object sender, CancelEventArgs e)
        {
            string xsltFilePath = openXSLTFile.FileName;

            xsltPath.Text = xsltFilePath;

            string xsltText = File.ReadAllText(xsltFilePath, Encoding.UTF8);

            currentXmlFile = XDocument.Parse(xsltText);

            xslPreview.Text = currentXmlFile.ToString();

            textTabs.SelectedIndex = 1;
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

        private void OnTransformXmlClick(object sender, EventArgs e)
        {
            XmlReader xslReader = XDocument.Parse(xslPreview.Text).CreateReader();

            XmlReader xmlReader = XDocument.Parse(xmlDataPreview.Text).CreateReader();

            XslCompiledTransform myXslTrans = new XslCompiledTransform();
            myXslTrans.Load(xslReader);

            StringWriter strWriter = new StringWriter();
            XmlTextWriter myWriter = new XmlTextWriter(strWriter);

            myXslTrans.Transform(xmlReader, null, myWriter);

            myWriter.Flush();
            //Return text from string writer...

            string xmlString = strWriter.ToString();
            //close the Objects
            myWriter.Close();
            strWriter.Close();

            currentXmlFile = XDocument.Parse(xmlString);

            SummarizeSalaries();

            xmlTransformedPreview.Text = currentXmlFile.ToString();

            textTabs.SelectedIndex = 2;
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

        private void OnSaveXMLClick(object sender, EventArgs e)
        {
            try
            {
                currentXmlFile = XDocument.Parse(currentWorkArea.Text);
            }
            catch(Exception ex)
            {
                ErrorMessage("Не правильный формат xml файла");
                return;
            }

            saveXmlExport.ShowDialog();
        }


        private void ErrorMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void textTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (textTabs.SelectedIndex)
            {
                //Initial xml data page
                case 0:
                    currentWorkArea = xmlDataPreview;
                    break;

                //Initial xsl data page
                case 1:
                    currentWorkArea = xslPreview;
                    break;

                //Initial converted data page
                case 2:
                    currentWorkArea = xmlTransformedPreview;
                    break;
                default:
                    ErrorMessage("Нет поля с xml файлом");
                    break;
            }
        }
    }
}
