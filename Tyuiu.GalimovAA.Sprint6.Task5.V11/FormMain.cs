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
                Filter = "��������� ����� (*.txt)|*.txt|��� ����� (*.*)|*.*",
                Title = "�������� ���� ��� ��������"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                DataService ds = new DataService();

                try
                {
                    double[] positiveValues = ds.LoadFromDataFile(path);

                    // ������� ������ � dataGridView
                    dataGridViewValues_GAA.Rows.Clear();
                    dataGridViewValues_GAA.Columns.Clear();

                    dataGridViewValues_GAA.Columns.Add("Value", "������������� ��������");

                    foreach (double value in positiveValues)
                    {
                        dataGridViewValues_GAA.Rows.Add(value.ToString("F3"));
                    }

                    // ������ ���������
                    chartDiagram_GAA.Series.Clear();
                    chartDiagram_GAA.ChartAreas.Clear();

                    ChartArea chartArea = new ChartArea();
                    chartArea.AxisX.Title = "��� X";
                    chartArea.AxisY.Title = "��� Y";
                    chartDiagram_GAA.ChartAreas.Add(chartArea);

                    Series series = new Series
                    {
                        Name = "������������� ��������",
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
                    MessageBox.Show($"������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonHelp_GAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 5 ������� 11 �������� ������� ������ ����-24-1 ������� ���� ��������", "�������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}