using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus.Entities;
using DSharpPlus.EventArgs;
using Wolfy.Modules;

namespace Wolfy.Commands.Workers
{
    public class CommandWorker_ResetAllCooldowns : CommandWorker_Simple
    {
        public override async Task<bool> Process(MessageCreateEventArgs e)
        {
            bool result = await base.Process(e);
            if (result)
            {
                Client.GetExtension<CooldownManagerModule>().Clear();

                var msg = new DiscordMessageBuilder().WithFile("Data/kitty.png", new FileStream("Data/kitty.png", FileMode.Open, FileAccess.Read));

                await e.Message.RespondAsync(msg);
            }
            return result;
        }
    }
}
