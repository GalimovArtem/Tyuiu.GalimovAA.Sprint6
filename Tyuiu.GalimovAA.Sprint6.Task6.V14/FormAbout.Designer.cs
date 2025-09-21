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
            pictureBoxAvatar = new PictureBox();
            labelDeveloper = new Label();
            labelGroup = new Label();
            labelDescription = new Label();
            labelUniversity = new Label();
            labelSchool = new Label();
            labelInternalName = new Label();
            buttonOk = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.Location = new Point(14, 14);
            pictureBoxAvatar.Margin = new Padding(4, 3, 4, 3);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(117, 133);
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAvatar.TabIndex = 0;
            pictureBoxAvatar.TabStop = false;
            pictureBoxAvatar.Click += pictureBoxAvatar_Click;
            // 
            // labelDeveloper
            // 
            labelDeveloper.AutoSize = true;
            labelDeveloper.Location = new Point(138, 14);
            labelDeveloper.Margin = new Padding(4, 0, 4, 0);
            labelDeveloper.Name = "labelDeveloper";
            labelDeveloper.Size = new Size(156, 15);
            labelDeveloper.TabIndex = 1;
            labelDeveloper.Text = "Разработчик: Галимов А.А.";
            // 
            // labelGroup
            // 
            labelGroup.AutoSize = true;
            labelGroup.Location = new Point(138, 40);
            labelGroup.Margin = new Padding(4, 0, 4, 0);
            labelGroup.Name = "labelGroup";
            labelGroup.Size = new Size(105, 15);
            labelGroup.TabIndex = 2;
            labelGroup.Text = "группа ПКТб-24-1";
            // 
            // labelDescription
            // 
            labelDescription.Location = new Point(138, 67);
            labelDescription.Margin = new Padding(4, 0, 4, 0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(310, 20);
            labelDescription.TabIndex = 3;
            labelDescription.Text = "Программа разработана в рамках изучения языка C#";
            // 
            // labelUniversity
            // 
            labelUniversity.AutoSize = true;
            labelUniversity.Location = new Point(138, 87);
            labelUniversity.Margin = new Padding(4, 0, 4, 0);
            labelUniversity.Name = "labelUniversity";
            labelUniversity.Size = new Size(265, 15);
            labelUniversity.TabIndex = 4;
            labelUniversity.Text = "Тюменский индустриальный университет 2024";
            // 
            // labelSchool
            // 
            labelSchool.AutoSize = true;
            labelSchool.Location = new Point(138, 102);
            labelSchool.Margin = new Padding(4, 0, 4, 0);
            labelSchool.Name = "labelSchool";
            labelSchool.Size = new Size(247, 15);
            labelSchool.TabIndex = 5;
            labelSchool.Text = "Высшая школа цифровых технологий 2024";
            labelSchool.Click += labelSchool_Click;
            // 
            // labelInternalName
            // 
            labelInternalName.AutoSize = true;
            labelInternalName.Location = new Point(138, 117);
            labelInternalName.Margin = new Padding(4, 0, 4, 0);
            labelInternalName.Name = "labelInternalName";
            labelInternalName.Size = new Size(286, 15);
            labelInternalName.TabIndex = 6;
            labelInternalName.Text = "Внутреннее имя: Tyuiu.GalimovAA.Sprint6.Task6.V14";
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(336, 159);
            buttonOk.Margin = new Padding(4, 3, 4, 3);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(88, 27);
            buttonOk.TabIndex = 7;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 198);
            Controls.Add(buttonOk);
            Controls.Add(labelInternalName);
            Controls.Add(labelSchool);
            Controls.Add(labelUniversity);
            Controls.Add(labelDescription);
            Controls.Add(labelGroup);
            Controls.Add(labelDeveloper);
            Controls.Add(pictureBoxAvatar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            Load += FormAbout_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.Label labelDeveloper;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelUniversity;
        private System.Windows.Forms.Label labelSchool;
        private System.Windows.Forms.Label labelInternalName;
        private System.Windows.Forms.Button buttonOk;
    }
}