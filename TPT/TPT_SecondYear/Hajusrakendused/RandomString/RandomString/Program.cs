using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace RandomString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var rnd = new Random();
            int port = rnd.Next(5000, 5999);
            HttpClient client = new HttpClient();
            HttpContent content = new StringContent(port.ToString(), Encoding.UTF8, "application/json");
            client.PostAsync("http://localhost:50883/api/Register", content);
            CreateHostBuilder(args, port).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args, int port) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseUrls("http://localhost:" + port)
                    .UseStartup<Startup>();
                });
    }
}
