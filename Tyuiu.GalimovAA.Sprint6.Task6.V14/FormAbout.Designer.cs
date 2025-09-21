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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxDeveloper = new System.Windows.Forms.PictureBox();
            this.labelDeveloper = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelUniversity = new System.Windows.Forms.Label();
            this.labelSchool = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelInternalName = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeveloper)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDeveloper
            // 
            this.pictureBoxDeveloper.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDeveloper.Image")));
            this.pictureBoxDeveloper.Location = new System.Drawing.Point(20, 20);
            this.pictureBoxDeveloper.Name = "pictureBoxDeveloper";
            this.pictureBoxDeveloper.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxDeveloper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDeveloper.TabIndex = 0;
            this.pictureBoxDeveloper.TabStop = false;
            // 
            // labelDeveloper
            // 
            this.labelDeveloper.AutoSize = true;
            this.labelDeveloper.Location = new System.Drawing.Point(140, 20);
            this.labelDeveloper.Name = "labelDeveloper";
            this.labelDeveloper.Size = new System.Drawing.Size(135, 13);
            this.labelDeveloper.TabIndex = 1;
            this.labelDeveloper.Text = "Разработчик: Галимов А.А.";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(140, 45);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(95, 13);
            this.labelGroup.TabIndex = 2;
            this.labelGroup.Text = "Группа: ПКТб-24-1";
            // 
            // labelUniversity
            // 
            this.labelUniversity.AutoSize = true;
            this.labelUniversity.Location = new System.Drawing.Point(20, 140);
            this.labelUniversity.Name = "labelUniversity";
            this.labelUniversity.Size = new System.Drawing.Size(253, 13);
            this.labelUniversity.TabIndex = 3;
            this.labelUniversity.Text = "Тюменский индустриальный университет (с) 2023";
            // 
            // labelSchool
            // 
            this.labelSchool.AutoSize = true;
            this.labelSchool.Location = new System.Drawing.Point(20, 165);
            this.labelSchool.Name = "labelSchool";
            this.labelSchool.Size = new System.Drawing.Size(246, 13);
            this.labelSchool.TabIndex = 4;
            this.labelSchool.Text = "Высшая школа цифровых технологий (с) 2023";
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Location = new System.Drawing.Point(140, 70);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(190, 13);
            this.labelCopyright.TabIndex = 5;
            this.labelCopyright.Text = "Программа разработана на языке C#";
            // 
            // labelInternalName
            // 
            this.labelInternalName.AutoSize = true;
            this.labelInternalName.Location = new System.Drawing.Point(20, 190);
            this.labelInternalName.Name = "labelInternalName";
            this.labelInternalName.Size = new System.Drawing.Size(242, 13);
            this.labelInternalName.TabIndex = 6;
            this.labelInternalName.Text = "Внутреннее имя: GalimovAA_Task6_V14.V0";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(120, 220);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 30);
            this.buttonOk.TabIndex = 7;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelInternalName);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelSchool);
            this.Controls.Add(this.labelUniversity);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.labelDeveloper);
            this.Controls.Add(this.pictureBoxDeveloper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeveloper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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