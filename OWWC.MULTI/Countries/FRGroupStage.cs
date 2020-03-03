using System;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace OWWC.MULTI.Countries
{
    public class FRGroupStage
    {
        public static string Name { get; set; } = "France Group Stage";
        public static int ID { get; set; } = 4;
        public static DateTime StartDate = new DateTime(2018, 9, 21);
        public static DateTime EndDate = new DateTime(2018, 9, 23);

        public static string[] home = { "France", "Germany", "Poland", "Germany", "United Kingdom", "France", "Netherlands", "Germany", "France", "Netherlands", "Italy", "France", "Italy", "Poland", "France" };
        public static string[] away = { "Netherlands", "United Kingdom", "Italy", "Netherlands", "Poland", "Germany", "Italy", "Poland", "Italy", "United Kingdom", "Germany", "Poland", "United Kingdom", "Netherlands", "United Kingdom" };


        public static Day1 Day1 = new Day1(GetMatchObjectFirst(home, away, 0, 0, 8, 00), GetMatchObjectFirst(home, away, 1, 1, 9, 45), GetMatchObjectFirst(home, away, 2, 2, 11, 30), GetMatchObjectFirst(home, away, 3, 3, 13, 15), GetMatchObjectFirst(home, away, 4, 4, 15, 00), date1());
        public static Day2 Day2 = new Day2(GetMatchObjectSecond(home, away, 5, 5, 10, 00), GetMatchObjectSecond(home, away, 6, 6, 11, 45), GetMatchObjectSecond(home, away, 7, 7, 13, 30), GetMatchObjectSecond(home, away, 8, 8, 15, 15), GetMatchObjectSecond(home, away, 9, 9, 17, 00), date2());
        public static Day3 Day3 = new Day3(GetMatchObjectThird(home, away, 10, 10, 10, 00), GetMatchObjectThird(home, away, 11, 11, 11, 45), GetMatchObjectThird(home, away, 12, 12, 20, 30), GetMatchObjectThird(home, away, 13, 13, 15, 15), GetMatchObjectThird(home, away, 14, 14, 17, 00), date3());

        public static string[] teams = { "France", "Germany", "Italy", "Netherlands", "Poland", "United Kingdom" };

        public static Match GetMatchObjectFirst(string[] home, string[] away, int homeIndex, int awayIndex, int hh, int mm)
        {
            DateTime dateTime = new DateTime(2018, 9, 21, hh, mm, 00);
            Match match = new Match(home[homeIndex], away[awayIndex], dateTime);
            return match;
        }
        public static Match GetMatchObjectSecond(string[] home, string[] away, int homeIndex, int awayIndex, int hh, int mm)
        {
            DateTime dateTime = new DateTime(2018, 9, 22, hh, mm, 00);
            Match match = new Match(home[homeIndex], away[awayIndex], dateTime);
            return match;
        }
        public static Match GetMatchObjectThird(string[] home, string[] away, int homeIndex, int awayIndex, int hh, int mm)
        {
            DateTime dateTime = new DateTime(2018, 9, 23, hh, mm, 00);
            Match match = new Match(home[homeIndex], away[awayIndex], dateTime);
            return match;
        }
        public static DateTime date1()
        {
            DateTime date = new DateTime(2018, 9, 21);
            return date;
        }
        public static DateTime date2()
        {
            DateTime date = new DateTime(2018, 9, 22);
            return date;
        }
        public static DateTime date3()
        {
            DateTime date = new DateTime(2018, 9, 23);
            return date;
        }
        public static string[] GetStandings()
        {
            var url = "https://www.over.gg/event/s/221/420/world-cup-2018-paris-group-stage";

            var web = new HtmlWeb();
            var doc = web.Load(url);
            string[] standings = new string[6];
            string TeamBlock;
            string TeamName;
            for (int i = 0; i < 6; i++)
            {
                TeamBlock = "//*[@id='wrapper']/div[1]/div/div[3]/div/div/div[2]/div[" + (i + 2).ToString();
                TeamName = TeamBlock + "]/div[3]/a";
                var tempp = doc.DocumentNode.SelectSingleNode(TeamName).InnerText;
                var regex = new Regex("[a-zA-Z]");
                var match = regex.Match(tempp);
                var index = tempp.IndexOf(match.ToString(), StringComparison.Ordinal);
                var tempo = tempp.Substring(index);
                var regexx = new Regex("[a-zA-Z ]");
                MatchCollection match2 = regexx.Matches(tempo);
                standings[i] = tempo.Substring(0, match2.Count);
            }
            return standings;
        }
    }
}
