namespace Tyuiu.GalimovAA.Sprint6.Task5.V11
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxInput_GAA = new System.Windows.Forms.GroupBox();
            this.textBoxPath_GAA = new System.Windows.Forms.TextBox();
            this.buttonOpenFile_GAA = new System.Windows.Forms.Button();
            this.groupBoxResult_GAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewNumbers_GAA = new System.Windows.Forms.DataGridView();
            this.ColumnIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartNumbers_GAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonHelp_GAA = new System.Windows.Forms.Button();
            this.groupBoxInput_GAA.SuspendLayout();
            this.groupBoxResult_GAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNumbers_GAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNumbers_GAA)).BeginInit();
            this.SuspendLayout();

            this.groupBoxInput_GAA.Controls.Add(this.textBoxPath_GAA);
            this.groupBoxInput_GAA.Controls.Add(this.buttonOpenFile_GAA);
            this.groupBoxInput_GAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInput_GAA.Name = "groupBoxInput_GAA";
            this.groupBoxInput_GAA.Size = new System.Drawing.Size(560, 60);
            this.groupBoxInput_GAA.TabIndex = 0;
            this.groupBoxInput_GAA.TabStop = false;
            this.groupBoxInput_GAA.Text = "Ввод данных";

            this.textBoxPath_GAA.Location = new System.Drawing.Point(6, 22);
            this.textBoxPath_GAA.Name = "textBoxPath_GAA";
            this.textBoxPath_GAA.ReadOnly = true;
            this.textBoxPath_GAA.Size = new System.Drawing.Size(400, 22);
            this.textBoxPath_GAA.TabIndex = 1;

            this.buttonOpenFile_GAA.Location = new System.Drawing.Point(412, 19);
            this.buttonOpenFile_GAA.Name = "buttonOpenFile_GAA";
            this.buttonOpenFile_GAA.Size = new System.Drawing.Size(142, 27);
            this.buttonOpenFile_GAA.TabIndex = 0;
            this.buttonOpenFile_GAA.Text = "Открыть файл";
            this.buttonOpenFile_GAA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_GAA.Click += new System.EventHandler(this.buttonOpenFile_GAA_Click);

            this.groupBoxResult_GAA.Controls.Add(this.dataGridViewNumbers_GAA);
            this.groupBoxResult_GAA.Controls.Add(this.chartNumbers_GAA);
            this.groupBoxResult_GAA.Location = new System.Drawing.Point(12, 78);
            this.groupBoxResult_GAA.Name = "groupBoxResult_GAA";
            this.groupBoxResult_GAA.Size = new System.Drawing.Size(560, 320);
            this.groupBoxResult_GAA.TabIndex = 1;
            this.groupBoxResult_GAA.TabStop = false;
            this.groupBoxResult_GAA.Text = "Результат";

            this.dataGridViewNumbers_GAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNumbers_GAA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIndex,
            this.ColumnValue});
            this.dataGridViewNumbers_GAA.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewNumbers_GAA.Name = "dataGridViewNumbers_GAA";
            this.dataGridViewNumbers_GAA.RowHeadersVisible = false;
            this.dataGridViewNumbers_GAA.RowHeadersWidth = 51;
            this.dataGridViewNumbers_GAA.RowTemplate.Height = 24;
            this.dataGridViewNumbers_GAA.Size = new System.Drawing.Size(200, 293);
            this.dataGridViewNumbers_GAA.TabIndex = 1;

            this.ColumnIndex.HeaderText = "Индекс";
            this.ColumnIndex.MinimumWidth = 6;
            this.ColumnIndex.Name = "ColumnIndex";
            this.ColumnIndex.Width = 70;

            this.ColumnValue.HeaderText = "Значение";
            this.ColumnValue.MinimumWidth = 6;
            this.ColumnValue.Name = "ColumnValue";
            this.ColumnValue.Width = 125;

            chartArea1.Name = "ChartArea1";
            this.chartNumbers_GAA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartNumbers_GAA.Legends.Add(legend1);
            this.chartNumbers_GAA.Location = new System.Drawing.Point(212, 21);
            this.chartNumbers_GAA.Name = "chartNumbers_GAA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartNumbers_GAA.Series.Add(series1);
            this.chartNumbers_GAA.Size = new System.Drawing.Size(342, 293);
            this.chartNumbers_GAA.TabIndex = 0;
            this.chartNumbers_GAA.Text = "chart1";

            this.buttonHelp_GAA.Location = new System.Drawing.Point(12, 404);
            this.buttonHelp_GAA.Name = "buttonHelp_GAA";
            this.buttonHelp_GAA.Size = new System.Drawing.Size(100, 30);
            this.buttonHelp_GAA.TabIndex = 2;
            this.buttonHelp_GAA.Text = "Справка";
            this.buttonHelp_GAA.UseVisualStyleBackColor = true;
            this.buttonHelp_GAA.Click += new System.EventHandler(this.buttonHelp_GAA_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 446);
            this.Controls.Add(this.buttonHelp_GAA);
            this.Controls.Add(this.groupBoxResult_GAA);
            this.Controls.Add(this.groupBoxInput_GAA);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 11 | Галимов А. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxInput_GAA.ResumeLayout(false);
            this.groupBoxInput_GAA.PerformLayout();
            this.groupBoxResult_GAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNumbers_GAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNumbers_GAA)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBoxInput_GAA;
        private System.Windows.Forms.TextBox textBoxPath_GAA;
        private System.Windows.Forms.Button buttonOpenFile_GAA;
        private System.Windows.Forms.GroupBox groupBoxResult_GAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNumbers_GAA;
        private System.Windows.Forms.DataGridView dataGridViewNumbers_GAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValue;
        private System.Windows.Forms.Button buttonHelp_GAA;
    }
}