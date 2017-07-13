using Microsoft.Win32;
using Secury.funct;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secury
{
    public partial class Form1 : Form
    {
        Analyze _analyze;
        private bool ThreadBusy = false;

        EventLog[] _eLogs = EventLog.GetEventLogs();

        Stopwatch sw = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
            _analyze = new Analyze();

            Analyze.ProgressBarChange += Analyze_ProgressBarChange;
            Analyze.EventGetData += Analyze_EventGetData;

            Analyze.WorkerCompleted += Analyze_WokerCompleted;
            Analyze.WorkerStatus += Analyze_WorkerStatus;
            Analyze.EventLogCategory += Analyze_EventLogCategory;
        }

        private void Analyze_EventLogCategory(HashSet<string> obj)
        {
            try
            {
                obj.Add("---Reload---");
                Action action = () => cbCollectEventCategory.Items.AddRange(obj.ToArray());    
                this.InvokeEx(action);

            }
            catch (Exception ex) { AddStateToStatus("Error", ex.Message); }
        }

        //Отрисоква progressBar 
        private void Analyze_ProgressBarChange(int obj)
        {
            try
            {
                Action action = () =>
                {
                    tspbStatus.Value = obj;
                    toolStripProgressBar1.Value = obj;
                    };
                this.InvokeEx(action);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Analyze_WorkerStatus(string obj)
        {
            try
            {
                tslStatus.Text = obj;
            }
            catch (Exception ex)
            {
                AddStateToStatus("Error", ex.Message);
            }

        }

        private void Analyze_WokerCompleted(bool obj)
        {
            try
            {
                string message = obj ? "Cancelled" : "All done!";
                sw.Stop();
                GetTimeWorking(sw.ElapsedMilliseconds/1000.00, "Of "+ tspbStatus.Maximum.ToString() +" elements.");

            }
            catch (Exception ex)
            {
                AddStateToStatus("Error", ex.Message);
            }
        }

        private void Analyze_EventGetData(ArrayList al)
        {
            try
            {
                Action action = () => listView1.Items.AddRange((ListViewItem[])(al.ToArray(typeof(ListViewItem))));
                this.InvokeEx(action);

            }
            catch (Exception ex) { AddStateToStatus("Error", ex.Message); }
        }

        private void bSearch_Click(object sender, EventArgs e)
        {

            if (ThreadBusy)
                return;
            if (!ThreadBusy)
            {
                sw.Reset();
                sw.Start();

                Analyze._EventLogName = (string)cbCollectEventLogs.SelectedItem;
                Analyze._EventSource = (string)cbCollectEventSource.SelectedItem;
                Analyze._EventCategory = (string)cbCollectEventCategory.SelectedItem;

                if (chkbDate.Checked)
                {
                    Analyze.SelectedDate = dateTimePicker1.Value;
                    Analyze.SelectedStatusDate = true;
                }
                else
                {
                    Analyze.SelectedStatusDate = false;
                }

                _analyze = new Analyze();

                Thread th = new Thread(new ThreadStart(() =>
                                            {
                                                Locks(true);
                                                ThreadBusy = true;
                                                _analyze.Work();
                                                ThreadBusy = false;
                                                Locks(false);
                                            }));
                    th.Start();
            }
        }
        private void bStop_Click(object sender, EventArgs e)
        {
            _analyze.Cancel();
        }

        #region Funct
        private void AddStateToStatus(string Status, string MessageText )
        {
            Action act = () => tslStatus.Text = "Status: " + Status + " = " + MessageText;
            this.InvokeEx(act);
        }
        private void AddStateToStatus(string MessageText)
        {
            Action act = () => tslStatus.Text = "Status: " + MessageText;
            this.InvokeEx(act);
        }
        private void GetTimeWorking(double TimeWorking, string MessageText)
        {
            Action act = () => tslStatus.Text = "Status: " + MessageText+ " Time working: " + TimeWorking.ToString() + " seconds.";
            this.InvokeEx(act);
        }
        private void ResetProgressBar()
        {
            if (!string.IsNullOrEmpty((string)cbCollectEventLogs.SelectedItem))
                try
                {
                    tspbStatus.Maximum = 100;
                    tspbStatus.Value = 0;
                }
                catch (Exception ex)
                {
                    AddStateToStatus("Error", ex.Message);
                }
        }

        //Блокирование или разблокирование элементов UI
        private void LockForm(bool stateLock)
        {
            if (stateLock)
            {
                bSearch.Enabled = false;
                tsbAStart.Enabled = false;
                tsbAAnalyze.Enabled = false;
                cbCollectEventCategory.Enabled = false;
                cbCollectEventLogs.Enabled = false;
                cbCollectEventSource.Enabled = false;
            }
            else
            {
                bSearch.Enabled = true;
                tsbAStart.Enabled = true;
                tsbAAnalyze.Enabled = true;
                cbCollectEventCategory.Enabled = true;
                cbCollectEventLogs.Enabled = true;
                cbCollectEventSource.Enabled = true;

            }
        }

        //Передача состояния, сблокирован или нет c InvokeEx
        private void Locks(bool State)
        {
            if (State)
            {
                ThreadBusy = true;
                Action action = () => LockForm(true);
                this.InvokeEx(action);
            }
            else
            {
                ThreadBusy = false;
                Action actionFalseLock = () => LockForm(false);
                this.InvokeEx(actionFalseLock);
            }
        }

        #endregion

        //Загружаем Logs при загрузке формы
        private void Form1_Load_1(object sender, EventArgs e)
        {
            //ArrayList al = new ArrayList();
            //for (int i = 0; i < 25000; i++)
            //{
            //    Random random = new Random();
            //    //string ip  = string.Format("{0}.{1}.{2}.{3}", _random.Next(0, 255), _random.Next(0, 255), _random.Next(0, 255), _random.Next(0, 255));
            //    string ip = $"{random.Next(1, 255)}.{random.Next(0, 255)}.{random.Next(0, 255)}.{random.Next(0, 255)}";
            //    ListViewItem lv1i = new ListViewItem(DateTime.Now.ToString());
            //    lv1i.SubItems.Add("failed");
            //    lv1i.SubItems.Add("'saf'");
            //    lv1i.SubItems.Add(ip);
            //    al.Add(lv1i);
            //}

            //listView1.Items.AddRange((ListViewItem[])(al.ToArray(typeof(ListViewItem))));
            //al.Clear();
            //listView1.Update();

            dateTimePicker1.Value = DateTime.Now;
        
            foreach (EventLog _eLog in _eLogs)
            {
                try
                {
                    cbCollectEventLogs.Items.Add(_eLog.Log);
                }
                catch (Exception ex)
                {
                    AddStateToStatus("Error",ex.Message);
                }
            }

        }

        private void cbCollectEventLogs_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           cbCollectEventSource.Items.Clear();
           cbCollectEventSource.Items.AddRange(FindSourceNamesFromLog(cbCollectEventLogs.SelectedItem.ToString()).ToArray());
        }

        private List<string> FindSourceNamesFromLog(string logName)
        {
            try
            {
                List<string> sourceNamesList = new List<string>();

                // Get the registry key for the specific log.
                RegistryKey keyLog = Registry.LocalMachine.OpenSubKey
                    (@"SYSTEM\CurrentControlSet\Services\Eventlog\" + logName);
                if (keyLog != null && keyLog.SubKeyCount > 0)
                {
                    // Get the sources from the log key.
                    string[] sourceNames = keyLog.GetSubKeyNames();

                    // Set capacity for the list.
                    sourceNamesList.Capacity = keyLog.SubKeyCount;

                    // Add all of the sources into the list.
                    sourceNamesList.AddRange(sourceNames);
                }
                sourceNamesList.Add("---Reload---");
                // Return the list.
                return sourceNamesList;
            }
            catch (System.Security.SecurityException ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return new List<string>{ "---Reload--"};
            }
        }

        //Категория, обновление 
        private void cbCollectEventCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((string)cbCollectEventLogs.SelectedItem))
            { AddStateToStatus("Select EventLogs"); return; }

            else if (string.IsNullOrEmpty((string)cbCollectEventSource.SelectedItem))
            { AddStateToStatus("Select EventSource"); return; }

            else if (
                (string)cbCollectEventCategory.SelectedItem == "---Reload---" &
                !string.IsNullOrEmpty((string)cbCollectEventLogs.SelectedItem) &
                !string.IsNullOrEmpty((string)cbCollectEventSource.SelectedItem))
            {

                try
                {
                    cbCollectEventCategory.Items.Clear();

                    Analyze._EventLogName = cbCollectEventLogs.SelectedItem.ToString();
                    Analyze._EventSource = cbCollectEventSource.SelectedItem.ToString();

                    ResetProgressBar();

                    if (ThreadBusy)
                        return;
                    if (!ThreadBusy)
                    {
                        #region Thread Old
                        //Thread th = new Thread(new ThreadStart(() =>
                        //                        {
                        //                            Locks(true);
                        //                            Analyze.GetEventLogCategory();
                        //                            Locks(false);
                        //                        }));
                        //th.Start();
                        #endregion

                        ThreadPool.QueueUserWorkItem(new WaitCallback((s) =>
                        {
                            AddStateToStatus("Start search category list");
                            sw.Reset();
                            sw.Start();

                            Locks(true);
                            Analyze.GetEventLogCategory();
                            Locks(false);

                            sw.Stop();
                            GetTimeWorking(sw.ElapsedMilliseconds / 1000.00, "Search category all done.");
                        }));
                    }

                }
                catch (Exception ex)
                {
                    AddStateToStatus("Error", ex.Message);
                }
            }
            
        }

        private void tsbExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "CSV files (*.CSV)|*.csv";
            dlg.FilterIndex = 1;
            dlg.RestoreDirectory = true;


            if (dlg.ShowDialog() == DialogResult.OK)
                if (ExportListViewToCSV(dlg.FileName, listView1))
                    Process.Start(dlg.FileName);
        }
        private bool ExportListViewToCSV(string filename, ListView lv)
        {
            
            try
            {
                // Open output file
                StreamWriter os = new StreamWriter(filename);
                                                                                                                      
                // Write Headers
                for (int i = 0; i <= lv.Columns.Count - 1; i++)
                {
                    // replace quotes with double quotes if necessary
                    os.Write("\"" + lv.Columns[i].Text.Replace("\"", "\"\"") + "\";");
                }
                os.WriteLine();

                // Write records
                for (int i = 0; i <= lv.Items.Count - 1; i++)
                {
                    for (int j = 0; j <= lv.Columns.Count - 1; j++)
                    {
                        os.Write("\"" + lv.Items[i].SubItems[j].Text.Replace("\"", "\"\"") + "\";");
                    }
                    os.WriteLine();

                }

                os.Close();

            }
            catch (Exception ex)
            {
                // catch any errors
                return false;
            }

            return true;

        }

        private void chkbShowDate_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkbShowDate.Checked)
            { listView1.Columns[0].Width = 0; Analyze.WithDate = false; }
            else
            {
                listView1.Columns[0].Width = 89; Analyze.WithDate = true;
            }
        }

        private void bAnalyze_Click(object sender, EventArgs e)
        {
            fStatistic.lvDataSources = listView1;
            //Analyze.lvPublic = listView1;
            fStatistic fs = new fStatistic();
            fs.ShowDialog();
            
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            GC.Collect();
        }

        private void bLoadDefault_Click(object sender, EventArgs e)
        {
            cbCollectEventLogs.Text = "Application";
            cbCollectEventSource.Text = "MSSQLSERVER";
            cbCollectEventCategory.Text = "Logon";
        }

        private void chkbUnbanScaner_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show( "You are banned?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                fUnban _fUnb = new fUnban();
                _fUnb.ShowDialog();
            }
        }

        private void bBlock_Click(object sender, EventArgs e)
        {
            using (fStatistic fs = new fStatistic())
                fBan.IP = fs.GetIPToBlock(listView1);

            fBan fb = new fBan();
            fb.Refresher();
            this.Hide();
            if (DialogResult.Cancel == fb.ShowDialog())
                fb.Dispose();
            this.Show();



        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsbFExportToCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.CSV)|*.csv";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportListViewToCSV(saveFileDialog.FileName, this.listView1);
            }
        }

        private void tsbsSettings_Click(object sender, EventArgs e)
        {
            fSettings fs = new fSettings();
            this.Hide();
            if (DialogResult.Cancel == fs.ShowDialog())
                fs.Dispose();
            this.Show();
        }

        private void chkbDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbDate.Checked)
                dateTimePicker1.Enabled = true;
            else
                dateTimePicker1.Enabled = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }
            else
            {
                this.ShowInTaskbar = true;
                notifyIcon1.Visible = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            if (this.WindowState == FormWindowState.Normal)
            {
                this.ShowInTaskbar = true;
                notifyIcon1.Visible = false;
            }
        }
    }
}
