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
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.readXML = new System.Windows.Forms.Button();
            this.readXSLT = new System.Windows.Forms.Button();
            this.xmlPath = new System.Windows.Forms.TextBox();
            this.xsltPath = new System.Windows.Forms.TextBox();
            this.xmlView = new System.Windows.Forms.TreeView();
            this.transformXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(751, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Превью файла";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OnFileOk);
            // 
            // readXML
            // 
            this.readXML.Location = new System.Drawing.Point(12, 116);
            this.readXML.Name = "readXML";
            this.readXML.Size = new System.Drawing.Size(126, 23);
            this.readXML.TabIndex = 1;
            this.readXML.Text = "Открыть XML";
            this.readXML.UseVisualStyleBackColor = true;
            // 
            // readXSLT
            // 
            this.readXSLT.Location = new System.Drawing.Point(12, 206);
            this.readXSLT.Name = "readXSLT";
            this.readXSLT.Size = new System.Drawing.Size(126, 23);
            this.readXSLT.TabIndex = 2;
            this.readXSLT.Text = "Открыть XSLT";
            this.readXSLT.UseVisualStyleBackColor = true;
            // 
            // xmlPath
            // 
            this.xmlPath.Location = new System.Drawing.Point(145, 116);
            this.xmlPath.Name = "xmlPath";
            this.xmlPath.ReadOnly = true;
            this.xmlPath.Size = new System.Drawing.Size(284, 20);
            this.xmlPath.TabIndex = 3;
            this.xmlPath.Text = "путь к xml...";
            // 
            // xsltPath
            // 
            this.xsltPath.Location = new System.Drawing.Point(145, 206);
            this.xsltPath.Name = "xsltPath";
            this.xsltPath.ReadOnly = true;
            this.xsltPath.Size = new System.Drawing.Size(284, 20);
            this.xsltPath.TabIndex = 4;
            this.xsltPath.Text = "путь к xslt...";
            // 
            // xmlView
            // 
            this.xmlView.Location = new System.Drawing.Point(452, 36);
            this.xmlView.Name = "xmlView";
            this.xmlView.Size = new System.Drawing.Size(720, 500);
            this.xmlView.TabIndex = 6;
            // 
            // transformXML
            // 
            this.transformXML.Location = new System.Drawing.Point(755, 543);
            this.transformXML.Name = "transformXML";
            this.transformXML.Size = new System.Drawing.Size(137, 23);
            this.transformXML.TabIndex = 7;
            this.transformXML.Text = "Конвертировать";
            this.transformXML.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.transformXML);
            this.Controls.Add(this.xmlView);
            this.Controls.Add(this.xsltPath);
            this.Controls.Add(this.xmlPath);
            this.Controls.Add(this.readXSLT);
            this.Controls.Add(this.readXML);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "XmlParser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button readXML;
        private System.Windows.Forms.Button readXSLT;
        private System.Windows.Forms.TextBox xmlPath;
        private System.Windows.Forms.TextBox xsltPath;
        private System.Windows.Forms.TreeView xmlView;
        private System.Windows.Forms.Button transformXML;
    }
}

