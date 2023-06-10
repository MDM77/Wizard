using LibreHardwareMonitor.Hardware;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using wizard.Core;

namespace wizard.Pages
{
    public partial class Overlay : Form
    {
        private string tempiInfo = string.Empty;
        public Point mouseLoc;
        private Visitor visitor = new Visitor();

        private Computer computer = new Computer
        {
            IsCpuEnabled = true,
            IsGpuEnabled = true,
            IsMemoryEnabled = true,
            IsMotherboardEnabled = true,
            IsControllerEnabled = true,
            IsNetworkEnabled = true,
            IsStorageEnabled = true
        };

        private void GetCPUTemp()
        {
            tempiInfo = string.Empty;
            computer.Open();
            computer.Accept(visitor);

            for (int i = 0; i < computer.Hardware.Count; i++)
            {
                if (computer.Hardware[i].HardwareType == HardwareType.Cpu)
                {
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature)
                        {
                            tempiInfo += computer.Hardware[i].Sensors[j].Name + " " +
                                computer.Hardware[i].Sensors[j].Value.ToString() + "°C" + "\n";
                        }
                    }
                }
            }

            labelCPUTemp.Text = tempiInfo;
            //metroLabel1.Text = tempiInfo;

            computer.Close();
        }

        private void GetGPUTemp()
        {
            string tempInfoG = string.Empty;
            computer.Open();
            computer.Accept(visitor);
            for (int i = 0; i < computer.Hardware.Count; i++)
            {
                if (computer.Hardware[i].HardwareType == HardwareType.GpuIntel)
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature)
                        {
                            tempInfoG += computer.Hardware[i].Sensors[j].Name + " " +
                                computer.Hardware[i].Sensors[j].Value.ToString() + "°C" + "\n";
                        }
                    }
                if (computer.Hardware[i].HardwareType == HardwareType.GpuAmd)
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature)
                        {
                            tempInfoG += computer.Hardware[i].Sensors[j].Name + " " +
                                computer.Hardware[i].Sensors[j].Value.ToString() + "°C" + "\n";
                        }
                    }
                if (computer.Hardware[i].HardwareType == HardwareType.GpuNvidia)
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature)
                        {
                            tempInfoG += computer.Hardware[i].Sensors[j].Name + " " +
                                computer.Hardware[i].Sensors[j].Value.ToString() + "°C" + "\n";
                        }
                    }
            }
            labelGPUTemp.Text = tempInfoG;
        }

        private void GetCPUClock()
        {
            string clockInfoC = string.Empty;
            computer.Open();
            computer.Accept(visitor);
            for (int i = 0; i < computer.Hardware.Count; i++)
            {
                if (computer.Hardware[i].HardwareType == HardwareType.Cpu)
                {
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Clock)
                        {
                            if (computer.Hardware[i].Sensors[j].Name.Contains("Core"))
                            {
                                clockInfoC += computer.Hardware[i].Sensors[j].Name + " " +
                                computer.Hardware[i].Sensors[j].Value.ToString() + " MHz" + "\n";
                            }
                            else
                            {
                                clockInfoC += computer.Hardware[i].Sensors[j].Name + " " +
                                computer.Hardware[i].Sensors[j].Value.ToString() + "\n";
                            }
                        }
                    }
                }
                labelCPUClock.Text = clockInfoC;
            }
        }

        public Overlay()
        {
            InitializeComponent();
            this.BackColor = Color.Green;
            this.TransparencyKey = Color.Green;
        }

        private void Overlay_Load(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //GetCPUTemp();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (Properties.Settings.Default.checkboxCPUT == true)
                {
                    GetCPUTemp();
                }
                if (Properties.Settings.Default.checkboxCPUC == true)
                {
                    GetCPUClock();
                }
                if (Properties.Settings.Default.checkboxGPUT == true)
                {
                    GetGPUTemp();
                }
                //GetCPUClock();
                //GetCPUTemp();
                //GetGPUTemp();
                Thread.Sleep(500);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLoc = new Point(-e.X, -e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLoc.X, mouseLoc.Y);
                Location = mousePos;
            }
        }
    }
}