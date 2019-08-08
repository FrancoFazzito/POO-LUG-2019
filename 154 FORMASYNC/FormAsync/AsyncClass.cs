using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FormAsync
{
    class AsyncClass
    {
        public static List<string> PreCarga()
        {
            List<string> output = new List<string>();

            output.Add("https://www.yahoo.com");
            output.Add("https://www.google.com");
            output.Add("https://www.microsoft.com");
            output.Add("https://www.cnn.com");
            output.Add("https://www.amazon.com");
            output.Add("https://www.facebook.com");
            output.Add("https://www.twitter.com");
            output.Add("https://www.codeproject.com");
            output.Add("https://www.stackoverflow.com");
            output.Add("https://en.wikipedia.org/wiki/.NET_Framework");

            return output;
        }

        #region SYNC
        public static List<WebSite> DownloadWebSync()
        {
            List<string> websites = PreCarga();
            List<WebSite> outPut = new List<WebSite>();

            foreach (string URL in websites)
            {
                WebClient client = new WebClient();
                string data = client.DownloadString(URL);
                WebSite site = new WebSite(URL,data);
                outPut.Add(site);
            }

            return outPut;
        }
        #endregion

        #region ASYNC
        public static async Task<List<WebSite>> DownloadWebAsync()
        {
            List<string> websites = PreCarga();
            List<WebSite> outPut = new List<WebSite>();

            foreach (string URL in websites)
            {
                WebClient client = new WebClient();
                string data = await client.DownloadStringTaskAsync(URL); //taskAsync variante para la funcion
                WebSite site = new WebSite(URL, data);
                outPut.Add(site);
            }

            return outPut;
        }
        #endregion

        #region PARALLEL
        public static List<WebSite> DownloadWebParallel()
        {
            List<string> websites = PreCarga();
            List<WebSite> outPut = new List<WebSite>();

            Parallel.ForEach(websites, (URL) => /*URL IN WEBSITE*/
            {
                WebClient client = new WebClient(); 
                string data = client.DownloadString(URL);
                WebSite site = new WebSite(URL, data);
                outPut.Add(site);
            });

            return outPut;
        }
        #endregion

        #region ASYNC PARALLEL 
        //2 ways 

        //with list of tasks y when all

        public static async Task<List<string>> DownloadWebParallelAsyncWhenAll()
        {
            List<string> websites = PreCarga();
            List<Task<string>> tasks = new List<Task<string>>();

            foreach (string URL in websites)
            {
                WebClient client = new WebClient();
                Task<string> TaskData = client.DownloadStringTaskAsync(URL);
                tasks.Add(TaskData);
            }
            
            string[] results = await Task.WhenAll(tasks);

            return results.ToList();
        }

        //with parallel and taskRun

        public static async Task<string[]> DownloadWebParallelAsyncParallel()
        {
            List<string> websites = PreCarga();
            List<Task<string>> tasks = new List<Task<string>>();

           await Task.Run(() =>
           {
               Parallel.ForEach<string>(websites, (URL) =>
               {
                   WebClient client = new WebClient();
                   Task<string> TaskData = client.DownloadStringTaskAsync(URL);
                   tasks.Add(TaskData);
               });
           });
            Task<string[]> array = Task.WhenAll(tasks);
            return await array;
        }
        #endregion
    }

    public class WebSite
    {
        public WebSite(string websiteUrl, string websiteData)
        {
            WebsiteUrl = websiteUrl;
            WebsiteData = websiteData;
        }

        public string WebsiteUrl { get; set; } = string.Empty;
        public string WebsiteData { get; set; } = "";
    }
}
