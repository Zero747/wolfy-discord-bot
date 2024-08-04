using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.CommandsNext;
using DSharpPlus;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Wolfy.Commands
{
    [CommandModule]
    public class ImgurCommands : BaseCommandModule
    {
#pragma warning disable CS0649
        class ImgurImage
        {
            public string link;
        }
        class ImgurResponse
        {
            public bool success;
            public int status;
            public ImgurImage[] data;
        }
#pragma warning restore CS0649
        [Command("awoo")]
        public async Task Awoo(CommandContext ctx)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Client-ID", Program.instance.auth[1]);
                    string result = "{\"data\":[{\"id\":\"Xd7f6J5\",\"title\":null,\"description\":null,\"datetime\":1722786447,\"type\":\"image\\/png\",\"animated\":false,\"width\":720,\"height\":405,\"size\":85324,\"views\":2,\"bandwidth\":170648,\"vote\":null,\"favorite\":false,\"nsfw\":null,\"section\":null,\"account_url\":null,\"account_id\":null,\"is_ad\":false,\"in_most_viral\":false,\"has_sound\":false,\"tags\":[],\"ad_type\":0,\"ad_url\":\"\",\"edited\":\"0\",\"in_gallery\":false,\"link\":\"https:\\/\\/i.imgur.com\\/Xd7f6J5.png\"},{\"id\":\"2yWgzBA\",\"title\":null,\"description\":null,\"datetime\":1722786447,\"type\":\"image\\/png\",\"animated\":false,\"width\":640,\"height\":930,\"size\":349440,\"views\":2,\"bandwidth\":698880,\"vote\":null,\"favorite\":false,\"nsfw\":null,\"section\":null,\"account_url\":null,\"account_id\":null,\"is_ad\":false,\"in_most_viral\":false,\"has_sound\":false,\"tags\":[],\"ad_type\":0,\"ad_url\":\"\",\"edited\":\"0\",\"in_gallery\":false,\"link\":\"https:\\/\\/i.imgur.com\\/2yWgzBA.png\"},{\"id\":\"ubUsu7x\",\"title\":null,\"description\":null,\"datetime\":1722786448,\"type\":\"image\\/jpeg\",\"animated\":false,\"width\":3508,\"height\":2480,\"size\":984975,\"views\":3,\"bandwidth\":2954925,\"vote\":null,\"favorite\":false,\"nsfw\":null,\"section\":null,\"account_url\":null,\"account_id\":null,\"is_ad\":false,\"in_most_viral\":false,\"has_sound\":false,\"tags\":[],\"ad_type\":0,\"ad_url\":\"\",\"edited\":\"0\",\"in_gallery\":false,\"link\":\"https:\\/\\/i.imgur.com\\/ubUsu7x.jpg\"},{\"id\":\"1loftCw\",\"title\":null,\"description\":null,\"datetime\":1722786451,\"type\":\"image\\/jpeg\",\"animated\":false,\"width\":3896,\"height\":3856,\"size\":634797,\"views\":3,\"bandwidth\":1904391,\"vote\":null,\"favorite\":false,\"nsfw\":null,\"section\":null,\"account_url\":null,\"account_id\":null,\"is_ad\":false,\"in_most_viral\":false,\"has_sound\":false,\"tags\":[],\"ad_type\":0,\"ad_url\":\"\",\"edited\":\"0\",\"in_gallery\":false,\"link\":\"https:\\/\\/i.imgur.com\\/1loftCw.jpg\"},{\"id\":\"0DBEIgf\",\"title\":null,\"description\":null,\"datetime\":1722786448,\"type\":\"image\\/png\",\"animated\":false,\"width\":1920,\"height\":1080,\"size\":3052053,\"views\":2,\"bandwidth\":6104106,\"vote\":null,\"favorite\":false,\"nsfw\":null,\"section\":null,\"account_url\":null,\"account_id\":null,\"is_ad\":false,\"in_most_viral\":false,\"has_sound\":false,\"tags\":[],\"ad_type\":0,\"ad_url\":\"\",\"edited\":\"0\",\"in_gallery\":false,\"link\":\"https:\\/\\/i.imgur.com\\/0DBEIgf.png\"},{\"id\":\"5jOt33c\",\"title\":null,\"description\":null,\"datetime\":1722786447,\"type\":\"image\\/jpeg\",\"animated\":false,\"width\":960,\"height\":1200,\"size\":240571,\"views\":3,\"bandwidth\":721713,\"vote\":null,\"favorite\":false,\"nsfw\":null,\"section\":null,\"account_url\":null,\"account_id\":null,\"is_ad\":false,\"in_most_viral\":false,\"has_sound\":false,\"tags\":[],\"ad_type\":0,\"ad_url\":\"\",\"edited\":\"0\",\"in_gallery\":false,\"link\":\"https:\\/\\/i.imgur.com\\/5jOt33c.jpg\"},{\"id\":\"zRYeeei\",\"title\":null,\"description\":null,\"datetime\":1722786447,\"type\":\"image\\/png\",\"animated\":false,\"width\":1280,\"height\":858,\"size\":632132,\"views\":2,\"bandwidth\":1264264,\"vote\":null,\"favorite\":false,\"nsfw\":null,\"section\":null,\"account_url\":null,\"account_id\":null,\"is_ad\":false,\"in_most_viral\":false,\"has_sound\":false,\"tags\":[],\"ad_type\":0,\"ad_url\":\"\",\"edited\":\"0\",\"in_gallery\":false,\"link\":\"https:\\/\\/i.imgur.com\\/zRYeeei.png\"},{\"id\":\"mMWmB4o\",\"title\":null,\"description\":null,\"datetime\":1722786448,\"type\":\"image\\/png\",\"animated\":false,\"width\":1250,\"height\":884,\"size\":1566686,\"views\":2,\"bandwidth\":3133372,\"vote\":null,\"favorite\":false,\"nsfw\":null,\"section\":null,\"account_url\":null,\"account_id\":null,\"is_ad\":false,\"in_most_viral\":false,\"has_sound\":false,\"tags\":[],\"ad_type\":0,\"ad_url\":\"\",\"edited\":\"0\",\"in_gallery\":false,\"link\":\"https:\\/\\/i.imgur.com\\/mMWmB4o.png\"},{\"id\":\"8eC8lN6\",\"title\":null,\"description\":null,\"datetime\":1722786448,\"type\":\"image\\/jpeg\",\"animated\":false,\"width\":907,\"height\":1200,\"size\":203551,\"views\":3,\"bandwidth\":610653,\"vote\":null,\"favorite\":false,\"nsfw\":null,\"section\":null,\"account_url\":null,\"account_id\":null,\"is_ad\":false,\"in_most_viral\":false,\"has_sound\":false,\"tags\":[],\"ad_type\":0,\"ad_url\":\"\",\"edited\":\"0\",\"in_gallery\":false,\"link\":\"https:\\/\\/i.imgur.com\\/8eC8lN6.jpg\"},{\"id\":\"OtyCyHi\",\"title\":null,\"description\":null,\"datetime\":1722786448,\"type\":\"image\\/png\",\"animated\":false,\"width\":602,\"height\":900,\"size\":668360,\"views\":2,\"bandwidth\":1336720,\"vote\":null,\"favorite\":false,\"nsfw\":null,\"section\":null,\"account_url\":null,\"account_id\":null,\"is_ad\":false,\"in_most_viral\":false,\"has_sound\":false,\"tags\":[],\"ad_type\":0,\"ad_url\":\"\",\"edited\":\"0\",\"in_gallery\":false,\"link\":\"https:\\/\\/i.imgur.com\\/OtyCyHi.png\"},{\"id\":\"SSjM99y\",\"title\":null,\"description\":null,\"datetime\":1722786448,\"type\":\"image\\/png\",\"animated\":false,\"width\":1329,\"height\":2047,\"size\":1098529,\"views\":2,\"bandwidth\":2197058,\"vote\":null,\"favorite\":false,\"nsfw\":null,\"section\":null,\"account_url\":null,\"account_id\":null,\"is_ad\":false,\"in_most_viral\":false,\"has_sound\":false,\"tags\":[],\"ad_type\":0,\"ad_url\":\"\",\"edited\":\"0\",\"in_gallery\":false,\"link\":\"https:\\/\\/i.imgur.com\\/SSjM99y.png\"},{\"id\":\"rQHMJzN\",\"title\":null,\"description\":null,\"datetime\":1722786449,\"type\":\"image\\/png\",\"animated\":false,\"width\":1503,\"height\":1191,\"size\":1904534,\"views\":2,\"bandwidth\":3809068,\"vote\":null,\"favorite\":false,\"nsfw\":null,\"section\":null,\"account_url\":null,\"account_id\":null,\"is_ad\":false,\"in_most_viral\":false,\"has_sound\":false,\"tags\":[],\"ad_type\":0,\"ad_url\":\"\",\"edited\":\"0\",\"in_gallery\":false,\"link\":\"https:\\/\\/i.imgur.com\\/rQHMJzN.png\"},{\"id\":\"wbHlo1K\",\"title\":null,\"description\":null,\"datetime\":1722786448,\"type\":\"image\\/jpeg\",\"animated\":false,\"width\":1719,\"height\":2048,\"size\":766135,\"views\":3,\"bandwidth\":2298405,\"vote\":null,\"favorite\":false,\"nsfw\":null,\"section\":null,\"account_url\":null,\"account_id\":null,\"is_ad\":false,\"in_most_viral\":false,\"has_sound\":false,\"tags\":[],\"ad_type\":0,\"ad_url\":\"\",\"edited\":\"0\",\"in_gallery\":false,\"link\":\"https:\\/\\/i.imgur.com\\/wbHlo1K.jpg\"},{\"id\":\"sGL71OR\",\"title\":null,\"description\":null,\"datetime\":1722786448,\"type\":\"image\\/png\",\"animated\":false,\"width\":772,\"height\":885,\"size\":402877,\"views\":2,\"bandwidth\":805754,\"vote\":null,\"favorite\":false,\"nsfw\":null,\"section\":null,\"account_url\":null,\"account_id\":null,\"is_ad\":false,\"in_most_viral\":false,\"has_sound\":false,\"tags\":[],\"ad_type\":0,\"ad_url\":\"\",\"edited\":\"0\",\"in_gallery\":false,\"link\":\"https:\\/\\/i.imgur.com\\/sGL71OR.png\"},{\"id\":\"T6D4SNW\",\"title\":null,\"description\":null,\"datetime\":1722786448,\"type\":\"image\\/jpeg\",\"animated\":false,\"width\":1158,\"height\":1637,\"size\":341371,\"views\":3,\"bandwidth\":1024113,\"vote\":null,\"favorite\":false,\"nsfw\":null,\"section\":null,\"account_url\":null,\"account_id\":null,\"is_ad\":false,\"in_most_viral\":false,\"has_sound\":false,\"tags\":[],\"ad_type\":0,\"ad_url\":\"\",\"edited\":\"0\",\"in_gallery\":false,\"link\":\"https:\\/\\/i.imgur.com\\/T6D4SNW.jpg\"},{\"id\":\"ubc0i4s\",\"title\":null,\"description\":null,\"datetime\":1722786449,\"type\":\"image\\/jpeg\",\"animated\":false,\"width\":2142,\"height\":3411,\"size\":1582988,\"views\":3,\"bandwidth\":4748964,\"vote\":null,\"favorite\":false,\"nsfw\":null,\"section\":null,\"account_url\":null,\"account_id\":null,\"is_ad\":false,\"in_most_viral\":false,\"has_sound\":false,\"tags\":[],\"ad_type\":0,\"ad_url\":\"\",\"edited\":\"0\",\"in_gallery\":false,\"link\":\"https:\\/\\/i.imgur.com\\/ubc0i4s.jpg\"},{\"id\":\"Msfxah2\",\"title\":null,\"description\":null,\"datetime\":1722786448,\"type\":\"image\\/jpeg\",\"animated\":false,\"width\":703,\"height\":767,\"size\":114445,\"views\":3,\"bandwidth\":343335,\"vote\":null,\"favorite\":false,\"nsfw\":null,\"section\":null,\"account_url\":null,\"account_id\":null,\"is_ad\":false,\"in_most_viral\":false,\"has_sound\":false,\"tags\":[],\"ad_type\":0,\"ad_url\":\"\",\"edited\":\"0\",\"in_gallery\":false,\"link\":\"https:\\/\\/i.imgur.com\\/Msfxah2.jpg\"},{\"id\":\"SIcUght\",\"title\":null,\"description\":null,\"datetime\":1722786448,\"type\":\"image\\/png\",\"animated\":false,\"width\":810,\"height\":976,\"size\":310181,\"views\":2,\"bandwidth\":620362,\"vote\":null,\"favorite\":false,\"nsfw\":null,\"section\":null,\"account_url\":null,\"account_id\":null,\"is_ad\":false,\"in_most_viral\":false,\"has_sound\":false,\"tags\":[],\"ad_type\":0,\"ad_url\":\"\",\"edited\":\"0\",\"in_gallery\":false,\"link\":\"https:\\/\\/i.imgur.com\\/SIcUght.png\"},{\"id\":\"tAhcRCq\",\"title\":null,\"description\":null,\"datetime\":1722786448,\"type\":\"image\\/png\",\"animated\":false,\"width\":900,\"height\":900,\"size\":385264,\"views\":2,\"bandwidth\":770528,\"vote\":null,\"favorite\":false,\"nsfw\":null,\"section\":null,\"account_url\":null,\"account_id\":null,\"is_ad\":false,\"in_most_viral\":false,\"has_sound\":false,\"tags\":[],\"ad_type\":0,\"ad_url\":\"\",\"edited\":\"0\",\"in_gallery\":false,\"link\":\"https:\\/\\/i.imgur.com\\/tAhcRCq.png\"},{\"id\":\"1oVo8Pz\",\"title\":null,\"description\":null,\"datetime\":1722786449,\"type\":\"image\\/png\",\"animated\":false,\"width\":1075,\"height\":825,\"size\":893714,\"views\":2,\"bandwidth\":1787428,\"vote\":null,\"favorite\":false,\"nsfw\":null,\"section\":null,\"account_url\":null,\"account_id\":null,\"is_ad\":false,\"in_most_viral\":false,\"has_sound\":false,\"tags\":[],\"ad_type\":0,\"ad_url\":\"\",\"edited\":\"0\",\"in_gallery\":false,\"link\":\"https:\\/\\/i.imgur.com\\/1oVo8Pz.png\"},{\"id\":\"R6M8qBL\",\"title\":null,\"description\":null,\"datetime\":1722786449,\"type\":\"image\\/png\",\"animated\":false,\"width\":1156,\"height\":1500,\"size\":1523704,\"views\":2,\"bandwidth\":3047408,\"vote\":null,\"favorite\":false,\"nsfw\":null,\"section\":null,\"account_url\":null,\"account_id\":null,\"is_ad\":false,\"in_most_viral\":false,\"has_sound\":false,\"tags\":[],\"ad_type\":0,\"ad_url\":\"\",\"edited\":\"0\",\"in_gallery\":false,\"link\":\"https:\\/\\/i.imgur.com\\/R6M8qBL.png\"}],\"success\":true,\"status\":200}";
                    // await client.GetStringAsync("https://api.imgur.com/3/album/W5lVIkX/images");
                    ImgurResponse res = JsonConvert.DeserializeObject<ImgurResponse>(result);
                    if (res.success)
                    {
                        await ctx.Client.SendMessageAsync(ctx.Channel, res.data[Rand.Instance.Next(res.data.Length)].link);
                        //await ctx.RespondAsync(res.data[Rand.Instance.Next(res.data.Length)].link);
                    }
                    else
                    {
                        await ctx.Client.SendMessageAsync(ctx.Channel, "Huh? Imgur isn't working properly! ;~;");
                        //await ctx.RespondAsync("Huh? Imgur isn't working properly! ;~;");
                    }
                }
                catch (Exception)
                {
                    await ctx.Client.SendMessageAsync(ctx.Channel, "Huh? Imgur isn't working properly! ;~;");
                    //await ctx.RespondAsync("Huh? Imgur isn't working properly! ;~;");
                }
            }
        }
        [Command("winnie")]
        public async Task Winnie(CommandContext ctx)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Client-ID", Program.instance.auth[1]);
                    string result = "{\"data\":[{\"id\":\"uKKVDi6\",\"title\":null,\"description\":null,\"datetime\":1722786901,\"type\":\"image\\/png\",\"animated\":false,\"width\":1280,\"height\":1280,\"size\":349075,\"views\":2,\"bandwidth\":698150,\"vote\":null,\"favorite\":false,\"nsfw\":null,\"section\":null,\"account_url\":null,\"account_id\":null,\"is_ad\":false,\"in_most_viral\":false,\"has_sound\":false,\"tags\":[],\"ad_type\":0,\"ad_url\":\"\",\"edited\":\"0\",\"in_gallery\":false,\"link\":\"https:\\/\\/i.imgur.com\\/uKKVDi6.png\"},{\"id\":\"j91R5a2\",\"title\":null,\"description\":null,\"datetime\":1722786901,\"type\":\"image\\/png\",\"animated\":false,\"width\":1280,\"height\":1280,\"size\":315633,\"views\":2,\"bandwidth\":631266,\"vote\":null,\"favorite\":false,\"nsfw\":null,\"section\":null,\"account_url\":null,\"account_id\":null,\"is_ad\":false,\"in_most_viral\":false,\"has_sound\":false,\"tags\":[],\"ad_type\":0,\"ad_url\":\"\",\"edited\":\"0\",\"in_gallery\":false,\"link\":\"https:\\/\\/i.imgur.com\\/j91R5a2.png\"},{\"id\":\"MFcUpbD\",\"title\":null,\"description\":null,\"datetime\":1722786902,\"type\":\"image\\/png\",\"animated\":false,\"width\":1587,\"height\":1241,\"size\":1641797,\"views\":2,\"bandwidth\":3283594,\"vote\":null,\"favorite\":false,\"nsfw\":null,\"section\":null,\"account_url\":null,\"account_id\":null,\"is_ad\":false,\"in_most_viral\":false,\"has_sound\":false,\"tags\":[],\"ad_type\":0,\"ad_url\":\"\",\"edited\":\"0\",\"in_gallery\":false,\"link\":\"https:\\/\\/i.imgur.com\\/MFcUpbD.png\"},{\"id\":\"SdIbWsq\",\"title\":null,\"description\":null,\"datetime\":1722786902,\"type\":\"image\\/png\",\"animated\":false,\"width\":1561,\"height\":1188,\"size\":1609275,\"views\":2,\"bandwidth\":3218550,\"vote\":null,\"favorite\":false,\"nsfw\":null,\"section\":null,\"account_url\":null,\"account_id\":null,\"is_ad\":false,\"in_most_viral\":false,\"has_sound\":false,\"tags\":[],\"ad_type\":0,\"ad_url\":\"\",\"edited\":\"0\",\"in_gallery\":false,\"link\":\"https:\\/\\/i.imgur.com\\/SdIbWsq.png\"}],\"success\":true,\"status\":200}";
                    //await client.GetStringAsync("https://api.imgur.com/3/album/OqDCoYF/images");
                    ImgurResponse res = JsonConvert.DeserializeObject<ImgurResponse>(result);
                    if (res.success)
                    {
                        await ctx.Client.SendMessageAsync(ctx.Channel, res.data[Rand.Instance.Next(res.data.Length)].link);
                        //await ctx.RespondAsync(res.data[Rand.Instance.Next(res.data.Length)].link);
                    }
                    else
                    {
                        await ctx.Client.SendMessageAsync(ctx.Channel, "Huh? Imgur isn't working properly! ;~;");
                        //await ctx.RespondAsync("Huh? Imgur isn't working properly! ;~;");
                    }
                }
                catch (Exception)
                {
                    await ctx.Client.SendMessageAsync(ctx.Channel, "Huh? Imgur isn't working properly! ;~;");
                    //await ctx.RespondAsync("Huh? Imgur isn't working properly! ;~;");
                }
            }
        }
    }
}
