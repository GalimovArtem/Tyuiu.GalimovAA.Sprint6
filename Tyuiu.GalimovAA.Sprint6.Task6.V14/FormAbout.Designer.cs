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
            pictureBoxDeveloper = new PictureBox();
            labelDeveloper = new Label();
            labelGroup = new Label();
            labelUniversity = new Label();
            labelSchool = new Label();
            labelCopyright = new Label();
            labelInternalName = new Label();
            buttonOk = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDeveloper).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxDeveloper
            // 
            pictureBoxDeveloper.Location = new Point(4, 23);
            pictureBoxDeveloper.Margin = new Padding(4, 3, 4, 3);
            pictureBoxDeveloper.Name = "pictureBoxDeveloper";
            pictureBoxDeveloper.Size = new Size(151, 229);
            pictureBoxDeveloper.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDeveloper.TabIndex = 0;
            pictureBoxDeveloper.TabStop = false;
            // 
            // labelDeveloper
            // 
            labelDeveloper.AutoSize = true;
            labelDeveloper.Location = new Point(163, 23);
            labelDeveloper.Margin = new Padding(4, 0, 4, 0);
            labelDeveloper.Name = "labelDeveloper";
            labelDeveloper.Size = new Size(156, 15);
            labelDeveloper.TabIndex = 1;
            labelDeveloper.Text = "Разработчик: Галимов А.А.";
            // 
            // labelGroup
            // 
            labelGroup.AutoSize = true;
            labelGroup.Location = new Point(163, 52);
            labelGroup.Margin = new Padding(4, 0, 4, 0);
            labelGroup.Name = "labelGroup";
            labelGroup.Size = new Size(109, 15);
            labelGroup.TabIndex = 2;
            labelGroup.Text = "Группа: ПКТб-24-1";
            // 
            // labelUniversity
            // 
            labelUniversity.AutoSize = true;
            labelUniversity.Location = new Point(163, 109);
            labelUniversity.Margin = new Padding(4, 0, 4, 0);
            labelUniversity.Name = "labelUniversity";
            labelUniversity.Size = new Size(265, 15);
            labelUniversity.TabIndex = 3;
            labelUniversity.Text = "Тюменский индустриальный университет 2024";
            // 
            // labelSchool
            // 
            labelSchool.AutoSize = true;
            labelSchool.Location = new Point(163, 135);
            labelSchool.Margin = new Padding(4, 0, 4, 0);
            labelSchool.Name = "labelSchool";
            labelSchool.Size = new Size(247, 15);
            labelSchool.TabIndex = 4;
            labelSchool.Text = "Высшая школа цифровых технологий 2024";
            // 
            // labelCopyright
            // 
            labelCopyright.AutoSize = true;
            labelCopyright.Location = new Point(163, 81);
            labelCopyright.Margin = new Padding(4, 0, 4, 0);
            labelCopyright.Name = "labelCopyright";
            labelCopyright.Size = new Size(213, 15);
            labelCopyright.TabIndex = 5;
            labelCopyright.Text = "Программа разработана на языке C#";
            // 
            // labelInternalName
            // 
            labelInternalName.AutoSize = true;
            labelInternalName.Location = new Point(163, 165);
            labelInternalName.Margin = new Padding(4, 0, 4, 0);
            labelInternalName.Name = "labelInternalName";
            labelInternalName.Size = new Size(286, 15);
            labelInternalName.TabIndex = 6;
            labelInternalName.Text = "Внутреннее имя: Tyuiu.GalimovAA.Sprint6.Task6.V14";
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(360, 217);
            buttonOk.Margin = new Padding(4, 3, 4, 3);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(88, 35);
            buttonOk.TabIndex = 7;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 264);
            Controls.Add(buttonOk);
            Controls.Add(labelInternalName);
            Controls.Add(labelCopyright);
            Controls.Add(labelSchool);
            Controls.Add(labelUniversity);
            Controls.Add(labelGroup);
            Controls.Add(labelDeveloper);
            Controls.Add(pictureBoxDeveloper);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxDeveloper).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        private System.Windows.Forms.PictureBox pictureBoxDeveloper;
        private System.Windows.Forms.Label labelDeveloper;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelUniversity;
        private System.Windows.Forms.Label labelSchool;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelInternalName;
        private System.Windows.Forms.Button buttonOk;
    }
}