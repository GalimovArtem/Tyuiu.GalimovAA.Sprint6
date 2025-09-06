namespace Tyuiu.GalimovAA.Sprint6.Task4.V3
{
    partial class MainForm
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
            this.textBoxStop_GAA = new System.Windows.Forms.TextBox();
            this.textBoxStart_GAA = new System.Windows.Forms.TextBox();
            this.labelStop_GAA = new System.Windows.Forms.Label();
            this.labelStart_GAA = new System.Windows.Forms.Label();
            this.groupBoxOutput_GAA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_GAA = new System.Windows.Forms.TextBox();
            this.chartFunction_GAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonDone_GAA = new System.Windows.Forms.Button();
            this.buttonSave_GAA = new System.Windows.Forms.Button();
            this.buttonInfo_GAA = new System.Windows.Forms.Button();
            this.groupBoxInput_GAA.SuspendLayout();
            this.groupBoxOutput_GAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_GAA)).BeginInit();
            this.SuspendLayout();
      
            this.groupBoxInput_GAA.Controls.Add(this.textBoxStop_GAA);
            this.groupBoxInput_GAA.Controls.Add(this.textBoxStart_GAA);
            this.groupBoxInput_GAA.Controls.Add(this.labelStop_GAA);
            this.groupBoxInput_GAA.Controls.Add(this.labelStart_GAA);
            this.groupBoxInput_GAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInput_GAA.Name = "groupBoxInput_GAA";
            this.groupBoxInput_GAA.Size = new System.Drawing.Size(200, 80);
            this.groupBoxInput_GAA.TabIndex = 0;
            this.groupBoxInput_GAA.TabStop = false;
            this.groupBoxInput_GAA.Text = "Ввод данных";

            this.textBoxStop_GAA.Location = new System.Drawing.Point(100, 45);
            this.textBoxStop_GAA.Name = "textBoxStop_GAA";
            this.textBoxStop_GAA.Size = new System.Drawing.Size(80, 20);
            this.textBoxStop_GAA.TabIndex = 3;
            this.textBoxStop_GAA.Text = "5";

            this.textBoxStart_GAA.Location = new System.Drawing.Point(100, 20);
            this.textBoxStart_GAA.Name = "textBoxStart_GAA";
            this.textBoxStart_GAA.Size = new System.Drawing.Size(80, 20);
            this.textBoxStart_GAA.TabIndex = 2;
            this.textBoxStart_GAA.Text = "-5";
 
            this.labelStop_GAA.AutoSize = true;
            this.labelStop_GAA.Location = new System.Drawing.Point(10, 50);
            this.labelStop_GAA.Name = "labelStop_GAA";
            this.labelStop_GAA.Size = new System.Drawing.Size(69, 13);
            this.labelStop_GAA.TabIndex = 1;
            this.labelStop_GAA.Text = "Конец шага:";
   
            this.labelStart_GAA.AutoSize = true;
            this.labelStart_GAA.Location = new System.Drawing.Point(10, 25);
            this.labelStart_GAA.Name = "labelStart_GAA";
            this.labelStart_GAA.Size = new System.Drawing.Size(67, 13);
            this.labelStart_GAA.TabIndex = 0;
            this.labelStart_GAA.Text = "Старт шага:";

            this.groupBoxOutput_GAA.Controls.Add(this.textBoxResult_GAA);
            this.groupBoxOutput_GAA.Location = new System.Drawing.Point(12, 100);
            this.groupBoxOutput_GAA.Name = "groupBoxOutput_GAA";
            this.groupBoxOutput_GAA.Size = new System.Drawing.Size(200, 250);
            this.groupBoxOutput_GAA.TabIndex = 1;
            this.groupBoxOutput_GAA.TabStop = false;
            this.groupBoxOutput_GAA.Text = "Вывод данных";
  
            this.textBoxResult_GAA.Location = new System.Drawing.Point(10, 20);
            this.textBoxResult_GAA.Multiline = true;
            this.textBoxResult_GAA.Name = "textBoxResult_GAA";
            this.textBoxResult_GAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_GAA.Size = new System.Drawing.Size(180, 220);
            this.textBoxResult_GAA.TabIndex = 0;
 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_GAA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_GAA.Legends.Add(legend1);
            this.chartFunction_GAA.Location = new System.Drawing.Point(220, 12);
            this.chartFunction_GAA.Name = "chartFunction_GAA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_GAA.Series.Add(series1);
            this.chartFunction_GAA.Size = new System.Drawing.Size(400, 300);
            this.chartFunction_GAA.TabIndex = 2;
            this.chartFunction_GAA.Text = "График функции";

            this.buttonDone_GAA.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonDone_GAA.Location = new System.Drawing.Point(12, 360);
            this.buttonDone_GAA.Name = "buttonDone_GAA";
            this.buttonDone_GAA.Size = new System.Drawing.Size(100, 30);
            this.buttonDone_GAA.TabIndex = 3;
            this.buttonDone_GAA.Text = "Выполнить";
            this.buttonDone_GAA.UseVisualStyleBackColor = false;
            this.buttonDone_GAA.Click += new System.EventHandler(this.buttonDone_GAA_Click);

            this.buttonSave_GAA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSave_GAA.Location = new System.Drawing.Point(120, 360);
            this.buttonSave_GAA.Name = "buttonSave_GAA";
            this.buttonSave_GAA.Size = new System.Drawing.Size(100, 30);
            this.buttonSave_GAA.TabIndex = 4;
            this.buttonSave_GAA.Text = "Сохранить";
            this.buttonSave_GAA.UseVisualStyleBackColor = false;
            this.buttonSave_GAA.Click += new System.EventHandler(this.buttonSave_GAA_Click);

            this.buttonInfo_GAA.BackColor = System.Drawing.Color.Gold;
            this.buttonInfo_GAA.Location = new System.Drawing.Point(520, 360);
            this.buttonInfo_GAA.Name = "buttonInfo_GAA";
            this.buttonInfo_GAA.Size = new System.Drawing.Size(100, 30);
            this.buttonInfo_GAA.TabIndex = 5;
            this.buttonInfo_GAA.Text = "Справка";
            this.buttonInfo_GAA.UseVisualStyleBackColor = false;
            this.buttonInfo_GAA.Click += new System.EventHandler(this.buttonInfo_GAA_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 400);
            this.Controls.Add(this.buttonInfo_GAA);
            this.Controls.Add(this.buttonSave_GAA);
            this.Controls.Add(this.buttonDone_GAA);
            this.Controls.Add(this.chartFunction_GAA);
            this.Controls.Add(this.groupBoxOutput_GAA);
            this.Controls.Add(this.groupBoxInput_GAA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 3 | Галимов А.А.";
            this.groupBoxInput_GAA.ResumeLayout(false);
            this.groupBoxInput_GAA.PerformLayout();
            this.groupBoxOutput_GAA.ResumeLayout(false);
            this.groupBoxOutput_GAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_GAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInput_GAA;
        private System.Windows.Forms.TextBox textBoxStop_GAA;
        private System.Windows.Forms.TextBox textBoxStart_GAA;
        private System.Windows.Forms.Label labelStop_GAA;
        private System.Windows.Forms.Label labelStart_GAA;
        private System.Windows.Forms.GroupBox groupBoxOutput_GAA;
        private System.Windows.Forms.TextBox textBoxResult_GAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_GAA;
        private System.Windows.Forms.Button buttonDone_GAA;
        private System.Windows.Forms.Button buttonSave_GAA;
        private System.Windows.Forms.Button buttonInfo_GAA;
    }
}