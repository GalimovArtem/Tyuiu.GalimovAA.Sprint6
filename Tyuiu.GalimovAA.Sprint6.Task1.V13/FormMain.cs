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

                textBoxResult_GAA.Text = "���������:" + Environment.NewLine;
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
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_GAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������������� ������� F(x) = (3cos(x))/(4x-0.5) + sin(x) - 5x - 2\n" +
                          "�� ��������� �� -5 �� 5 � ����� 1.\n" +
                          "��������: ������� ���� ��������, ����-24-1",
                          "�������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}