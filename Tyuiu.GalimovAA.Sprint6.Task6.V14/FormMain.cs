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

            try
            {
                textBoxIn_GAA.Text = File.ReadAllText(path);

                DataService ds = new DataService();
                textBoxOut_GAA.Text = ds.CollectTextFromFile(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_GAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void textBoxIn_GAA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOut_GAA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}