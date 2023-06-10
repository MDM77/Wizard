namespace wizard.Pages
{
    partial class Overlay
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
            this.labelCPUTemp = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelCPUClock = new System.Windows.Forms.Label();
            this.labelGPUTemp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelCPUTemp
            // 
            this.labelCPUTemp.AutoEllipsis = true;
            this.labelCPUTemp.AutoSize = true;
            this.labelCPUTemp.BackColor = System.Drawing.Color.Transparent;
            this.labelCPUTemp.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCPUTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCPUTemp.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPUTemp.ForeColor = System.Drawing.Color.LightGreen;
            this.labelCPUTemp.Location = new System.Drawing.Point(20, 30);
            this.labelCPUTemp.MaximumSize = new System.Drawing.Size(500, 400);
            this.labelCPUTemp.Name = "labelCPUTemp";
            this.labelCPUTemp.Size = new System.Drawing.Size(0, 30);
            this.labelCPUTemp.TabIndex = 0;
            this.labelCPUTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // labelCPUClock
            // 
            this.labelCPUClock.AutoEllipsis = true;
            this.labelCPUClock.AutoSize = true;
            this.labelCPUClock.BackColor = System.Drawing.Color.Transparent;
            this.labelCPUClock.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCPUClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCPUClock.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPUClock.ForeColor = System.Drawing.Color.LightGreen;
            this.labelCPUClock.Location = new System.Drawing.Point(20, 60);
            this.labelCPUClock.MaximumSize = new System.Drawing.Size(500, 400);
            this.labelCPUClock.Name = "labelCPUClock";
            this.labelCPUClock.Size = new System.Drawing.Size(0, 30);
            this.labelCPUClock.TabIndex = 5;
            this.labelCPUClock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGPUTemp
            // 
            this.labelGPUTemp.AutoEllipsis = true;
            this.labelGPUTemp.AutoSize = true;
            this.labelGPUTemp.BackColor = System.Drawing.Color.Transparent;
            this.labelGPUTemp.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelGPUTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelGPUTemp.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGPUTemp.ForeColor = System.Drawing.Color.LightGreen;
            this.labelGPUTemp.Location = new System.Drawing.Point(20, 90);
            this.labelGPUTemp.MaximumSize = new System.Drawing.Size(500, 400);
            this.labelGPUTemp.Name = "labelGPUTemp";
            this.labelGPUTemp.Size = new System.Drawing.Size(0, 30);
            this.labelGPUTemp.TabIndex = 6;
            this.labelGPUTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::wizard.Properties.Resources.all_directions;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(35, 30);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Overlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(570, 628);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelGPUTemp);
            this.Controls.Add(this.labelCPUClock);
            this.Controls.Add(this.labelCPUTemp);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Overlay";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Green;
            this.Load += new System.EventHandler(this.Overlay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Label labelCPUTemp;
        public System.Windows.Forms.Label labelCPUClock;
        public System.Windows.Forms.Label labelGPUTemp;
        private System.Windows.Forms.Panel panel1;
    }
}