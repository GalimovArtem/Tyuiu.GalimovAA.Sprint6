namespace Tyuiu.GalimovAA.Sprint6.Task7.V16
{
    partial class FormAbout
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelInfo;
        private Button buttonOk;
        private PictureBox pictureBoxIcon;

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
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();

            // labelInfo
            this.labelInfo.Location = new System.Drawing.Point(120, 20);
            this.labelInfo.Size = new System.Drawing.Size(300, 150);
            this.labelInfo.Text = "Разработчик: Галимов Артём Азатович\nГруппа: ПКТб-24-1\n\nПрограмма разработана в рамках изучения языка C#\n\nТюменский индустриальный университет 2024\nВысшая школа цифровых технологий 2024";

            // buttonOk
            this.buttonOk.Location = new System.Drawing.Point(170, 180);
            this.buttonOk.Size = new System.Drawing.Size(100, 30);
            this.buttonOk.Text = "OK";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);

            // pictureBoxIcon
            this.pictureBoxIcon.Location = new System.Drawing.Point(20, 20);
            this.pictureBoxIcon.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // Добавьте иконку человека в ресурсы или укажите путь к изображению
            // this.pictureBoxIcon.Image = Properties.Resources.UserIcon;

            // FormAbout
            this.ClientSize = new System.Drawing.Size(440, 230);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pictureBoxIcon, this.labelInfo, this.buttonOk
            });
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
        }
    }
}