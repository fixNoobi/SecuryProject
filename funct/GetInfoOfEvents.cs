using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secury.funct
{
    class GetInfoOfEvents
    {
        public static EventLog eLog { get; set; }

        public static int CountEntry { get; private set; }
        public static string _EventLogName { get; set; }
        public static string _EventSource { get; set; }
        public static string _EventCategory { get; set; }


        private static void CheckEventLogName()
        {
            if (eLog != null)
            {
                if (string.IsNullOrEmpty(eLog.Log))
                    eLog.Log = _EventLogName;
            }
            else
            {
                eLog = new EventLog();
                eLog.Log = _EventLogName;
            }
        }

        public static HashSet<string> GetEventLogSource(string _eLog)
        {
            //EventLog eLog = new EventLog();
            //eLog.Log = _EventLogName;
            CheckEventLogName();
            HashSet<string> shs = new HashSet<string>();

            try
            {
                foreach (EventLogEntry d in eLog.Entries)
                    shs.Add(d.Source);

                return shs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return null;
            }
        }
        public static int CountEventLogSource()
        {
            CountEntry = eLog.Entries.Count;
            return eLog.Entries.Count;
        }
        public static void GetEventLogSource()
        {
            //EventLog eLog = new EventLog();
            //eLog.Log = _EventLogName;
            int count = 0;
            HashSet<string> shs = new HashSet<string>();
            try
            {
                foreach (EventLogEntry d in eLog.Entries)
                {
                    ProgressBarChange(count);
                    shs.Add(d.Source);
                    count++;
                }
                EventLogSource(shs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        public static HashSet<string> GetEventLogCategory(string _eLog, string _eLogSource)
        {
            //EventLog eLog = new EventLog();
            //eLog.Log = _eLog;
            HashSet<string> shs = new HashSet<string>();
            try
            {
                foreach (EventLogEntry d in eLog.Entries)
                {
                    if (d.Source == _eLogSource)
                        shs.Add(d.Category);

                }
                return shs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return null;
            }
        }
        public static void GetEventLogCategory()
        {

            //EventLog eLog = new EventLog();
            //eLog.Log = _EventLogName;
            int count = 0;
            HashSet<string> shs = new HashSet<string>();
            try
            {
                foreach (EventLogEntry d in eLog.Entries)
                {
                    ProgressBarChange(count);
                    if (d.Source == _EventSource)
                        shs.Add(d.Category);
                    count++;
                }
                EventLogCategory(shs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }


        public static event Action<int> ProgressBarChange;
        //public static event Action<int> ProgressBarSet;

        public static event Action<HashSet<string>> EventLogCategory;
        public static event Action<HashSet<string>> EventLogSource;
    }
}
