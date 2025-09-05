using System;
using System.Windows.Forms;
using Tyuiu.GalimovAA.Sprint6.Task1.V13.Lib;

namespace Tyuiu.GalimovAA.Sprint6.Task1.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_GAA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_GAA.Text);
                int stopValue = Convert.ToInt32(textBoxStop_GAA.Text);

                double[] valueArray = ds.GetMassFunction(startValue, stopValue);

                textBoxResult_GAA.Text = "Результат:" + Environment.NewLine;
                textBoxResult_GAA.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_GAA.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxResult_GAA.AppendText("+----------+----------+" + Environment.NewLine);

                int count = 0;
                for (int x = startValue; x <= stopValue; x++)
                {
                    textBoxResult_GAA.AppendText($"| {x,5}    | {valueArray[count],6:f2}   |" + Environment.NewLine);
                    count++;
                }

                textBoxResult_GAA.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_GAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Табулирование функции F(x) = (3cos(x))/(4x-0.5) + sin(x) - 5x - 2\n" +
                          "на диапазоне от -5 до 5 с шагом 1.\n" +
                          "Выполнил: Галимов Артём Азатович, ПКТб-24-1",
                          "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}