namespace wizard.Pages
{
    partial class SystemForm
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
            this.panelSys = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroCBParts = new MetroFramework.Controls.MetroComboBox();
            this.panelSys.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSys
            // 
            this.panelSys.Controls.Add(this.label1);
            this.panelSys.Controls.Add(this.metroListView1);
            this.panelSys.Controls.Add(this.metroCBParts);
            this.panelSys.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSys.Location = new System.Drawing.Point(184, 60);
            this.panelSys.Name = "panelSys";
            this.panelSys.Size = new System.Drawing.Size(980, 481);
            this.panelSys.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите элемент:";
            // 
            // metroListView1
            // 
            this.metroListView1.AllowSorting = true;
            this.metroListView1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.metroListView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.GridLines = true;
            this.metroListView1.Location = new System.Drawing.Point(198, 0);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(782, 481);
            this.metroListView1.TabIndex = 1;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название";
            this.columnHeader1.Width = 275;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Значение";
            this.columnHeader2.Width = 500;
            // 
            // metroCBParts
            // 
            this.metroCBParts.FormattingEnabled = true;
            this.metroCBParts.ItemHeight = 23;
            this.metroCBParts.Items.AddRange(new object[] {
            "Процессор",
            "Видеокарта",
            "Чипсет",
            "Батарея",
            "Биос",
            "Оперативная память",
            "Кэш",
            "USB",
            "Диск",
            "Логические диски",
            "Клавиатура",
            "Сеть",
            "Пользователи"});
            this.metroCBParts.Location = new System.Drawing.Point(3, 29);
            this.metroCBParts.Name = "metroCBParts";
            this.metroCBParts.Size = new System.Drawing.Size(189, 29);
            this.metroCBParts.TabIndex = 0;
            this.metroCBParts.UseSelectable = true;
            this.metroCBParts.SelectedIndexChanged += new System.EventHandler(this.metroCBParts_SelectedIndexChanged);
            // 
            // SystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.panelSys);
            this.Name = "SystemForm";
            this.Text = "SystemForm";
            this.Load += new System.EventHandler(this.SystemForm_Load);
            this.panelSys.ResumeLayout(false);
            this.panelSys.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox metroCBParts;
        private MetroFramework.Controls.MetroListView metroListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.Panel panelSys;
        private System.Windows.Forms.Label label1;
    }
}