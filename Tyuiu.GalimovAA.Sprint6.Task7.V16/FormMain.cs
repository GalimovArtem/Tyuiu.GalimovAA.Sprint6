using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.GalimovAA.Sprint6.Task7.V16.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.GalimovAA.Sprint6.Task7.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            toolTip.SetToolTip(buttonOpenFile, "������� ���� ��� ���������");
            toolTip.SetToolTip(buttonSaveFile, "��������� ���������");
            toolTip.SetToolTip(buttonAbout, "���������� � ������������");
            toolTip.SetToolTip(buttonExecute, "��������� ��������� ������");
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                Title = "�������� ������� ����"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxInputFile.Text = openFileDialog.FileName;
                LoadDataToGrid(openFileDialog.FileName, dataGridViewIn);
            }
        }

        private void LoadDataToGrid(string filePath, DataGridView grid)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                grid.RowCount = lines.Length;
                grid.ColumnCount = lines[0].Split(';').Length;

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] values = lines[i].Split(';');
                    for (int j = 0; j < values.Length; j++)
                    {
                        grid.Rows[i].Cells[j].Value = values[j];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ �������� �����: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxInputFile.Text))
            {
                MessageBox.Show("������� �������� ������� ����!", "��������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataService ds = new DataService();
                int[,] resultMatrix = ds.GetMatrix(textBoxInputFile.Text);

                DisplayMatrixInGrid(resultMatrix, dataGridViewOut);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ���������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayMatrixInGrid(int[,] matrix, DataGridView grid)
        {
            grid.RowCount = matrix.GetLength(0);
            grid.ColumnCount = matrix.GetLength(1);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    grid.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            if (dataGridViewOut.RowCount == 0)
            {
                MessageBox.Show("������� ��������� ��������� ������!", "��������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                Title = "��������� ���������",
                FileName = "OutPutFileTask7.csv"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveGridToCSV(dataGridViewOut, saveFileDialog.FileName);
                MessageBox.Show("���� ������� ��������!", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SaveGridToCSV(DataGridView grid, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 0; i < grid.RowCount; i++)
                {
                    string line = "";
                    for (int j = 0; j < grid.ColumnCount; j++)
                    {
                        line += grid.Rows[i].Cells[j].Value?.ToString() + ";";
                    }
                    writer.WriteLine(line.TrimEnd(';'));
                }
            }
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}