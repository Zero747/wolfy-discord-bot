using DSharpPlus;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wolfy.Modules
{
    public class ReleaseBuildProfilerModule : BaseExtension
    {
#if DEBUG
        protected override void Setup(DiscordClient client)
        {
        }
#else
        protected override void Setup(DiscordClient client)
        {
            Client = client;
            client.Heartbeated += Client_Heartbeated;
            client.Ready += Client_Ready;
        }

        private Task Client_Ready(DiscordClient client, DSharpPlus.EventArgs.ReadyEventArgs e)
        {
            client.Logger.Log(LogLevel.Information, $"Wolfy Ready!", DateTime.Now);
            return Task.CompletedTask;
        }

        private Task Client_Heartbeated(DiscordClient client, DSharpPlus.EventArgs.HeartbeatEventArgs e)
        {
            client.Logger.Log(LogLevel.Debug, $"Wolfy Heartbeat - Ping " + e.Ping, DateTime.Now);
            return Task.CompletedTask;
        }
#endif
    }
}
