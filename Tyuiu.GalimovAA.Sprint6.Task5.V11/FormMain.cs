// FormMain.cs
using System;
using System.Windows.Forms;
using Tyuiu.GalimovAA.Sprint6.Task6.V14.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            string selectedFile = openFileDialogTask.FileName;

            try
            {
                textBoxIn.Text = System.IO.File.ReadAllText(selectedFile);
                buttonExecute.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Не удалось открыть файл", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            string path = openFileDialogTask.FileName;

            try
            {
                textBoxOut.Text = ds.CollectTextFromFile("", path);
            }
            catch
            {
                MessageBox.Show("Ошибка при выполнении задания", "Ошибка",
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