using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secury
{
    public partial class fUnban : Form
    {
        public fUnban()
        {
            InitializeComponent();
            bUpdateIP_Click(this, null);
        }

        private void bUpdateIP_Click(object sender, EventArgs e)
        {
            WebClient Client = new WebClient();
            Client.Proxy = new WebProxy();
            string Tmp = Client.DownloadString("http://ip-address.ru/show");
            textBox1.Text = Tmp;
            Client.Dispose();
        }

        private void llSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process ps = new Process();
            ps.StartInfo.FileName = "http://ip-api.com/docs/unban";
            ps.Start();
        }
    }
}
