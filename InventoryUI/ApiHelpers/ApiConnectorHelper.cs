using InventoryLibrary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryUI.ApiHelpers
{
    public class ApiConnectorHelper
    {
        public static Uri UriConnection(string path)
        {
            UriBuilder uriBuilder = new UriBuilder();
            uriBuilder.Scheme = "http";
            uriBuilder.Host = Properties.Settings.Default.Host;
            if (Properties.Settings.Default.Port != 0)
            {
                uriBuilder.Port = Properties.Settings.Default.Port;
            }
            //uriBuilder.Port = Properties.Settings.Default.Port;
            uriBuilder.Path = System.Configuration.ConfigurationManager.AppSettings[path];

            return uriBuilder.Uri;
        }

        public static void EditData<T>(string id, T model, string path) where T : class, new()
        {
            Uri url = ApiConnectorHelper.UriConnection(path);
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + $"/{id}");

            httpWebRequest.ContentType = "application/json";
            string token = System.Configuration.ConfigurationManager.AppSettings["Token"];
            httpWebRequest.Headers.Add("Token", token);
            httpWebRequest.Method = "POST";

            try
            {
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    var serialized = JsonConvert.SerializeObject(model);
                    streamWriter.Write(serialized);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var output = streamReader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //return output;
        }

        //public static void EditData<T>(T model, string path) where T : class, new()
        //{
        //    Uri url = ApiConnectorHelper.UriConnection(path);
        //    var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
        //    httpWebRequest.ContentType = "application/json";
        //    string token = System.Configuration.ConfigurationManager.AppSettings["Token"];
        //    httpWebRequest.Headers.Add("Token", token);
        //    httpWebRequest.Method = "POST";

        //    try
        //    {
        //        using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
        //        {
        //            var serialized = JsonConvert.SerializeObject(model);
        //            streamWriter.Write(serialized);
        //        }

        //        var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
        //        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        //        {
        //            var output = streamReader.ReadToEnd();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }

        //    //return output;
        //}

        public static int SaveData<T>(T model, string path) where T : class, new()
        {
            int output = 0;
            Uri url = ApiConnectorHelper.UriConnection(path);

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            string token = System.Configuration.ConfigurationManager.AppSettings["Token"];
            httpWebRequest.Headers.Add("Token", token);
            httpWebRequest.Method = "POST";

            try
            {
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    var serialized = JsonConvert.SerializeObject(model);
                    streamWriter.Write(serialized);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    output = int.Parse(streamReader.ReadToEnd());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return output;
        }

        public static List<T> DataLoad<T>(string what, string where, string path) where T : class, new()
        {
            List<T> items = new List<T>();
            Uri url = ApiConnectorHelper.UriConnection(path);
            //MessageBox.Show(url.ToString());

            var client = new WebClient();
            string token = System.Configuration.ConfigurationManager.AppSettings["Token"];
            client.Headers["Token"] = token;
            client.Headers.Add("Content-Type", "application/json");

            try
            {
                var content = client.DownloadString(url + "?what=" + what + "&where=" + where);

                if (content != null)
                {
                    var serializer = new DataContractJsonSerializer(typeof(List<T>));
                    using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(content)))
                    {
                        items = (List<T>)serializer.ReadObject(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return items;
        }

        public static List<T> CustomDataLoad<T>(string item, string asset, string path) where T : class, new()
        {
            List<T> items = new List<T>();
            Uri url = ApiConnectorHelper.UriConnection(path);

            var client = new WebClient();
            string token = System.Configuration.ConfigurationManager.AppSettings["Token"];
            client.Headers["Token"] = token;
            client.Headers.Add("Content-Type", "application/json");

            try
            {
                var content = client.DownloadString(url + "?item=" + item + "&asset=" + asset);

                if (content != null)
                {
                    var serializer = new DataContractJsonSerializer(typeof(List<T>));
                    using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(content)))
                    {
                        items = (List<T>)serializer.ReadObject(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return items;
        }
        public static List<T> GetSelectedJobData<T>(string jobnumber, string path) where T : class, new()
        {
            List<T> items = new List<T>();
            Uri url = ApiConnectorHelper.UriConnection(path);

            

            var client = new WebClient();
            string token = System.Configuration.ConfigurationManager.AppSettings["Token"];
            client.Headers["Token"] = token;
            client.Headers.Add("Content-Type", "application/json");

            try
            {
                var content = client.DownloadString(url + "/" + jobnumber);

                if (content != null)
                {
                    var serializer = new DataContractJsonSerializer(typeof(List<T>));
                    using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(content)))
                    {
                        items = (List<T>)serializer.ReadObject(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return items;
        }

        public static Dictionary<string, string> getConfigData()
        {
            Dictionary<string, string> data = null;
            // AZURE
            //string url = "http://demotestapi.cloudapp.net/AuthServices/AuthService.svc/sentConfig";
            string url = System.Configuration.ConfigurationManager.AppSettings["Configs"];
            // Local
            //string url = "http://192.168.0.102:8081/AuthServices/AuthService.svc/sentConfig";

            var client = new WebClient();
            client.Headers.Add("Content-Type", "application/json");

            try
            {
                var content = client.DownloadString(url);

                if (content != null)
                {
                    var serializer = new DataContractJsonSerializer(typeof(Dictionary<string, string>));
                    using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(content)))
                    {
                        data = (Dictionary<string, string>)serializer.ReadObject(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return data;
        }
    }
}
