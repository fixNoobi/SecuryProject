using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Secury.funct;
using System.Threading;

namespace Secury
{
    public partial class fStatistic : Form
    {
        public static ListView lvDataSources { get; set; }

        private DataTable dt = new DataTable();

        private string sRegex, sSucces, sFailed;

        public fStatistic()
        {
            Analyze.ParsingIPDate += Analyze_ParsingIPDate;
            InitializeComponent();
        }

        private void LoadSettings()
        {
            string filePath = Environment.CurrentDirectory + @"\set.dat";
            if (File.Exists(filePath))
            {
                sRegex = IniFileHelper.ReadValue("Main", "Regex", filePath);
                sSucces = IniFileHelper.ReadValue("Main", "Success", filePath);
                sFailed = IniFileHelper.ReadValue("Main", "Failed", filePath);
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

        private void Analyze_ParsingIPDate(DataTable obj)
        {
            Action act = () => dataGridView1.DataSource = obj;
            this.InvokeEx(act);
        }

        private void FromListView(DataTable table, ListView lvw)
        {
            table.Clear();
            var columns = lvw.Columns.Count;

            foreach (ColumnHeader column in lvw.Columns)
                table.Columns.Add(column.Text);

            foreach (ListViewItem item in lvw.Items)
            {
                var cells = new object[columns];
                for (var i = 0; i < columns; i++)
                    cells[i] = item.SubItems[i].Text;
                table.Rows.Add(cells);
            }
            table = dt;
        }
        //Получение основной информации
        private void btGeneralInformation_Click(object sender, EventArgs e)
        {
            if (lvDataSources != null)
            {
                try
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = AddToDGVSuccessFailedByIP(lvDataSources);
                    //BanIP();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        //КомбоБокс где все IP
        private void cbAboutIP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAboutIP.SelectedItem.ToString() == "---Reload---")
            {
                cbAboutIP.Items.Clear();
                cbAboutIP.Items.AddRange(GetIPList(lvDataSources).ToArray());
                cbAboutIP.Items.Add("---Reload---");
            }
            else
            {
                var ipInfo = GetIPInfo.GetCountryByIP((string)cbAboutIP.SelectedItem);
                tsbCountry.Text = "Country: " + ipInfo.Country;
                tsbCountry.Image = imgFlags.Images[ipInfo.Country.Replace(' ', '-') + ".png"];

                dataGridView1.DataSource = AddToDGVNames(lvDataSources, (string)cbAboutIP.SelectedItem);
            }
        }

        //Получем Дату Время Пользователя, не понимаю, зачем я ее написал
        private DataTable AddToDGVNames(ListView lv, string IP)
        {
            Dictionary<string, HashSet<string[]>> IPDic = GetInfoNamesByIP(lv, IP);

            DataTable dt = new DataTable();
            dt.Columns.Add("Users", typeof(string));
            dt.Columns.Add("Date", typeof(string));
            dt.Columns.Add("Time", typeof(string));
            dt.Columns.Add("Connection", typeof(string));

            foreach (var tmp in IPDic)
                foreach (var tmpValue in tmp.Value)
                    dt.Rows.Add(new object[]
                    {
                        tmp.Key,
                        tmpValue[0],
                        tmpValue[1],
                        tmpValue[2]
                    });



            return dt;
        }

        /// <summary>
        /// Записываем в DT количество успешных и не очень попыток, используем в общих сведениях.
        /// </summary>
        /// <param name="lv"></param>
        /// <returns></returns>
        private DataTable AddToDGVSuccessFailedByIP(ListView lv)
        {
            int iCount = 0;
            //

                Dictionary<string, int[]> IPDic = GetSuccessFailedCount(lv);
                List<string> lst = new List<string>();

                DataTable dt = new DataTable();
                dt.Columns.Add("IP", typeof(string));
                dt.Columns.Add("Success Сount", typeof(string));
                dt.Columns.Add("Failed Сount", typeof(string));
                dt.Columns.Add("Flags", typeof(Bitmap));
                dt.Columns.Add("Country", typeof(string));

            //Перебираем словарь и берем значения
            foreach (var tmp in IPDic)
            {
                if (iCount < 100)
                {
                    //var ipResponse = GetIPInfo.GetCountryByIP(tmp.Key);
                    if (tmp.Value[1] > 10)
                    {
                        lst.Add(tmp.Key);
                    }
                    //Добавление в DT
                    dt.Rows.Add(new object[]
                    {
                        tmp.Key,
                        tmp.Value[0],
                        tmp.Value[1],
                        //imgFlags.Images[ipResponse.Country.Replace(' ','-')+".png"],
                        //ipResponse.Country
                    });
                }
                //else if (iCount>100)
                //{
                //    Thread.Sleep(1000);
                //    if (iCount == 500)
                //        iCount = 0;
                //}
                //iCount++;
            }

            fBan.IP = lst;
            return dt;
        }

        public List<string> GetIPToBlock(ListView lv)
        {
            int ErrorCount = Convert.ToInt32(CheckConfigValue("Main", "ErrorCount"));

            Dictionary<string, int[]> IPDic = GetSuccessFailedCount(lv);
            List<string> lst = new List<string>();

            foreach (var tmp in IPDic)
                    if (tmp.Value[1] >= ErrorCount)
                        lst.Add(tmp.Key);
            return lst;
        }

        private object CheckConfigValue (string selection, string key )
        {
            string filePath = Environment.CurrentDirectory + @"\set.dat";
            object result;
            if (File.Exists(filePath))
            {
                try
                {
                    result = IniFileHelper.ReadValue(selection, key, filePath);
                    if (result != null)
                        return result;
                }
                catch
                {
                    return null;
                }
                return null;
            }
            else
            { 
                using (fSettings fs = new fSettings())
                {
                    this.Hide();
                    if (DialogResult.Cancel == fs.ShowDialog())
                        fs.Dispose();
                    this.Show();

                    result = IniFileHelper.ReadValue(selection, key, filePath);
                    if (result != null)
                        return result;
                }
                return null;
            }
            
        }

        #region Main Function

        private bool BanIP()
        {
            foreach(DataGridViewRow dr in dataGridView1.Rows)
            {
                if (Convert.ToInt32(dr.Cells[2].Value) > 10)
                    MessageBox.Show(dr.Cells[2].Value.ToString());
            }
            return true;
        }

        //Подсчет успешных и провальных соединений
        private Dictionary<string, int[]> GetSuccessFailedCount(ListView lv)
        {
            sSucces = CheckConfigValue("Main", "Success").ToString();
            sFailed = CheckConfigValue("Main", "Failed").ToString();

            Dictionary<string, int[]> repeats = new Dictionary<string, int[]>();

            //Получение списка IP
            HashSet<string> shs = GetIPList(lv);

            //Сразу доалвяем все слова(IP) с нулевыми ключами(Success|Failed)
            foreach (var sIP in shs)
                repeats.Add(sIP, new int[] { 0, 0 });

            foreach (ListViewItem _sState in lv.Items)
                //Поверка сразу, получилось зайти или нет
                if (_sState.SubItems[1].Text == sSucces)
                    //Если есть в словаре добавляем 1
                    repeats[_sState.SubItems[3].Text][0] += 1;
                else if (_sState.SubItems[1].Text == sFailed)
                    repeats[_sState.SubItems[3].Text][1] += 1;


            return repeats;
        }

        //Получение списка IP без повторений
        private HashSet<string> GetIPList(ListView lv, bool OnlBan = false)
        {
            sFailed = CheckConfigValue("Main", "Failed").ToString();

            HashSet<string> shsUni = new HashSet<string>();

            if (lv != null & lv.Items.Count > 0)
            {
                if (!OnlBan)
                {
                    foreach (ListViewItem lvi in lv.Items)
                        shsUni.Add(lvi.SubItems[3].Text);
                }
                else
                {
                    foreach (ListViewItem lvi in lv.Items)
                    {
                        if (lvi.SubItems[0].Text == sFailed)
                            shsUni.Add(lvi.SubItems[3].Text);
                        fBan.IP = shsUni.ToList();
                    }
                }
            }
            

            return shsUni;
        }
        //Получаем информацию об логинах по выбранному IP
        private Dictionary<string, HashSet<string[]>> GetInfoNamesByIP(ListView lv, string sIP)
        {
            Dictionary<string, HashSet<string[]>> dicInfoNamesByIP = new Dictionary<string, HashSet<string[]>>();

            foreach (ListViewItem lvi in lv.Items)
            {
                //Если выбранный ip = из столбца Listview
                if (sIP == lvi.SubItems[3].Text)
                {
                    string sDate = "";
                    string sTime = "";
                    //Проверяем, чтобы колонка даты была не пустая
                    if (!string.IsNullOrEmpty(lvi.Text))
                    {
                        //Разбивка даты и времени
                        string[] _DateTimes = lvi.SubItems[0].Text.Split(' ');

                        sDate = _DateTimes[0];
                        sTime = _DateTimes[1];
                    }
                    else
                    {
                        sDate = "---";
                        sTime = "---";
                    }

                    string sUsername = lvi.SubItems[2].Text;
                    string sConnection = lvi.SubItems[1].Text;

                    if (!dicInfoNamesByIP.ContainsKey(sUsername))
                        dicInfoNamesByIP.Add(sUsername, new HashSet<string[]> { new string[] { sDate, sTime, sConnection } });
                    else
                        dicInfoNamesByIP[sUsername].Add(new string[] { sDate, sTime, sConnection });
                }
            }

            return dicInfoNamesByIP;
        }


        #endregion

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(new ThreadStart(() =>
            {
                Analyze.SuccessFailedByIP(lvDataSources);
            }));
            th.Start();
        }
    }
}
