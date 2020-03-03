using System;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace OWWC.MULTI.Countries
{
    public class THGroupStage
    {
        public static string Name { get; set; } = "Thailand Group Stage";
        public static int ID { get; set; } = 3;
        public static DateTime StartDate = new DateTime(2018, 9, 14);
        public static DateTime EndDate = new DateTime(2018, 9, 16);

        public static string[] home = { "Denmark", "Spain", "Sweden", "Spain", "Australia", "Australia", "China", "Australia", "Denmark", "Spain", "Sweden", "Spain", "Denmark", "Australia", "Spain" };
        public static string[] away = { "Thailand", "Australia", "China", "Denmark", "Thailand", "Denmark", "Thailand", "Sweden", "China", "Sweden", "Thailand", "China", "Sweden", "China", "Thailand" };

        public static int[] scoreHome = { 3, 1, 1, 1, 4, 1, 3, 4, 2, 0, 3, 0, 2, 2, 1 };
        public static int[] scoreAway = { 1, 3, 3, 2, 0, 3, 2, 0, 3, 4, 1, 4, 3, 3, 3 };

        public static Day1 Day1 = new Day1(GetMatchObjectFirst(home, away, 0, 0, 03, 00), GetMatchObjectFirst(home, away, 1, 1, 4, 45), GetMatchObjectFirst(home, away, 2, 2, 6, 30), GetMatchObjectFirst(home, away, 3, 3, 8, 15), GetMatchObjectFirst(home, away, 4, 4, 10, 00), date1());
        public static Day2 Day2 = new Day2(GetMatchObjectSecond(home, away, 5, 5, 03, 00), GetMatchObjectSecond(home, away, 6, 6, 4, 45), GetMatchObjectSecond(home, away, 7, 7, 6, 30), GetMatchObjectSecond(home, away, 8, 8, 8, 15), GetMatchObjectSecond(home, away, 9, 9, 10, 00), date2());
        public static Day3 Day3 = new Day3(GetMatchObjectThird(home, away, 10, 10, 03, 00), GetMatchObjectThird(home, away, 11, 11, 4, 45), GetMatchObjectThird(home, away, 12, 12, 6, 30), GetMatchObjectThird(home, away, 13, 13, 8, 15), GetMatchObjectThird(home, away, 14, 14, 10, 00), date3());

        public static string[] teams = { "Australia", "China", "Denmark", "Spain", "Sweden", "Thailand" };

        public static Match GetMatchObjectFirst(string[] home, string[] away, int homeIndex, int awayIndex, int hh, int mm)
        {
            DateTime dateTime = new DateTime(2018, 9, 14, hh, mm, 00);
            Match match = new Match(home[homeIndex], away[awayIndex], dateTime);
            return match;
        }
        public static Match GetMatchObjectSecond(string[] home, string[] away, int homeIndex, int awayIndex, int hh, int mm)
        {
            DateTime dateTime = new DateTime(2018, 9, 15, hh, mm, 00);
            Match match = new Match(home[homeIndex], away[awayIndex], dateTime);
            return match;
        }
        public static Match GetMatchObjectThird(string[] home, string[] away, int homeIndex, int awayIndex, int hh, int mm)
        {
            DateTime dateTime = new DateTime(2018, 9, 16, hh, mm, 00);
            Match match = new Match(home[homeIndex], away[awayIndex], dateTime);
            return match;
        }
        public static DateTime date1()
        {
            DateTime date = new DateTime(2018, 9, 14);
            return date;
        }
        public static DateTime date2()
        {
            DateTime date = new DateTime(2018, 9, 15);
            return date;
        }
        public static DateTime date3()
        {
            DateTime date = new DateTime(2018, 9, 16);
            return date;
        }
        public static string[] GetStandings()
        {
            var url = "https://www.over.gg/event/s/221/422/world-cup-2018-bangkok-group-stage";

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
