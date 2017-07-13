using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secury
{
    public partial class fItems : Form
    {
        public fItems()
        {
            InitializeComponent();
        }

        char[] sep = { ',',';','\n','\r' };

        public string[] IPs { get; private set; }

        private void bCheckIPList_Click(object sender, EventArgs e)
        {
            string lstSuccess = string.Empty;
            string lstFailed = string.Empty;
            
            string[] strIPs = (tbIPList.Text.Replace("\r","").Split(sep));

            foreach(string str in strIPs)
            {
                if (IsAddressValid(str) & IsAddressValidMask(str))
                    lstSuccess +=str+"\r\n";
                else
                    lstFailed +=str+"\n";
            }
            MessageBox.Show("Normal IP: \r\n" + lstSuccess +"\r\n*************************\r\nFailed IP: \r\n"+lstFailed);

        }

        private bool IsAddressValid(string addrString)
        {
            IPAddress address;
            return IPAddress.TryParse(addrString, out address);
        }
        private bool IsAddressValidMask(string addrString)
        {
            string RegexUniversal = @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}";
            Match mtc = Regex.Match(addrString, RegexUniversal);
            if (!string.IsNullOrEmpty( mtc.Value))
                return true;
            else
                return false;
                
        }

        private void bAddIPToList_Click(object sender, EventArgs e)
        {
            List<string> lst = new List<string>();
            string[] strIPs = (tbIPList.Text.Split(sep));

            foreach (string str in strIPs)
            {
                if (IsAddressValid(str) & IsAddressValidMask(str))
                    lst.Add(str);
            }
            IPs = lst.ToArray();
        }

    }
}
