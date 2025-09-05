namespace Tyuiu.GalimovAA.Sprint6.Task3.V2
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
            this.dataGridViewMatrix_GAA = new System.Windows.Forms.DataGridView();
            this.dataGridViewResult_GAA = new System.Windows.Forms.DataGridView();
            this.buttonDone_GAA = new System.Windows.Forms.Button();
            this.buttonHelp_GAA = new System.Windows.Forms.Button();
            this.labelTask_GAA = new System.Windows.Forms.Label();
            this.labelMatrix_GAA = new System.Windows.Forms.Label();
            this.labelResult_GAA = new System.Windows.Forms.Label();
            this.labelCondition_GAA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_GAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_GAA)).BeginInit();
            this.SuspendLayout();

            // dataGridViewMatrix_GAA
            this.dataGridViewMatrix_GAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_GAA.Location = new System.Drawing.Point(12, 80);
            this.dataGridViewMatrix_GAA.Name = "dataGridViewMatrix_GAA";
            this.dataGridViewMatrix_GAA.Size = new System.Drawing.Size(260, 150);
            this.dataGridViewMatrix_GAA.TabIndex = 0;

            // dataGridViewResult_GAA
            this.dataGridViewResult_GAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_GAA.Location = new System.Drawing.Point(300, 80);
            this.dataGridViewResult_GAA.Name = "dataGridViewResult_GAA";
            this.dataGridViewResult_GAA.Size = new System.Drawing.Size(260, 150);
            this.dataGridViewResult_GAA.TabIndex = 1;

            // buttonDone_GAA
            this.buttonDone_GAA.Location = new System.Drawing.Point(12, 250);
            this.buttonDone_GAA.Name = "buttonDone_GAA";
            this.buttonDone_GAA.Size = new System.Drawing.Size(100, 30);
            this.buttonDone_GAA.TabIndex = 2;
            this.buttonDone_GAA.Text = "Выполнить";
            this.buttonDone_GAA.UseVisualStyleBackColor = true;
            this.buttonDone_GAA.Click += new System.EventHandler(this.buttonDone_GAA_Click);

            // buttonHelp_GAA
            this.buttonHelp_GAA.Location = new System.Drawing.Point(460, 250);
            this.buttonHelp_GAA.Name = "buttonHelp_GAA";
            this.buttonHelp_GAA.Size = new System.Drawing.Size(100, 30);
            this.buttonHelp_GAA.TabIndex = 3;
            this.buttonHelp_GAA.Text = "Справка";
            this.buttonHelp_GAA.UseVisualStyleBackColor = true;
            this.buttonHelp_GAA.Click += new System.EventHandler(this.buttonHelp_GAA_Click);

            // labelTask_GAA
            this.labelTask_GAA.AutoSize = true;
            this.labelTask_GAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTask_GAA.Location = new System.Drawing.Point(12, 20);
            this.labelTask_GAA.Name = "labelTask_GAA";
            this.labelTask_GAA.Size = new System.Drawing.Size(548, 15);
            this.labelTask_GAA.TabIndex = 4;
            this.labelTask_GAA.Text = "Таск 3. Заменить четные значения в первой строке матрицы 5x5 на 0";

            // labelMatrix_GAA
            this.labelMatrix_GAA.AutoSize = true;
            this.labelMatrix_GAA.Location = new System.Drawing.Point(12, 65);
            this.labelMatrix_GAA.Name = "labelMatrix_GAA";
            this.labelMatrix_GAA.Size = new System.Drawing.Size(65, 13);
            this.labelMatrix_GAA.TabIndex = 5;
            this.labelMatrix_GAA.Text = "Матрица:";

            // labelResult_GAA
            this.labelResult_GAA.AutoSize = true;
            this.labelResult_GAA.Location = new System.Drawing.Point(300, 65);
            this.labelResult_GAA.Name = "labelResult_GAA";
            this.labelResult_GAA.Size = new System.Drawing.Size(65, 13);
            this.labelResult_GAA.TabIndex = 6;
            this.labelResult_GAA.Text = "Результат:";

            // labelCondition_GAA
            this.labelCondition_GAA.AutoSize = true;
            this.labelCondition_GAA.Location = new System.Drawing.Point(12, 45);
            this.labelCondition_GAA.Name = "labelCondition_GAA";
            this.labelCondition_GAA.Size = new System.Drawing.Size(548, 13);
            this.labelCondition_GAA.TabIndex = 7;
            this.labelCondition_GAA.Text = "Дана матрица: [-12, -4, -20, 5, -5], [2, 15, 1, -20, 7], [15, -15, 2, 11, 5], [-19, -9, 16, 0, 1], [17, 16, 5, 12, -8]";

            // FormMain
            this.ClientSize = new System.Drawing.Size(580, 300);
            this.Controls.Add(this.labelCondition_GAA);
            this.Controls.Add(this.labelResult_GAA);
            this.Controls.Add(this.labelMatrix_GAA);
            this.Controls.Add(this.labelTask_GAA);
            this.Controls.Add(this.buttonHelp_GAA);
            this.Controls.Add(this.buttonDone_GAA);
            this.Controls.Add(this.dataGridViewResult_GAA);
            this.Controls.Add(this.dataGridViewMatrix_GAA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 3 | Вариант 2 | Галимов А.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_GAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_GAA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridViewMatrix_GAA;
        private System.Windows.Forms.DataGridView dataGridViewResult_GAA;
        private System.Windows.Forms.Button buttonDone_GAA;
        private System.Windows.Forms.Button buttonHelp_GAA;
        private System.Windows.Forms.Label labelTask_GAA;
        private System.Windows.Forms.Label labelMatrix_GAA;
        private System.Windows.Forms.Label labelResult_GAA;
        private System.Windows.Forms.Label labelCondition_GAA;
    }
}