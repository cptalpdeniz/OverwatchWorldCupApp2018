using System.Net;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using OWWC.MULTI.Countries;
using OWWC.MULTI.Services;
using Foundation;
using HtmlAgilityPack;
using System.Text.RegularExpressions;

namespace OWWC.MULTI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorldcupPage : ContentPage
    {

        public string[] GetNextGamesLive(string team1, string team2)
        {
            string[] teams = new string[6];
            DateTime currentDate = DateTime.UtcNow.Date;
            bool isTwelveHourFormat = false;

            var DeviceHourFormat = DependencyService.Get<IHourFormat>();
            isTwelveHourFormat = DeviceHourFormat.CheckTwelveHourFormat();

            if (currentDate == FRGroupStage.Day1.Date)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (team1 == FRGroupStage.home[i] && team2 == FRGroupStage.away[i])
                    {
                        if (i < 3)
                        {
                            if (isTwelveHourFormat)
                            {
                                game1Date.Text = FRGroupStage.Day1.Match[i].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                                game2Date.Text = FRGroupStage.Day1.Match[i + 1].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                                game3Date.Text = FRGroupStage.Day1.Match[i + 2].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                            }
                            else
                            {
                                game1Date.Text = FRGroupStage.Day1.Match[i].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                                game2Date.Text = FRGroupStage.Day1.Match[i + 1].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                                game3Date.Text = FRGroupStage.Day1.Match[i + 2].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                            }

                            teams[0] = FRGroupStage.home[i];
                            teams[1] = FRGroupStage.away[i];
                            teams[2] = FRGroupStage.home[i + 1];
                            teams[3] = FRGroupStage.away[i + 1];
                            teams[4] = FRGroupStage.home[i + 2];
                            teams[5] = FRGroupStage.away[i + 2];
                            return teams;
                        }
                        else if (i == 3)
                        {
                            if (isTwelveHourFormat)
                            {
                                game1Date.Text = FRGroupStage.Day1.Match[i].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                                game2Date.Text = FRGroupStage.Day1.Match[i + 1].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                                game3Date.Text = FRGroupStage.Day2.Match[0].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                            }
                            else
                            {
                                game1Date.Text = FRGroupStage.Day1.Match[i].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                                game2Date.Text = FRGroupStage.Day1.Match[i + 1].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                                game3Date.Text = FRGroupStage.Day2.Match[0].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                            }

                            teams[0] = FRGroupStage.home[i];
                            teams[1] = FRGroupStage.away[i];
                            teams[2] = FRGroupStage.home[i + 1];
                            teams[3] = FRGroupStage.away[i + 1];
                            teams[4] = FRGroupStage.home[0];
                            teams[5] = FRGroupStage.away[0];
                            return teams;
                        }
                        else
                        {
                            if (isTwelveHourFormat)
                            {
                                game1Date.Text = FRGroupStage.Day1.Match[i].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                                game2Date.Text = FRGroupStage.Day2.Match[0].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                                game3Date.Text = FRGroupStage.Day2.Match[1].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                            }
                            else
                            {
                                game1Date.Text = FRGroupStage.Day1.Match[i].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                                game2Date.Text = FRGroupStage.Day2.Match[0].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                                game3Date.Text = FRGroupStage.Day2.Match[1].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                            }

                            teams[0] = FRGroupStage.home[i];
                            teams[1] = FRGroupStage.away[i];
                            teams[2] = FRGroupStage.home[0];
                            teams[3] = FRGroupStage.away[0];
                            teams[4] = FRGroupStage.home[1];
                            teams[5] = FRGroupStage.away[1];
                            return teams;
                        }
                    }
                }
            }
            else if (currentDate == FRGroupStage.Day2.Date)
            {
                for (int i = 5; i < 10; i++)
                {
                    if (team1 == FRGroupStage.home[i] && team2 == FRGroupStage.away[i])
                    {
                        if (i < 8)
                        {
                            if (isTwelveHourFormat)
                            {
                                game1Date.Text = FRGroupStage.Day2.Match[(i - 5)].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                                game2Date.Text = FRGroupStage.Day2.Match[(i - 5) + 1].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                                game3Date.Text = FRGroupStage.Day2.Match[(i - 5) + 2].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                            }
                            else
                            {
                                game1Date.Text = FRGroupStage.Day2.Match[(i - 5)].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                                game2Date.Text = FRGroupStage.Day2.Match[(i - 5) + 1].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                                game3Date.Text = FRGroupStage.Day2.Match[(i - 5) + 2].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                            }

                            teams[0] = FRGroupStage.home[i];
                            teams[1] = FRGroupStage.away[i];
                            teams[2] = FRGroupStage.home[i + 1];
                            teams[3] = FRGroupStage.away[i + 1];
                            teams[4] = FRGroupStage.home[i + 2];
                            teams[5] = FRGroupStage.away[i + 2];
                            return teams;
                        }
                        else if (i == 8)
                        {
                            if (isTwelveHourFormat)
                            {
                                game1Date.Text = FRGroupStage.Day2.Match[(i - 5)].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                                game2Date.Text = FRGroupStage.Day2.Match[(i - 5) + 1].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                                game3Date.Text = FRGroupStage.Day3.Match[0].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                            }
                            else
                            {
                                game1Date.Text = FRGroupStage.Day2.Match[(i - 5)].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                                game2Date.Text = FRGroupStage.Day2.Match[(i - 5) + 1].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                                game3Date.Text = FRGroupStage.Day3.Match[0].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                            }

                            teams[0] = FRGroupStage.home[i];
                            teams[1] = FRGroupStage.away[i];
                            teams[2] = FRGroupStage.home[i + 1];
                            teams[3] = FRGroupStage.away[i + 1];
                            teams[4] = FRGroupStage.home[i + 2];
                            teams[5] = FRGroupStage.away[i + 2];
                            return teams;
                        }
                        else
                        {
                            if (isTwelveHourFormat)
                            {
                                game1Date.Text = FRGroupStage.Day2.Match[(i - 5)].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                                game2Date.Text = FRGroupStage.Day3.Match[0].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                                game3Date.Text = FRGroupStage.Day3.Match[1].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                            }
                            else
                            {
                                game1Date.Text = FRGroupStage.Day2.Match[(i - 5)].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                                game2Date.Text = FRGroupStage.Day3.Match[0].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                                game3Date.Text = FRGroupStage.Day3.Match[1].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                            }

                            teams[0] = FRGroupStage.home[i];
                            teams[1] = FRGroupStage.away[i];
                            teams[2] = FRGroupStage.home[i + 1];
                            teams[3] = FRGroupStage.away[i + 1];
                            teams[4] = FRGroupStage.home[i + 2];
                            teams[5] = FRGroupStage.away[i + 2];
                            return teams;
                        }
                    }
                }
            }
            else if (currentDate == FRGroupStage.Day3.Date)
            {
                for (int i = 10; i < 15; i++)
                {
                    if (team1 == FRGroupStage.home[i] && team2 == FRGroupStage.away[i])
                    {
                        if (i < 13)
                        {
                            if (isTwelveHourFormat)
                            {
                                game1Date.Text = FRGroupStage.Day3.Match[(i - 10)].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                                game2Date.Text = FRGroupStage.Day3.Match[(i - 10) + 1].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                                game3Date.Text = FRGroupStage.Day3.Match[(i - 10) + 2].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                            }
                            else
                            {
                                game1Date.Text = FRGroupStage.Day3.Match[(i - 10)].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                                game2Date.Text = FRGroupStage.Day3.Match[(i - 10) + 1].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                                game3Date.Text = FRGroupStage.Day3.Match[(i - 10) + 2].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                            }

                            teams[0] = FRGroupStage.home[(i - 10)];
                            teams[1] = FRGroupStage.away[(i - 10)];
                            teams[2] = FRGroupStage.home[(i - 10) + 1];
                            teams[3] = FRGroupStage.away[(i - 10) + 1];
                            teams[4] = FRGroupStage.home[(i - 10) + 2];
                            teams[5] = FRGroupStage.away[(i - 10) + 2];
                            return teams;
                        }
                        else
                        {
                            if (isTwelveHourFormat)
                            {
                                game1Date.Text = FRGroupStage.Day3.Match[2].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                                game2Date.Text = FRGroupStage.Day3.Match[3].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                                game3Date.Text = FRGroupStage.Day3.Match[4].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                            }
                            else
                            {
                                game1Date.Text = FRGroupStage.Day3.Match[2].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                                game2Date.Text = FRGroupStage.Day3.Match[3].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                                game3Date.Text = FRGroupStage.Day3.Match[4].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                            }

                            teams[0] = FRGroupStage.home[12];
                            teams[1] = FRGroupStage.away[12];
                            teams[2] = FRGroupStage.home[13];
                            teams[3] = FRGroupStage.away[13];
                            teams[4] = FRGroupStage.home[14];
                            teams[5] = FRGroupStage.away[14];
                            return teams;
                        }
                    }
                }
            }
            return teams;

        }

        public string[] GetNextGames()
        {
            string[] teams = new string[6];
            DateTime currentDate = DateTime.UtcNow;

            var DeviceHourFormat = DependencyService.Get<IHourFormat>();
            bool isTwelveHourFormat = DeviceHourFormat.CheckTwelveHourFormat();
            if (currentDate > FRGroupStage.Day1.Match[4].Date && currentDate < FRGroupStage.Day2.Match[0].Date)
            {
                if (isTwelveHourFormat)
                {
                    game1Date.Text = FRGroupStage.Day2.Match[0].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                    game2Date.Text = FRGroupStage.Day2.Match[1].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                    game3Date.Text = FRGroupStage.Day2.Match[2].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                }
                else
                {
                    game1Date.Text = FRGroupStage.Day2.Match[0].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                    game2Date.Text = FRGroupStage.Day2.Match[1].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                    game3Date.Text = FRGroupStage.Day2.Match[2].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                }

                teams[0] = FRGroupStage.Day2.Match[0].Home;
                teams[1] = FRGroupStage.Day2.Match[0].Away;
                teams[2] = FRGroupStage.Day2.Match[1].Home;
                teams[3] = FRGroupStage.Day2.Match[1].Away;
                teams[4] = FRGroupStage.Day2.Match[2].Home;
                teams[5] = FRGroupStage.Day2.Match[2].Away;
                return teams;

            }
            else if (currentDate > FRGroupStage.Day2.Match[4].Date && currentDate < FRGroupStage.Day3.Match[0].Date)
            {
                if (isTwelveHourFormat)
                {
                    game1Date.Text = FRGroupStage.Day3.Match[0].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                    game2Date.Text = FRGroupStage.Day3.Match[1].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                    game3Date.Text = FRGroupStage.Day3.Match[2].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                }
                else
                {
                    game1Date.Text = FRGroupStage.Day3.Match[0].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                    game2Date.Text = FRGroupStage.Day3.Match[1].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                    game3Date.Text = FRGroupStage.Day3.Match[2].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                }

                teams[0] = FRGroupStage.Day3.Match[0].Home;
                teams[1] = FRGroupStage.Day3.Match[0].Away;
                teams[2] = FRGroupStage.Day3.Match[1].Home;
                teams[3] = FRGroupStage.Day3.Match[1].Away;
                teams[4] = FRGroupStage.Day3.Match[2].Home;
                teams[5] = FRGroupStage.Day3.Match[2].Away;
                return teams;

            }
            else
            {
                if (isTwelveHourFormat)
                {
                    game1Date.Text = FRGroupStage.Day3.Match[2].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                    game2Date.Text = FRGroupStage.Day3.Match[3].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                    game3Date.Text = FRGroupStage.Day3.Match[4].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                }
                else
                {
                    game1Date.Text = FRGroupStage.Day3.Match[2].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                    game2Date.Text = FRGroupStage.Day3.Match[3].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                    game3Date.Text = FRGroupStage.Day3.Match[4].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                }

                teams[0] = FRGroupStage.Day3.Match[2].Home;
                teams[1] = FRGroupStage.Day3.Match[2].Away;
                teams[2] = FRGroupStage.Day3.Match[3].Home;
                teams[3] = FRGroupStage.Day3.Match[3].Away;
                teams[4] = FRGroupStage.Day3.Match[4].Home;
                teams[5] = FRGroupStage.Day3.Match[4].Away;
                return teams;

            }
        }


        public WorldcupPage()
        {

            InitializeComponent();

            if (TwitchClass.GetLiveWC())
            {
                liveGame.IsVisible = true;
                var titleText = TwitchClass.getStreams.Streams[0].Title; //test this part
                int index = titleText.IndexOf(" v", StringComparison.Ordinal);
                if (index > 0)
                    liveText1.Text = titleText.Substring(0, index);
                if (titleText.Contains("vs. "))
                {
                    index = titleText.IndexOf("vs. ", StringComparison.Ordinal) + "vs. ".Length;
                }
                else if (titleText.Contains("vs"))
                {
                    index = titleText.IndexOf("vs ", StringComparison.Ordinal) + "vs ".Length;
                }
                int index2 = titleText.IndexOf(" |", StringComparison.Ordinal);
                var tempor = titleText.Substring(index);
                index2 = tempor.IndexOf(" |", StringComparison.Ordinal);

                liveText2.Text = titleText.Substring(index, index2);

                team1.Text = liveText1.Text;
                team2.Text = liveText2.Text;

                Country country1 = OpeningPage._countries[team1.Text];
                Country country2 = OpeningPage._countries[team2.Text];

                flag1.Source = ImageSource.FromFile(country1.GetFlag());
                flag2.Source = ImageSource.FromFile(country2.GetFlag());

                string[] Teams = new string[6];
                Teams = GetNextGamesLive(team1.Text, team2.Text);
                team3.Text = Teams[2];
                team4.Text = Teams[3];
                team5.Text = Teams[4];
                team6.Text = Teams[5];

                Country country3 = OpeningPage._countries[Teams[2]];
                Country country4 = OpeningPage._countries[Teams[3]];
                Country country5 = OpeningPage._countries[Teams[4]];
                Country country6 = OpeningPage._countries[Teams[5]];

                flag3.Source = ImageSource.FromFile(country3.GetFlag());
                flag4.Source = ImageSource.FromFile(country4.GetFlag());
                flag5.Source = ImageSource.FromFile(country5.GetFlag());
                flag6.Source = ImageSource.FromFile(country6.GetFlag());

            }
            else
            {
                liveGame.IsVisible = false;

                string[] Teams = new string[6];
                Teams = GetNextGames();
                team1.Text = Teams[0];
                team2.Text = Teams[1];
                team3.Text = Teams[2];
                team4.Text = Teams[3];
                team5.Text = Teams[4];
                team6.Text = Teams[5];

                Country country1 = OpeningPage._countries[Teams[0]];
                Country country2 = OpeningPage._countries[Teams[1]];
                Country country3 = OpeningPage._countries[Teams[2]];
                Country country4 = OpeningPage._countries[Teams[3]];
                Country country5 = OpeningPage._countries[Teams[4]];
                Country country6 = OpeningPage._countries[Teams[5]];

                flag1.Source = ImageSource.FromFile(country1.GetFlag());
                flag2.Source = ImageSource.FromFile(country2.GetFlag());
                flag3.Source = ImageSource.FromFile(country3.GetFlag());
                flag4.Source = ImageSource.FromFile(country4.GetFlag());
                flag5.Source = ImageSource.FromFile(country5.GetFlag());
                flag6.Source = ImageSource.FromFile(country6.GetFlag());


            }

            NewsGrid0.Margin = new Thickness(2, 10);
            NewsGrid1.Margin = new Thickness(2, 10);
            NewsGrid2.Margin = new Thickness(2, 10);

            int count = 0;

            var url = "https://overwatchleague.com/en-us/news";
            var web = new HtmlWeb();
            var doc = web.Load(url);

            var block = "//*[@id='tab1']/div[1]/div[";

            string title;
            string[] titleTextArray = new string[5];
            string[] newsImage = new string[5];
            DateTime[] DateText = new DateTime[5];

            for (int i = 1; true; i++)
            {
                if (count > 3)
                {
                    break;
                }
                var xpath = block + i.ToString() + "]/div[2]/div/div/div/span[1]";
                if (doc.DocumentNode.SelectNodes(xpath)[0].InnerText.Contains("Feature"))
                {
                    title = block + i.ToString() + "]/div[2]/div/h6/a";
                    titleTextArray[count] = doc.DocumentNode.SelectNodes(title)[0].InnerText;

                    var xpathDate = block + i.ToString() + "]/div[2]/div/div/div/span[2]/time";
                    var dateTemp = doc.DocumentNode.SelectNodes(xpathDate)[0].Attributes["datetime"].Value;
                    DateText[count] = DateTime.ParseExact(dateTemp, "yyyy-MM-dd'T'HH:mm:ss.fff'Z\'", null);

                    var imagepath = block + i.ToString() + "]/div[1]/a";
                    var imagelink = doc.DocumentNode.SelectNodes(imagepath)[0].Attributes["style"].Value;
                    var index = imagelink.IndexOf("url('", StringComparison.Ordinal) + "url('".Length;
                    var index2 = imagelink.IndexOf("');", StringComparison.Ordinal);
                    newsImage[count] = imagelink.Substring(index, index2 - index);

                    var urlpath = block + i.ToString() + "]/div[2]/div/h6/a";
                    ConstantsClass.NewsUrl[count] = "http://overwatchleague.com" + doc.DocumentNode.SelectNodes(urlpath)[0].Attributes["href"].Value;
                    count++;
                }
            }

            //*[@id="tab1"]/div[1]/div[1]/div[2]/div/h6/a

            var newsGrid1TapGesture = new TapGestureRecognizer();
            newsGrid1TapGesture.Tapped += (s, e) =>
                    {
                        Navigation.PushAsync(new NewsContent1());
                    };
            NewsGrid0.GestureRecognizers.Add(newsGrid1TapGesture);

            var newsGrid2TapGesture = new TapGestureRecognizer();
            newsGrid2TapGesture.Tapped += (s, e) =>
                        {
                            Navigation.PushAsync(new NewsContent2());
                        };
            NewsGrid1.GestureRecognizers.Add(newsGrid2TapGesture);

            var newsGrid3TapGesture = new TapGestureRecognizer();
            newsGrid3TapGesture.Tapped += (s, e) =>
                        {
                            Navigation.PushAsync(new NewsContent3());
                        };
            NewsGrid2.GestureRecognizers.Add(newsGrid3TapGesture);

            var newsGrid4TapGesture = new TapGestureRecognizer();
            newsGrid3TapGesture.Tapped += (s, e) =>
                        {
                            Navigation.PushAsync(new NewsContent4());
                        };
            NewsGrid3.GestureRecognizers.Add(newsGrid4TapGesture);




            newsImage0.Source = ImageSource.FromUri(new Uri(newsImage[0]));
            title0.Text = titleTextArray[0];
            date0.Text = DateText[0].ToString("MMM dd");

            newsImage1.Source = ImageSource.FromUri(new Uri(newsImage[1]));
            title1.Text = titleTextArray[1];
            date1.Text = DateText[1].ToString("MMM dd");

            newsImage2.Source = ImageSource.FromUri(new Uri(newsImage[2]));
            title2.Text = titleTextArray[2];
            date2.Text = DateText[2].ToString("MMM dd");

            newsImage3.Source = ImageSource.FromUri(new Uri(newsImage[3]));
            title3.Text = titleTextArray[3];
            date3.Text = DateText[3].ToString("MMM dd");

        }

        async void OnAboutTextClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }
    }
}
