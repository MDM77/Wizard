using LibreHardwareMonitor.Hardware;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using wizard.Core;

namespace wizard.Pages
{
    public partial class MonitorForm : Form
    {
        private float cpu;
        private float ram;
        private ulong installedMemory;
        private Visitor visitor = new Visitor();
        private string tempInfoCPU = string.Empty;
        private string tempInfoGPU = string.Empty;

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

        private void GetVoltageCPU()
        {
            tempInfoCPU = string.Empty;
            computer.Open();
            computer.Accept(visitor);

            for (int i = 0; i < computer.Hardware.Count; i++)
            {
                if (computer.Hardware[i].HardwareType == HardwareType.Cpu)
                {
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Voltage)
                        {
                            tempInfoCPU += computer.Hardware[i].Sensors[j].Name +
                               computer.Hardware[i].Sensors[j].Value.ToString() + "\n";
                        }
                    }
                }
            }
            label1.Text = "Вольтаж ЦП: \n" + tempInfoCPU;
        }

        private void GetVoltageGPU()
        {
            tempInfoGPU = string.Empty;
            computer.Open();
            computer.Accept(visitor);

            for (int i = 0; i < computer.Hardware.Count; i++)
            {
                if (computer.Hardware[i].HardwareType == HardwareType.GpuIntel)
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Voltage)
                        {
                            tempInfoGPU += computer.Hardware[i].Sensors[j].Name +
                                computer.Hardware[i].Sensors[j].Value.ToString() + "\n";
                        }
                    }
                if (computer.Hardware[i].HardwareType == HardwareType.GpuAmd)
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Voltage)
                        {
                            tempInfoGPU += computer.Hardware[i].Sensors[j].Name +
                                computer.Hardware[i].Sensors[j].Value.ToString() + "\n";
                        }
                    }
                if (computer.Hardware[i].HardwareType == HardwareType.GpuNvidia)
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Voltage)
                        {
                            tempInfoGPU += computer.Hardware[i].Sensors[j].Name +
                                computer.Hardware[i].Sensors[j].Value.ToString() + "\n";
                        }
                    }
            }
            label2.Text = "Вольтаж ГП: \n" + tempInfoGPU;
        }

        public MonitorForm()
        {
            InitializeComponent();
        }

        private void MonitorForm_Load(object sender, EventArgs e)
        {
            MEMORYSTATUSEX mEMORYSTATUSEX = new MEMORYSTATUSEX();

            if (GlobalMemoryStatusEx(mEMORYSTATUSEX))
            {
                installedMemory = mEMORYSTATUSEX.ulTotalPhys;
            }
            metroLabel10.Text = Convert.ToString(installedMemory / 1000000000) + "Гб";
            timer1.Interval = 1000;
            timer1.Start();

            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        private class MEMORYSTATUSEX
        {
            public uint dwLength;
            public uint dwMemoryLength;
            public ulong ulTotalPhys;
            public ulong ulAvailPhys;
            public ulong ulTotalPageFile;
            public ulong ulAvailPageFile;
            public ulong ulTotalVirtual;
            public ulong ulAvailVirtual;
            public ulong ulAvailExtendedVirtual;

            public MEMORYSTATUSEX()
            {
                this.dwLength = (uint)Marshal.SizeOf(typeof(MEMORYSTATUSEX));
            }
        }

        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool GlobalMemoryStatusEx([In, Out] MEMORYSTATUSEX lpBuffer);

        private void timer1_Tick(object sender, EventArgs e)
        {
            cpu = performanceCPU.NextValue();
            ram = performanceRAM.NextValue();

            metroProgressSpinner2.Value = (int)cpu;
            metroProgressSpinner1.Value = (int)ram;

            labelCPv.Text = Convert.ToString(Math.Round(cpu, 1)) + " %";
            labelMemv.Text = Convert.ToString(Math.Round(ram, 1)) + " %";

            metroLabel8.Text = Convert.ToString(Math.Round((ram / 100 * installedMemory) / 1024 / 1024 / 1024, 1)) + " Гб";
            metroLabel9.Text = Convert.ToString(Math.Round((installedMemory - ram / 100 * installedMemory) / 1024 / 1024 / 1024, 1)) + " Гб";

            chart1.Series["ЦП"].Points.AddY(cpu);
            chart1.Series["ОЗУ"].Points.AddY(ram);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                GetVoltageGPU();
                GetVoltageCPU();
                Thread.Sleep(500);
            }
        }
    }
}