using Xamarin.Forms;
using Foundation;
using OWWC.MULTI.Services;
using OWWC.MULTI.iOS.Data;

[assembly: Dependency(typeof(BaseUrl_iOS))]

namespace OWWC.MULTI.iOS.Data
{
    public class BaseUrl_iOS : IBaseUrl
    {
        public string Get()
        {
            return NSBundle.MainBundle.BundlePath;
        }
    }
}