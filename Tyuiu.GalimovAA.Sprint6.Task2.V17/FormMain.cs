using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.GalimovAA.Sprint6.Task2.V17.Lib;

namespace Tyuiu.GalimovAA.Sprint6.Task2.V17
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
                int startStep = Convert.ToInt32(textBoxStartStep_GAA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_GAA.Text);

                int len = stopStep - startStep + 1;
                double[] valueArray = ds.GetMassFunction(startStep, stopStep);

                // Очищаем DataGridView
                dataGridViewResult_GAA.Rows.Clear();
                dataGridViewResult_GAA.Columns.Clear();

                // Добавляем колонки
                dataGridViewResult_GAA.Columns.Add("X", "X");
                dataGridViewResult_GAA.Columns.Add("F(X)", "F(X)");

                // Заполняем данные
                for (int i = 0; i < len; i++)
                {
                    dataGridViewResult_GAA.Rows.Add(
                        (startStep + i).ToString(),
                        valueArray[i].ToString()
                    );
                }

                // Строим график
                chartFunction_GAA.Series[0].Points.Clear();
                for (int i = 0; i < len; i++)
                {
                    chartFunction_GAA.Series[0].Points.AddXY(startStep + i, valueArray[i]);
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_GAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Табулирование функции F(x) = cos(x) + (4x)/2 - sin(x)*3x\n" +
                          "Диапазон: [-5; 5] с шагом 1\n" +
                          "Выполнил: Галимов Артём Азатович, ПКТб-24-1",
                          "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}