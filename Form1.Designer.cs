namespace ParserApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.previewLabel = new System.Windows.Forms.Label();
            this.openXMLFile = new System.Windows.Forms.OpenFileDialog();
            this.readXML = new System.Windows.Forms.Button();
            this.readXSLT = new System.Windows.Forms.Button();
            this.xmlPath = new System.Windows.Forms.TextBox();
            this.xsltPath = new System.Windows.Forms.TextBox();
            this.transformXML = new System.Windows.Forms.Button();
            this.openXSLTFile = new System.Windows.Forms.OpenFileDialog();
            this.saveXmlExport = new System.Windows.Forms.SaveFileDialog();
            this.saveExportXml = new System.Windows.Forms.Button();
            this.textTabs = new System.Windows.Forms.TabControl();
            this.xmlPage = new System.Windows.Forms.TabPage();
            this.previewBox = new System.Windows.Forms.TextBox();
            this.employeeTablePage = new System.Windows.Forms.TabPage();
            this.textTabs.SuspendLayout();
            this.xmlPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // previewLabel
            // 
            this.previewLabel.AutoSize = true;
            this.previewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.previewLabel.Location = new System.Drawing.Point(751, 9);
            this.previewLabel.Name = "previewLabel";
            this.previewLabel.Size = new System.Drawing.Size(141, 24);
            this.previewLabel.TabIndex = 0;
            this.previewLabel.Text = "Превью файла";
            // 
            // openXMLFile
            // 
            this.openXMLFile.Filter = "Xml files|*.xml";
            this.openXMLFile.FileOk += new System.ComponentModel.CancelEventHandler(this.OnXmlFileOk);
            // 
            // readXML
            // 
            this.readXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readXML.Location = new System.Drawing.Point(12, 116);
            this.readXML.Name = "readXML";
            this.readXML.Size = new System.Drawing.Size(136, 34);
            this.readXML.TabIndex = 1;
            this.readXML.Text = "Открыть XML";
            this.readXML.UseVisualStyleBackColor = true;
            this.readXML.Click += new System.EventHandler(this.readXML_Click);
            // 
            // readXSLT
            // 
            this.readXSLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readXSLT.Location = new System.Drawing.Point(12, 206);
            this.readXSLT.Name = "readXSLT";
            this.readXSLT.Size = new System.Drawing.Size(136, 33);
            this.readXSLT.TabIndex = 2;
            this.readXSLT.Text = "Открыть XSLT";
            this.readXSLT.UseVisualStyleBackColor = true;
            this.readXSLT.Click += new System.EventHandler(this.readXSLT_Click);
            // 
            // xmlPath
            // 
            this.xmlPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xmlPath.Location = new System.Drawing.Point(154, 120);
            this.xmlPath.Name = "xmlPath";
            this.xmlPath.ReadOnly = true;
            this.xmlPath.Size = new System.Drawing.Size(275, 26);
            this.xmlPath.TabIndex = 3;
            this.xmlPath.Text = "путь к xml...";
            // 
            // xsltPath
            // 
            this.xsltPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xsltPath.Location = new System.Drawing.Point(154, 209);
            this.xsltPath.Name = "xsltPath";
            this.xsltPath.ReadOnly = true;
            this.xsltPath.Size = new System.Drawing.Size(275, 26);
            this.xsltPath.TabIndex = 4;
            this.xsltPath.Text = "путь к xslt...";
            // 
            // transformXML
            // 
            this.transformXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transformXML.Location = new System.Drawing.Point(452, 615);
            this.transformXML.Name = "transformXML";
            this.transformXML.Size = new System.Drawing.Size(152, 38);
            this.transformXML.TabIndex = 7;
            this.transformXML.Text = "Конвертировать";
            this.transformXML.UseVisualStyleBackColor = true;
            this.transformXML.Click += new System.EventHandler(this.exportTransformedXML);
            // 
            // openXSLTFile
            // 
            this.openXSLTFile.Filter = "XSLT file|*.xsl";
            this.openXSLTFile.FileOk += new System.ComponentModel.CancelEventHandler(this.OnXsltFileOk);
            // 
            // saveXmlExport
            // 
            this.saveXmlExport.Filter = "Xml file|*.xml|Xsl file|*.xsl";
            this.saveXmlExport.FileOk += new System.ComponentModel.CancelEventHandler(this.OnXmlSaveFileOk);
            // 
            // saveExportXml
            // 
            this.saveExportXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveExportXml.Location = new System.Drawing.Point(1020, 615);
            this.saveExportXml.Name = "saveExportXml";
            this.saveExportXml.Size = new System.Drawing.Size(152, 38);
            this.saveExportXml.TabIndex = 9;
            this.saveExportXml.Text = "Сохранить";
            this.saveExportXml.UseVisualStyleBackColor = true;
            this.saveExportXml.Click += new System.EventHandler(this.saveTransformedXML);
            // 
            // textTabs
            // 
            this.textTabs.Controls.Add(this.xmlPage);
            this.textTabs.Controls.Add(this.employeeTablePage);
            this.textTabs.Location = new System.Drawing.Point(452, 46);
            this.textTabs.Name = "textTabs";
            this.textTabs.SelectedIndex = 0;
            this.textTabs.Size = new System.Drawing.Size(720, 563);
            this.textTabs.TabIndex = 10;
            // 
            // xmlPage
            // 
            this.xmlPage.Controls.Add(this.previewBox);
            this.xmlPage.Location = new System.Drawing.Point(4, 22);
            this.xmlPage.Name = "xmlPage";
            this.xmlPage.Padding = new System.Windows.Forms.Padding(3);
            this.xmlPage.Size = new System.Drawing.Size(712, 537);
            this.xmlPage.TabIndex = 0;
            this.xmlPage.Text = "xmlPage";
            this.xmlPage.UseVisualStyleBackColor = true;
            // 
            // previewBox
            // 
            this.previewBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.previewBox.Location = new System.Drawing.Point(0, 0);
            this.previewBox.Multiline = true;
            this.previewBox.Name = "previewBox";
            this.previewBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.previewBox.Size = new System.Drawing.Size(709, 534);
            this.previewBox.TabIndex = 0;
            // 
            // employeeTablePage
            // 
            this.employeeTablePage.Location = new System.Drawing.Point(4, 22);
            this.employeeTablePage.Name = "employeeTablePage";
            this.employeeTablePage.Padding = new System.Windows.Forms.Padding(3);
            this.employeeTablePage.Size = new System.Drawing.Size(712, 537);
            this.employeeTablePage.TabIndex = 1;
            this.employeeTablePage.Text = "tablePage";
            this.employeeTablePage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.textTabs);
            this.Controls.Add(this.saveExportXml);
            this.Controls.Add(this.transformXML);
            this.Controls.Add(this.xsltPath);
            this.Controls.Add(this.xmlPath);
            this.Controls.Add(this.readXSLT);
            this.Controls.Add(this.readXML);
            this.Controls.Add(this.previewLabel);
            this.Name = "Form1";
            this.Text = "XmlParser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.textTabs.ResumeLayout(false);
            this.xmlPage.ResumeLayout(false);
            this.xmlPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label previewLabel;
        private System.Windows.Forms.OpenFileDialog openXMLFile;
        private System.Windows.Forms.Button readXML;
        private System.Windows.Forms.Button readXSLT;
        private System.Windows.Forms.TextBox xmlPath;
        private System.Windows.Forms.TextBox xsltPath;
        private System.Windows.Forms.Button transformXML;
        private System.Windows.Forms.OpenFileDialog openXSLTFile;
        private System.Windows.Forms.SaveFileDialog saveXmlExport;
        private System.Windows.Forms.Button saveExportXml;
        private System.Windows.Forms.TabControl textTabs;
        private System.Windows.Forms.TabPage xmlPage;
        private System.Windows.Forms.TabPage employeeTablePage;
        private System.Windows.Forms.TextBox previewBox;
    }
}

