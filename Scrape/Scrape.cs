using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ScrapeLibrary
{
    public class Scrape
    {
        public string ScrapeWebepage(string url)
        {
            return GetWebPage(url);
        }

        public string ScrapeWebepage(string url, string filePath)
        {
            string reply = GetWebPage(url);

            File.WriteAllText(filePath, reply);
            return reply;
        }

        private string GetWebPage(string url)
        {
            WebClient client = new WebClient();
            string content = client.DownloadString(url);

            content += "Thats it folks";
            return content;
        }
    }
}
