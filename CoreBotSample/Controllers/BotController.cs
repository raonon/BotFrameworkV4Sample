// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
//
// Generated with Bot Builder V4 SDK Template for Visual Studio CoreBot v4.3.0

using System.Threading.Tasks;
using BotSample.Monitoring;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Integration.AspNet.Core;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace CoreBotSample.Controllers
{
    // This ASP Controller is created to handle a request. Dependency Injection will provide the Adapter and IBot
    // implementation at runtime. Multiple different IBot implementations running at different endpoints can be
    // achieved by specifying a more specific type for the bot constructor argument.
    [Route("api/messages")]
    [ApiController]
    public class BotController : ControllerBase
    {
        private readonly IBotFrameworkHttpAdapter Adapter;
        private readonly ILogger _logger;
        private readonly IBot Bot;

        public BotController(IBotFrameworkHttpAdapter adapter, IBot bot, ILogger<BotController> logger)
        {
            Adapter = adapter;
            Bot = bot;
            _logger = logger;
        }

        [HttpPost]
        public async Task PostAsync()
        {
            // Delegate the processing of the HTTP POST to the adapter.
            // The adapter will invoke the bot.
            _logger.LogInformation("I got into the controller ------");
            _logger.LogTrace("Testing trace logging");
            await Adapter.ProcessAsync(Request, Response, Bot);
        }
    }
}
