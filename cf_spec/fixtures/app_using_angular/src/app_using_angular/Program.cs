﻿using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;

namespace app_using_angular
{
    public class Program
    {

        // Entry point for the application.
        public static void Main(string[] args) {
           var config = new ConfigurationBuilder()
                          .AddCommandLine(args)
                          .Build();

            var content_root = Path.Combine(Directory.GetCurrentDirectory(), "src", "app_using_angular");

            var host = new WebHostBuilder()
                        .UseKestrel()
                        .UseConfiguration(config)
                        .UseContentRoot(content_root)
                        .UseIISIntegration()
                        .UseStartup<Startup>()
                        .Build();

            host.Run();
        }
    }
}
