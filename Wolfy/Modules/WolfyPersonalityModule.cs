using DSharpPlus;
using DSharpPlus.Entities;
using DSharpPlus.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wolfy.Modules
{
    // 10/10 name tho
    public class WolfyPersonalityModule : BaseExtension
    {
        bool weekend = false;
        Random rand = new Random();
        DateTime nextReturn = DateTime.Now.AddMinutes(60);
        protected override void Setup(DiscordClient client)
        {
            Client = client;
            client.Heartbeated += Client_Heartbeated;
            client.Ready += Client_Ready;
        }

        async Task Client_Ready(DiscordClient client, ReadyEventArgs e)
        {
            DiscordChannel channel = await Client.GetChannelAsync(214523379766525963); //214523379766525963
            if (channel != null)
            {

                await channel.SendMessageAsync("I\'m back! <:awoo:254007902510120961>");

            }
        }

        async Task Client_Heartbeated(DiscordClient client, HeartbeatEventArgs e)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday && DateTime.Now.Hour == 9)
            {
                DiscordChannel channel = await Client.GetChannelAsync(214523379766525963); //214523379766525963
                if (channel != null && !weekend)
                {
#if DEBUG
#else
                    await channel.SendMessageAsync("Yay it\'s finally the weekend! Hope everyone is having an amazing Saturday so far!\r\nhttps://imgur.com/RNj2coB");
#endif
                    weekend = true;
                }
            }
            else
            {
                weekend = false; //reset flag
            }

            //fake restart
            if(DateTime.Now > nextReturn)
            {
                DiscordChannel channel = await Client.GetChannelAsync(214523379766525963); //214523379766525963
                if (channel != null)
                {
                    //generate next time
                    nextReturn = DateTime.Now.AddMinutes(rand.Next(180, 420));
                    await channel.SendMessageAsync("I\'m back! <:awoo:254007902510120961>");
                }
            }

        }
    }
}
