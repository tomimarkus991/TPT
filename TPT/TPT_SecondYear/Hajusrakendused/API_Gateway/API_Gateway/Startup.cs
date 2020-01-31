using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ProxyKit;
using Newtonsoft.Json;
using System.Net.Http;

namespace API_Gateway
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ServerPool>();
            services.AddControllers().AddNewtonsoftJson();
            services.AddProxy();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ServerPool servers)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


            app.RunProxy(
                async context =>
                {
                    if(!servers.isEmpty())
                    {
                    var host = servers.Next();

                    var response = await context
                        .ForwardTo(host)
                        .Send();

                        while(!response.IsSuccessStatusCode && host != null)
                        {
                            servers.Remove(host);
                            host = servers.Next();
                            if (host != null)
                            {
                                response = await context.ForwardTo(host).Send();
                            }
                        }
                        return response;
                    }
                    return new HttpResponseMessage(System.Net.HttpStatusCode.ServiceUnavailable);
                });
        }
    }
}
