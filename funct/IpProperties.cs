using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Secury.funct
{
   public class GetIPInfo
    {
        #region IP Country
        public class IpProperties
        {
            public string Status { get; set; }
            public string Country { get; set; }
            public string CountryCode { get; set; }
            public string Region { get; set; }
            public string RegionName { get; set; }
            public string City { get; set; }
            public string Zip { get; set; }
            public string Lat { get; set; }
            public string Lon { get; set; }
            public string TimeZone { get; set; }
            public string ISP { get; set; }
            public string ORG { get; set; }
            public string AS { get; set; }
            public string Query { get; set; }
        }
        private static string IPRequestHelper(string url)
        {
            HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();

            StreamReader responseStream = new StreamReader(objResponse.GetResponseStream());
            string responseRead = responseStream.ReadToEnd();

            responseStream.Close();
            responseStream.Dispose();

            return responseRead;
        }

        public static IpProperties GetCountryByIP(string ipAddress)
        {
            string ipResponse = IPRequestHelper("http://ip-api.com/xml/" + ipAddress);
            if (!string.IsNullOrEmpty(ipResponse))
            {
                using (TextReader sr = new StringReader(ipResponse))
                {
                    using (System.Data.DataSet dataBase = new System.Data.DataSet())
                    {
                        dataBase.ReadXml(sr);
                        IpProperties ipProperties = new IpProperties();
                        ipProperties.Status = dataBase.Tables[0].Rows[0][0].ToString();
                        if (ipProperties.Status == "success")
                        {
                            ipProperties.Country = dataBase.Tables[0].Rows[0][1].ToString();
                            ipProperties.CountryCode = dataBase.Tables[0].Rows[0][2].ToString();
                            ipProperties.Region = dataBase.Tables[0].Rows[0][3].ToString();
                            ipProperties.RegionName = dataBase.Tables[0].Rows[0][4].ToString();
                            ipProperties.City = dataBase.Tables[0].Rows[0][5].ToString();
                            ipProperties.Zip = dataBase.Tables[0].Rows[0][6].ToString();
                            ipProperties.Lat = dataBase.Tables[0].Rows[0][7].ToString();
                            ipProperties.Lon = dataBase.Tables[0].Rows[0][8].ToString();
                            ipProperties.TimeZone = dataBase.Tables[0].Rows[0][9].ToString();
                            ipProperties.ISP = dataBase.Tables[0].Rows[0][10].ToString();
                            ipProperties.ORG = dataBase.Tables[0].Rows[0][11].ToString();
                            ipProperties.AS = dataBase.Tables[0].Rows[0][12].ToString();
                            ipProperties.Query = dataBase.Tables[0].Rows[0][13].ToString();
                        }
                        else if (ipProperties.Status == "fail")
                        {
                            ipProperties.Country = dataBase.Tables[0].Rows[0][1].ToString();
                            ipProperties.Query = dataBase.Tables[0].Rows[0][2].ToString();
                        }


                        return ipProperties;
                    }
                }

            }
            else
            {
                IpProperties ipPropError = new IpProperties();
                ipPropError.Country = "";
                return ipPropError;
            }
        }

        public static bool Banned()
        {

            string host = "http://ip-api.com";
            TcpClient tc = new TcpClient();

            Ping pg = new Ping();
            PingReply pgr = pg.Send(host);
            if (pgr.Status == IPStatus.Success)
                return false;
            else
                return true;
        }
        #endregion
    }
}
