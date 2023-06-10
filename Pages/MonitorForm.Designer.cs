namespace wizard.Pages
{
    partial class MonitorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelMonitor = new System.Windows.Forms.Panel();
            this.metrotab2 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelInUse = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.labelAvail = new MetroFramework.Controls.MetroLabel();
            this.labelActive = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelMemv = new MetroFramework.Controls.MetroLabel();
            this.labelCPv = new MetroFramework.Controls.MetroLabel();
            this.labelMem = new MetroFramework.Controls.MetroLabel();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.labelCP = new MetroFramework.Controls.MetroLabel();
            this.metroProgressSpinner2 = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.performanceCPU = new System.Diagnostics.PerformanceCounter();
            this.performanceRAM = new System.Diagnostics.PerformanceCounter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelMonitor.SuspendLayout();
            this.metrotab2.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceRAM)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMonitor
            // 
            this.panelMonitor.Controls.Add(this.metrotab2);
            this.panelMonitor.Location = new System.Drawing.Point(199, 6);
            this.panelMonitor.Name = "panelMonitor";
            this.panelMonitor.Size = new System.Drawing.Size(985, 553);
            this.panelMonitor.TabIndex = 0;
            // 
            // metrotab2
            // 
            this.metrotab2.Controls.Add(this.metroTabPage1);
            this.metrotab2.Controls.Add(this.metroTabPage2);
            this.metrotab2.Location = new System.Drawing.Point(0, 6);
            this.metrotab2.Name = "metrotab2";
            this.metrotab2.SelectedIndex = 0;
            this.metrotab2.Size = new System.Drawing.Size(985, 544);
            this.metrotab2.TabIndex = 1;
            this.metrotab2.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.chart1);
            this.metroTabPage1.Controls.Add(this.tableLayoutPanel2);
            this.metroTabPage1.Controls.Add(this.tableLayoutPanel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(977, 502);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "ЦП и ОЗУ";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(246, 6);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.SystemColors.MenuHighlight;
            series1.MarkerSize = 10;
            series1.Name = "ОЗУ";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.MarkerSize = 10;
            series2.Name = "ЦП";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(712, 410);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.labelInUse, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel8, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel10, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelAvail, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelActive, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel9, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 278);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(240, 138);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // labelInUse
            // 
            this.labelInUse.AutoSize = true;
            this.labelInUse.Location = new System.Drawing.Point(3, 0);
            this.labelInUse.Name = "labelInUse";
            this.labelInUse.Size = new System.Drawing.Size(94, 19);
            this.labelInUse.TabIndex = 1;
            this.labelInUse.Text = "Используется:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(123, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(53, 19);
            this.metroLabel8.TabIndex = 4;
            this.metroLabel8.Text = "loading";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(123, 92);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(53, 19);
            this.metroLabel10.TabIndex = 6;
            this.metroLabel10.Text = "loading";
            // 
            // labelAvail
            // 
            this.labelAvail.AutoSize = true;
            this.labelAvail.Location = new System.Drawing.Point(3, 46);
            this.labelAvail.Name = "labelAvail";
            this.labelAvail.Size = new System.Drawing.Size(70, 19);
            this.labelAvail.TabIndex = 2;
            this.labelAvail.Text = "Доступно:";
            // 
            // labelActive
            // 
            this.labelActive.AutoSize = true;
            this.labelActive.Location = new System.Drawing.Point(3, 92);
            this.labelActive.Name = "labelActive";
            this.labelActive.Size = new System.Drawing.Size(91, 19);
            this.labelActive.TabIndex = 3;
            this.labelActive.Text = "Установлено:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(123, 46);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(53, 19);
            this.metroLabel9.TabIndex = 5;
            this.metroLabel9.Text = "loading";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.0597F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.9403F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.Controls.Add(this.labelMemv, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelCPv, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelMem, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroProgressSpinner1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelCP, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroProgressSpinner2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(240, 266);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelMemv
            // 
            this.labelMemv.AutoSize = true;
            this.labelMemv.Location = new System.Drawing.Point(161, 133);
            this.labelMemv.Name = "labelMemv";
            this.labelMemv.Size = new System.Drawing.Size(20, 19);
            this.labelMemv.TabIndex = 6;
            this.labelMemv.Text = "%";
            // 
            // labelCPv
            // 
            this.labelCPv.AutoSize = true;
            this.labelCPv.Location = new System.Drawing.Point(161, 0);
            this.labelCPv.Name = "labelCPv";
            this.labelCPv.Size = new System.Drawing.Size(20, 19);
            this.labelCPv.TabIndex = 5;
            this.labelCPv.Text = "%";
            // 
            // labelMem
            // 
            this.labelMem.AutoSize = true;
            this.labelMem.Location = new System.Drawing.Point(3, 133);
            this.labelMem.Name = "labelMem";
            this.labelMem.Size = new System.Drawing.Size(36, 19);
            this.labelMem.TabIndex = 2;
            this.labelMem.Text = "ОЗУ";
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(63, 136);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.MinimumSize = new System.Drawing.Size(100, 100);
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(100, 100);
            this.metroProgressSpinner1.Spinning = false;
            this.metroProgressSpinner1.TabIndex = 3;
            this.metroProgressSpinner1.UseSelectable = true;
            // 
            // labelCP
            // 
            this.labelCP.AutoSize = true;
            this.labelCP.Location = new System.Drawing.Point(3, 0);
            this.labelCP.Name = "labelCP";
            this.labelCP.Size = new System.Drawing.Size(28, 19);
            this.labelCP.TabIndex = 1;
            this.labelCP.Text = "ЦП";
            // 
            // metroProgressSpinner2
            // 
            this.metroProgressSpinner2.Location = new System.Drawing.Point(63, 3);
            this.metroProgressSpinner2.Maximum = 100;
            this.metroProgressSpinner2.MinimumSize = new System.Drawing.Size(100, 100);
            this.metroProgressSpinner2.Name = "metroProgressSpinner2";
            this.metroProgressSpinner2.Size = new System.Drawing.Size(100, 100);
            this.metroProgressSpinner2.Spinning = false;
            this.metroProgressSpinner2.TabIndex = 4;
            this.metroProgressSpinner2.UseSelectable = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.label2);
            this.metroTabPage2.Controls.Add(this.label1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(977, 502);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Вольтаж";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(223, 12);
            this.label2.MaximumSize = new System.Drawing.Size(170, 210);
            this.label2.MinimumSize = new System.Drawing.Size(170, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 210);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вольтаж ГП:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.MaximumSize = new System.Drawing.Size(170, 210);
            this.label1.MinimumSize = new System.Drawing.Size(170, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 210);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вольтаж ЦП:";
            // 
            // performanceCPU
            // 
            this.performanceCPU.CategoryName = "Processor";
            this.performanceCPU.CounterName = "% Processor Time";
            this.performanceCPU.InstanceName = "_total";
            // 
            // performanceRAM
            // 
            this.performanceRAM.CategoryName = "Memory";
            this.performanceRAM.CounterName = "% Committed Bytes In Use";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // MonitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.panelMonitor);
            this.Name = "MonitorForm";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "MonitorForm";
            this.Load += new System.EventHandler(this.MonitorForm_Load);
            this.panelMonitor.ResumeLayout(false);
            this.metrotab2.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceRAM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroTabControl metrotab2;
        public System.Windows.Forms.Panel panelMonitor;
        public MetroFramework.Controls.MetroLabel metroLabel10;
        public MetroFramework.Controls.MetroLabel metroLabel9;
        public MetroFramework.Controls.MetroLabel metroLabel8;
        public MetroFramework.Controls.MetroLabel labelMemv;
        public MetroFramework.Controls.MetroLabel labelCPv;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public MetroFramework.Controls.MetroTabPage metroTabPage1;
        public MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        public MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner2;
        public MetroFramework.Controls.MetroLabel labelActive;
        public MetroFramework.Controls.MetroLabel labelAvail;
        public MetroFramework.Controls.MetroLabel labelInUse;
        public MetroFramework.Controls.MetroLabel labelMem;
        public MetroFramework.Controls.MetroLabel labelCP;
        private System.Diagnostics.PerformanceCounter performanceCPU;
        private System.Diagnostics.PerformanceCounter performanceRAM;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}