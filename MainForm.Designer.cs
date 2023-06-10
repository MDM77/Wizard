namespace wizard
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mpMainForm = new MetroFramework.Controls.MetroPanel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonMon = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonOver = new System.Windows.Forms.Button();
            this.buttonSys = new System.Windows.Forms.Button();
            this.mpMainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // mpMainForm
            // 
            this.mpMainForm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mpMainForm.BackColor = System.Drawing.Color.Transparent;
            this.mpMainForm.Controls.Add(this.buttonSettings);
            this.mpMainForm.Controls.Add(this.pictureBoxLogo);
            this.mpMainForm.Controls.Add(this.buttonMon);
            this.mpMainForm.Controls.Add(this.buttonHome);
            this.mpMainForm.Controls.Add(this.buttonOver);
            this.mpMainForm.Controls.Add(this.buttonSys);
            this.mpMainForm.ForeColor = System.Drawing.Color.Transparent;
            this.mpMainForm.HorizontalScrollbarBarColor = true;
            this.mpMainForm.HorizontalScrollbarHighlightOnWheel = false;
            this.mpMainForm.HorizontalScrollbarSize = 10;
            this.mpMainForm.Location = new System.Drawing.Point(2, 7);
            this.mpMainForm.Name = "mpMainForm";
            this.mpMainForm.Size = new System.Drawing.Size(175, 582);
            this.mpMainForm.Style = MetroFramework.MetroColorStyle.Blue;
            this.mpMainForm.TabIndex = 2;
            this.mpMainForm.VerticalScrollbarBarColor = true;
            this.mpMainForm.VerticalScrollbarHighlightOnWheel = false;
            this.mpMainForm.VerticalScrollbarSize = 10;
            // 
            // buttonSettings
            // 
            this.buttonSettings.AutoSize = true;
            this.buttonSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSettings.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.ForeColor = System.Drawing.Color.Black;
            this.buttonSettings.Image = global::wizard.Properties.Resources.settings;
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.Location = new System.Drawing.Point(12, 357);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(12, 6, 6, 13);
            this.buttonSettings.MinimumSize = new System.Drawing.Size(152, 50);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Padding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.buttonSettings.Size = new System.Drawing.Size(152, 50);
            this.buttonSettings.TabIndex = 5;
            this.buttonSettings.Text = "Настройки";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImage = global::wizard.Properties.Resources.computer_repair_icon;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 6);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(152, 70);
            this.pictureBoxLogo.TabIndex = 4;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonMon
            // 
            this.buttonMon.AutoSize = true;
            this.buttonMon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonMon.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMon.ForeColor = System.Drawing.Color.Black;
            this.buttonMon.Image = global::wizard.Properties.Resources.cpu;
            this.buttonMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMon.Location = new System.Drawing.Point(12, 150);
            this.buttonMon.Margin = new System.Windows.Forms.Padding(12, 6, 6, 13);
            this.buttonMon.MinimumSize = new System.Drawing.Size(152, 50);
            this.buttonMon.Name = "buttonMon";
            this.buttonMon.Padding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.buttonMon.Size = new System.Drawing.Size(152, 50);
            this.buttonMon.TabIndex = 1;
            this.buttonMon.Text = "Монитор";
            this.buttonMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMon.UseVisualStyleBackColor = false;
            this.buttonMon.Click += new System.EventHandler(this.buttonMon_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonHome.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.Black;
            this.buttonHome.Image = global::wizard.Properties.Resources.home_2_;
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(12, 81);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.buttonHome.MinimumSize = new System.Drawing.Size(152, 46);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Padding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.buttonHome.Size = new System.Drawing.Size(152, 50);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "Главная";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonOver
            // 
            this.buttonOver.AutoSize = true;
            this.buttonOver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonOver.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonOver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOver.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOver.ForeColor = System.Drawing.Color.Black;
            this.buttonOver.Image = global::wizard.Properties.Resources.cms_1_;
            this.buttonOver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOver.Location = new System.Drawing.Point(12, 288);
            this.buttonOver.Margin = new System.Windows.Forms.Padding(12, 6, 6, 13);
            this.buttonOver.MinimumSize = new System.Drawing.Size(152, 50);
            this.buttonOver.Name = "buttonOver";
            this.buttonOver.Padding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.buttonOver.Size = new System.Drawing.Size(152, 50);
            this.buttonOver.TabIndex = 3;
            this.buttonOver.Text = "Оверлей";
            this.buttonOver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonOver.UseVisualStyleBackColor = false;
            this.buttonOver.Click += new System.EventHandler(this.buttonOver_Click);
            // 
            // buttonSys
            // 
            this.buttonSys.AutoSize = true;
            this.buttonSys.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSys.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonSys.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSys.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSys.ForeColor = System.Drawing.Color.Black;
            this.buttonSys.Image = global::wizard.Properties.Resources.desktop_pc_1_;
            this.buttonSys.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSys.Location = new System.Drawing.Point(12, 219);
            this.buttonSys.Margin = new System.Windows.Forms.Padding(12, 6, 6, 13);
            this.buttonSys.MinimumSize = new System.Drawing.Size(152, 50);
            this.buttonSys.Name = "buttonSys";
            this.buttonSys.Padding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.buttonSys.Size = new System.Drawing.Size(152, 50);
            this.buttonSys.TabIndex = 2;
            this.buttonSys.Text = "Система";
            this.buttonSys.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSys.UseVisualStyleBackColor = false;
            this.buttonSys.Click += new System.EventHandler(this.buttonSys_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.mpMainForm);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(23, 79, 23, 26);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowIcon = false;
            this.mpMainForm.ResumeLayout(false);
            this.mpMainForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mpMainForm;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonMon;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonOver;
        private System.Windows.Forms.Button buttonSys;
        private System.Windows.Forms.Button buttonSettings;
    }
}

