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
            pictureBoxAvatar_GAA = new PictureBox();
            labelInfo_GAA = new Label();
            buttonOk_GAA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_GAA).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_GAA
            // 
            pictureBoxAvatar_GAA.Location = new Point(2, 12);
            pictureBoxAvatar_GAA.Name = "pictureBoxAvatar_GAA";
            pictureBoxAvatar_GAA.Size = new Size(124, 150);
            pictureBoxAvatar_GAA.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAvatar_GAA.TabIndex = 0;
            pictureBoxAvatar_GAA.TabStop = false;
            // 
            // labelInfo_GAA
            // 
            labelInfo_GAA.Location = new Point(135, 12);
            labelInfo_GAA.Name = "labelInfo_GAA";
            labelInfo_GAA.Size = new Size(282, 135);
            labelInfo_GAA.TabIndex = 3;
            labelInfo_GAA.Text = resources.GetString("labelInfo_GAA.Text");
            labelInfo_GAA.Click += labelInfo_GAA_Click;
            // 
            // buttonOk_GAA
            // 
            buttonOk_GAA.Location = new Point(329, 150);
            buttonOk_GAA.Name = "buttonOk_GAA";
            buttonOk_GAA.Size = new Size(75, 23);
            buttonOk_GAA.TabIndex = 2;
            buttonOk_GAA.Text = "ОК";
            buttonOk_GAA.Click += buttonOk_GAA_Click;
            // 
            // FormAbout
            // 
            ClientSize = new Size(429, 185);
            Controls.Add(buttonOk_GAA);
            Controls.Add(labelInfo_GAA);
            Controls.Add(pictureBoxAvatar_GAA);
            Name = "FormAbout";
            Text = "О программе";
            Load += FormAbout_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_GAA).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox pictureBoxAvatar_GAA;
        private System.Windows.Forms.Label labelInfo_GAA;
        private System.Windows.Forms.Button buttonOk_GAA;
    }
}