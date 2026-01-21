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
            this.previewBox = new System.Windows.Forms.TextBox();
            this.saveXmlExport = new System.Windows.Forms.SaveFileDialog();
            this.saveExportXml = new System.Windows.Forms.Button();
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
            this.transformXML.Location = new System.Drawing.Point(452, 542);
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
            // previewBox
            // 
            this.previewBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.previewBox.Location = new System.Drawing.Point(452, 36);
            this.previewBox.Multiline = true;
            this.previewBox.Name = "previewBox";
            this.previewBox.ReadOnly = true;
            this.previewBox.Size = new System.Drawing.Size(720, 500);
            this.previewBox.TabIndex = 8;
            // 
            // saveExportXml
            // 
            this.saveExportXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveExportXml.Location = new System.Drawing.Point(1020, 542);
            this.saveExportXml.Name = "saveExportXml";
            this.saveExportXml.Size = new System.Drawing.Size(152, 38);
            this.saveExportXml.TabIndex = 9;
            this.saveExportXml.Text = "Сохранить";
            this.saveExportXml.UseVisualStyleBackColor = true;
            this.saveExportXml.Click += new System.EventHandler(this.saveTransformedXML);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.saveExportXml);
            this.Controls.Add(this.previewBox);
            this.Controls.Add(this.transformXML);
            this.Controls.Add(this.xsltPath);
            this.Controls.Add(this.xmlPath);
            this.Controls.Add(this.readXSLT);
            this.Controls.Add(this.readXML);
            this.Controls.Add(this.previewLabel);
            this.Name = "Form1";
            this.Text = "XmlParser";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox previewBox;
        private System.Windows.Forms.SaveFileDialog saveXmlExport;
        private System.Windows.Forms.Button saveExportXml;
    }
}

