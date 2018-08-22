namespace ImageFetcher
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
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtOpenFile = new System.Windows.Forms.TextBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.txtColumnIndex = new System.Windows.Forms.TextBox();
            this.txtCopyToFolder = new System.Windows.Forms.TextBox();
            this.txtTestCount = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCopyFromFormat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.txtColumnName = new System.Windows.Forms.TextBox();
            this.txtFileType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(247, 31);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Öppna";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtOpenFile
            // 
            this.txtOpenFile.Location = new System.Drawing.Point(12, 33);
            this.txtOpenFile.Name = "txtOpenFile";
            this.txtOpenFile.Size = new System.Drawing.Size(229, 20);
            this.txtOpenFile.TabIndex = 1;
            this.txtOpenFile.Text = "C:\\Tmp\\FileList.csv";
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(12, 308);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResults.Size = new System.Drawing.Size(503, 323);
            this.txtResults.TabIndex = 2;
            this.txtResults.Text = "(results)";
            // 
            // txtColumnIndex
            // 
            this.txtColumnIndex.Location = new System.Drawing.Point(12, 94);
            this.txtColumnIndex.Name = "txtColumnIndex";
            this.txtColumnIndex.Size = new System.Drawing.Size(100, 20);
            this.txtColumnIndex.TabIndex = 3;
            this.txtColumnIndex.Text = "4";
            this.txtColumnIndex.TextChanged += new System.EventHandler(this.txtColumnIndex_TextChanged);
            // 
            // txtCopyToFolder
            // 
            this.txtCopyToFolder.Location = new System.Drawing.Point(15, 230);
            this.txtCopyToFolder.Name = "txtCopyToFolder";
            this.txtCopyToFolder.Size = new System.Drawing.Size(427, 20);
            this.txtCopyToFolder.TabIndex = 4;
            this.txtCopyToFolder.Text = "C:\\To\\";
            // 
            // txtTestCount
            // 
            this.txtTestCount.Location = new System.Drawing.Point(12, 281);
            this.txtTestCount.Name = "txtTestCount";
            this.txtTestCount.Size = new System.Drawing.Size(100, 20);
            this.txtTestCount.TabIndex = 5;
            this.txtTestCount.Text = "10";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(130, 279);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 6;
            this.btnTest.Text = "Testa!";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(440, 278);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 7;
            this.btnCopy.Text = "Kopiera!";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Öppna en csv eller txt, ;-separerad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Välj vilken kolumn som ska användas som sökväg";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Testa såhär många bilder:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(464, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "String.Format för den fulla sökvägen, där värdet i kolumnen som valdes ovan komme" +
    "r läggas i {0}";
            // 
            // txtCopyFromFormat
            // 
            this.txtCopyFromFormat.Location = new System.Drawing.Point(15, 191);
            this.txtCopyFromFormat.Name = "txtCopyFromFormat";
            this.txtCopyFromFormat.Size = new System.Drawing.Size(424, 20);
            this.txtCopyFromFormat.TabIndex = 4;
            this.txtCopyFromFormat.Text = "C:\\From\\";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kopiera till denna mapp";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(12, 128);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(242, 13);
            this.lblFile.TabIndex = 12;
            this.lblFile.Text = "Välj vilken kolumn som ska användas som filnamn";
            // 
            // txtColumnName
            // 
            this.txtColumnName.Location = new System.Drawing.Point(12, 144);
            this.txtColumnName.Name = "txtColumnName";
            this.txtColumnName.Size = new System.Drawing.Size(100, 20);
            this.txtColumnName.TabIndex = 11;
            this.txtColumnName.Text = "0";
            this.txtColumnName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtFileType
            // 
            this.txtFileType.Location = new System.Drawing.Point(118, 144);
            this.txtFileType.Name = "txtFileType";
            this.txtFileType.Size = new System.Drawing.Size(100, 20);
            this.txtFileType.TabIndex = 11;
            this.txtFileType.Text = ".jpg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 643);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.txtFileType);
            this.Controls.Add(this.txtColumnName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtTestCount);
            this.Controls.Add(this.txtCopyFromFormat);
            this.Controls.Add(this.txtCopyToFolder);
            this.Controls.Add(this.txtColumnIndex);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.txtOpenFile);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtOpenFile;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.TextBox txtColumnIndex;
        private System.Windows.Forms.TextBox txtCopyToFolder;
        private System.Windows.Forms.TextBox txtTestCount;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCopyFromFormat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.TextBox txtColumnName;
        private System.Windows.Forms.TextBox txtFileType;
    }
}

