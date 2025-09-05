namespace Tyuiu.GalimovAA.Sprint6.Task2.V17
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxInput_GAA = new System.Windows.Forms.GroupBox();
            this.textBoxStopStep_GAA = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_GAA = new System.Windows.Forms.TextBox();
            this.labelStopStep_GAA = new System.Windows.Forms.Label();
            this.labelStartStep_GAA = new System.Windows.Forms.Label();
            this.groupBoxOutput_GAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_GAA = new System.Windows.Forms.DataGridView();
            this.buttonDone_GAA = new System.Windows.Forms.Button();
            this.buttonHelp_GAA = new System.Windows.Forms.Button();
            this.chartFunction_GAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxInput_GAA.SuspendLayout();
            this.groupBoxOutput_GAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_GAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_GAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInput_GAA
            // 
            this.groupBoxInput_GAA.Controls.Add(this.textBoxStopStep_GAA);
            this.groupBoxInput_GAA.Controls.Add(this.textBoxStartStep_GAA);
            this.groupBoxInput_GAA.Controls.Add(this.labelStopStep_GAA);
            this.groupBoxInput_GAA.Controls.Add(this.labelStartStep_GAA);
            this.groupBoxInput_GAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInput_GAA.Name = "groupBoxInput_GAA";
            this.groupBoxInput_GAA.Size = new System.Drawing.Size(300, 80);
            this.groupBoxInput_GAA.TabIndex = 0;
            this.groupBoxInput_GAA.TabStop = false;
            this.groupBoxInput_GAA.Text = "Ввод данных";
            // 
            // textBoxStopStep_GAA
            // 
            this.textBoxStopStep_GAA.Location = new System.Drawing.Point(180, 35);
            this.textBoxStopStep_GAA.Name = "textBoxStopStep_GAA";
            this.textBoxStopStep_GAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopStep_GAA.TabIndex = 3;
            this.textBoxStopStep_GAA.Text = "5";
            // 
            // textBoxStartStep_GAA
            // 
            this.textBoxStartStep_GAA.Location = new System.Drawing.Point(20, 35);
            this.textBoxStartStep_GAA.Name = "textBoxStartStep_GAA";
            this.textBoxStartStep_GAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartStep_GAA.TabIndex = 2;
            this.textBoxStartStep_GAA.Text = "-5";
            // 
            // labelStopStep_GAA
            // 
            this.labelStopStep_GAA.AutoSize = true;
            this.labelStopStep_GAA.Location = new System.Drawing.Point(177, 19);
            this.labelStopStep_GAA.Name = "labelStopStep_GAA";
            this.labelStopStep_GAA.Size = new System.Drawing.Size(69, 13);
            this.labelStopStep_GAA.TabIndex = 1;
            this.labelStopStep_GAA.Text = "Конец шага:";
            // 
            // labelStartStep_GAA
            // 
            this.labelStartStep_GAA.AutoSize = true;
            this.labelStartStep_GAA.Location = new System.Drawing.Point(17, 19);
            this.labelStartStep_GAA.Name = "labelStartStep_GAA";
            this.labelStartStep_GAA.Size = new System.Drawing.Size(67, 13);
            this.labelStartStep_GAA.TabIndex = 0;
            this.labelStartStep_GAA.Text = "Старт шага:";
            // 
            // groupBoxOutput_GAA
            // 
            this.groupBoxOutput_GAA.Controls.Add(this.dataGridViewResult_GAA);
            this.groupBoxOutput_GAA.Location = new System.Drawing.Point(12, 98);
            this.groupBoxOutput_GAA.Name = "groupBoxOutput_GAA";
            this.groupBoxOutput_GAA.Size = new System.Drawing.Size(300, 250);
            this.groupBoxOutput_GAA.TabIndex = 1;
            this.groupBoxOutput_GAA.TabStop = false;
            this.groupBoxOutput_GAA.Text = "Вывод данных";
            // 
            // dataGridViewResult_GAA
            // 
            this.dataGridViewResult_GAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_GAA.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewResult_GAA.Name = "dataGridViewResult_GAA";
            this.dataGridViewResult_GAA.Size = new System.Drawing.Size(288, 225);
            this.dataGridViewResult_GAA.TabIndex = 0;
            // 
            // buttonDone_GAA
            // 
            this.buttonDone_GAA.BackColor = System.Drawing.Color.Lime;
            this.buttonDone_GAA.Location = new System.Drawing.Point(318, 12);
            this.buttonDone_GAA.Name = "buttonDone_GAA";
            this.buttonDone_GAA.Size = new System.Drawing.Size(75, 80);
            this.buttonDone_GAA.TabIndex = 2;
            this.buttonDone_GAA.Text = "Выполнить";
            this.buttonDone_GAA.UseVisualStyleBackColor = false;
            this.buttonDone_GAA.Click += new System.EventHandler(this.buttonDone_GAA_Click);
            // 
            // buttonHelp_GAA
            // 
            this.buttonHelp_GAA.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonHelp_GAA.Location = new System.Drawing.Point(399, 12);
            this.buttonHelp_GAA.Name = "buttonHelp_GAA";
            this.buttonHelp_GAA.Size = new System.Drawing.Size(75, 80);
            this.buttonHelp_GAA.TabIndex = 3;
            this.buttonHelp_GAA.Text = "Справка";
            this.buttonHelp_GAA.UseVisualStyleBackColor = false;
            this.buttonHelp_GAA.Click += new System.EventHandler(this.buttonHelp_GAA_Click);
            // 
            // chartFunction_GAA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_GAA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_GAA.Legends.Add(legend1);
            this.chartFunction_GAA.Location = new System.Drawing.Point(318, 98);
            this.chartFunction_GAA.Name = "chartFunction_GAA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "F(x)";
            this.chartFunction_GAA.Series.Add(series1);
            this.chartFunction_GAA.Size = new System.Drawing.Size(470, 250);
            this.chartFunction_GAA.TabIndex = 4;
            this.chartFunction_GAA.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.chartFunction_GAA);
            this.Controls.Add(this.buttonHelp_GAA);
            this.Controls.Add(this.buttonDone_GAA);
            this.Controls.Add(this.groupBoxOutput_GAA);
            this.Controls.Add(this.groupBoxInput_GAA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 2 | Вариант 17 | Галимов А. А.";
            this.groupBoxInput_GAA.ResumeLayout(false);
            this.groupBoxInput_GAA.PerformLayout();
            this.groupBoxOutput_GAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_GAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_GAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInput_GAA;
        private System.Windows.Forms.TextBox textBoxStopStep_GAA;
        private System.Windows.Forms.TextBox textBoxStartStep_GAA;
        private System.Windows.Forms.Label labelStopStep_GAA;
        private System.Windows.Forms.Label labelStartStep_GAA;
        private System.Windows.Forms.GroupBox groupBoxOutput_GAA;
        private System.Windows.Forms.DataGridView dataGridViewResult_GAA;
        private System.Windows.Forms.Button buttonDone_GAA;
        private System.Windows.Forms.Button buttonHelp_GAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_GAA;
    }
}