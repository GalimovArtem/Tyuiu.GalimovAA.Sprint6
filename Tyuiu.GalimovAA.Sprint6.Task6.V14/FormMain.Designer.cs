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
            textBoxIn_GAA.Location = new Point(12, 68);
            textBoxIn_GAA.Multiline = true;
            textBoxIn_GAA.Name = "textBoxIn_GAA";
            textBoxIn_GAA.ScrollBars = ScrollBars.Vertical;
            textBoxIn_GAA.Size = new Size(231, 200);
            textBoxIn_GAA.TabIndex = 0;
            textBoxIn_GAA.TextChanged += textBoxIn_GAA_TextChanged;
            // 
            // textBoxOut_GAA
            // 
            textBoxOut_GAA.Location = new Point(288, 68);
            textBoxOut_GAA.Multiline = true;
            textBoxOut_GAA.Name = "textBoxOut_GAA";
            textBoxOut_GAA.ReadOnly = true;
            textBoxOut_GAA.ScrollBars = ScrollBars.Vertical;
            textBoxOut_GAA.Size = new Size(228, 200);
            textBoxOut_GAA.TabIndex = 1;
            textBoxOut_GAA.TextChanged += textBoxOut_GAA_TextChanged;
            // 
            // buttonOpenFile_GAA
            // 
            buttonOpenFile_GAA.Location = new Point(12, 12);
            buttonOpenFile_GAA.Name = "buttonOpenFile_GAA";
            buttonOpenFile_GAA.Size = new Size(100, 30);
            buttonOpenFile_GAA.TabIndex = 2;
            buttonOpenFile_GAA.Text = "Открыть файл";
            buttonOpenFile_GAA.UseVisualStyleBackColor = true;
            buttonOpenFile_GAA.Click += buttonOpenFile_GAA_Click;
            // 
            // buttonHelp_GAA
            // 
            buttonHelp_GAA.Location = new Point(438, 12);
            buttonHelp_GAA.Name = "buttonHelp_GAA";
            buttonHelp_GAA.Size = new Size(100, 30);
            buttonHelp_GAA.TabIndex = 3;
            buttonHelp_GAA.Text = "Справка";
            buttonHelp_GAA.UseVisualStyleBackColor = true;
            buttonHelp_GAA.Click += buttonHelp_GAA_Click;
            // 
            // openFileDialogTask_GAA
            // 
            openFileDialogTask_GAA.FileName = "openFileDialog1";
            openFileDialogTask_GAA.Filter = "Текстовые файлы|*.txt";
            // 
            // labelIn_GAA
            // 
            labelIn_GAA.AutoSize = true;
            labelIn_GAA.Location = new Point(12, 50);
            labelIn_GAA.Name = "labelIn_GAA";
            labelIn_GAA.Size = new Size(36, 15);
            labelIn_GAA.TabIndex = 4;
            labelIn_GAA.Text = "Ввод:";
            // 
            // labelOut_GAA
            // 
            labelOut_GAA.AutoSize = true;
            labelOut_GAA.Location = new Point(288, 50);
            labelOut_GAA.Name = "labelOut_GAA";
            labelOut_GAA.Size = new Size(45, 15);
            labelOut_GAA.TabIndex = 5;
            labelOut_GAA.Text = "Вывод:";
            // 
            // FormMain
            // 
            ClientSize = new Size(550, 281);
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