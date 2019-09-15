using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace P2ringud
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetPage("https://www.postimees.ee");

            //using (var client = new WebClient())
            //{
            //    var contents = client.DownloadString("https://www.postimees.ee");
            //    Console.WriteLine(contents);
            //}
            string urlAddress = "http://google.com";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;

                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }

                string data = readStream.ReadToEnd();

                response.Close();
                readStream.Close();
            }
            Console.ReadKey();
            
        }
        //async static void GetPage(string url)
        //{
        //    HttpClient client = new HttpClient();
        //    string response = await client.GetStringAsync(url);
        //    Console.WriteLine(response);
        //}
    }
}
