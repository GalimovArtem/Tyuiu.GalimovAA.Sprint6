using System;
using System.Windows.Forms;
using System.IO;
using Tyuiu.GalimovAA.Sprint6.Task5.V11.Lib;

namespace Tyuiu.GalimovAA.Sprint6.Task5.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\Users\artem\source\repos\Tyuiu.GalimovAA.Sprint6\Tyuiu.GalimovAA.Sprint6.Task5.V11\bin\Debug\InPutFileTask5V11.txt";

        private void buttonOpenFile_GAA_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
                Title = "Выберите файл с данными",
                InitialDirectory = Directory.GetCurrentDirectory()
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;

                try
                {
                    double[] numbers = ds.LoadFromDataFile(path);

                    dataGridViewNumbers_GAA.Rows.Clear();
                    chartNumbers_GAA.Series[0].Points.Clear();

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        dataGridViewNumbers_GAA.Rows.Add(i.ToString(), numbers[i].ToString("F3"));
                    }

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        chartNumbers_GAA.Series[0].Points.AddXY(i, numbers[i]);
                    }

                    textBoxPath_GAA.Text = path;
                    groupBoxResult_GAA.Text = $"Результат (найдено {numbers.Length} чисел)";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonHelp_GAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 Вариант 11 выполнил студент группы ПКТб-24-1 Галимов Артём Азатович", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            chartNumbers_GAA.ChartAreas[0].AxisX.Title = "Индекс";
            chartNumbers_GAA.ChartAreas[0].AxisY.Title = "Значение";
            chartNumbers_GAA.Series[0].LegendText = "Числа кратные 5";
        }
    }
}