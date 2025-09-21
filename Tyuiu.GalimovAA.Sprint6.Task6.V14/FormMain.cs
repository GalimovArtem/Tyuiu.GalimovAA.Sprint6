using System;
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

        private void buttonOpenFile_GAA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_GAA.ShowDialog();
            string path = openFileDialogTask_GAA.FileName;

            if (File.Exists(path))
            {
                textBoxIn_GAA.Text = File.ReadAllText(path);

                DataService ds = new DataService();
                textBoxOut_GAA.Text = ds.CollectTextFromFile(path);
            }
            else
            {
                MessageBox.Show("Файл не выбран или не существует", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_GAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}