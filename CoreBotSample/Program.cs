// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
//
// Generated with Bot Builder V4 SDK Template for Visual Studio CoreBot v4.3.0

using BotSample.Monitoring;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;

namespace CoreBotSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureLogging((logging) =>
                {
                    logging.AddDebug();
                    logging.AddConsole();
                })

                /// Utilize your extension methods from the BotMonitoring Library
                .ConfigureBotSampleLogging()
                .ConfigureBotSampleMonitoring()

                .UseStartup<Startup>();
    }
}
