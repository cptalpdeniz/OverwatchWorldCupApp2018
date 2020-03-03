using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
using Newtonsoft.Json;
using OWWC.MULTI.Countries;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OWWC.MULTI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OpeningPage : TabbedPage
    {

        static GroupStage groupstage1 = new GroupStage("South Korea Group Stage", 1, 2018, 8, 16, 2018, 9, 19);
        static GroupStage groupstage2 = new GroupStage("United States Group Stage", 2, 2018, 9, 7, 2018, 9, 9);
        static GroupStage groupstage3 = new GroupStage("Thailand Group Stage", 3, 2018, 9, 13, 2018, 9, 16);
        static GroupStage groupstage4 = new GroupStage("France Group Stage", 4, 2018, 9, 21, 2018, 9, 23);
        public static HtmlWeb web = new HtmlWeb();
        public static HtmlDocument docSK = web.Load("https://www.over.gg/event/s/221/421/world-cup-2018-incheon-group-stage");
        public static HtmlDocument docUS = web.Load("https://www.over.gg/event/s/221/423/world-cup-2018-los-angeles-group-stage");
        public static HtmlDocument docTH = web.Load("https://www.over.gg/event/s/221/422/world-cup-2018-bangkok-group-stage");
        public static HtmlDocument docFR = web.Load("https://www.over.gg/event/s/221/420/world-cup-2018-paris-group-stage");


        public static Dictionary<string, Country> _countries = new Dictionary<string, Country>
        {
            ["Australia"] = new Country(1, "Australia", true, "AU", "ausFlag.png", 3, groupstage3, GetScore("Australia", 3)),
            ["Austria"] = new Country(2, "Austria", false, "AT", "austriaFlag.png", 2, groupstage4, GetScore("Austria", 2)),
            ["Brazil"] = new Country(3, "Brazil", false, "BR", "brazilFlag.png", 2, groupstage2, GetScore("Brazil", 2)),
            ["Canada"] = new Country(4, "Canada", true, "CA", "canadaFlag.png", 2, groupstage2, GetScore("Canada", 2)),
            ["China"] = new Country(5, "China", true, "CN", "chinaFlag.png", 3, groupstage3, GetScore("China", 3)),
            ["Denmark"] = new Country(6, "Denmark", false, "DK", "denmarkFlag.png", 3, groupstage3, GetScore("Denmark", 3)),
            ["Finland"] = new Country(7, "Finland", true, "FI", "finlandFlag.png", 1, groupstage1, GetScore("Finland", 1)),
            ["France"] = new Country(8, "France", true, "FR", "franceFlag.png", 4, groupstage4, GetScore("France", 4)),
            ["Germany"] = new Country(9, "Germany", false, "DE", "germanFlag.png", 4, groupstage4, GetScore("Germany", 4)),
            ["Hong Kong"] = new Country(10, "Hong Kong", false, "HK", "hkFlag.png", 1, groupstage1, GetScore("Hong Kong", 1)),
            ["Italy"] = new Country(11, "Italy", false, "IT", "italyFlag.png", 4, groupstage4, GetScore("Italy", 4)),
            ["Japan"] = new Country(12, "Japan", false, "JP", "japanFlag.png", 1, groupstage1, GetScore("Japan", 1)),
            ["Netherlands"] = new Country(13, "Netherlands", false, "NL", "nlFlag.png", 4, groupstage4, GetScore("Netherlands", 4)),
            ["Norway"] = new Country(14, "Norway", false, "NO", "norwayFlag.png", 2, groupstage2, GetScore("Norway", 2)),
            ["Poland"] = new Country(15, "Poland", false, "PL", "polandFlag.png", 4, groupstage4, GetScore("Poland", 4)),
            ["Russia"] = new Country(16, "Russia", false, "RU", "russiaFlag.png", 1, groupstage1, GetScore("Russia", 1)),
            ["South Korea"] = new Country(17, "South Korea", true, "SK", "skFlag.png", 1, groupstage1, GetScore("South Korea", 1)),
            ["Spain"] = new Country(18, "Spain", false, "ES", "spainFlag.png", 3, groupstage3, GetScore("Spain", 3)),
            ["Sweden"] = new Country(19, "Sweden", false, "SE", "swedenFlag.png", 3, groupstage3, GetScore("Sweden", 3)),
            ["Switzerland"] = new Country(20, "Switzerland", false, "CH", "swissFlag.png", 2, groupstage2, GetScore("Switzerland", 2)),
            ["Taiwan"] = new Country(21, "Taiwan", false, "TW", "taiwanFlag.png", 1, groupstage1, GetScore("Taiwan", 1)),
            ["Thailand"] = new Country(22, "Thailand", false, "TH", "thaiFlag.png", 3, groupstage3, GetScore("Thailand", 3)),
            ["United Kingdom"] = new Country(23, "United Kingdom", true, "UK", "ukFlag.png", 4, groupstage4, GetScore("United Kingdom", 4)),
            ["United States"] = new Country(24, "United States", true, "US", "usFlag.png", 2, groupstage2, GetScore("United States", 2)),
        };

        public static string[] GetScore(string name, int GroupID)
        {
            string[] data = new string[2];

            if (GroupID == 1)
            {
                string TeamBlock;
                string TeamName;
                string tempp;
                for (int i = 0; i < 6; i++)
                {
                    TeamBlock = "//*[@id='wrapper']/div[1]/div/div[3]/div/div/div[2]/div[" + (i + 2).ToString();
                    TeamName = TeamBlock + "]/div[3]/a";
                    tempp = docSK.DocumentNode.SelectSingleNode(TeamName).InnerText;
                    var regex = new Regex("[a-zA-Z]");
                    var match = regex.Match(tempp);
                    var index = tempp.IndexOf(match.ToString(), StringComparison.Ordinal);
                    var tempo = tempp.Substring(index);
                    var regexx = new Regex("[a-zA-Z ]");
                    MatchCollection match2 = regexx.Matches(tempo);
                    var something = tempo.Substring(0, match2.Count);
                    if (something == name)
                    {
                        string data1 = TeamBlock + "]/div[4]";
                        string data2 = TeamBlock + "]/div[5]";
                        data[0] = docSK.DocumentNode.SelectSingleNode(data1).InnerText;
                        data[1] = docSK.DocumentNode.SelectSingleNode(data2).InnerText;
                        break;

                    }
                }

                for (int i = 0; i < 2; i++)
                {
                    var regex = new Regex("[0-9]");
                    var match = regex.Match(data[i]);
                    var index = data[i].IndexOf(match.ToString(), StringComparison.Ordinal);
                    var tempo = data[i].Substring(index);
                    var regexx = new Regex("[-]", RegexOptions.RightToLeft);
                    match = regexx.Match(tempo);
                    var aa = tempo.IndexOf(match.ToString(), StringComparison.Ordinal);
                    var something = tempo.Substring(0, aa + 2);
                    data[i] = something;
                }
                return data;
            }

            else if (GroupID == 2)
            {
                string TeamBlock;
                string TeamName;
                string tempp;
                for (int i = 0; i < 6; i++)
                {
                    TeamBlock = "//*[@id='wrapper']/div[1]/div/div[3]/div/div/div[2]/div[" + (i + 2).ToString();
                    TeamName = TeamBlock + "]/div[3]/a";
                    tempp = docUS.DocumentNode.SelectSingleNode(TeamName).InnerText;
                    var regex = new Regex("[a-zA-Z]");
                    var match = regex.Match(tempp);
                    var index = tempp.IndexOf(match.ToString(), StringComparison.Ordinal);
                    var tempo = tempp.Substring(index);
                    var regexx = new Regex("[a-zA-Z ]");
                    MatchCollection match2 = regexx.Matches(tempo);
                    var something = tempo.Substring(0, match2.Count);
                    if (something == name)
                    {
                        string data1 = TeamBlock + "]/div[4]";
                        string data2 = TeamBlock + "]/div[5]";
                        data[0] = docUS.DocumentNode.SelectSingleNode(data1).InnerText;
                        data[1] = docUS.DocumentNode.SelectSingleNode(data2).InnerText;
                        break;

                    }
                }

                for (int i = 0; i < 2; i++)
                {
                    var regex = new Regex("[0-9]");
                    var match = regex.Match(data[i]);
                    var index = data[i].IndexOf(match.ToString(), StringComparison.Ordinal);
                    var tempo = data[i].Substring(index);
                    var regexx = new Regex("[-]", RegexOptions.RightToLeft);
                    match = regexx.Match(tempo);
                    var aa = tempo.IndexOf(match.ToString(), StringComparison.Ordinal);
                    var something = tempo.Substring(0, aa + 2);
                    data[i] = something;
                }
                return data;

            }
            else if (GroupID == 3)
            {
                string TeamBlock;
                string TeamName;
                string tempp;
                for (int i = 0; i < 6; i++)
                {
                    TeamBlock = "//*[@id='wrapper']/div[1]/div/div[3]/div/div/div[2]/div[" + (i + 2).ToString();
                    TeamName = TeamBlock + "]/div[3]/a";
                    tempp = docTH.DocumentNode.SelectSingleNode(TeamName).InnerText;
                    var regex = new Regex("[a-zA-Z]");
                    var match = regex.Match(tempp);
                    var index = tempp.IndexOf(match.ToString(), StringComparison.Ordinal);
                    var tempo = tempp.Substring(index);
                    var regexx = new Regex("[a-zA-Z ]");
                    MatchCollection match2 = regexx.Matches(tempo);
                    var something = tempo.Substring(0, match2.Count);
                    if (something == name)
                    {
                        string data1 = TeamBlock + "]/div[4]";
                        string data2 = TeamBlock + "]/div[5]";
                        data[0] = docTH.DocumentNode.SelectSingleNode(data1).InnerText;
                        data[1] = docTH.DocumentNode.SelectSingleNode(data2).InnerText;
                        break;

                    }
                }

                for (int i = 0; i < 2; i++)
                {
                    var regex = new Regex("[0-9]");
                    var match = regex.Match(data[i]);
                    var index = data[i].IndexOf(match.ToString(), StringComparison.Ordinal);
                    var tempo = data[i].Substring(index);
                    var regexx = new Regex("[-]", RegexOptions.RightToLeft);
                    match = regexx.Match(tempo);
                    var aa = tempo.IndexOf(match.ToString(), StringComparison.Ordinal);
                    var something = tempo.Substring(0, aa + 2);
                    data[i] = something;
                }
                return data;
            }

            else if (GroupID == 4)
            {
                string TeamBlock;
                string TeamName;
                string tempp;
                for (int i = 0; i < 6; i++)
                {
                    TeamBlock = "//*[@id='wrapper']/div[1]/div/div[3]/div/div/div[2]/div[" + (i + 2).ToString();
                    TeamName = TeamBlock + "]/div[3]/a";
                    tempp = docFR.DocumentNode.SelectSingleNode(TeamName).InnerText;
                    var regex = new Regex("[a-zA-Z]");
                    var match = regex.Match(tempp);
                    var index = tempp.IndexOf(match.ToString(), StringComparison.Ordinal);
                    var tempo = tempp.Substring(index);
                    var regexx = new Regex("[a-zA-Z ]");
                    MatchCollection match2 = regexx.Matches(tempo);
                    var something = tempo.Substring(0, match2.Count);
                    if (something == name)
                    {
                        string data1 = TeamBlock + "]/div[4]";
                        string data2 = TeamBlock + "]/div[5]";
                        data[0] = docFR.DocumentNode.SelectSingleNode(data1).InnerText;
                        data[1] = docFR.DocumentNode.SelectSingleNode(data2).InnerText;
                        break;

                    }
                }

                for (int i = 0; i < 2; i++)
                {
                    var regex = new Regex("[0-9]");
                    var match = regex.Match(data[i]);
                    var index = data[i].IndexOf(match.ToString(), StringComparison.Ordinal);
                    var tempo = data[i].Substring(index);
                    var regexx = new Regex("[-]", RegexOptions.RightToLeft);
                    match = regexx.Match(tempo);
                    var aa = tempo.IndexOf(match.ToString(), StringComparison.Ordinal);
                    var something = tempo.Substring(0, aa + 2);
                    data[i] = something;
                }
                return data;
            }
            data[0] = "error";
            data[1] = "error";
            return data;
        }


        public OpeningPage()
        {
            InitializeComponent();
        }
    }
}