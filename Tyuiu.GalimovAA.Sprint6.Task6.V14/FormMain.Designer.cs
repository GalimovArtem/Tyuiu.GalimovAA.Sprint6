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
            textBoxIn_GAA = new TextBox();
            textBoxOut_GAA = new TextBox();
            buttonOpenFile_GAA = new Button();
            buttonHelp_GAA = new Button();
            openFileDialogTask_GAA = new OpenFileDialog();
            labelIn_GAA = new Label();
            labelOut_GAA = new Label();
            SuspendLayout();
            // 
            // textBoxIn_GAA
            // 
            textBoxIn_GAA.Location = new Point(12, 65);
            textBoxIn_GAA.Multiline = true;
            textBoxIn_GAA.Name = "textBoxIn_GAA";
            textBoxIn_GAA.ScrollBars = ScrollBars.Vertical;
            textBoxIn_GAA.Size = new Size(243, 200);
            textBoxIn_GAA.TabIndex = 0;
            // 
            // textBoxOut_GAA
            // 
            textBoxOut_GAA.Location = new Point(282, 65);
            textBoxOut_GAA.Multiline = true;
            textBoxOut_GAA.Name = "textBoxOut_GAA";
            textBoxOut_GAA.ReadOnly = true;
            textBoxOut_GAA.ScrollBars = ScrollBars.Vertical;
            textBoxOut_GAA.Size = new Size(250, 200);
            textBoxOut_GAA.TabIndex = 1;
            // 
            // buttonOpenFile_GAA
            // 
            buttonOpenFile_GAA.Location = new Point(12, 9);
            buttonOpenFile_GAA.Name = "buttonOpenFile_GAA";
            buttonOpenFile_GAA.Size = new Size(100, 25);
            buttonOpenFile_GAA.TabIndex = 2;
            buttonOpenFile_GAA.Text = "Открыть файл";
            buttonOpenFile_GAA.Click += buttonOpenFile_GAA_Click;
            // 
            // buttonHelp_GAA
            // 
            buttonHelp_GAA.Location = new Point(432, 9);
            buttonHelp_GAA.Name = "buttonHelp_GAA";
            buttonHelp_GAA.Size = new Size(100, 25);
            buttonHelp_GAA.TabIndex = 3;
            buttonHelp_GAA.Text = "Справка";
            buttonHelp_GAA.Click += buttonHelp_GAA_Click;
            // 
            // openFileDialogTask_GAA
            // 
            openFileDialogTask_GAA.FileName = "openFileDialog";
            openFileDialogTask_GAA.Filter = "Текстовые файлы|*.txt";
            // 
            // labelIn_GAA
            // 
            labelIn_GAA.AutoSize = true;
            labelIn_GAA.Location = new Point(12, 47);
            labelIn_GAA.Name = "labelIn_GAA";
            labelIn_GAA.Size = new Size(36, 15);
            labelIn_GAA.TabIndex = 1;
            labelIn_GAA.Text = "Ввод:";
            labelIn_GAA.Click += labelIn_GAA_Click;
            // 
            // labelOut_GAA
            // 
            labelOut_GAA.AutoSize = true;
            labelOut_GAA.Location = new Point(282, 47);
            labelOut_GAA.Name = "labelOut_GAA";
            labelOut_GAA.Size = new Size(45, 15);
            labelOut_GAA.TabIndex = 0;
            labelOut_GAA.Text = "Вывод:";
            // 
            // FormMain
            // 
            ClientSize = new Size(540, 272);
            Controls.Add(labelOut_GAA);
            Controls.Add(labelIn_GAA);
            Controls.Add(buttonHelp_GAA);
            Controls.Add(buttonOpenFile_GAA);
            Controls.Add(textBoxOut_GAA);
            Controls.Add(textBoxIn_GAA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 14 | Галимов А. А.";
            ResumeLayout(false);
            PerformLayout();
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