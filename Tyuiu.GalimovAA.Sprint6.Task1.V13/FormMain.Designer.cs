namespace Tyuiu.GalimovAA.Sprint6.Task1.V13
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
            this.labelStart_GAA = new System.Windows.Forms.Label();
            this.labelStop_GAA = new System.Windows.Forms.Label();
            this.textBoxStart_GAA = new System.Windows.Forms.TextBox();
            this.textBoxStop_GAA = new System.Windows.Forms.TextBox();
            this.textBoxResult_GAA = new System.Windows.Forms.TextBox();
            this.buttonDone_GAA = new System.Windows.Forms.Button();
            this.buttonHelp_GAA = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // labelStart_GAA
            this.labelStart_GAA.AutoSize = true;
            this.labelStart_GAA.Location = new System.Drawing.Point(12, 15);
            this.labelStart_GAA.Name = "labelStart_GAA";
            this.labelStart_GAA.Size = new System.Drawing.Size(67, 13);
            this.labelStart_GAA.TabIndex = 0;
            this.labelStart_GAA.Text = "Старт шага:";

            // labelStop_GAA
            this.labelStop_GAA.AutoSize = true;
            this.labelStop_GAA.Location = new System.Drawing.Point(12, 45);
            this.labelStop_GAA.Name = "labelStop_GAA";
            this.labelStop_GAA.Size = new System.Drawing.Size(69, 13);
            this.labelStop_GAA.TabIndex = 1;
            this.labelStop_GAA.Text = "Конец шага:";

            // textBoxStart_GAA
            this.textBoxStart_GAA.Location = new System.Drawing.Point(90, 12);
            this.textBoxStart_GAA.Name = "textBoxStart_GAA";
            this.textBoxStart_GAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_GAA.TabIndex = 2;
            this.textBoxStart_GAA.Text = "-5";

            // textBoxStop_GAA
            this.textBoxStop_GAA.Location = new System.Drawing.Point(90, 42);
            this.textBoxStop_GAA.Name = "textBoxStop_GAA";
            this.textBoxStop_GAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop_GAA.TabIndex = 3;
            this.textBoxStop_GAA.Text = "5";

            // textBoxResult_GAA
            this.textBoxResult_GAA.Location = new System.Drawing.Point(12, 80);
            this.textBoxResult_GAA.Multiline = true;
            this.textBoxResult_GAA.Name = "textBoxResult_GAA";
            this.textBoxResult_GAA.ReadOnly = true;
            this.textBoxResult_GAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_GAA.Size = new System.Drawing.Size(360, 200);
            this.textBoxResult_GAA.TabIndex = 4;

            // buttonDone_GAA
            this.buttonDone_GAA.Location = new System.Drawing.Point(210, 10);
            this.buttonDone_GAA.Name = "buttonDone_GAA";
            this.buttonDone_GAA.Size = new System.Drawing.Size(75, 23);
            this.buttonDone_GAA.TabIndex = 5;
            this.buttonDone_GAA.Text = "Выполнить";
            this.buttonDone_GAA.UseVisualStyleBackColor = true;
            this.buttonDone_GAA.Click += new System.EventHandler(this.buttonDone_GAA_Click);

            // buttonHelp_GAA
            this.buttonHelp_GAA.Location = new System.Drawing.Point(210, 40);
            this.buttonHelp_GAA.Name = "buttonHelp_GAA";
            this.buttonHelp_GAA.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp_GAA.TabIndex = 6;
            this.buttonHelp_GAA.Text = "Справка";
            this.buttonHelp_GAA.UseVisualStyleBackColor = true;
            this.buttonHelp_GAA.Click += new System.EventHandler(this.buttonHelp_GAA_Click);

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 291);
            this.Controls.Add(this.buttonHelp_GAA);
            this.Controls.Add(this.buttonDone_GAA);
            this.Controls.Add(this.textBoxResult_GAA);
            this.Controls.Add(this.textBoxStop_GAA);
            this.Controls.Add(this.textBoxStart_GAA);
            this.Controls.Add(this.labelStop_GAA);
            this.Controls.Add(this.labelStart_GAA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 1 | Вариант 13 | Галимов А. А.";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelStart_GAA;
        private System.Windows.Forms.Label labelStop_GAA;
        private System.Windows.Forms.TextBox textBoxStart_GAA;
        private System.Windows.Forms.TextBox textBoxStop_GAA;
        private System.Windows.Forms.TextBox textBoxResult_GAA;
        private System.Windows.Forms.Button buttonDone_GAA;
        private System.Windows.Forms.Button buttonHelp_GAA;
    }
}