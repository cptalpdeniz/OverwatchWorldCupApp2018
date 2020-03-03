using System;
namespace OWWC.MULTI.Countries
{
    public class Match
    {
        public string Home { get; set; }
        public string Away { get; set; }
        public DateTime Date { get; set; }
        public Match(string home, string away, DateTime datetime)
        {
            Home = home;
            Away = away;
            Date = datetime;
        }
    }
}
