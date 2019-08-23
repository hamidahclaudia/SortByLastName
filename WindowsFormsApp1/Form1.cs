using System;
using System.Windows.Forms;
using WindowsFormsApp1.ApplicationShared.FileHelper;
using WindowsFormsApp1.ApplicationShared.SortName;

namespace SortByLastNameApp
{
    public partial class Form1 : Form
    {
        private ISortName sortName;
        private IFileHelper fileHelper; 
        private String unsortedNameText;
        private String path;

        public Form1(ISortName _sortName, IFileHelper _filehelper)
        {
            InitializeComponent();
            this.sortName = _sortName;
            this.fileHelper = _filehelper;
        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents|*.txt", Multiselect = false, ValidateNames = true })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        textBox1.Text = fileHelper.ReadTextFile(ofd.FileName);
                        path = ofd.FileName;
                        unsortedNameText = textBox1.Text;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            try
            {
                var nameSorted =  sortName.SortByFirstName(unsortedNameText, path);
                //fileHelper.WriteFile()
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
