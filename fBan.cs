using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Secury.funct;
using System.IO;

namespace Secury
{
    public partial class fBan : Form
    {
        public fBan()
        {
            InitializeComponent();
        }

        public static List<string> IP { private get; set; }

        public static List<string> AddIPs { private get; set; }

        private void bBanListApply_Click(object sender, EventArgs e)
        {

        }

        private void AddToLogs(string sText, string sDateTime, string sState)
        {
            ListViewItem lvi = new ListViewItem(sDateTime);
            lvi.SubItems.Add(sText);

            listView1.Items.Add(lvi);
        }

        enum Execut { Add, Delete, Show, Rebuild }
        private void FunctExecute(string ip = "", Execut exu = Execut.Add)
        {
            string filePath = Environment.CurrentDirectory + @"\set.dat";
            if (File.Exists(filePath))
            {
                string sNameRule = IniFileHelper.ReadValue("Firewall", "Name", filePath);
                string sProtocolRule = IniFileHelper.ReadValue("Firewall", "Protocol", filePath);
                string sProfileRule = IniFileHelper.ReadValue("Firewall", "Profile", filePath);
                string sLocalPortRule = IniFileHelper.ReadValue("Firewall", "LocalPort", filePath);
                string sRemotePortRule = IniFileHelper.ReadValue("Firewall", "RemotePort", filePath);
                string sAction = IniFileHelper.ReadValue("Firewall", "Action", filePath);
                string sDir = IniFileHelper.ReadValue("Firewall", "Dir", filePath);

                if (exu == Execut.Show)
                {
                    string Command = @"netsh advfirewall firewall show rule name="+ sNameRule;

                    ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/c " + Command);

                    procStartInfo.RedirectStandardOutput = true;
                    procStartInfo.UseShellExecute = false;
                    procStartInfo.CreateNoWindow = true;

                    Process proc = new Process();
                    procStartInfo.StandardOutputEncoding = Encoding.GetEncoding(866);
                    proc.StartInfo = procStartInfo;
                    proc.Start();
                    string OutputResult = proc.StandardOutput.ReadToEnd();

                    AddToLogs(OutputResult, DateTime.Now.ToString(), "");

                    listBox2.Items.AddRange(ParseOut(OutputResult).ToArray());
                }
                else if (exu == Execut.Add)
                {
                    string Command = @"netsh advfirewall firewall add rule name=" + sNameRule + " protocol=" + sProtocolRule + " profile=" + sProfileRule + " localport=" + sLocalPortRule + " remoteport=" + sRemotePortRule + " action=" + sAction + " dir=" + sDir + " remoteip=" + ip;

                    ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/c " + Command);

                    procStartInfo.RedirectStandardOutput = true;
                    procStartInfo.UseShellExecute = false;
                    procStartInfo.CreateNoWindow = true;

                    Process proc = new Process();
                    procStartInfo.StandardOutputEncoding = Encoding.GetEncoding(866);
                    proc.StartInfo = procStartInfo;
                    proc.Start();

                    string OutputResult = proc.StandardOutput.ReadToEnd();

                    AddToLogs(OutputResult, DateTime.Now.ToString(), "");

                }
                if (exu == Execut.Delete)
                {
                    string Command = @"netsh advfirewall firewall delete rule name=" + sNameRule;

                    ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/c " + Command);

                    procStartInfo.RedirectStandardOutput = true;
                    procStartInfo.UseShellExecute = false;
                    procStartInfo.CreateNoWindow = true;

                    Process proc = new Process();
                    procStartInfo.StandardOutputEncoding = Encoding.GetEncoding(866);
                    proc.StartInfo = procStartInfo;
                    proc.Start();

                    string OutputResult = proc.StandardOutput.ReadToEnd();

                    AddToLogs(OutputResult, DateTime.Now.ToString(), "");

                }
            }
            else
            {
                fSettings fs = new fSettings();
                this.Hide();
                if (DialogResult.Cancel == fs.ShowDialog())
                    fs.Dispose();
                this.Show();
            }

        }


        private void bRead_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            FunctExecute(null, Execut.Show);
        }

        private List<string> ParseOut(string str)
        {
            MatchCollection mt = Regex.Matches(str, @"\d{1,3}.\d{1,3}.\d{1,3}.\d{1,3}/\d{1,2}");
            List<string> lst = new List<string>();
            foreach (Match mts in mt)
                lst.Add(mts.Value);
            return lst;
        }

        private void bIPListRefresh_Click(object sender, EventArgs e)
        {
            if (IP != null & IP.Count > 0)
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(IP.ToArray());
            }
        }

        public void Refresher()
        {
            bIPListRefresh_Click(this, null);
            bRead_Click(this, null);

        }

        private void msfwTASort_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = false;
            listBox1.Sorted = true;

            listBox2.Sorted = false;
            listBox2.Sorted = true;

            listBox3.Sorted = false;
            listBox3.Sorted = true;
        }

        private void bSearchInListIP_Click(object sender, EventArgs e)
        {
            if (searchString.Text != string.Empty)
            {
                // Find the item in the list and store the index to the item.

                int index1 = listBox1.FindString(searchString.Text);
                // Determine if a valid index is returned. Select the item if it is valid.
                if (index1 != -1)
                    listBox1.SetSelected(index1, true);

                // Find the item in the list and store the index to the item.
                int index2 = listBox2.FindString(searchString.Text);
                // Determine if a valid index is returned. Select the item if it is valid.
                if (index2 != -1)
                    listBox2.SetSelected(index2, true);

                // Find the item in the list and store the index to the item.
                int index3 = listBox3.FindString(searchString.Text);
                // Determine if a valid index is returned. Select the item if it is valid.
                if (index3 != -1)
                    listBox3.SetSelected(index3, true);
            }
        }

        private void msfwTARefresh_Click(object sender, EventArgs e)
        {
            ssfwTStatus.Text = "Count: " + listBox1.Items.Count;
            ssfwDStatus.Text = "Count: " + listBox2.Items.Count;
            ssfwAStatus.Text = "Count: " + listBox3.Items.Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HashSet<string> htt = new HashSet<string>();
            for (int i = 0; i < 250055; i++)
            {
                Random random = new Random();
                //string ip  = string.Format("{0}.{1}.{2}.{3}", _random.Next(0, 255), _random.Next(0, 255), _random.Next(0, 255), _random.Next(0, 255));
                string ip = $"{random.Next(1, 255)}.{random.Next(0, 255)}.{random.Next(0, 255)}.{random.Next(0, 255)}";
                htt.Add(ip);
            }
            listBox1.Items.AddRange(htt.ToArray());
        }

        private void blockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ips = "";
            if (listBox1.Items.Count < 250)
            {
                foreach (string ip in listBox1.Items)
                {
                    if (!listBox2.Items.Contains(ip + "/32"))
                        ips += ip + ",";
                }
                if (!string.IsNullOrEmpty(ips))
                    FunctExecute(ips, Execut.Add);
                //textBox1.Text = ips;
            }
            else
            {
                int iCount = 0;
                int iState = 0;

                foreach (string ip in listBox1.Items)
                {
                    if (!listBox2.Items.Contains(ip + "/32"))
                        ips += ip + ",";

                    if (iCount >= 250)
                    {
                        FunctExecute(ips, Execut.Add);
                        ips = string.Empty;
                        iCount = 0;
                    }

                    if (iState == listBox1.Items.Count)
                    {
                        FunctExecute(ips, Execut.Add);
                        ips = string.Empty;
                    }
                    iCount++;
                    iState++;


                }
                AddToLogs("Banned: " + ips, DateTime.Now.ToString(), "");
                FunctExecute(ips, Execut.Add);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            List<string> lst = new List<string>();

            lst.Add(listView1.SelectedItems[0].Text);
            lst.Add(listView1.SelectedItems[0].SubItems[1].Text);
            lst.Add(listView1.SelectedItems[0].ImageIndex.ToString());

            using (fShowInfoLog sil = new fShowInfoLog())
            {
                fShowInfoLog.lst = lst;
                sil.ReloadLogData();
                sil.ShowDialog();
            }
        }

        private void bBanListOk_Click(object sender, EventArgs e)
        {

        }

        private void tstAdd_Click(object sender, EventArgs e)
        {
            fItems fi = new fItems();
            if (fi.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.AddRange(fi.IPs.ToArray());
            }
        }

        private void tsfdApply_Click(object sender, EventArgs e)
        {
            FunctExecute("", Execut.Delete);

            string ips = "";
            if (listBox2.Items.Count < 250)
            {
                foreach (string ip in listBox2.Items)
                    ips += ip + ",";

                if (!string.IsNullOrEmpty(ips))
                    FunctExecute(ips, Execut.Add);
            }
            else
            {
                int iCount = 0;
                int iState = 0;

                foreach (string ip in listBox2.Items)
                {
                    ips += ip + ",";

                    if (iCount >= 250)
                    {
                        FunctExecute(ips, Execut.Add);
                        ips = string.Empty;
                        iCount = 0;
                    }

                    if (iState == listBox1.Items.Count)
                    {
                        FunctExecute(ips, Execut.Add);
                        ips = string.Empty;
                    }
                    iCount++;
                    iState++;


                }
                AddToLogs("Banned: " + ips, DateTime.Now.ToString(), "");
                FunctExecute(ips, Execut.Add);
            }
        }
    }
}
