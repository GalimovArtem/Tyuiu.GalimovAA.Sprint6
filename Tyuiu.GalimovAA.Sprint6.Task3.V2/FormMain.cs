using System;
using System.Drawing;
using System.Windows.Forms;
using Tyuiu.GalimovAA.Sprint6.Task3.V2.Lib;

namespace Tyuiu.GalimovAA.Sprint6.Task3.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewMatrix_GAA.ColumnCount = 5;
            dataGridViewMatrix_GAA.RowCount = 5;

            dataGridViewResult_GAA.ColumnCount = 5;
            dataGridViewResult_GAA.RowCount = 5;

            for (int i = 0; i < 5; i++)
            {
                dataGridViewMatrix_GAA.Columns[i].Width = 50;
                dataGridViewResult_GAA.Columns[i].Width = 50;
            }

            // Предзаполнение матрицы данными из условия
            int[,] initialMatrix = new int[5, 5]
            {
                { -12, -4, -20, 5, -5 },
                { 2, 15, 1, -20, 7 },
                { 15, -15, 2, 11, 5 },
                { -19, -9, 16, 0, 1 },
                { 17, 16, 5, 12, -8 }
            };

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridViewMatrix_GAA.Rows[i].Cells[j].Value = initialMatrix[i, j];
                }
            }
        }

        private void buttonDone_GAA_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] matrix = new int[5, 5];

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        matrix[i, j] = Convert.ToInt32(dataGridViewMatrix_GAA.Rows[i].Cells[j].Value);
                    }
                }

                DataService ds = new DataService();
                int[,] resultMatrix = ds.Calculate(matrix);

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        dataGridViewResult_GAA.Rows[i].Cells[j].Value = resultMatrix[i, j];
                    }
                }

                buttonDone_GAA.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_GAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ПКТб-24-1 Галимов Артём Азатович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}