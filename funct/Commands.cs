using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Secury.funct
{
    public class Commands
    {
        public static Dictionary<string, string> LoadSettings(string XMLFile)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            //задаем путь к нашему рабочему файлу XML
            string fileName = "base.xml";
            //читаем данные из файла
            XDocument doc = XDocument.Load(fileName);

            //проходим по каждому элементу в найшей library
            //(этот элемент сразу доступен через свойство doc.Root)

            foreach (XElement el in doc.Root.Elements())
            {
                //выводим в цикле названия всех дочерних элементов и их значения
                foreach (XElement element in el.Elements())
                    dict.Add(element.Name.ToString(), element.Value);
            }


            return dict;
        }

        public static bool SaveSettings(Dictionary<string, string> DictSettings, string SettingsFileName = "settings.xml")
        {

            XDocument doc = new XDocument(
                new XElement("Settings",
                    new XElement("Main",
                        new XElement("CollectEventLogs", DictSettings["CollectEventLogs"]),
                        new XElement("CollectEventSource", DictSettings["CollectEventSource"]),
                        new XElement("CollectEventCategory", DictSettings["CollectEventCategory"])),
                    new XElement("GeoSettings",
                        new XElement("SiteGeo", DictSettings["SiteGeo"])
                        )));
            //сохраняем наш документ
            doc.Save(SettingsFileName);

            return true;
        }



    }
}
