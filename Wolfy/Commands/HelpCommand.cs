﻿using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wolfy.Commands.Workers;
using Wolfy.Modules;

namespace Wolfy.Commands
{
    [CommandModule]
    public class HelpCommand : BaseCommandModule
    {
        [Command("help")]
        public async Task SendHelp(CommandContext ctx)
        {
            DiscordEmbedBuilder builder = new DiscordEmbedBuilder()
            {
                Color = DiscordColor.Orange,
                Title = "Wolfy help",
                Description = "Hi, I'm Wolfy! <:awoo:254007902510120961>"
            };
            builder.WithAuthor(ctx.Client.CurrentUser.Username, null, ctx.Client.CurrentUser.AvatarUrl);
            StringBuilder triggerBuilder = new StringBuilder();
            triggerBuilder.AppendLine("There isn't any official help for my triggers. Offer me a <:wolfybone:259416003534913537>, or tell me to do a flip? Maybe regulars know a few more things I can do.");
            builder.AddField("Triggers", triggerBuilder.ToString());
            builder.AddField("Commands", "`!awoo`: Posts an awoo image.\r\n`!winnie`: Posts a winnie image.\r\n`!help`: Displays this message.");

            /*
            if(ctx.Member != null)
            {
                DiscordDmChannel chan = await ctx.Member.CreateDmChannelAsync();
                await chan.SendMessageAsync(embed: builder);
            }
            */
            await ctx.Channel.SendMessageAsync(embed: builder);

        }
    }
}
