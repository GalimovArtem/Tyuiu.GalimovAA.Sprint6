using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.GalimovAA.Sprint6.Task6.V14
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            try
            {
                pictureBoxAvatar_GAA.Image = Image.FromFile("C:/Users/Яр/source/repos/Tyuiu.GalimovAA.Sprint6/photo_2025-09-06_18-17-26.png");
            }
            catch
            {
                pictureBoxAvatar_GAA.Image = SystemIcons.Warning.ToBitmap();
            }
        }

        private void buttonOk_GAA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelInfo_GAA_Click(object sender, EventArgs e)
        {

        }
    }
}