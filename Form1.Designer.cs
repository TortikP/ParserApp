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
            this.saveToFile = new System.Windows.Forms.Button();
            this.textTabs = new System.Windows.Forms.TabControl();
            this.xmlDataPage = new System.Windows.Forms.TabPage();
            this.xmlDataPreview = new System.Windows.Forms.TextBox();
            this.xsltDataPage = new System.Windows.Forms.TabPage();
            this.xslPreview = new System.Windows.Forms.TextBox();
            this.xmlTransformedPage = new System.Windows.Forms.TabPage();
            this.xmlTransformedPreview = new System.Windows.Forms.TextBox();
            this.acceptChanges = new System.Windows.Forms.Button();
            this.onErrorPopup = new System.Windows.Forms.HelpProvider();
            this.textTabs.SuspendLayout();
            this.xmlDataPage.SuspendLayout();
            this.xsltDataPage.SuspendLayout();
            this.xmlTransformedPage.SuspendLayout();
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
            this.transformXML.Location = new System.Drawing.Point(456, 615);
            this.transformXML.Name = "transformXML";
            this.transformXML.Size = new System.Drawing.Size(152, 38);
            this.transformXML.TabIndex = 7;
            this.transformXML.Text = "Конвертировать";
            this.transformXML.UseVisualStyleBackColor = true;
            this.transformXML.Click += new System.EventHandler(this.OnTransformXmlClick);
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
            // saveToFile
            // 
            this.saveToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveToFile.Location = new System.Drawing.Point(1013, 615);
            this.saveToFile.Name = "saveToFile";
            this.saveToFile.Size = new System.Drawing.Size(152, 38);
            this.saveToFile.TabIndex = 9;
            this.saveToFile.Text = "Сохранить";
            this.saveToFile.UseVisualStyleBackColor = true;
            this.saveToFile.Click += new System.EventHandler(this.OnSaveXMLClick);
            // 
            // textTabs
            // 
            this.textTabs.Controls.Add(this.xmlDataPage);
            this.textTabs.Controls.Add(this.xsltDataPage);
            this.textTabs.Controls.Add(this.xmlTransformedPage);
            this.textTabs.Location = new System.Drawing.Point(452, 46);
            this.textTabs.Name = "textTabs";
            this.textTabs.SelectedIndex = 0;
            this.textTabs.Size = new System.Drawing.Size(720, 563);
            this.textTabs.TabIndex = 10;
            this.textTabs.SelectedIndexChanged += new System.EventHandler(this.textTabs_SelectedIndexChanged);
            // 
            // xmlDataPage
            // 
            this.xmlDataPage.Controls.Add(this.xmlDataPreview);
            this.xmlDataPage.Location = new System.Drawing.Point(4, 22);
            this.xmlDataPage.Name = "xmlDataPage";
            this.xmlDataPage.Padding = new System.Windows.Forms.Padding(3);
            this.xmlDataPage.Size = new System.Drawing.Size(712, 537);
            this.xmlDataPage.TabIndex = 0;
            this.xmlDataPage.Text = "xmlDataPage";
            this.xmlDataPage.UseVisualStyleBackColor = true;
            // 
            // xmlDataPreview
            // 
            this.xmlDataPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xmlDataPreview.Location = new System.Drawing.Point(0, 0);
            this.xmlDataPreview.Multiline = true;
            this.xmlDataPreview.Name = "xmlDataPreview";
            this.xmlDataPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.xmlDataPreview.Size = new System.Drawing.Size(709, 531);
            this.xmlDataPreview.TabIndex = 0;
            // 
            // xsltDataPage
            // 
            this.xsltDataPage.Controls.Add(this.xslPreview);
            this.xsltDataPage.Location = new System.Drawing.Point(4, 22);
            this.xsltDataPage.Name = "xsltDataPage";
            this.xsltDataPage.Padding = new System.Windows.Forms.Padding(3);
            this.xsltDataPage.Size = new System.Drawing.Size(712, 537);
            this.xsltDataPage.TabIndex = 1;
            this.xsltDataPage.Text = "xsltDataPage";
            this.xsltDataPage.UseVisualStyleBackColor = true;
            // 
            // xslPreview
            // 
            this.xslPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xslPreview.Location = new System.Drawing.Point(0, 0);
            this.xslPreview.Multiline = true;
            this.xslPreview.Name = "xslPreview";
            this.xslPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.xslPreview.Size = new System.Drawing.Size(709, 531);
            this.xslPreview.TabIndex = 11;
            // 
            // xmlTransformedPage
            // 
            this.xmlTransformedPage.Controls.Add(this.xmlTransformedPreview);
            this.xmlTransformedPage.Location = new System.Drawing.Point(4, 22);
            this.xmlTransformedPage.Name = "xmlTransformedPage";
            this.xmlTransformedPage.Size = new System.Drawing.Size(712, 537);
            this.xmlTransformedPage.TabIndex = 2;
            this.xmlTransformedPage.Text = "xmlTransformedPage";
            this.xmlTransformedPage.UseVisualStyleBackColor = true;
            // 
            // xmlTransformedPreview
            // 
            this.xmlTransformedPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xmlTransformedPreview.Location = new System.Drawing.Point(0, 0);
            this.xmlTransformedPreview.Multiline = true;
            this.xmlTransformedPreview.Name = "xmlTransformedPreview";
            this.xmlTransformedPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.xmlTransformedPreview.Size = new System.Drawing.Size(709, 534);
            this.xmlTransformedPreview.TabIndex = 12;
            // 
            // acceptChanges
            // 
            this.acceptChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptChanges.Location = new System.Drawing.Point(740, 615);
            this.acceptChanges.Name = "acceptChanges";
            this.acceptChanges.Size = new System.Drawing.Size(152, 38);
            this.acceptChanges.TabIndex = 10;
            this.acceptChanges.Text = "Применить";
            this.acceptChanges.UseVisualStyleBackColor = true;
            this.acceptChanges.Click += new System.EventHandler(this.OnAcceptClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.acceptChanges);
            this.Controls.Add(this.saveToFile);
            this.Controls.Add(this.textTabs);
            this.Controls.Add(this.transformXML);
            this.Controls.Add(this.xsltPath);
            this.Controls.Add(this.xmlPath);
            this.Controls.Add(this.readXSLT);
            this.Controls.Add(this.readXML);
            this.Controls.Add(this.previewLabel);
            this.Name = "Form1";
            this.Text = "XmlParser";
            this.textTabs.ResumeLayout(false);
            this.xmlDataPage.ResumeLayout(false);
            this.xmlDataPage.PerformLayout();
            this.xsltDataPage.ResumeLayout(false);
            this.xsltDataPage.PerformLayout();
            this.xmlTransformedPage.ResumeLayout(false);
            this.xmlTransformedPage.PerformLayout();
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
        private System.Windows.Forms.Button saveToFile;
        private System.Windows.Forms.TabControl textTabs;
        private System.Windows.Forms.TabPage xmlDataPage;
        private System.Windows.Forms.TabPage xsltDataPage;
        private System.Windows.Forms.TextBox xmlDataPreview;
        private System.Windows.Forms.TabPage xmlTransformedPage;
        private System.Windows.Forms.HelpProvider onErrorPopup;
        private System.Windows.Forms.Button acceptChanges;
        private System.Windows.Forms.TextBox xslPreview;
        private System.Windows.Forms.TextBox xmlTransformedPreview;
    }
}

