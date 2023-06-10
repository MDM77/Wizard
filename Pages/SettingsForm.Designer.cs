namespace wizard.Pages
{
    partial class SettingsForm
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
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.metroCheckBoxCPU = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBoxCPUCL = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBoxGPU = new MetroFramework.Controls.MetroCheckBox();
            this.buttonHome = new System.Windows.Forms.Button();
            this.settingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.settingsPanel.Controls.Add(this.buttonHome);
            this.settingsPanel.Controls.Add(this.metroCheckBoxGPU);
            this.settingsPanel.Controls.Add(this.metroCheckBoxCPUCL);
            this.settingsPanel.Controls.Add(this.metroLabel1);
            this.settingsPanel.Controls.Add(this.metroCheckBoxCPU);
            this.settingsPanel.Location = new System.Drawing.Point(199, 12);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(985, 553);
            this.settingsPanel.TabIndex = 0;
            // 
            // metroCheckBoxCPU
            // 
            this.metroCheckBoxCPU.AutoSize = true;
            this.metroCheckBoxCPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroCheckBoxCPU.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.metroCheckBoxCPU.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.metroCheckBoxCPU.Location = new System.Drawing.Point(28, 85);
            this.metroCheckBoxCPU.Name = "metroCheckBoxCPU";
            this.metroCheckBoxCPU.Size = new System.Drawing.Size(198, 19);
            this.metroCheckBoxCPU.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroCheckBoxCPU.TabIndex = 0;
            this.metroCheckBoxCPU.Text = "Показывать температуру ЦП";
            this.metroCheckBoxCPU.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroCheckBoxCPU.UseSelectable = true;
            this.metroCheckBoxCPU.CheckedChanged += new System.EventHandler(this.metroCheckBoxCPU_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(28, 41);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(170, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Настройки оверлея:";
            // 
            // metroCheckBoxCPUCL
            // 
            this.metroCheckBoxCPUCL.AutoSize = true;
            this.metroCheckBoxCPUCL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroCheckBoxCPUCL.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.metroCheckBoxCPUCL.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.metroCheckBoxCPUCL.Location = new System.Drawing.Point(28, 123);
            this.metroCheckBoxCPUCL.Name = "metroCheckBoxCPUCL";
            this.metroCheckBoxCPUCL.Size = new System.Drawing.Size(225, 19);
            this.metroCheckBoxCPUCL.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroCheckBoxCPUCL.TabIndex = 2;
            this.metroCheckBoxCPUCL.Text = "Показывать тактовую частоту ЦП";
            this.metroCheckBoxCPUCL.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroCheckBoxCPUCL.UseSelectable = true;
            this.metroCheckBoxCPUCL.CheckedChanged += new System.EventHandler(this.metroCheckBoxCPUCL_CheckedChanged);
            // 
            // metroCheckBoxGPU
            // 
            this.metroCheckBoxGPU.AutoSize = true;
            this.metroCheckBoxGPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroCheckBoxGPU.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.metroCheckBoxGPU.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.metroCheckBoxGPU.Location = new System.Drawing.Point(28, 161);
            this.metroCheckBoxGPU.Name = "metroCheckBoxGPU";
            this.metroCheckBoxGPU.Size = new System.Drawing.Size(194, 19);
            this.metroCheckBoxGPU.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroCheckBoxGPU.TabIndex = 3;
            this.metroCheckBoxGPU.Text = "Показывать температуру ГП";
            this.metroCheckBoxGPU.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroCheckBoxGPU.UseSelectable = true;
            // 
            // buttonHome
            // 
            this.buttonHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonHome.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.Black;
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(839, 499);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(7);
            this.buttonHome.MinimumSize = new System.Drawing.Size(130, 30);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Padding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.buttonHome.Size = new System.Drawing.Size(130, 34);
            this.buttonHome.TabIndex = 4;
            this.buttonHome.Text = "Сохранить";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.settingsPanel);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button buttonHome;
        public System.Windows.Forms.Panel settingsPanel;
        public MetroFramework.Controls.MetroCheckBox metroCheckBoxCPU;
        public MetroFramework.Controls.MetroCheckBox metroCheckBoxGPU;
        public MetroFramework.Controls.MetroCheckBox metroCheckBoxCPUCL;
    }
}