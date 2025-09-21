using System;
using System.Windows.Forms;

namespace Tyuiu.GalimovAA.Sprint6.Task6.V14
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