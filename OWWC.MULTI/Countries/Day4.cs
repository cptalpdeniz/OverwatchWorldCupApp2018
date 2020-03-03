using System;
namespace OWWC.MULTI.Countries
{
    public class Day4
    {
        public Match Match1;
        public Match Match2;
        public Match Match3;
        public Match Match4;
        public Match Match5;
        public DateTime Date;
        public Day4(Match match1, Match match2, Match match3, Match match4, Match match5, DateTime date)
        {
            Match1 = match1;
            Match2 = match2;
            Match3 = match3;
            Match4 = match4;
            Match5 = match5;
            Date = date;
        }
    }
}
