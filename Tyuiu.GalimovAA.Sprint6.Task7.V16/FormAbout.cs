using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.GalimovAA.Sprint6.Task7.V16
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}