using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace BADCIrrigationEquipmentSurvey
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();

            //CreateWebHostBuilder(args).Build().Run();
        }

        private static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                //.UseConfiguration(
                //    new ConfigurationBuilder()
                //        .SetBasePath(Directory.GetCurrentDirectory())
                //        .AddJsonFile("appsettings.json")
                //        .AddCommandLine(args)
                //        .Build())
                //.UseContentRoot(Directory.GetCurrentDirectory())
                .UseKestrel()
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }

}
