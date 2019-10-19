using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml;

namespace CurrentNewsApp.Services
{
    public class HttpWebRequestHandler : IHttpWebRequestHandler
    {
        public string GetNews(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);

            request.Method = "GET";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;

            string content;


            using (var response = (HttpWebResponse)request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    using (var sr = new StreamReader(stream))
                    {
                        XmlDocument doc = new XmlDocument();
                        doc.LoadXml(sr.ReadToEnd());
                        content = JsonConvert.SerializeXmlNode(doc);
                    }
                }
            }

            return content;
        }
    }
}
