using System;
using CoreFoundation;
using Foundation;
using OWWC.MULTI.iOS.Data;
using OWWC.MULTI.Services;
using SystemConfiguration;
using Xamarin.Forms;

[assembly: Dependency(typeof(TwelveHour))]

namespace OWWC.MULTI.iOS.Data
{
    public class TwelveHour : IHourFormat
    {
        public bool TwelveHourFormat { get; set; }

        public bool CheckTwelveHourFormat()
        {
            var dateFormatter = new NSDateFormatter();
            dateFormatter.DateStyle = NSDateFormatterStyle.None;
            dateFormatter.TimeStyle = NSDateFormatterStyle.Short;

            var dateString = dateFormatter.ToString(NSDate.Now);
            TwelveHourFormat =
            dateString.Contains(dateFormatter.AMSymbol) ||
            dateString.Contains(dateFormatter.PMSymbol);

            return TwelveHourFormat;
        }
    }
}
