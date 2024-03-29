﻿using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Wolfy.Modules;
using DSharpPlus;

namespace Wolfy.Commands
{
    [CommandModule, Group("meta"), RequirePermissions(Permissions.ViewAuditLog)]
    public class MetaCommands : BaseCommandModule
    {
        [Command("reload")]
        public async Task ReloadAsync(CommandContext ctx)
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("https://raw.githubusercontent.com/Zero747/wolfy-discord-bot/master/Wolfy/Data/commands_simple.json");
                File.WriteAllText("Data/commands_simple.json", result);
                ctx.Client.GetExtension<JsonCommandsReaderModule>().LoadAllWorkers();
            }
            await ctx.RespondAsync("Done!");
        }
    }
}
