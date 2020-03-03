using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TwitchLib.Api;

namespace OWWC.MULTI.Views
{
    public static class TwitchClass
    {

        public static bool ifStreaming { get; set; }
        public static string errorMessage { get; set; }
        public static string OWChannelID { get; set; } = "59980349";
        public static TwitchLib.Api.Models.Helix.Streams.GetStreams.GetStreamsResponse getStreams = new TwitchLib.Api.Models.Helix.Streams.GetStreams.GetStreamsResponse();

        public static TwitchAPI api;

        static TwitchClass()
        {
            HttpClient web = new HttpClient();
            string uri = "https://api.twitch.tv/helix/streams?user_id=59980349";
            web.DefaultRequestHeaders.Add("Client-ID", " ");
            string jsonString = web.GetStringAsync(uri).Result;
            getStreams = JsonConvert.DeserializeObject<TwitchLib.Api.Models.Helix.Streams.GetStreams.GetStreamsResponse>(jsonString);
        }

        public static async Task MainAsync()
        {
            api = new TwitchAPI();
            api.Settings.ClientId = " ";
        }

        public static string GetTitle()
        {
            if (getStreams.Streams.Length != 0)
            {
                return getStreams.Streams[0].Title;
            }
            return " ";
        }

        public static bool GetLiveWC() //WC as in World Cup
        {
            string titleStream = GetTitle();
            if (GetLive() && (titleStream.Contains("Worldcup") || titleStream.Contains("World Cup")) && Regex.IsMatch(titleStream.Substring(0, 2), "[a-zA-Z ]"))
            {
                return true;
            }
            return false;
        }

        public static bool GetLive()
        {
            ifStreaming = api.Streams.v5.BroadcasterOnlineAsync("59980349").Result;
            return ifStreaming;
        }

    }
}
