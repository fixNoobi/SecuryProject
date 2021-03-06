﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Secury.funct;
using System.IO;

namespace Secury
{
    public partial class fSettings : Form
    {
        public fSettings()
        {
            InitializeComponent();
            bReadConfig_Click(this, null);
        }

        private void DefaultSettings ()
        {
            
            string filePath = Environment.CurrentDirectory + @"\set.dat";
            if (!File.Exists(filePath))
                File.Create(filePath);

            IniFileHelper.WriteValue("Timer", "Enable", "false", filePath);
            IniFileHelper.WriteValue("Timer", "Format", "seconds", filePath);
            IniFileHelper.WriteValue("Timer", "Value", "3600", filePath);

            IniFileHelper.WriteValue("Main", "ErrorCount", "10", filePath);
            IniFileHelper.WriteValue("Main", "Regex", @"fa\S+|suc\S+|\<\S+.+\>|\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}|\'.+'", filePath);
            IniFileHelper.WriteValue("Main", "Success", "succeeded", filePath);
            IniFileHelper.WriteValue("Main", "Failed", "Failed", filePath);
            IniFileHelper.WriteValue("Main", "EventLogs", "Application", filePath);
            IniFileHelper.WriteValue("Main", "EventSource", "MSSQLSERVER", filePath);
            IniFileHelper.WriteValue("Main", "EventCategory", "Logon", filePath);


            IniFileHelper.WriteValue("Firewall", "Name", "Block", filePath);
            IniFileHelper.WriteValue("Firewall", "Protocol", "tcp", filePath);
            IniFileHelper.WriteValue("Firewall", "Profile", "private", filePath);
            IniFileHelper.WriteValue("Firewall", "LocalPort", "1433", filePath);
            IniFileHelper.WriteValue("Firewall", "RemotePort", "any", filePath);
            IniFileHelper.WriteValue("Firewall", "Action", "block", filePath);
            IniFileHelper.WriteValue("Firewall", "Dir", "in", filePath);
        }

        private void bSaveConfig_Click(object sender, EventArgs e)
        {
            string filePath = Environment.CurrentDirectory + @"\set.dat";
            if (!File.Exists(filePath))
                File.Create(filePath);

            IniFileHelper.WriteValue("Timer", "Enable", checkBox1.Checked.ToString(), filePath);
            IniFileHelper.WriteValue("Timer", "Format", (string)comboBox1.SelectedItem, filePath);
            IniFileHelper.WriteValue("Timer", "Value", textBox7.Text, filePath);

            IniFileHelper.WriteValue("Main", "ErrorCount", numericUpDown1.Value.ToString(), filePath);
            IniFileHelper.WriteValue("Main", "Regex", textBox1.Text, filePath);
            IniFileHelper.WriteValue("Main", "Success", textBox5.Text, filePath);
            IniFileHelper.WriteValue("Main", "Failed", textBox6.Text, filePath);
            IniFileHelper.WriteValue("Main", "EventLogs", (string)cbCollectEventLogs.SelectedItem, filePath);
            IniFileHelper.WriteValue("Main", "EventSource", (string)cbCollectEventSource.SelectedItem, filePath);
            IniFileHelper.WriteValue("Main", "EventCategory", (string)cbCollectEventCategory.SelectedItem, filePath);

            IniFileHelper.WriteValue("Firewall", "Name", textBox2.Text, filePath);
            IniFileHelper.WriteValue("Firewall", "Protocol", comboBox2.Text, filePath);
            IniFileHelper.WriteValue("Firewall", "Profile", (string)comboBox3.SelectedItem, filePath);
            IniFileHelper.WriteValue("Firewall", "LocalPort", textBox3.Text, filePath);
            IniFileHelper.WriteValue("Firewall", "RemotePort", textBox4.Text, filePath);
            IniFileHelper.WriteValue("Firewall", "Action", (string)comboBox4.SelectedItem, filePath);
            IniFileHelper.WriteValue("Firewall", "Dir", (string)comboBox5.SelectedItem, filePath);

        }

        private void bReadConfig_Click(object sender, EventArgs e)
        {
            string filePath = Environment.CurrentDirectory + @"\set.dat";
            if (File.Exists(filePath))
            {
                try
                {
                    checkBox1.Checked = Convert.ToBoolean(IniFileHelper.ReadValue("Timer", "Enable", filePath));
                    comboBox1.SelectedItem = IniFileHelper.ReadValue("Timer", "Format", filePath);
                    textBox7.Text = IniFileHelper.ReadValue("Timer", "Value", filePath);

                    numericUpDown1.Value = Convert.ToDecimal(IniFileHelper.ReadValue("Main", "ErrorCount", filePath));
                    textBox1.Text = IniFileHelper.ReadValue("Main", "Regex", filePath);
                    textBox5.Text = IniFileHelper.ReadValue("Main", "Success", filePath);
                    textBox6.Text = IniFileHelper.ReadValue("Main", "Failed", filePath);
                    cbCollectEventLogs.Text = IniFileHelper.ReadValue("Main", "EventLogs", filePath);
                    cbCollectEventSource.Text = IniFileHelper.ReadValue("Main", "EventSource", filePath); 
                    cbCollectEventCategory.Text = IniFileHelper.ReadValue("Main", "EventCategory", filePath);


                    textBox2.Text = IniFileHelper.ReadValue("Firewall", "Name", filePath);
                    comboBox2.SelectedValue = IniFileHelper.ReadValue("Firewall", "Protocol", filePath);
                    comboBox3.SelectedItem = IniFileHelper.ReadValue("Firewall", "Profile", filePath);
                    textBox3.Text = IniFileHelper.ReadValue("Firewall", "LocalPort", filePath);
                    textBox4.Text = IniFileHelper.ReadValue("Firewall", "RemotePort", filePath);
                    comboBox4.SelectedItem = IniFileHelper.ReadValue("Firewall", "Action", filePath);
                    comboBox5.SelectedItem = IniFileHelper.ReadValue("Firewall", "Dir", filePath);
                }
                catch
                {
                    MessageBox.Show("Error on reading filed configuration.\r\nLoad standart configuration.");
                    DefaultSettings();
                }
            }
            else
                DefaultSettings();
        }
    }
}
