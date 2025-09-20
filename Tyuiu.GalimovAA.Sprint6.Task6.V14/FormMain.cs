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
                string result = ds.CollectTextFromFile("z", path);
                textBoxOut_GAA.Text = result;
            }
            else
            {
                MessageBox.Show("Файл не выбран!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_GAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void labelIn_GAA_Click(object sender, EventArgs e)
        {

        }
    }
}