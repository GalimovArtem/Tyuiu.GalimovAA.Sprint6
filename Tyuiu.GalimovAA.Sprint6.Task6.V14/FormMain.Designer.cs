namespace Tyuiu.GalimovAA.Sprint6.Task6.V14
{
    partial class FormMain
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
            this.textBoxIn_GAA = new System.Windows.Forms.TextBox();
            this.textBoxOut_GAA = new System.Windows.Forms.TextBox();
            this.buttonOpenFile_GAA = new System.Windows.Forms.Button();
            this.buttonHelp_GAA = new System.Windows.Forms.Button();
            this.openFileDialogTask_GAA = new System.Windows.Forms.OpenFileDialog();
            this.labelIn_GAA = new System.Windows.Forms.Label();
            this.labelOut_GAA = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // textBoxIn_GAA
            this.textBoxIn_GAA.Location = new System.Drawing.Point(12, 35);
            this.textBoxIn_GAA.Multiline = true;
            this.textBoxIn_GAA.Name = "textBoxIn_GAA";
            this.textBoxIn_GAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIn_GAA.Size = new System.Drawing.Size(400, 200);
            this.textBoxIn_GAA.TabIndex = 0;

            // textBoxOut_GAA
            this.textBoxOut_GAA.Location = new System.Drawing.Point(12, 270);
            this.textBoxOut_GAA.Multiline = true;
            this.textBoxOut_GAA.Name = "textBoxOut_GAA";
            this.textBoxOut_GAA.ReadOnly = true;
            this.textBoxOut_GAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut_GAA.Size = new System.Drawing.Size(400, 100);
            this.textBoxOut_GAA.TabIndex = 1;

            // buttonOpenFile_GAA
            this.buttonOpenFile_GAA.Location = new System.Drawing.Point(12, 240);
            this.buttonOpenFile_GAA.Name = "buttonOpenFile_GAA";
            this.buttonOpenFile_GAA.Size = new System.Drawing.Size(100, 25);
            this.buttonOpenFile_GAA.TabIndex = 2;
            this.buttonOpenFile_GAA.Text = "Открыть файл";
            this.buttonOpenFile_GAA.Click += new System.EventHandler(this.buttonOpenFile_GAA_Click);

            // buttonHelp_GAA
            this.buttonHelp_GAA.Location = new System.Drawing.Point(312, 240);
            this.buttonHelp_GAA.Name = "buttonHelp_GAA";
            this.buttonHelp_GAA.Size = new System.Drawing.Size(100, 25);
            this.buttonHelp_GAA.TabIndex = 3;
            this.buttonHelp_GAA.Text = "Справка";
            this.buttonHelp_GAA.Click += new System.EventHandler(this.buttonHelp_GAA_Click);

            // openFileDialogTask_GAA
            this.openFileDialogTask_GAA.FileName = "openFileDialog1";
            this.openFileDialogTask_GAA.Filter = "Текстовые файлы|*.txt";

            // labelIn_GAA
            this.labelIn_GAA.AutoSize = true;
            this.labelIn_GAA.Location = new System.Drawing.Point(12, 15);
            this.labelIn_GAA.Name = "labelIn_GAA";
            this.labelIn_GAA.Size = new System.Drawing.Size(38, 13);
            this.labelIn_GAA.Text = "Ввод:";

            // labelOut_GAA
            this.labelOut_GAA.AutoSize = true;
            this.labelOut_GAA.Location = new System.Drawing.Point(12, 250);
            this.labelOut_GAA.Name = "labelOut_GAA";
            this.labelOut_GAA.Size = new System.Drawing.Size(46, 13);
            this.labelOut_GAA.Text = "Вывод:";

            // FormMain
            this.ClientSize = new System.Drawing.Size(424, 381);
            this.Controls.Add(this.labelOut_GAA);
            this.Controls.Add(this.labelIn_GAA);
            this.Controls.Add(this.buttonHelp_GAA);
            this.Controls.Add(this.buttonOpenFile_GAA);
            this.Controls.Add(this.textBoxOut_GAA);
            this.Controls.Add(this.textBoxIn_GAA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 6 | Вариант 14 | Галимов А. А.";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxIn_GAA;
        private System.Windows.Forms.TextBox textBoxOut_GAA;
        private System.Windows.Forms.Button buttonOpenFile_GAA;
        private System.Windows.Forms.Button buttonHelp_GAA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_GAA;
        private System.Windows.Forms.Label labelIn_GAA;
        private System.Windows.Forms.Label labelOut_GAA;
    }
}