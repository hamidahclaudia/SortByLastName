using System;
using System.Windows.Forms;

namespace SortByLastNameApp
{
    public partial class Form1 : Form
    {
        private SortName sort;
        private String unsortedNameText;
        private String path;

        public Form1(SortName _sort)
        {
            InitializeComponent();
            sort = _sort;
        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents|*.txt", Multiselect = false, ValidateNames = true })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        textBox1.Text = sort.ReadUnsortedList(ofd.FileName);
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
                textBox1.Text = sort.SortByLastname(unsortedNameText, path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
