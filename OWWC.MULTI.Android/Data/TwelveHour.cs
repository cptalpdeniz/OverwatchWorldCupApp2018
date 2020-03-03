using Android.App;
using OWWC.MULTI.Droid.Data;
using OWWC.MULTI.Services;

[assembly: Xamarin.Forms.Dependency(typeof(TwelveHour))]

namespace OWWC.MULTI.Droid.Data
{
    public class TwelveHour : IHourFormat
    {
        public bool TwelveHourFormat { get; set; }

        public bool CheckTwelveHourFormat()
        {
            TwelveHourFormat = Android.Text.Format.DateFormat.Is24HourFormat(Application.Context);
            return TwelveHourFormat;
        }
    }
}
