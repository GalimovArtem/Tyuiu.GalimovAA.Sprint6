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
            components = new System.ComponentModel.Container();
            textBoxIn = new TextBox();
            textBoxOut = new TextBox();
            buttonOpenFile = new Button();
            buttonExecute = new Button();
            buttonHelp = new Button();
            openFileDialogTask = new OpenFileDialog();
            labelIn = new Label();
            labelOut = new Label();
            panelButtons = new Panel();
            toolTip = new ToolTip(components);
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxIn
            // 
            textBoxIn.Location = new Point(13, 118);
            textBoxIn.Margin = new Padding(4, 3, 4, 3);
            textBoxIn.Multiline = true;
            textBoxIn.Name = "textBoxIn";
            textBoxIn.ScrollBars = ScrollBars.Vertical;
            textBoxIn.Size = new Size(251, 230);
            textBoxIn.TabIndex = 0;
            // 
            // textBoxOut
            // 
            textBoxOut.Location = new Point(306, 118);
            textBoxOut.Margin = new Padding(4, 3, 4, 3);
            textBoxOut.Multiline = true;
            textBoxOut.Name = "textBoxOut";
            textBoxOut.ReadOnly = true;
            textBoxOut.ScrollBars = ScrollBars.Vertical;
            textBoxOut.Size = new Size(251, 230);
            textBoxOut.TabIndex = 1;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(4, 3);
            buttonOpenFile.Margin = new Padding(4, 3, 4, 3);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(47, 46);
            buttonOpenFile.TabIndex = 2;
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonExecute
            // 
            buttonExecute.Enabled = false;
            buttonExecute.Location = new Point(57, 3);
            buttonExecute.Margin = new Padding(4, 3, 4, 3);
            buttonExecute.Name = "buttonExecute";
            buttonExecute.Size = new Size(47, 46);
            buttonExecute.TabIndex = 3;
            buttonExecute.UseVisualStyleBackColor = true;
            buttonExecute.Click += buttonExecute_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(493, 3);
            buttonHelp.Margin = new Padding(4, 3, 4, 3);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(47, 46);
            buttonHelp.TabIndex = 4;
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialogTask";
            openFileDialogTask.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
            // 
            // labelIn
            // 
            labelIn.AutoSize = true;
            labelIn.Location = new Point(17, 87);
            labelIn.Margin = new Padding(4, 0, 4, 0);
            labelIn.Name = "labelIn";
            labelIn.Size = new Size(36, 15);
            labelIn.TabIndex = 5;
            labelIn.Text = "Ввод:";
            // 
            // labelOut
            // 
            labelOut.AutoSize = true;
            labelOut.Location = new Point(306, 87);
            labelOut.Margin = new Padding(4, 0, 4, 0);
            labelOut.Name = "labelOut";
            labelOut.Size = new Size(45, 15);
            labelOut.TabIndex = 6;
            labelOut.Text = "Вывод:";
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonOpenFile);
            panelButtons.Controls.Add(buttonExecute);
            panelButtons.Controls.Add(buttonHelp);
            panelButtons.Location = new Point(13, 12);
            panelButtons.Margin = new Padding(4, 3, 4, 3);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(544, 53);
            panelButtons.TabIndex = 7;
            panelButtons.Paint += panelButtons_Paint;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 367);
            Controls.Add(panelButtons);
            Controls.Add(labelOut);
            Controls.Add(labelIn);
            Controls.Add(textBoxOut);
            Controls.Add(textBoxIn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 14 | Галимов А. А.";
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxIn;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.Label labelIn;
        private System.Windows.Forms.Label labelOut;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.ToolTip toolTip;
    }
}