using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace D2L_DataLake_Templates.Win
{
    public partial class CloneAndRename : Form
    {
        private string[] files;

        public CloneAndRename()
        {
            InitializeComponent();
        }

        private void btnListOfFiles_Click(object sender, EventArgs e)
        {
            GetListOfFiles();
        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            Clone();
        }

        private void Clone()
        {
            try
            {
                List<string> newFiles = new List<string>();
                var searchFor = txtSearchFor.Text;
                var cloneTo = txtCloneTo.Text;
                for (int index = 0; index < chkLstFiles.Items.Count; index++)
                {
                    var item = chkLstFiles.Items[index];
                    var currentFilePath = (item as string);

                    //Read File
                    var contents = File.ReadAllText(currentFilePath);
                    contents = contents.Replace(searchFor, cloneTo);
                    //Save new file
                    var newFilePath = currentFilePath.Replace(searchFor, cloneTo);
                    var temp = newFilePath.Split("\\");
                    var tempPath = "";
                    for (int i = 0; i < temp.Length - 1; i++)
                    {
                        tempPath += (i == 0 ? "" : "\\") + temp[i];
                    }

                    //Save file
                    if (!Directory.Exists(tempPath))
                    {
                        Directory.CreateDirectory(tempPath);
                    }
                    // Create a new file
                    using (FileStream fs = File.Create(newFilePath))
                    {
                        // Add some text to file
                        byte[] tempFile = new UTF8Encoding(true).GetBytes(contents);
                        fs.Write(tempFile, 0, tempFile.Length);
                    }
                    //File.WriteAllText(newFilePath, contents);
                    //Add file to list of new Files
                    newFiles.Add(newFilePath);

                    //Checked processed item
                    chkLstFiles.SetItemChecked(index, true);
                }

                //Show new files
                if (newFiles.Count > 0)
                {
                    chkLstNewFiles.Items.AddRange(newFiles.ToArray());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                //throw;
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetListOfFiles()
        {
            this.files = null;
            chkLstFiles.Items.Clear();
            chkLstNewFiles.Items.Clear();

            var baseFolder = txtBaseFolder.Text;
            var searchFor = txtSearchFor.Text;

            //Get all the files in folders and subfolder
            var searchPattern = $"*{searchFor}*.*";
            files = Directory.GetFiles(baseFolder, searchPattern, SearchOption.AllDirectories);
            if (files != null)
            {
                chkLstFiles.Items.AddRange(files);
            }
        }
    }
}