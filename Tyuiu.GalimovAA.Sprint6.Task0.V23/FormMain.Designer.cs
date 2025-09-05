namespace Tyuiu.GalimovAA.Sprint6.Task0.V23
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
            labelInput_GAA = new Label();
            textBoxInput_GAA = new TextBox();
            labelResult_GAA = new Label();
            textBoxResult_GAA = new TextBox();
            buttonCalculate_GAA = new Button();
            buttonHelp_GAA = new Button();
            labelExpression_GAA = new Label();
            SuspendLayout();
            // 
            // labelInput_GAA
            // 
            labelInput_GAA.AutoSize = true;
            labelInput_GAA.Location = new Point(14, 46);
            labelInput_GAA.Margin = new Padding(4, 0, 4, 0);
            labelInput_GAA.Name = "labelInput_GAA";
            labelInput_GAA.Size = new Size(116, 15);
            labelInput_GAA.TabIndex = 1;
            labelInput_GAA.Text = "Введите значение x:";
            // 
            // textBoxInput_GAA
            // 
            textBoxInput_GAA.Location = new Point(140, 43);
            textBoxInput_GAA.Margin = new Padding(4, 3, 4, 3);
            textBoxInput_GAA.Name = "textBoxInput_GAA";
            textBoxInput_GAA.Size = new Size(116, 23);
            textBoxInput_GAA.TabIndex = 2;
            textBoxInput_GAA.Text = "3";
            // 
            // labelResult_GAA
            // 
            labelResult_GAA.AutoSize = true;
            labelResult_GAA.Location = new Point(14, 81);
            labelResult_GAA.Margin = new Padding(4, 0, 4, 0);
            labelResult_GAA.Name = "labelResult_GAA";
            labelResult_GAA.Size = new Size(63, 15);
            labelResult_GAA.TabIndex = 3;
            labelResult_GAA.Text = "Результат:";
            // 
            // textBoxResult_GAA
            // 
            textBoxResult_GAA.Location = new Point(140, 77);
            textBoxResult_GAA.Margin = new Padding(4, 3, 4, 3);
            textBoxResult_GAA.Name = "textBoxResult_GAA";
            textBoxResult_GAA.ReadOnly = true;
            textBoxResult_GAA.Size = new Size(116, 23);
            textBoxResult_GAA.TabIndex = 4;
            // 
            // buttonCalculate_GAA
            // 
            buttonCalculate_GAA.Location = new Point(18, 115);
            buttonCalculate_GAA.Margin = new Padding(4, 3, 4, 3);
            buttonCalculate_GAA.Name = "buttonCalculate_GAA";
            buttonCalculate_GAA.Size = new Size(117, 35);
            buttonCalculate_GAA.TabIndex = 5;
            buttonCalculate_GAA.Text = "Выполнить";
            buttonCalculate_GAA.UseVisualStyleBackColor = true;
            buttonCalculate_GAA.Click += buttonCalculate_GAA_Click;
            // 
            // buttonHelp_GAA
            // 
            buttonHelp_GAA.Location = new Point(140, 115);
            buttonHelp_GAA.Margin = new Padding(4, 3, 4, 3);
            buttonHelp_GAA.Name = "buttonHelp_GAA";
            buttonHelp_GAA.Size = new Size(117, 35);
            buttonHelp_GAA.TabIndex = 6;
            buttonHelp_GAA.Text = "Справка";
            buttonHelp_GAA.UseVisualStyleBackColor = true;
            buttonHelp_GAA.Click += buttonHelp_GAA_Click;
            // 
            // labelExpression_GAA
            // 
            labelExpression_GAA.AutoSize = true;
            labelExpression_GAA.Location = new Point(14, 10);
            labelExpression_GAA.Margin = new Padding(4, 0, 4, 0);
            labelExpression_GAA.Name = "labelExpression_GAA";
            labelExpression_GAA.Size = new Size(241, 15);
            labelExpression_GAA.TabIndex = 0;
            labelExpression_GAA.Text = "Выражение: y = ln((x + 1)/(x + 2)) при x = 3";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 174);
            Controls.Add(buttonHelp_GAA);
            Controls.Add(buttonCalculate_GAA);
            Controls.Add(textBoxResult_GAA);
            Controls.Add(labelResult_GAA);
            Controls.Add(textBoxInput_GAA);
            Controls.Add(labelInput_GAA);
            Controls.Add(labelExpression_GAA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 23 | Галимов А.А.";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelInput_GAA;
        private System.Windows.Forms.TextBox textBoxInput_GAA;
        private System.Windows.Forms.Label labelResult_GAA;
        private System.Windows.Forms.TextBox textBoxResult_GAA;
        private System.Windows.Forms.Button buttonCalculate_GAA;
        private System.Windows.Forms.Button buttonHelp_GAA;
        private System.Windows.Forms.Label labelExpression_GAA;
    }
}