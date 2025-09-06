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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop_GAA = new System.Windows.Forms.Panel();
            this.textBoxPath_GAA = new System.Windows.Forms.TextBox();
            this.buttonOpenFile_GAA = new System.Windows.Forms.Button();
            this.buttonHelp_GAA = new System.Windows.Forms.Button();
            this.panelCenter_GAA = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewValues_GAA = new System.Windows.Forms.DataGridView();
            this.chartDiagram_GAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTop_GAA.SuspendLayout();
            this.panelCenter_GAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValues_GAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagram_GAA)).BeginInit();
            this.SuspendLayout();
  
            this.panelTop_GAA.Controls.Add(this.textBoxPath_GAA);
            this.panelTop_GAA.Controls.Add(this.buttonOpenFile_GAA);
            this.panelTop_GAA.Controls.Add(this.buttonHelp_GAA);
            this.panelTop_GAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_GAA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_GAA.Name = "panelTop_GAA";
            this.panelTop_GAA.Size = new System.Drawing.Size(884, 60);
            this.panelTop_GAA.TabIndex = 0;

            this.textBoxPath_GAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPath_GAA.Location = new System.Drawing.Point(12, 19);
            this.textBoxPath_GAA.Name = "textBoxPath_GAA";
            this.textBoxPath_GAA.ReadOnly = true;
            this.textBoxPath_GAA.Size = new System.Drawing.Size(650, 20);
            this.textBoxPath_GAA.TabIndex = 2;
       
            this.buttonOpenFile_GAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenFile_GAA.Location = new System.Drawing.Point(668, 17);
            this.buttonOpenFile_GAA.Name = "buttonOpenFile_GAA";
            this.buttonOpenFile_GAA.Size = new System.Drawing.Size(100, 23);
            this.buttonOpenFile_GAA.TabIndex = 1;
            this.buttonOpenFile_GAA.Text = "Открыть файл";
            this.buttonOpenFile_GAA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_GAA.Click += new System.EventHandler(this.buttonOpenFile_GAA_Click);
  
            this.buttonHelp_GAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_GAA.Location = new System.Drawing.Point(774, 17);
            this.buttonHelp_GAA.Name = "buttonHelp_GAA";
            this.buttonHelp_GAA.Size = new System.Drawing.Size(100, 23);
            this.buttonHelp_GAA.TabIndex = 0;
            this.buttonHelp_GAA.Text = "Справка";
            this.buttonHelp_GAA.UseVisualStyleBackColor = true;
            this.buttonHelp_GAA.Click += new System.EventHandler(this.buttonHelp_GAA_Click);
    
            this.panelCenter_GAA.Controls.Add(this.splitContainer1);
            this.panelCenter_GAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter_GAA.Location = new System.Drawing.Point(0, 60);
            this.panelCenter_GAA.Name = "panelCenter_GAA";
            this.panelCenter_GAA.Size = new System.Drawing.Size(884, 501);
            this.panelCenter_GAA.TabIndex = 1;

            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
  
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewValues_GAA);
 
            this.splitContainer1.Panel2.Controls.Add(this.chartDiagram_GAA);
            this.splitContainer1.Size = new System.Drawing.Size(884, 501);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.TabIndex = 0;

            this.dataGridViewValues_GAA.AllowUserToAddRows = false;
            this.dataGridViewValues_GAA.AllowUserToDeleteRows = false;
            this.dataGridViewValues_GAA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewValues_GAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewValues_GAA.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewValues_GAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewValues_GAA.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewValues_GAA.Name = "dataGridViewValues_GAA";
            this.dataGridViewValues_GAA.ReadOnly = true;
            this.dataGridViewValues_GAA.Size = new System.Drawing.Size(294, 501);
            this.dataGridViewValues_GAA.TabIndex = 0;
 
            this.chartDiagram_GAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartDiagram_GAA.Location = new System.Drawing.Point(0, 0);
            this.chartDiagram_GAA.Name = "chartDiagram_GAA";
            this.chartDiagram_GAA.Size = new System.Drawing.Size(586, 501);
            this.chartDiagram_GAA.TabIndex = 0;
            this.chartDiagram_GAA.Text = "chart1";
  
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panelCenter_GAA);
            this.Controls.Add(this.panelTop_GAA);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 11 | Галимов А.А.";
            this.panelTop_GAA.ResumeLayout(false);
            this.panelTop_GAA.PerformLayout();
            this.panelCenter_GAA.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValues_GAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagram_GAA)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop_GAA;
        private System.Windows.Forms.Panel panelCenter_GAA;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewValues_GAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiagram_GAA;
        private System.Windows.Forms.Button buttonHelp_GAA;
        private System.Windows.Forms.Button buttonOpenFile_GAA;
        private System.Windows.Forms.TextBox textBoxPath_GAA;
    }
}