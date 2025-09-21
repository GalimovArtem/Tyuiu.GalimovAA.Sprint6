using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.GalimovAA.Sprint6.Task6.V14.Lib;

namespace Tyuiu.GalimovAA.Sprint6.Task6.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            string filename = openFileDialogTask.FileName;

            if (File.Exists(filename))
            {
                textBoxIn.Text = File.ReadAllText(filename);
                buttonExecute.Enabled = true;
            }
            else
            {
                MessageBox.Show("Файл не выбран или не существует!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                string path = openFileDialogTask.FileName;
                string result = ds.CollectTextFromFile(path);
                textBoxOut.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}