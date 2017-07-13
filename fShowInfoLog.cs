using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secury
{
    public partial class fShowInfoLog : Form
    {
        public fShowInfoLog()
        {
            InitializeComponent();
        }

        public static List<string> lst {get; set;}

        public void ReloadLogData()
        {

            if (lst.Count > 0)
            {
                textBox1.Text = lst[0];
                textBox2.Text = lst[1];
            }
        }
    }
}
