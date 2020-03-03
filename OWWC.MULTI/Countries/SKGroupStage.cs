using System;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace OWWC.MULTI.Countries
{
    public class SKGroupStage
    {
        public static string Name { get; set; } = "South Korea Group Stage";
        public static int ID { get; set; } = 1;
        public static DateTime StartDate = new DateTime(2018, 8, 17);
        public static DateTime EndDate = new DateTime(2018, 8, 19);
        public static string[] home = { "Hong Kong", "Taiwan", "Hong Kong", "Japan", "Finland", "Hong Kong", "Taiwan", "Russia", "Taiwan", "Japan", "Japan", "Taiwan", "Hong Kong", "Russia", "Taiwan" };
        public static string[] away = { "Russia", "South Korea", "Finland", "Russia", "South Korea", "South Korea", "Japan", "Finland", "Hong Kong", "South Korea", "Finland", "Russia", "Japan", "South Korea", "Finland" };

        public static int[] scoreHome = { 0, 0, 0, 1, 2, 0, 1, 1, 4, 0, 0, 0, 0, 0, 0 };
        public static int[] scoreAway = { 4, 4, 4, 3, 3, 4, 3, 2, 0, 4, 4, 4, 4, 4, 4 };

        public static Day1 Day1 = new Day1(GetMatchObjectFirst(home, away, 0, 0, 03, 00), GetMatchObjectFirst(home, away, 1, 1, 4, 20), GetMatchObjectFirst(home, away, 2, 2, 5, 50), GetMatchObjectFirst(home, away, 3, 3, 7, 10), GetMatchObjectFirst(home, away, 4, 4, 8, 30), date1());
        public static Day2 Day2 = new Day2(GetMatchObjectSecond(home, away, 5, 5, 03, 00), GetMatchObjectSecond(home, away, 6, 6, 4, 20), GetMatchObjectSecond(home, away, 7, 7, 5, 50), GetMatchObjectSecond(home, away, 8, 8, 8, 00), GetMatchObjectSecond(home, away, 9, 9, 9, 00), date2());
        public static Day3 Day3 = new Day3(GetMatchObjectThird(home, away, 10, 10, 03, 00), GetMatchObjectThird(home, away, 11, 11, 4, 45), GetMatchObjectThird(home, away, 12, 12, 5, 30), GetMatchObjectThird(home, away, 13, 13, 5, 00), GetMatchObjectThird(home, away, 14, 14, 8, 30), date3());

        public static string[] teams = { "Finland", "Hong Kong", "Japan", "Russia", "South Korea", "Taiwan" };

        public static Match GetMatchObjectFirst(string[] home, string[] away, int homeIndex, int awayIndex, int hh, int mm)
        {
            DateTime dateTime = new DateTime(2018, 8, 17, hh, mm, 00);
            Match match = new Match(home[homeIndex], away[awayIndex], dateTime);
            return match;
        }
        public static Match GetMatchObjectSecond(string[] home, string[] away, int homeIndex, int awayIndex, int hh, int mm)
        {
            DateTime dateTime = new DateTime(2018, 8, 18, hh, mm, 00);
            Match match = new Match(home[homeIndex], away[awayIndex], dateTime);
            return match;
        }
        public static Match GetMatchObjectThird(string[] home, string[] away, int homeIndex, int awayIndex, int hh, int mm)
        {
            DateTime dateTime = new DateTime(2018, 8, 19, hh, mm, 00);
            Match match = new Match(home[homeIndex], away[awayIndex], dateTime);
            return match;
        }
        public static DateTime date1()
        {
            DateTime date = new DateTime(2018, 8, 17);
            return date;
        }
        public static DateTime date2()
        {
            DateTime date = new DateTime(2018, 8, 18);
            return date;
        }
        public static DateTime date3()
        {
            DateTime date = new DateTime(2018, 8, 19);
            return date;
        }

        public static string[] GetStandings()
        {
            var url = "https://www.over.gg/event/s/221/421/world-cup-2018-incheon-group-stage";

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