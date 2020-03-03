﻿using OWWC.MULTI.iOS.Data;
using OWWC.MULTI.Services;
using OWWC.MULTI.Views;

[assembly: Xamarin.Forms.Dependency(typeof(TwitchLive))]

namespace OWWC.MULTI.iOS.Data
{
    public class TwitchLive : ITwitchLive
    {
        public bool IsLive { get; set; }

        public void IsTwitchLive()
        {
            IsLive = TwitchClass.api.Streams.v5.BroadcasterOnlineAsync("59980349").Result;
        }
    }
}
