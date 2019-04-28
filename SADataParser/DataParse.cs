using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SADataParser
{
    public partial class DataParse : Form
    {
        public DataParse()
        {
            InitializeComponent();
        }

        private void DataParse_Load(object sender, EventArgs e)
        {
            SetupControls();
        }

        private void SetupControls()
        {
            List<FormatItem> formattedItems = GetFormat();
            comboBoxFormat.DataSource = formattedItems;
            comboBoxFormat.DisplayMember = "Format";
            comboBoxFormat.ValueMember = "FormatId";

        }

        private static List<FormatItem> GetFormat()
        {
            List<FormatItem> formattedItems = new List<FormatItem>();
            formattedItems.Add(new FormatItem { FormatId = 1, Format = @"'{Data}'," });
            return formattedItems;
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
           FileInfo fileInfo = BrowseFile();
            txtSearchFile.Text = fileInfo.FullName;
        }

        #region Common

        public System.IO.FileInfo BrowseFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog {
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileToOpen = openFileDialog.FileName;
                System.IO.FileInfo fileInfo = new System.IO.FileInfo(fileToOpen);
              
                return fileInfo;
                //System.IO.StreamReader reader = new System.IO.StreamReader(fileToOpen);                
            }
            return null;
        }

        #endregion

        

        private void btnLoadData_Click(object sender, EventArgs e)
        {           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(txtSearchFile.Text);
            while ((line = file.ReadLine()) != null)
            {
                if (string.Equals(comboBoxFormat.SelectedValue.ToString(), "1"))
                {
                    string formattedLine = Regex.Replace(line, @"\s{2,}", "|", RegexOptions.Multiline);
                    string[] dataCol = formattedLine.Split('|');
                    string prepareFormattedData = $"'{dataCol[Convert.ToInt32(numericUpDownTabNo.Value-1)]}',";
                    using (System.IO.StreamWriter savfile = File.AppendText(@"d:\output.txt"))
                    {
                        savfile.WriteLine(prepareFormattedData);
                    }
                }
                counter++;
            }

            file.Close();
        }
    }

    public class FormatItem {
        public int FormatId { get; set; }
        public string Format { get; set; }
    }
}
