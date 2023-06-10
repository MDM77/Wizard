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

namespace wizard.Pages
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void metroCheckBoxCPU_CheckedChanged(object sender, EventArgs e)
        {
            var ov = new Overlay();
            if (metroCheckBoxCPU.Checked == true)
            {
                ov.labelCPUTemp.Hide();
            }
        }

        private void metroCheckBoxCPUCL_CheckedChanged(object sender, EventArgs e)
        {
            var ov = new Overlay();
            if (metroCheckBoxCPUCL.Checked == true)
            {
                ov.labelCPUClock.Hide();
            }
        }

        private void metroCheckBoxGPU_CheckedChanged(object sender, EventArgs e)
        {
            var ov = new Overlay();
            if (metroCheckBoxGPU.Checked == true)
            {
                ov.labelGPUTemp.Hide();
            }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.checkboxCPUT = metroCheckBoxCPU.Checked;
            Properties.Settings.Default.checkboxCPUC = metroCheckBoxCPUCL.Checked;
            Properties.Settings.Default.checkboxGPUT = metroCheckBoxGPU.Checked;
            Properties.Settings.Default.Save();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            metroCheckBoxCPU.Checked = Properties.Settings.Default.checkboxCPUT;
            metroCheckBoxCPUCL.Checked = Properties.Settings.Default.checkboxCPUC;
            metroCheckBoxGPU.Checked = Properties.Settings.Default.checkboxGPUT;
        }
    }
}