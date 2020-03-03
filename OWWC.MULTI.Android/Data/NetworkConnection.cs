using System;
using Android.App;
using Android.Content;
using Android.Net;
using OWWC.MULTI.Droid.Data;
using OWWC.MULTI.Services;

[assembly: Xamarin.Forms.Dependency(typeof(NetworkConnection))]

namespace OWWC.MULTI.Droid.Data
{
    public class NetworkConnection : INetworkConnection
    {
        public bool IsConnected { get; set; }

        public void CheckNetworkConnection()
        {
            var ConnectivityManager = (ConnectivityManager)Application.Context.GetSystemService(Context.ConnectivityService);
            var ActiveNetworkInfo = ConnectivityManager.ActiveNetworkInfo;
            if (ActiveNetworkInfo != null && ActiveNetworkInfo.IsConnectedOrConnecting)
            {
                IsConnected = true;
            }
            else
            {
                IsConnected = false;
            }
        }
    }
}
