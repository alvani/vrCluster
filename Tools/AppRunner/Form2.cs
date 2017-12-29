using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Threading.Tasks;
using System.Threading;

namespace AppRunner
{
    public partial class Form2 : Form
    {
        const int nodeListenerPort = 9777;

        public struct WindowConfig
        {
            public string nodeId;
            public int left;
            public int top;
        }

        Dictionary<string, WindowConfig> wcDict;

        public Form2()
        {
            InitializeComponent();

            AppSettings settings = AppSettings.Load();
            foreach (var item in settings.Configs)
            {
                configListBox.Items.Add(item);
            }
            foreach (var item in settings.Exes)
            {
                exeListBox.Items.Add(item);
            }
            configListBox.SelectedIndex = settings.configIndex;
            exeListBox.SelectedIndex = settings.exeIndex;
            windowedCheckBox.Checked = settings.windowed;
            resXCheckBox.Checked = settings.resX;
            resXTextBox.Text = settings.resXVal;
            resYCheckBox.Checked = settings.resY;
            resYTextBox.Text = settings.resYVal;
            wcUseCheckBox.Checked = settings.useWcDict;
            wcDict = new Dictionary<string, WindowConfig>(settings.wcDict);
            UpdateWindowConfigList();
        }

        private void UpdateCommandLine()
        {
            cmdTextBox.Text = BuildCommandLine("<node_id>");
        }

        private string BuildCommandLine(string nodeId)
        {
            string cmd = "";
            if (exeListBox.SelectedIndex >= 0)
            {
                cmd += exeListBox.Items[exeListBox.SelectedIndex].ToString();
            }
            cmd += " uvr_node=" + nodeId;            
            if (configListBox.SelectedIndex >= 0)
            {
                cmd += " uvr_cfg=" + configListBox.Items[configListBox.SelectedIndex].ToString();
            }
            if (windowedCheckBox.Checked)
            {
                cmd += " -windowed";
            }
            if (resXCheckBox.Checked)
            {
                cmd += " -resX=" + resXTextBox.Text;
            }
            if (resYCheckBox.Checked)
            {
                cmd += " -resY=" + resYTextBox.Text;
            }
            if (wcUseCheckBox.Checked)
            {
                if (wcDict.ContainsKey(nodeId))
                {
                    WindowConfig wc = wcDict[nodeId];
                    cmd += " WinX=" + wc.left.ToString() + " WinY=" + wc.top.ToString();
                }
            }
            if (debugCheckBox.Checked)
            {
                cmd += " -uvr_dev_debug";
            }

            if (oglCheckBox.Checked)
            {
                cmd += " -opengl3";
            }

            cmd += " -uvr_cluster -nosplash -nowrite uvr_camera=camera_dynamic";
            return cmd;
        }

        private void SendDaemonCommand(string nodeAddress, string cmd)
        {
            TcpClient nodeClient = new TcpClient();

            try
            {
                nodeClient.Connect(nodeAddress, nodeListenerPort);
                NetworkStream networkStream = nodeClient.GetStream();
                StreamWriter clientStreamWriter = new StreamWriter(networkStream);

                if (networkStream.CanWrite)
                {
                    clientStreamWriter.Write(cmd);
                    clientStreamWriter.Flush();
                }
                else
                {
                    LogInfoSafe("Can't write to client on node [" + nodeAddress + "]");
                }

                nodeClient.Close();
            }
            catch (Exception exception)
            {
                LogInfoSafe("Can't connect to node " + nodeAddress + ". EXCEPTION: " + exception.Message);
            }
        }

        private void LogInfo(string info)
        {
            if (info == "")
            {
                tbConsole.AppendText("--//----------------------------------------" + Environment.NewLine);
                return;
            }

            tbConsole.AppendText("[" + DateTime.Now.ToString() + "] " + info + Environment.NewLine);
        }

        private void LogInfoSafe(string info)
        {
            Invoke(new Action(() =>
            {                
                LogInfo(info);
            }));
        }

        private void UpdateWindowConfigList()
        {
            wcListBox.Items.Clear();
            foreach (var key in wcDict.Keys)
            {
                var val = wcDict[key].nodeId;
                wcListBox.Items.Add(val);
            }            
        }

        private void addConfig_Click(object sender, EventArgs e)
        {            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            
            openFileDialog.Filter = "cfg files (*.cfg)|*.cfg";                        

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                configListBox.Items.Add(openFileDialog.FileName);                
            }
        }

        private void configListBox_SelectedIndexChanged(object sender, EventArgs e)
        {            
            UpdateCommandLine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (configListBox.SelectedIndex >= 0)
            {
                configListBox.Items.RemoveAt(configListBox.SelectedIndex);
            }            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "exe files (*.exe)|*.exe";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                exeListBox.Items.Add(openFileDialog.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (exeListBox.SelectedIndex >= 0)
            {
                exeListBox.Items.RemoveAt(exeListBox.SelectedIndex);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            AppSettings settings = new AppSettings();            
            foreach (var item in configListBox.Items)
            {
                settings.Configs.Add(item.ToString());
            }
            foreach (var item in exeListBox.Items)
            {
                settings.Exes.Add(item.ToString());
            }
            settings.configIndex = configListBox.SelectedIndex;
            settings.exeIndex = exeListBox.SelectedIndex;
            settings.windowed = windowedCheckBox.Checked;
            settings.resX = resXCheckBox.Checked;
            settings.resXVal = resXTextBox.Text;
            settings.resY = resYCheckBox.Checked;
            settings.resYVal = resYTextBox.Text;
            settings.useWcDict = wcUseCheckBox.Checked;
            settings.wcDict = new Dictionary<string, WindowConfig>(wcDict);
            settings.Save();
        }

        private void exeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCommandLine();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ConfigSerializer cfg = new ConfigSerializer();
            if (configListBox.SelectedIndex >= 0)
            {
                cfg.Load(configListBox.Items[configListBox.SelectedIndex].ToString());
            }

            foreach (var node in cfg.clusterNodes)
            {
                string cmd = "start " + BuildCommandLine(node.id);
                LogInfo("Send command to :  " + node.addr);
                Task.Factory.StartNew(() =>
                {
                    SendDaemonCommand(node.addr, cmd);
                });
            }                        
        }

        private void btnConsoleClear_Click(object sender, EventArgs e)
        {
            tbConsole.Clear();
        }

        private void btnConsoleCopy_Click(object sender, EventArgs e)
        {
            if (tbConsole.Text != String.Empty)
            {
                Clipboard.SetText(tbConsole.Text);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void windowedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCommandLine();
        }

        private void resXCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCommandLine();
        }

        private void resYCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCommandLine();
        }

        private void winXCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCommandLine();
        }

        private void winYCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCommandLine();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (wcNodeTextBox.Text.Length == 0)
            {
                return;
            }
            
            WindowConfig wc = new WindowConfig();
            wc.nodeId = wcNodeTextBox.Text;
            try
            {
                wc.left = Convert.ToInt32(wcLeftTextBox.Text);
                wc.top = Convert.ToInt32(wcTopTextBox.Text);
            }
            catch (Exception ex)
            {

            }
            wcDict[wc.nodeId] = wc;
            UpdateWindowConfigList();
        }

        private void wndCfgListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (wcListBox.SelectedIndex >= 0)
            {
                var selNodeId = wcListBox.Items[wcListBox.SelectedIndex].ToString();
                var wc = wcDict[selNodeId];
                wcNodeTextBox.Text = wc.nodeId;
                wcLeftTextBox.Text = wc.left.ToString();
                wcTopTextBox.Text = wc.top.ToString();
            }            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (wcListBox.SelectedIndex >= 0)
            {
                var selNodeId = wcListBox.Items[wcListBox.SelectedIndex].ToString();
                wcDict.Remove(selNodeId);
                UpdateWindowConfigList();
            }
        }

        private void debugCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCommandLine();
        }

        private void oglCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCommandLine();
        }
    }
}
