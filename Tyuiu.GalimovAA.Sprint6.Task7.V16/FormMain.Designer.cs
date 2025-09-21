namespace Tyuiu.GalimovAA.Sprint6.Task7.V16
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private Button buttonOpenFile;
        private Button buttonSaveFile;
        private Button buttonAbout;
        private Button buttonExecute;
        private TextBox textBoxInputFile;
        private DataGridView dataGridViewIn;
        private DataGridView dataGridViewOut;
        private Label labelInput;
        private Label labelOutput;
        private ToolTip toolTip;

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
            this.components = new System.ComponentModel.Container();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.textBoxInputFile = new System.Windows.Forms.TextBox();
            this.dataGridViewIn = new System.Windows.Forms.DataGridView();
            this.dataGridViewOut = new System.Windows.Forms.DataGridView();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut)).BeginInit();
            this.SuspendLayout();

            // buttonOpenFile
            this.buttonOpenFile.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(100, 30);
            this.buttonOpenFile.Text = "Открыть файл";
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);

            // textBoxInputFile
            this.textBoxInputFile.Location = new System.Drawing.Point(118, 15);
            this.textBoxInputFile.Size = new System.Drawing.Size(400, 20);
            this.textBoxInputFile.ReadOnly = true;

            // buttonExecute
            this.buttonExecute.Location = new System.Drawing.Point(524, 12);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(100, 30);
            this.buttonExecute.Text = "Выполнить";
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);

            // buttonSaveFile
            this.buttonSaveFile.Location = new System.Drawing.Point(630, 12);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(100, 30);
            this.buttonSaveFile.Text = "Сохранить";
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);

            // buttonAbout
            this.buttonAbout.Location = new System.Drawing.Point(736, 12);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(100, 30);
            this.buttonAbout.Text = "О программе";
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);

            // dataGridViewIn
            this.dataGridViewIn.Location = new System.Drawing.Point(12, 60);
            this.dataGridViewIn.Size = new System.Drawing.Size(400, 300);
            this.dataGridViewIn.ReadOnly = true;

            // dataGridViewOut
            this.dataGridViewOut.Location = new System.Drawing.Point(436, 60);
            this.dataGridViewOut.Size = new System.Drawing.Size(400, 300);
            this.dataGridViewOut.ReadOnly = true;

            // labelInput
            this.labelInput.Location = new System.Drawing.Point(12, 40);
            this.labelInput.Text = "Входные данные:";

            // labelOutput
            this.labelOutput.Location = new System.Drawing.Point(436, 40);
            this.labelOutput.Text = "Результат:";

            // FormMain
            this.ClientSize = new System.Drawing.Size(850, 380);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.buttonOpenFile, this.buttonSaveFile, this.buttonAbout,
                this.buttonExecute, this.textBoxInputFile, this.dataGridViewIn,
                this.dataGridViewOut, this.labelInput, this.labelOutput
            });
            this.Text = "Обработка матрицы - Галимов А.А. ПКТб-24-1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}