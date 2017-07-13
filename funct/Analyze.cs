using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secury.funct
{
    public class Analyze
    {

        public static bool WithDate = true;

        public static bool SelectedStatusDate = false;

        public static DateTime SelectedDate { get; set; }

        #region Search Events
        public static string _EventLogName { get; set; }
        public static string _EventSource { get; set; }
        public static string _EventCategory { get; set; }

        public static ListView ListViewMy { get; set; }

        public static DataTable DTStatistic { get; set; }

        private bool _cancelled = false;

        private static string RegexUniversal = @"fa\S+|suc\S+|\<\S+.+\>|\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}|\'.+'";

        public void Cancel()
        {
            _cancelled = true;
        }

        public void Work()
        {
            #region Old
            //ArrayList al1 = new ArrayList();
            ////Переменная для progressBar
            //int i = 0;
            //HashSet<string> shsIP = new HashSet<string>();
            //HashSet<string> shsName = new HashSet<string>();
            //try
            //{
            //    EventLog eLog = new EventLog();
            //    eLog.Log = _EventLogName;

               #region Реализация через цикл For
            //    //EventLogEntryCollection elec = _EventLog.Entries;

            //    //for(int ds = 0; ds<elec.Count; ds++)
            //    //{
            //    //    //Проверка На отмену
            //    //    if (_cancelled)
            //    //        break;
            //    //    //Проверка чтобы были указаны значения
            //    //    if (elec[ds].Source == _EventSource)
            //    //        //
            //    //        if (elec[ds].Category == _EventCategory)
            //    //        {
            //    //            //Проверка На отмену
            //    //            if (_cancelled)
            //    //                break;
            //    //            //
            //    //            foreach (Match _st in Regex.Matches(elec[ds].Message, regexMain))
            //    //                shsIP.Add(_st.Value);

            //    //            foreach (Match _st in Regex.Matches(elec[ds].Message, regexName))
            //    //                shsName.Add(_st.Value);
            //    //        }
            //    //    WorkerStatus("Status: Work..");
            //    //    ProgressBarChange(i);

            //    //    ++i;
            //    //} 
                #endregion

            //    //Перебираем логи
            //    foreach (EventLogEntry entry in eLog.Entries)
            //    {
            //        //Проверка На отмену
            //        if (_cancelled)
            //            break;
            //        //Проверка чтобы были указаны значения
            //        if (entry.Source == _EventSource)
            //            //Проверяем категорию
            //            if (entry.Category == _EventCategory)
            //            {
            //                //Проверка На отмену
            //                if (_cancelled)
            //                    break;

            //                foreach (Match _st in Regex.Matches(entry.Message, regexMain))
            //                    shsIP.Add(_st.Value);

            //                foreach (Match _st in Regex.Matches(entry.Message, regexName))
            //                    shsName.Add(_st.Value);
            //            }

            //        WorkerStatus("Status: Work..");
            //        ProgressBarChange(i);
            //        i++;
            //    }
            //    if (shsIP.Count > 0 | shsName.Count > 0)
            //        al1.AddRange(GetParseData(shsIP, shsName));

            //}
            #endregion

            //Переменная для progressBar
            int i = 0;

            HashSet<string> shsUni = new HashSet<string>();
            EventLog eLog = new EventLog();
            ArrayList al = new ArrayList();

            try
            {
                eLog.Log = _EventLogName;
                int EventLogCount = GetCountEventLogSource();
                WorkerStatus("Working...");
                //Перебираем логи
                foreach (EventLogEntry entry in eLog.Entries)
                {
                    //Проверка На отмену
                    if (_cancelled)
                        break;
                    //Проверка на отмеченную дату и выбраный пунск с датой, так же дата не должна быть равно null
                    if (SelectedStatusDate & WithDate & SelectedDate.ToShortDateString()!=null)
                    {
                        //если дата записи равна выбранной, то идем дальше
                        if (entry.TimeWritten.ToShortDateString() == SelectedDate.ToShortDateString())
                        {
                            //Проверка чтобы были указаны значения
                            if (entry.Source == _EventSource)
                                ////Проверяем категорию
                                if (entry.Category == _EventCategory)
                                {
                                    //При парсинге будет 3 значения Статус, IP и имя
                                    MatchCollection mtc = Regex.Matches(entry.Message, RegexUniversal);
                                    if (mtc.Count == 3)
                                        shsUni.Add(entry.TimeWritten + ";" + mtc[0] + ";" + mtc[1] + ';' + mtc[2]);

                                }
                        }
                    }
                    //Проверка чтобы были указаны значения
                    else if (entry.Source == _EventSource)
                        ////Проверяем категорию
                        if (entry.Category == _EventCategory)
                        {
                            //При парсинге будет 3 значения Статус, IP и имя
                            MatchCollection mtc = Regex.Matches(entry.Message, RegexUniversal);
                            if (mtc.Count == 3)
                            {
                                //если нужно с датой (больше элементов будет)
                                if (!SelectedStatusDate & WithDate)
                                    shsUni.Add(entry.TimeWritten + ";" + mtc[0] + ";" + mtc[1] + ';' + mtc[2]);
                                else
                                    shsUni.Add(";" + mtc[0] + ";" + mtc[1] + ';' + mtc[2]);
                            }
                        }

                    ProgressBarChange((int)(Convert.ToDouble(i) / EventLogCount * 100));
                    i++;
                }

                if (shsUni.Count > 0)
                    al = UniParseData(shsUni);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            EventGetData(al);
            WorkerCompleted(_cancelled);
            WorkerStatus("Status: Work Done! Result " + al.Count.ToString() + " of " + i);
        }

        private static ArrayList UniParseData(HashSet<string> shsUni)
        {
            ArrayList al = new ArrayList();

            foreach(string str in shsUni)
            {
                string[] stUni = str.Split(';');
                ListViewItem lvi = new ListViewItem(stUni[0]);
                lvi.SubItems.Add(stUni[1]);
                lvi.SubItems.Add(stUni[2]);
                lvi.SubItems.Add(stUni[3]);
                al.Add(lvi);
            }
            return al;
        }

        #region old
        //private ArrayList GetParseData(HashSet<string> sIP, HashSet<string> sName)
        //{
        //    ArrayList al1 = new ArrayList();

        //    int iCountIP = 0;
        //    int iCountName = 0;
        //    try
        //    {
        //        int iCountAll = sIP.Count + sName.Count;

        //        for (int o = 0; o < iCountAll; o++)
        //        {
        //            try
        //            {
        //                iCountIP = sIP.Count;
        //                iCountName = sName.Count;

        //                if (iCountIP > 0 & iCountName > 0 & o <= iCountIP & o <= iCountName)
        //                {
        //                    al1.Add(new ListViewItem(new[] { sIP.ElementAt(o), sName.ElementAt(o) }));
        //                    sIP.Remove(sIP.ElementAt(o));
        //                    sName.Remove(sName.ElementAt(o));
        //                }
        //                else if (o >= iCountIP & o < iCountName)
        //                {
        //                    al1.Add(new ListViewItem(new[] { "", sName.ElementAt(o) }));
        //                    sName.Remove(sName.ElementAt(o));
        //                }
        //                else if (o >= iCountName & o < iCountIP)
        //                {
        //                    al1.Add(new ListViewItem(new[] { sIP.ElementAt(o), "" }));
        //                    sIP.Remove(sIP.ElementAt(o));
        //                }
        //                else
        //                    break;
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show(ex.Message);
        //            }
        //        }
        //        return al1;
        //    }
        //    catch (Exception ex)
        //    {
        //        al1.Add(new ListViewItem(new[] { ex.Message, "" }));
        //        return al1;
        //    }
        //}

        #endregion

        public static int GetCountEventLogSource()
        {
            try
            {
                EventLog eLog = new EventLog();
                eLog.Log = _EventLogName;
                return eLog.Entries.Count;
            }
            catch
            {
                return 0;
            }
        }
        public static void GetEventLogCategory()
        {
            EventLog eLog = new EventLog();
            eLog.Log = _EventLogName;
            int count = 0;
            int EventLogCount = GetCountEventLogSource();
            HashSet<string> shs = new HashSet<string>();
            try
            {
                foreach (EventLogEntry d in eLog.Entries)
                {
                    
                    if (d.Source == _EventSource)
                        shs.Add(d.Category);
                    count++;
                    ProgressBarChange((int)(Convert.ToDouble(count) / EventLogCount * 100));
                }
                EventLogCategory(shs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        #endregion

        public static void SuccessFailedByIP(ListView lvs)
        {

            Dictionary<string, int[]> IPDic = GetSuccessFailedCount(lvs);

            DataTable dt = new DataTable();
            dt.Columns.Add("IP", typeof(string));
            dt.Columns.Add("Success Сount", typeof(string));
            dt.Columns.Add("Failed Сount", typeof(string));
            dt.Columns.Add("Flags", typeof(Bitmap));
            dt.Columns.Add("Country", typeof(string));

            ResourceManager rm = new ResourceManager("ResFlags", Assembly.GetExecutingAssembly());

            //Перебираем словарь и берем значения
            foreach (var tmp in IPDic)
            {
                var ipResponse = GetIPInfo.GetCountryByIP(tmp.Key);
                
                //Добавление в DT
                dt.Rows.Add(new object[]
                {
                    tmp.Key,
                    tmp.Value[0],
                    tmp.Value[1],
                   (Bitmap)rm.GetObject(ipResponse.Country.Replace(' ', '-') + ".png"),
                 ipResponse.Country
            });
            }
            ParsingIPDate(dt);
        }
        private static Dictionary<string, int[]> GetSuccessFailedCount(ListView lv)
        {
            Dictionary<string, int[]> repeats = new Dictionary<string, int[]>();

            //Получение списка IP
            HashSet<string> shs = GetIPList(lv);

            //Сразу доалвяем все слова(IP) с нулевыми ключами(Success|Failed)
            foreach (var sIP in shs)
                repeats.Add(sIP, new int[] { 0, 0 });

            foreach (ListViewItem _sState in lv.Items)
                //Поверка сразу, получилось зайти или нет
                if (_sState.SubItems[1].Text == "succeeded")
                    //Если есть в словаре добавляем 1
                    repeats[_sState.SubItems[3].Text][0] += 1;
                else if (_sState.SubItems[1].Text == "failed")
                    repeats[_sState.SubItems[3].Text][1] += 1;


            return repeats;
        }

         static private HashSet<string> GetIPList(ListView lv)
        {
            HashSet<string> shsUni = new HashSet<string>();
            if (lv != null & lv.Items.Count > 0)
                foreach (ListViewItem lvi in lv.Items)
                    shsUni.Add(lvi.SubItems[3].Text);

            return shsUni;
        }

        public static event Action<ArrayList> EventGetData;
        public static event Action<bool> WorkerCompleted;
        public static event Action<string> WorkerStatus;
        public static event Action<int> ProgressBarChange;
        public static event Action<HashSet<string>> EventLogCategory;

        public static event Action<DataTable> ParsingIPDate;

    }
}
