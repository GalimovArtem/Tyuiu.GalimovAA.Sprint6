using System;
using System.Windows.Forms;
using Tyuiu.GalimovAA.Sprint6.Task0.V23.Lib;

namespace Tyuiu.GalimovAA.Sprint6.Task0.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCalculate_GAA_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                int x = Convert.ToInt32(textBoxInput_GAA.Text);
                double result = ds.Calculate(x);
                textBoxResult_GAA.Text = result.ToString("F3");
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_GAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ПКТб-24-1 Галимов Артём Азатович",
                "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}