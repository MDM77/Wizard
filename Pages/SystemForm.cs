using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MetroFramework.Controls;
using ListView = System.Windows.Forms.ListView;
using MetroFramework.Forms;

namespace wizard.Pages
{
    public partial class SystemForm : MetroForm
    {
        public SystemForm()
        {
            InitializeComponent();
        }

        private void GetHardwareInfo(string key, MetroListView list)
        {
            list.Items.Clear();

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM " + key);

            try
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    ListViewGroup listViewGroup;
                    try
                    {
                        listViewGroup = list.Groups.Add(obj["Name"].ToString(), obj["Name"].ToString());
                    }
                    catch (Exception ex)
                    {
                        listViewGroup = list.Groups.Add(obj.ToString(), obj.ToString());
                    }
                    if (obj.Properties.Count == 0)
                    {
                        MessageBox.Show("Не удалось получить информацию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }
                    foreach (PropertyData data in obj.Properties)
                    {
                        ListViewItem item = new ListViewItem(listViewGroup);

                        //if (list.Items.Count % 2 != 0)
                        //{
                        //    item.BackColor = Color.Red;
                        //}
                        //else
                        //{
                        //    item.BackColor = Color.DarkBlue;
                        //}
                        item.Text = data.Name;
                        if (data.Value != null && !string.IsNullOrEmpty(data.Value.ToString()))
                        {
                            switch (data.Value.GetType().ToString())
                            {
                                case "System.String[]":
                                    string[] stringData = data.Value as string[];

                                    string resStr1 = string.Empty;

                                    foreach (string s in stringData)
                                    {
                                        resStr1 += $"{s} ";
                                    }

                                    item.SubItems.Add(resStr1);

                                    break;

                                case "System.UInt16[]":

                                    ushort[] ushortData = data.Value as ushort[];

                                    string resStr2 = string.Empty;

                                    foreach (ushort u in ushortData)
                                    {
                                        resStr2 += $"{Convert.ToString(u)} ";
                                    }

                                    item.SubItems.Add(resStr2);

                                    break;

                                default:

                                    item.SubItems.Add(data.Value.ToString());

                                    break;
                            }

                            list.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SystemForm_Load(object sender, EventArgs e)
        {
            metroCBParts.SelectedIndex = 0;
        }

        private void metroCBParts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = string.Empty;

            switch (metroCBParts.SelectedItem.ToString())
            {
                case "Процессор":
                    key = "Win32_Processor";
                    break;

                case "Видеокарта":
                    key = "Win32_VideoController";
                    break;

                case "Чипсет":
                    key = "Win32_IDEController";
                    break;

                case "Батарея":
                    key = "Win32_Battery";
                    break;

                case "Биос":
                    key = "Win32_BIOS";
                    break;

                case "Оперативная память":
                    key = "Win32_PhysicalMemory";
                    break;

                case "Кэш":
                    key = "Win32_CacheMemory";
                    break;

                case "USB":
                    key = "Win32_USBController";
                    break;

                case "Диск":
                    key = "Win32_DiskDrive";
                    break;

                case "Логические диски":
                    key = "Win32_LogicalDisk";
                    break;

                case "Клавиатура":
                    key = "Win32_Keyboard";
                    break;

                case "Сеть":
                    key = "Win32_NetworkAdapter";
                    break;

                case "Пользователи":
                    key = "Win32_Account";
                    break;

                default:
                    key = "Win32_Processor";
                    break;
            }
            GetHardwareInfo(key, metroListView1);
            //metroListView1.Sty
        }
    }
}