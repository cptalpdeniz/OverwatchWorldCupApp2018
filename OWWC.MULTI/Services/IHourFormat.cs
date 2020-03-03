using System;
namespace OWWC.MULTI.Services
{
    public interface IHourFormat
    {
        bool TwelveHourFormat { get; }
        bool CheckTwelveHourFormat();
    }
}