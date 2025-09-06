using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.GalimovAA.Sprint6.Task4.V3.Lib;

namespace Tyuiu.GalimovAA.Sprint6.Task4.V3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

         
            chartFunction_GAA.ChartAreas[0].AxisX.Title = "Ось X";
            chartFunction_GAA.ChartAreas[0].AxisY.Title = "Ось Y";
            chartFunction_GAA.Series[0].Name = "F(x)";
            chartFunction_GAA.Series[0].ChartType = SeriesChartType.Spline;
            chartFunction_GAA.Series[0].BorderWidth = 3;
        }

        private void buttonDone_GAA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                int startValue = Convert.ToInt32(textBoxStart_GAA.Text);
                int stopValue = Convert.ToInt32(textBoxStop_GAA.Text);

                if (startValue > stopValue)
                {
                    MessageBox.Show("Стартовое значение не может быть больше конечного", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double[] valueArray = ds.GetMassFunction(startValue, stopValue);

                textBoxResult_GAA.Text = "";
                chartFunction_GAA.Series[0].Points.Clear();

                for (int i = 0; i < valueArray.Length; i++)
                {
                    double x = startValue + i;
                    textBoxResult_GAA.AppendText($"F({x}) = {valueArray[i]}" + Environment.NewLine);
                    chartFunction_GAA.Series[0].Points.AddXY(x, valueArray[i]);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены неверные данные. Пожалуйста, введите целые числа.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_GAA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V3.txt";

                if (string.IsNullOrEmpty(textBoxResult_GAA.Text))
                {
                    MessageBox.Show("Нет данных для сохранения. Сначала выполните расчет.", "Предупреждение",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                File.WriteAllText(path, textBoxResult_GAA.Text);

                DialogResult result = MessageBox.Show($"Файл {path} сохранен успешно!\nОткрыть его в блокноте?",
                    "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("notepad.exe", path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сбой при сохранении файла: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_GAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ПКТб-24-1 Галимов Артём Азатович",
                "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}