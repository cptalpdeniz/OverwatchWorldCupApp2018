using System;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace OWWC.MULTI.Countries
{
    public class LAGroupStage
    {
        public static string Name { get; set; } = "United States Group Stage";
        public static int ID { get; set; } = 2;
        public static DateTime StartDate = new DateTime(2018, 9, 7);
        public static DateTime EndDate = new DateTime(2018, 9, 9);
        public static string[] home = { "Austria", "Norway", "Canada", "Austria", "Norway", "Switzerland", "Brazil", "Norway", "United States", "Brazil", "Norway", "Canada", "Norway", "Switzerland", "Canada" };
        public static string[] away = { "Canada", "Switzerland", "Brazil", "United States", "Brazil", "Austria", "United States", "Canada", "Switzerland", "Austria", "Austria", "Switzerland", "United States", "Brazil", "United States" };

        public static int[] scoreHome = { 0, 3, 4, 0, 2, 2, 1, 0, 4, 3, 3, 4, 0, 1, 1 };
        public static int[] scoreAway = { 4, 1, 0, 4, 3, 3, 3, 4, 0, 1, 1, 0, 4, 3, 3 };

        public static Day1 Day1 = new Day1(GetMatchObjectFirst(home, away, 0, 0, 17, 00), GetMatchObjectFirst(home, away, 1, 1, 18, 20), GetMatchObjectFirst(home, away, 2, 2, 19, 45), GetMatchObjectFirst(home, away, 3, 3, 21, 30), GetMatchObjectFirst(home, away, 4, 4, 22, 30), date1());
        public static Day2 Day2 = new Day2(GetMatchObjectSecond(home, away, 5, 5, 17, 00), GetMatchObjectSecond(home, away, 6, 6, 18, 45), GetMatchObjectSecond(home, away, 7, 7, 20, 00), GetMatchObjectSecond(home, away, 8, 8, 21, 20), GetMatchObjectSecond(home, away, 9, 9, 22, 40), date2());
        public static Day3 Day3 = new Day3(GetMatchObjectThird(home, away, 10, 10, 17, 00), GetMatchObjectThird(home, away, 11, 11, 18, 10), GetMatchObjectThird(home, away, 12, 12, 19, 25), GetMatchObjectThird(home, away, 13, 13, 20, 35), GetMatchObjectThird(home, away, 14, 14, 22, 05), date3());

        public static string[] teams = { "Austria", "Brazil", "Canada", "Norway", "Switzerland", "United States" };

        public static Match GetMatchObjectFirst(string[] home, string[] away, int homeIndex, int awayIndex, int hh, int mm)
        {
            DateTime dateTime = new DateTime(2018, 9, 7, hh, mm, 00);
            Match match = new Match(home[homeIndex], away[awayIndex], dateTime);
            return match;
        }
        public static Match GetMatchObjectSecond(string[] home, string[] away, int homeIndex, int awayIndex, int hh, int mm)
        {
            DateTime dateTime = new DateTime(2018, 9, 8, hh, mm, 00);
            Match match = new Match(home[homeIndex], away[awayIndex], dateTime);
            return match;
        }
        public static Match GetMatchObjectThird(string[] home, string[] away, int homeIndex, int awayIndex, int hh, int mm)
        {
            DateTime dateTime = new DateTime(2018, 9, 9, hh, mm, 00);
            Match match = new Match(home[homeIndex], away[awayIndex], dateTime);
            return match;
        }
        public static DateTime date1()
        {
            DateTime date = new DateTime(2018, 9, 7);
            return date;
        }
        public static DateTime date2()
        {
            DateTime date = new DateTime(2018, 9, 8);
            return date;
        }
        public static DateTime date3()
        {
            DateTime date = new DateTime(2018, 9, 9);
            return date;
        }
        public static string[] GetStandings()
        {
            var url = "https://www.over.gg/event/s/221/423/world-cup-2018-los-angeles-group-stage";

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