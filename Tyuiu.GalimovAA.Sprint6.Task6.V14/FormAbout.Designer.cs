namespace Tyuiu.GalimovAA.Sprint6.Task6.V14
{
    partial class FormAbout
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelInfo_GAA = new System.Windows.Forms.Label();
            this.buttonOk_GAA = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // labelInfo_GAA
            this.labelInfo_GAA.AutoSize = true;
            this.labelInfo_GAA.Location = new System.Drawing.Point(12, 20);
            this.labelInfo_GAA.Name = "labelInfo_GAA";
            this.labelInfo_GAA.Size = new System.Drawing.Size(260, 65);
            this.labelInfo_GAA.Text = "Разработчик: Галимов А. А.\r\nгруппа ПКТб-24-1\r\n\r\nПрограмма разработана в рамках изучения C#\r\nТюменский индустриальный университет (c) 2024";

            // buttonOk_GAA
            this.buttonOk_GAA.Location = new System.Drawing.Point(100, 100);
            this.buttonOk_GAA.Name = "buttonOk_GAA";
            this.buttonOk_GAA.Size = new System.Drawing.Size(75, 25);
            this.buttonOk_GAA.TabIndex = 1;
            this.buttonOk_GAA.Text = "Ок";
            this.buttonOk_GAA.Click += new System.EventHandler(this.buttonOk_GAA_Click);

            // FormAbout
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.buttonOk_GAA);
            this.Controls.Add(this.labelInfo_GAA);
            this.Name = "FormAbout";
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelInfo_GAA;
        private System.Windows.Forms.Button buttonOk_GAA;
    }
}