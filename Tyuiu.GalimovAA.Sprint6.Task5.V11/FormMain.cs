using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.GalimovAA.Sprint6.Task5.V11.Lib;

namespace Tyuiu.GalimovAA.Sprint6.Task5.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_GAA_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
                Title = "Выберите файл для открытия"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                DataService ds = new DataService();

                try
                {
                    double[] positiveValues = ds.LoadFromDataFile(path);

                    // Выводим данные в dataGridView
                    dataGridViewValues_GAA.Rows.Clear();
                    dataGridViewValues_GAA.Columns.Clear();

                    dataGridViewValues_GAA.Columns.Add("Value", "Положительные значения");

                    foreach (double value in positiveValues)
                    {
                        dataGridViewValues_GAA.Rows.Add(value.ToString("F3"));
                    }

                    // Строим диаграмму
                    chartDiagram_GAA.Series.Clear();
                    chartDiagram_GAA.ChartAreas.Clear();

                    ChartArea chartArea = new ChartArea();
                    chartArea.AxisX.Title = "Ось X";
                    chartArea.AxisY.Title = "Ось Y";
                    chartDiagram_GAA.ChartAreas.Add(chartArea);

                    Series series = new Series
                    {
                        Name = "Положительные значения",
                        ChartType = SeriesChartType.Column,
                        Color = System.Drawing.Color.Blue
                    };

                    for (int i = 0; i < positiveValues.Length; i++)
                    {
                        series.Points.AddXY(i + 1, positiveValues[i]);
                    }

                    chartDiagram_GAA.Series.Add(series);
                    chartDiagram_GAA.ChartAreas[0].AxisX.Interval = 1;

                    textBoxPath_GAA.Text = path;
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
    }
}