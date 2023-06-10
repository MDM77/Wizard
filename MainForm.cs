using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wizard.Pages;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.Runtime.InteropServices;
using System.Windows.Forms.DataVisualization.Charting;

namespace wizard
{
    public partial class MainForm : MetroForm
    {
        private Control oldParent;
        private Panel oldPanel;

        private void SetContent(Panel targetPanel)
        {
            if (oldPanel != null)
            {
                oldPanel.Parent = oldParent;
                if (oldParent is Form oldParentForm)
                {
                    oldParentForm.Dispose();
                }
            }

            var targetParent = targetPanel.Parent;
            targetPanel.Parent = this;
            oldParent = targetParent;
            oldPanel = targetPanel;
        }

        public MainForm()
        {
            InitializeComponent();
            var HomeForm = new HomeForm();
            SetContent(HomeForm.panelHome);
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            var HomeForm = new HomeForm();
            SetContent(HomeForm.panelHome);
        }

        private void buttonMon_Click(object sender, EventArgs e)
        {
            var mf = new MonitorForm();
            SetContent(mf.panelMonitor);
            mf.Show();
            mf.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void buttonOver_Click(object sender, EventArgs e)
        {
            var ov = new Overlay();
            if (!Application.OpenForms.OfType<Overlay>().Any())
            {
                ov.Show();
                buttonOver.BackColor = Color.IndianRed;
            }
            else
            {
                Application.OpenForms.OfType<Overlay>().First().Close();
                buttonOver.BackColor = Color.LightSkyBlue;
            }
        }

        private void buttonSys_Click(object sender, EventArgs e)
        {
            var sys = new SystemForm();
            SetContent(sys.panelSys);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            var settings = new SettingsForm();
            settings.metroCheckBoxCPU.Checked = Properties.Settings.Default.checkboxCPUT;
            settings.metroCheckBoxCPUCL.Checked = Properties.Settings.Default.checkboxCPUC;
            settings.metroCheckBoxGPU.Checked = Properties.Settings.Default.checkboxGPUT;
            SetContent(settings.settingsPanel);
        }
    }
}