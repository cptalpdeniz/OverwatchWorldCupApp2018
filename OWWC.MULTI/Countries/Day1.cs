using System;
namespace OWWC.MULTI.Countries
{
    public class Day1
    {
        public Match[] Match { get; set; }
        public DateTime Date;
        public Day1(Match match1, Match match2, Match match3, Match match4, Match match5, DateTime date)
        {
            Match = new Match[5];
            Match[0] = match1;
            Match[1] = match2;
            Match[2] = match3;
            Match[3] = match4;
            Match[4] = match5;
            Date = date;
        }
    }
}
