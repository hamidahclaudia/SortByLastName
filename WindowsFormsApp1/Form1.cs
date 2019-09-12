using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.ApplicationService;
using WindowsFormsApp1.ApplicationShared.FileHelper;
using WindowsFormsApp1.ApplicationShared.SortName;
using WindowsFormsApp1.ApplicationShared.SortName.Model;

namespace SortByLastNameApp
{
    public partial class Form1 : Form
    {
        private String unsortedNameText;
        private String path;

        private IFileHelper fileHelper;
        private ISortName sortName;

        public Form1(IFileHelper _fileHelper, ISortName _sortName)
        {
            InitializeComponent();
            this.fileHelper = _fileHelper;
            this.sortName = _sortName;
        }
                    
        private void ChooseButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents|*.txt", Multiselect = false, ValidateNames = true })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        unsortedNameText = fileHelper.ReadTextFile(ofd.FileName);
                        path = ofd.FileName;
                        textBox1.Text = unsortedNameText;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LastNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                //SortName sortName = new SortName();
                var nameSorted = sortName.SortByLastName(unsortedNameText, path).ToList();

                var fileNameUnsorted = path.Split(new char[] { '\\' }).Last();
                var resultPath = path.Replace(fileNameUnsorted, "sorted-by-last-name.txt");

                fileHelper.WriteFile(resultPath, nameSorted);
                textBox1.Text = fileHelper.ReadTextFile(resultPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FirstNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                //SortName sortName = new SortName();
                var nameSorted = sortName.SortByFirstName(unsortedNameText, path).ToList();

                var fileNameUnsorted = path.Split(new char[] { '\\' }).Last();
                var resultPath = path.Replace(fileNameUnsorted, "sorted-by-first-name.txt");

                fileHelper.WriteFile(resultPath, nameSorted);
                textBox1.Text = fileHelper.ReadTextFile(resultPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


