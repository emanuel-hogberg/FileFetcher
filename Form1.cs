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

namespace ImageFetcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataInput x = new DataInput();
        List<string> missingImages = new List<string>();
        int columnImage = -1;
        int columnName = -1;
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtResults.Clear();
                x.LoadFile(this.txtOpenFile.Text, ";", ";");
                ColumnIndexOk();
            }
            catch (Exception ex)
            {
                this.txtResults.Text = ex.ToString();
            }
        }

        private void ColumnIndexOk(bool showExamples = true)
        {
            txtResults.Text = "";
            this.columnImage = -1;
            this.columnName = -1;
            if (int.TryParse(this.txtColumnIndex.Text, out int i))
            {
                if (i >= 0 && i < x.Columns.Count)
                {

                    if (showExamples)
                        ShowColumnContentExamples(i);
                    this.columnImage = i;
                }
                else
                {
                    txtResults.Text = "Image column out of bounds.";
                    this.columnImage = -1;
                }
            }
            else
            {
                txtResults.Text = " Image columnnot a number";
                this.columnImage = -1;
            }
            if (int.TryParse(this.txtColumnName.Text, out int j))
            {
                if (j >= 0 && j < x.Columns.Count)
                {
                    this.columnName = j;
                    if (showExamples)
                        ShowColumnContentExamples(j);

                    if (this.columnName >= 0 && this.columnImage >= 0)
                    {
                        try
                        {
                            var imageCol = x.Columns[this.columnImage];
                            if (imageCol.Example1.Contains("."))
                            {
                                int d = imageCol.Example1.IndexOf('.');
                                txtFileType.Text = imageCol.Example1.Substring(d).Replace("\"", "");
                            }
                            else
                            {
                                txtFileType.Text = "";
                                this.txtResults.Text += " Image column has no file ending!";
                            }
                        }
                        catch
                        {
                            this.txtResults.Text = this.txtResults.Text + "Error when trying to get file type from image name example!";
                        }
                    }
                }
                else
                {
                    txtResults.Text = "Name column out of bounds";
                    this.columnName = -1;
                }
            }
            else
            {
                txtResults.Text = "Name column  not a number";
                this.columnName = -1;
            }
        }

        private void ShowColumnContentExamples(int i)
        {
            this.txtResults.Text = this.txtResults.Text + x.Columns[i].ToString() + Environment.NewLine;
        }

        private void txtColumnIndex_TextChanged(object sender, EventArgs e)
        {
            ColumnIndexOk();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ColumnIndexOk();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            this.txtResults.Text = "Testing... ";
            bool prepsOK = true;
            if (!int.TryParse(this.txtTestCount.Text, out int c))
            {
                this.txtResults.Text += "Test count is not an int! ";
                prepsOK = false;
            }
            string from = "", to = "", fileEnding = "";
            prepsOK = prepsOK && PrepareCopy(out from, out to, out fileEnding);

            if (prepsOK)
            {
                CopyImages(c, from, to, fileEnding);
            }
            this.txtResults.Text += Environment.NewLine + string.Format("Full copy will include {0} images!", x.Count);
        }

        private void CopyImages(int imagesToCopy, string from, string to, string fileEnding)
        {
            var images = x.GetColumn(this.columnImage);
            var names = x.GetColumn(this.columnName);
            if (images.Count() != names.Count()) throw new IndexOutOfRangeException("Columns do not have the same number of rows!!");
            if (names.Count() < imagesToCopy) throw new IndexOutOfRangeException("Number of images to copy is larger than the available number of images!");
            int alreadyExisted = 0;
            for (int i = 0; i < imagesToCopy; i++)
            {
                string fileToCopy = string.Format(from, images[i]).Replace("/", "\\").Replace("\"", "");
                string toFile = string.Concat(to, names[i].Replace("\"", ""), fileEnding);
                if (File.Exists(fileToCopy))
                {
                    if (!File.Exists(toFile))
                    {
                        File.Copy(fileToCopy, toFile);
                    }
                    else
                    {
                        alreadyExisted++;
                    }
                }
                else
                {
                    this.missingImages.Add(fileToCopy);
                }
            }

            if (this.missingImages.Any())
            {
                this.txtResults.Text = "Missing images:";
                this.missingImages.GetRange(0, Math.Min(4, this.missingImages.Count)).ForEach(i => this.txtResults.Text += i + ",");
                this.txtResults.Text += string.Format(" {0} in total.", this.missingImages.Count);
            }
            this.txtResults.Text += Environment.NewLine + string.Format("Copy complete!! Copies: {0}, already existed: {1}", imagesToCopy, alreadyExisted);
        }

        private bool PrepareCopy(out string from, out string to, out string fileEnding)
        {
            bool prepsOK = true;
            missingImages.Clear();
            ColumnIndexOk(false);
            from = txtCopyFromFormat.Text;
            to = txtCopyToFolder.Text;
            fileEnding = this.txtFileType.Text;
            if (!from.Contains("{0}")) from += "{0}";
            if (!to.EndsWith("\\")) to += "\\";
            if (!Directory.Exists(to))
            {
                this.txtResults.Text += "To folder does not exist. ";
                prepsOK = false;
            }
            if (!Directory.Exists(to.Replace("{0}", "")))
            {
                this.txtResults.Text += "From folder does not exist. ";
            }
            if (!fileEnding.StartsWith("."))
            {
                this.txtResults.Text += "Invalid file ending. ";
            }
            if (this.columnName < 0 || this.columnImage < 0)
            {
                this.txtResults.Text += " Columns not ok!";
                return false;
            }

            return prepsOK;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            this.txtResults.Text = "Testing... ";
            bool prepsOK = true;
            string from = "", to = "", fileEnding = "";
            prepsOK = prepsOK && PrepareCopy(out from, out to, out fileEnding);

            if (prepsOK)
            {
                CopyImages(x.Count, from, to, fileEnding);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
