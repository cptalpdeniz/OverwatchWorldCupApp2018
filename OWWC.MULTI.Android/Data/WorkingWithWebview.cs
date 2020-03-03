using System;
using OWWC.MULTI.Droid.Data;
using OWWC.MULTI.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(BaseUrl_Android))]
namespace OWWC.MULTI.Droid.Data
{
    public class BaseUrl_Android : IBaseUrl
    {
        public string Get()
        {
            return "file:///android_asset/";
        }
    }
}