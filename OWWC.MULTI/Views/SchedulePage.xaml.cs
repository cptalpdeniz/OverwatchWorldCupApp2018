using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using OWWC.MULTI.Services;

using Xamarin.Forms;
using OWWC.MULTI.Countries;
using System.Text.RegularExpressions;

namespace OWWC.MULTI.Views
{
    public partial class SchedulePage : CarouselPage
    {
        bool isTwelveHourFormat;

        public SchedulePage()
        {
            InitializeComponent();
            DateTime currentDate = DateTime.UtcNow.Date;
            var DeviceHourFormat = DependencyService.Get<IHourFormat>();
            isTwelveHourFormat = DeviceHourFormat.CheckTwelveHourFormat();

            if (isTwelveHourFormat)
            {
                SKDay1Game1.Text = SKGroupStage.Day1.Match[0].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                SKDay1Game2.Text = SKGroupStage.Day1.Match[1].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                SKDay1Game3.Text = SKGroupStage.Day1.Match[2].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                SKDay1Game4.Text = SKGroupStage.Day1.Match[3].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                SKDay1Game5.Text = SKGroupStage.Day1.Match[4].Date.ToLocalTime().ToString("MMM dd, h:mm tt");

                SKDay2Game1.Text = SKGroupStage.Day2.Match[0].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                SKDay2Game2.Text = SKGroupStage.Day2.Match[1].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                SKDay2Game3.Text = SKGroupStage.Day2.Match[2].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                SKDay2Game4.Text = SKGroupStage.Day2.Match[3].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                SKDay2Game5.Text = SKGroupStage.Day2.Match[4].Date.ToLocalTime().ToString("MMM dd, h:mm tt");

                SKDay3Game1.Text = SKGroupStage.Day3.Match[0].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                SKDay3Game2.Text = SKGroupStage.Day3.Match[1].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                SKDay3Game3.Text = SKGroupStage.Day3.Match[2].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                SKDay3Game4.Text = SKGroupStage.Day3.Match[3].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                SKDay3Game5.Text = SKGroupStage.Day3.Match[4].Date.ToLocalTime().ToString("MMM dd, h:mm tt");

                LADay1Game1.Text = LAGroupStage.Day1.Match[0].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                LADay1Game2.Text = LAGroupStage.Day1.Match[1].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                LADay1Game3.Text = LAGroupStage.Day1.Match[2].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                LADay1Game4.Text = LAGroupStage.Day1.Match[3].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                LADay1Game5.Text = LAGroupStage.Day1.Match[4].Date.ToLocalTime().ToString("MMM dd, h:mm tt");

                LADay2Game1.Text = LAGroupStage.Day2.Match[0].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                LADay2Game2.Text = LAGroupStage.Day2.Match[1].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                LADay2Game3.Text = LAGroupStage.Day2.Match[2].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                LADay2Game4.Text = LAGroupStage.Day2.Match[3].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                LADay2Game5.Text = LAGroupStage.Day2.Match[4].Date.ToLocalTime().ToString("MMM dd, h:mm tt");

                LADay3Game1.Text = LAGroupStage.Day3.Match[0].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                LADay3Game2.Text = LAGroupStage.Day3.Match[1].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                LADay3Game3.Text = LAGroupStage.Day3.Match[2].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                LADay3Game4.Text = LAGroupStage.Day3.Match[3].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                LADay3Game5.Text = LAGroupStage.Day3.Match[4].Date.ToLocalTime().ToString("MMM dd, h:mm tt");

                THDay1Game1.Text = THGroupStage.Day1.Match[0].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                THDay1Game2.Text = THGroupStage.Day1.Match[1].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                THDay1Game3.Text = THGroupStage.Day1.Match[2].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                THDay1Game4.Text = THGroupStage.Day1.Match[3].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                THDay1Game5.Text = THGroupStage.Day1.Match[4].Date.ToLocalTime().ToString("MMM dd, HH:mm");

                THDay2Game1.Text = THGroupStage.Day2.Match[0].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                THDay2Game2.Text = THGroupStage.Day2.Match[1].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                THDay2Game3.Text = THGroupStage.Day2.Match[2].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                THDay2Game4.Text = THGroupStage.Day2.Match[3].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                THDay2Game5.Text = THGroupStage.Day2.Match[4].Date.ToLocalTime().ToString("MMM dd, HH:mm");

                THDay3Game1.Text = THGroupStage.Day3.Match[0].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                THDay3Game2.Text = THGroupStage.Day3.Match[1].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                THDay3Game3.Text = THGroupStage.Day3.Match[2].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                THDay3Game4.Text = THGroupStage.Day3.Match[3].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                THDay3Game5.Text = THGroupStage.Day3.Match[4].Date.ToLocalTime().ToString("MMM dd, HH:mm");

                FRDay1Game1.Text = FRGroupStage.Day1.Match[0].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                FRDay1Game2.Text = FRGroupStage.Day1.Match[1].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                FRDay1Game3.Text = FRGroupStage.Day1.Match[2].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                FRDay1Game4.Text = FRGroupStage.Day1.Match[3].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                FRDay1Game5.Text = FRGroupStage.Day1.Match[4].Date.ToLocalTime().ToString("MMM dd, h:mm tt");

                FRDay2Game1.Text = FRGroupStage.Day2.Match[0].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                FRDay2Game2.Text = FRGroupStage.Day2.Match[1].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                FRDay2Game3.Text = FRGroupStage.Day2.Match[2].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                FRDay2Game4.Text = FRGroupStage.Day2.Match[3].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                FRDay2Game5.Text = FRGroupStage.Day2.Match[4].Date.ToLocalTime().ToString("MMM dd, h:mm tt");

                FRDay3Game1.Text = FRGroupStage.Day3.Match[0].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                FRDay3Game2.Text = FRGroupStage.Day3.Match[1].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                FRDay3Game3.Text = FRGroupStage.Day3.Match[2].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                FRDay3Game4.Text = FRGroupStage.Day3.Match[3].Date.ToLocalTime().ToString("MMM dd, h:mm tt");
                FRDay3Game5.Text = FRGroupStage.Day3.Match[4].Date.ToLocalTime().ToString("MMM dd, h:mm tt");

            }
            else
            {
                SKDay1Game1.Text = SKGroupStage.Day1.Match[0].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                SKDay1Game2.Text = SKGroupStage.Day1.Match[1].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                SKDay1Game3.Text = SKGroupStage.Day1.Match[2].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                SKDay1Game4.Text = SKGroupStage.Day1.Match[3].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                SKDay1Game5.Text = SKGroupStage.Day1.Match[4].Date.ToLocalTime().ToString("MMM dd, HH:mm");

                SKDay2Game1.Text = SKGroupStage.Day2.Match[0].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                SKDay2Game2.Text = SKGroupStage.Day2.Match[1].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                SKDay2Game3.Text = SKGroupStage.Day2.Match[2].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                SKDay2Game4.Text = SKGroupStage.Day2.Match[3].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                SKDay2Game5.Text = SKGroupStage.Day2.Match[4].Date.ToLocalTime().ToString("MMM dd, HH:mm");

                SKDay3Game1.Text = SKGroupStage.Day3.Match[0].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                SKDay3Game2.Text = SKGroupStage.Day3.Match[1].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                SKDay3Game3.Text = SKGroupStage.Day3.Match[2].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                SKDay3Game4.Text = SKGroupStage.Day3.Match[3].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                SKDay3Game5.Text = SKGroupStage.Day3.Match[4].Date.ToLocalTime().ToString("MMM dd, HH:mm");

                LADay1Game1.Text = LAGroupStage.Day1.Match[0].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                LADay1Game2.Text = LAGroupStage.Day1.Match[1].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                LADay1Game3.Text = LAGroupStage.Day1.Match[2].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                LADay1Game4.Text = LAGroupStage.Day1.Match[3].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                LADay1Game5.Text = LAGroupStage.Day1.Match[4].Date.ToLocalTime().ToString("MMM dd, HH:mm");

                LADay2Game1.Text = LAGroupStage.Day2.Match[0].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                LADay2Game2.Text = LAGroupStage.Day2.Match[1].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                LADay2Game3.Text = LAGroupStage.Day2.Match[2].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                LADay2Game4.Text = LAGroupStage.Day2.Match[3].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                LADay2Game5.Text = LAGroupStage.Day2.Match[4].Date.ToLocalTime().ToString("MMM dd, HH:mm");

                LADay3Game1.Text = LAGroupStage.Day3.Match[0].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                LADay3Game2.Text = LAGroupStage.Day3.Match[1].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                LADay3Game3.Text = LAGroupStage.Day3.Match[2].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                LADay3Game4.Text = LAGroupStage.Day3.Match[3].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                LADay3Game5.Text = LAGroupStage.Day3.Match[4].Date.ToLocalTime().ToString("MMM dd, HH:mm");

                THDay1Game1.Text = THGroupStage.Day1.Match[0].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                THDay1Game2.Text = THGroupStage.Day1.Match[1].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                THDay1Game3.Text = THGroupStage.Day1.Match[2].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                THDay1Game4.Text = THGroupStage.Day1.Match[3].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                THDay1Game5.Text = THGroupStage.Day1.Match[4].Date.ToLocalTime().ToString("MMM dd, HH:mm");

                THDay2Game1.Text = THGroupStage.Day2.Match[0].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                THDay2Game2.Text = THGroupStage.Day2.Match[1].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                THDay2Game3.Text = THGroupStage.Day2.Match[2].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                THDay2Game4.Text = THGroupStage.Day2.Match[3].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                THDay2Game5.Text = THGroupStage.Day2.Match[4].Date.ToLocalTime().ToString("MMM dd, HH:mm");

                THDay3Game1.Text = THGroupStage.Day3.Match[0].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                THDay3Game2.Text = THGroupStage.Day3.Match[1].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                THDay3Game3.Text = THGroupStage.Day3.Match[2].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                THDay3Game4.Text = THGroupStage.Day3.Match[3].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                THDay3Game5.Text = THGroupStage.Day3.Match[4].Date.ToLocalTime().ToString("MMM dd, HH:mm");

                FRDay1Game1.Text = FRGroupStage.Day1.Match[0].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                FRDay1Game2.Text = FRGroupStage.Day1.Match[1].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                FRDay1Game3.Text = FRGroupStage.Day1.Match[2].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                FRDay1Game4.Text = FRGroupStage.Day1.Match[3].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                FRDay1Game5.Text = FRGroupStage.Day1.Match[4].Date.ToLocalTime().ToString("MMM dd, HH:mm");

                FRDay2Game1.Text = FRGroupStage.Day2.Match[0].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                FRDay2Game2.Text = FRGroupStage.Day2.Match[1].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                FRDay2Game3.Text = FRGroupStage.Day2.Match[2].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                FRDay2Game4.Text = FRGroupStage.Day2.Match[3].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                FRDay2Game5.Text = FRGroupStage.Day2.Match[4].Date.ToLocalTime().ToString("MMM dd, HH:mm");

                FRDay3Game1.Text = FRGroupStage.Day3.Match[0].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                FRDay3Game2.Text = FRGroupStage.Day3.Match[1].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                FRDay3Game3.Text = FRGroupStage.Day3.Match[2].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                FRDay3Game4.Text = FRGroupStage.Day3.Match[3].Date.ToLocalTime().ToString("MMM dd, HH:mm");
                FRDay3Game5.Text = FRGroupStage.Day3.Match[4].Date.ToLocalTime().ToString("MMM dd, HH:mm");


            }

            string[] countryhome = new string[15];
            string[] countryaway = new string[15];
            string[] countryFlaghome = new string[15];
            string[] countryFlagaway = new string[15];

            for (int i = 0; i < 15; i++)
            {
                var country1 = OpeningPage._countries[SKGroupStage.home[i]];
                var country2 = OpeningPage._countries[SKGroupStage.away[i]];
                countryhome[i] = country1.Abbreviation;
                countryaway[i] = country2.Abbreviation;
                countryFlaghome[i] = country1.FlagLocation;
                countryFlagaway[i] = country2.FlagLocation;
            }

            SKDay1Game1T1.Text = countryhome[0];
            SKDay1Game1T2.Text = countryaway[0];
            SKDay1Game1T1png.Source = ImageSource.FromFile(countryFlaghome[0]);
            SKDay1Game1T2png.Source = ImageSource.FromFile(countryFlagaway[0]);
            SKDay1Game1S1.Text = SKGroupStage.scoreHome[0].ToString();
            SKDay1Game1S2.Text = SKGroupStage.scoreAway[0].ToString();

            SKDay1Game2T1.Text = countryhome[1];
            SKDay1Game2T2.Text = countryaway[1];
            SKDay1Game2T1png.Source = ImageSource.FromFile(countryFlaghome[1]);
            SKDay1Game2T2png.Source = ImageSource.FromFile(countryFlagaway[1]);
            SKDay1Game2S1.Text = SKGroupStage.scoreHome[1].ToString();
            SKDay1Game2S2.Text = SKGroupStage.scoreAway[1].ToString();

            SKDay1Game3T1.Text = countryhome[2];
            SKDay1Game3T2.Text = countryaway[2];
            SKDay1Game3T1png.Source = ImageSource.FromFile(countryFlaghome[2]);
            SKDay1Game3T2png.Source = ImageSource.FromFile(countryFlagaway[2]);
            SKDay1Game3S1.Text = SKGroupStage.scoreHome[2].ToString();
            SKDay1Game3S2.Text = SKGroupStage.scoreAway[2].ToString();

            SKDay1Game4T1.Text = countryhome[3];
            SKDay1Game4T2.Text = countryaway[3];
            SKDay1Game4T1png.Source = ImageSource.FromFile(countryFlaghome[3]);
            SKDay1Game4T2png.Source = ImageSource.FromFile(countryFlagaway[3]);
            SKDay1Game4S1.Text = SKGroupStage.scoreHome[3].ToString();
            SKDay1Game4S2.Text = SKGroupStage.scoreAway[3].ToString();

            SKDay1Game5T1.Text = countryhome[4];
            SKDay1Game5T2.Text = countryaway[4];
            SKDay1Game5T1png.Source = ImageSource.FromFile(countryFlaghome[4]);
            SKDay1Game5T2png.Source = ImageSource.FromFile(countryFlagaway[4]);
            SKDay1Game5S1.Text = SKGroupStage.scoreHome[4].ToString();
            SKDay1Game5S2.Text = SKGroupStage.scoreAway[4].ToString();

            SKDay2Game1T1.Text = countryhome[5];
            SKDay2Game1T2.Text = countryaway[5];
            SKDay2Game1T1png.Source = ImageSource.FromFile(countryFlaghome[5]);
            SKDay2Game1T2png.Source = ImageSource.FromFile(countryFlagaway[5]);
            SKDay2Game1S1.Text = SKGroupStage.scoreHome[5].ToString();
            SKDay2Game1S2.Text = SKGroupStage.scoreAway[5].ToString();

            SKDay2Game2T1.Text = countryhome[6];
            SKDay2Game2T2.Text = countryaway[6];
            SKDay2Game2T1png.Source = ImageSource.FromFile(countryFlaghome[6]);
            SKDay2Game2T2png.Source = ImageSource.FromFile(countryFlagaway[6]);
            SKDay2Game2S1.Text = SKGroupStage.scoreHome[6].ToString();
            SKDay2Game2S2.Text = SKGroupStage.scoreAway[6].ToString();

            SKDay2Game3T1.Text = countryhome[7];
            SKDay2Game3T2.Text = countryaway[7];
            SKDay2Game3T1png.Source = ImageSource.FromFile(countryFlaghome[7]);
            SKDay2Game3T2png.Source = ImageSource.FromFile(countryFlagaway[7]);
            SKDay2Game3S1.Text = SKGroupStage.scoreHome[7].ToString();
            SKDay2Game3S2.Text = SKGroupStage.scoreAway[7].ToString();

            SKDay2Game4T1.Text = countryhome[8];
            SKDay2Game4T2.Text = countryaway[8];
            SKDay2Game4T1png.Source = ImageSource.FromFile(countryFlaghome[8]);
            SKDay2Game4T2png.Source = ImageSource.FromFile(countryFlagaway[8]);
            SKDay2Game4S1.Text = SKGroupStage.scoreHome[8].ToString();
            SKDay2Game4S2.Text = SKGroupStage.scoreAway[8].ToString();

            SKDay2Game5T1.Text = countryhome[9];
            SKDay2Game5T2.Text = countryaway[9];
            SKDay2Game5T1png.Source = ImageSource.FromFile(countryFlaghome[9]);
            SKDay2Game5T2png.Source = ImageSource.FromFile(countryFlagaway[9]);
            SKDay2Game5S1.Text = SKGroupStage.scoreHome[9].ToString();
            SKDay2Game5S2.Text = SKGroupStage.scoreAway[9].ToString();

            SKDay3Game1T1.Text = countryhome[10];
            SKDay3Game1T2.Text = countryaway[10];
            SKDay3Game1T1png.Source = ImageSource.FromFile(countryFlaghome[10]);
            SKDay3Game1T2png.Source = ImageSource.FromFile(countryFlagaway[10]);
            SKDay3Game1S1.Text = SKGroupStage.scoreHome[10].ToString();
            SKDay3Game1S2.Text = SKGroupStage.scoreAway[10].ToString();

            SKDay3Game2T1.Text = countryhome[11];
            SKDay3Game2T2.Text = countryaway[11];
            SKDay3Game2T1png.Source = ImageSource.FromFile(countryFlaghome[11]);
            SKDay3Game2T2png.Source = ImageSource.FromFile(countryFlagaway[11]);
            SKDay3Game2S1.Text = SKGroupStage.scoreHome[11].ToString();
            SKDay3Game2S2.Text = SKGroupStage.scoreAway[11].ToString();

            SKDay3Game3T1.Text = countryhome[12];
            SKDay3Game3T2.Text = countryaway[12];
            SKDay3Game3T1png.Source = ImageSource.FromFile(countryFlaghome[12]);
            SKDay3Game3T2png.Source = ImageSource.FromFile(countryFlagaway[12]);
            SKDay3Game3S1.Text = SKGroupStage.scoreHome[12].ToString();
            SKDay3Game3S2.Text = SKGroupStage.scoreAway[12].ToString();

            SKDay3Game4T1.Text = countryhome[13];
            SKDay3Game4T2.Text = countryaway[13];
            SKDay3Game4T1png.Source = ImageSource.FromFile(countryFlaghome[13]);
            SKDay3Game4T2png.Source = ImageSource.FromFile(countryFlagaway[13]);
            SKDay3Game4S1.Text = SKGroupStage.scoreHome[13].ToString();
            SKDay3Game4S2.Text = SKGroupStage.scoreAway[13].ToString();

            SKDay3Game5T1.Text = countryhome[14];
            SKDay3Game5T2.Text = countryaway[14];
            SKDay3Game5T1png.Source = ImageSource.FromFile(countryFlaghome[14]);
            SKDay3Game5T2png.Source = ImageSource.FromFile(countryFlagaway[14]);
            SKDay3Game5S1.Text = SKGroupStage.scoreHome[14].ToString();
            SKDay3Game5S2.Text = SKGroupStage.scoreAway[14].ToString();

            for (int i = 0; i < 15; i++)
            {
                var country1 = OpeningPage._countries[LAGroupStage.home[i]];
                var country2 = OpeningPage._countries[LAGroupStage.away[i]];
                countryhome[i] = country1.Abbreviation;
                countryaway[i] = country2.Abbreviation;
                countryFlaghome[i] = country1.FlagLocation;
                countryFlagaway[i] = country2.FlagLocation;
            }

            LADay1Game1T1.Text = countryhome[0];
            LADay1Game1T2.Text = countryaway[0];
            LADay1Game1T1png.Source = ImageSource.FromFile(countryFlaghome[0]);
            LADay1Game1T2png.Source = ImageSource.FromFile(countryFlagaway[0]);
            LADay1Game1S1.Text = LAGroupStage.scoreHome[0].ToString();
            LADay1Game1S2.Text = LAGroupStage.scoreAway[0].ToString();

            LADay1Game2T1.Text = countryhome[1];
            LADay1Game2T2.Text = countryaway[1];
            LADay1Game2T1png.Source = ImageSource.FromFile(countryFlaghome[1]);
            LADay1Game2T2png.Source = ImageSource.FromFile(countryFlagaway[1]);
            LADay1Game2S1.Text = LAGroupStage.scoreHome[1].ToString();
            LADay1Game2S2.Text = LAGroupStage.scoreAway[1].ToString();

            LADay1Game3T1.Text = countryhome[2];
            LADay1Game3T2.Text = countryaway[2];
            LADay1Game3T1png.Source = ImageSource.FromFile(countryFlaghome[2]);
            LADay1Game3T2png.Source = ImageSource.FromFile(countryFlagaway[2]);
            LADay1Game3S1.Text = LAGroupStage.scoreHome[2].ToString();
            LADay1Game3S2.Text = LAGroupStage.scoreAway[2].ToString();

            LADay1Game4T1.Text = countryhome[3];
            LADay1Game4T2.Text = countryaway[3];
            LADay1Game4T1png.Source = ImageSource.FromFile(countryFlaghome[3]);
            LADay1Game4T2png.Source = ImageSource.FromFile(countryFlagaway[3]);
            LADay1Game4S1.Text = LAGroupStage.scoreHome[3].ToString();
            LADay1Game4S2.Text = LAGroupStage.scoreAway[3].ToString();

            LADay1Game5T1.Text = countryhome[4];
            LADay1Game5T2.Text = countryaway[4];
            LADay1Game5T1png.Source = ImageSource.FromFile(countryFlaghome[4]);
            LADay1Game5T2png.Source = ImageSource.FromFile(countryFlagaway[4]);
            LADay1Game5S1.Text = LAGroupStage.scoreHome[4].ToString();
            LADay1Game5S2.Text = LAGroupStage.scoreAway[4].ToString();

            LADay2Game1T1.Text = countryhome[5];
            LADay2Game1T2.Text = countryaway[5];
            LADay2Game1T1png.Source = ImageSource.FromFile(countryFlaghome[5]);
            LADay2Game1T2png.Source = ImageSource.FromFile(countryFlagaway[5]);
            LADay2Game1S1.Text = LAGroupStage.scoreHome[5].ToString();
            LADay2Game1S2.Text = LAGroupStage.scoreAway[5].ToString();

            LADay2Game2T1.Text = countryhome[6];
            LADay2Game2T2.Text = countryaway[6];
            LADay2Game2T1png.Source = ImageSource.FromFile(countryFlaghome[6]);
            LADay2Game2T2png.Source = ImageSource.FromFile(countryFlagaway[6]);
            LADay2Game2S1.Text = LAGroupStage.scoreHome[6].ToString();
            LADay2Game2S2.Text = LAGroupStage.scoreAway[6].ToString();

            LADay2Game3T1.Text = countryhome[7];
            LADay2Game3T2.Text = countryaway[7];
            LADay2Game3T1png.Source = ImageSource.FromFile(countryFlaghome[7]);
            LADay2Game3T2png.Source = ImageSource.FromFile(countryFlagaway[7]);
            LADay2Game3S1.Text = LAGroupStage.scoreHome[7].ToString();
            LADay2Game3S2.Text = LAGroupStage.scoreAway[7].ToString();

            LADay2Game4T1.Text = countryhome[8];
            LADay2Game4T2.Text = countryaway[8];
            LADay2Game4T1png.Source = ImageSource.FromFile(countryFlaghome[8]);
            LADay2Game4T2png.Source = ImageSource.FromFile(countryFlagaway[8]);
            LADay2Game4S1.Text = LAGroupStage.scoreHome[8].ToString();
            LADay2Game4S2.Text = LAGroupStage.scoreAway[8].ToString();

            LADay2Game5T1.Text = countryhome[9];
            LADay2Game5T2.Text = countryaway[9];
            LADay2Game5T1png.Source = ImageSource.FromFile(countryFlaghome[9]);
            LADay2Game5T2png.Source = ImageSource.FromFile(countryFlagaway[9]);
            LADay2Game5S1.Text = LAGroupStage.scoreHome[9].ToString();
            LADay2Game5S2.Text = LAGroupStage.scoreAway[9].ToString();

            LADay3Game1T1.Text = countryhome[10];
            LADay3Game1T2.Text = countryaway[10];
            LADay3Game1T1png.Source = ImageSource.FromFile(countryFlaghome[10]);
            LADay3Game1T2png.Source = ImageSource.FromFile(countryFlagaway[10]);
            LADay3Game1S1.Text = LAGroupStage.scoreHome[10].ToString();
            LADay3Game1S2.Text = LAGroupStage.scoreAway[10].ToString();

            LADay3Game2T1.Text = countryhome[11];
            LADay3Game2T2.Text = countryaway[11];
            LADay3Game2T1png.Source = ImageSource.FromFile(countryFlaghome[11]);
            LADay3Game2T2png.Source = ImageSource.FromFile(countryFlagaway[11]);
            LADay3Game2S1.Text = LAGroupStage.scoreHome[11].ToString();
            LADay3Game2S2.Text = LAGroupStage.scoreAway[11].ToString();

            LADay3Game3T1.Text = countryhome[12];
            LADay3Game3T2.Text = countryaway[12];
            LADay3Game3T1png.Source = ImageSource.FromFile(countryFlaghome[12]);
            LADay3Game3T2png.Source = ImageSource.FromFile(countryFlagaway[12]);
            LADay3Game3S1.Text = LAGroupStage.scoreHome[12].ToString();
            LADay3Game3S2.Text = LAGroupStage.scoreAway[12].ToString();

            LADay3Game4T1.Text = countryhome[13];
            LADay3Game4T2.Text = countryaway[13];
            LADay3Game4T1png.Source = ImageSource.FromFile(countryFlaghome[13]);
            LADay3Game4T2png.Source = ImageSource.FromFile(countryFlagaway[13]);
            LADay3Game4S1.Text = LAGroupStage.scoreHome[13].ToString();
            LADay3Game4S2.Text = LAGroupStage.scoreAway[13].ToString();

            LADay3Game5T1.Text = countryhome[14];
            LADay3Game5T2.Text = countryaway[14];
            LADay3Game5T1png.Source = ImageSource.FromFile(countryFlaghome[14]);
            LADay3Game5T2png.Source = ImageSource.FromFile(countryFlagaway[14]);
            LADay3Game5S1.Text = LAGroupStage.scoreHome[14].ToString();
            LADay3Game5S2.Text = LAGroupStage.scoreAway[14].ToString();



            for (int i = 0; i < 15; i++)
            {
                var country1 = OpeningPage._countries[THGroupStage.home[i]];
                var country2 = OpeningPage._countries[THGroupStage.away[i]];
                countryhome[i] = country1.Abbreviation;
                countryaway[i] = country2.Abbreviation;
                countryFlaghome[i] = country1.FlagLocation;
                countryFlagaway[i] = country2.FlagLocation;
            }

            THDay1Game1T1.Text = countryhome[0];
            THDay1Game1T2.Text = countryaway[0];
            THDay1Game1T1png.Source = ImageSource.FromFile(countryFlaghome[0]);
            THDay1Game1T2png.Source = ImageSource.FromFile(countryFlagaway[0]);
            THDay1Game1S1.Text = THGroupStage.scoreHome[0].ToString();
            THDay1Game1S2.Text = THGroupStage.scoreAway[0].ToString();

            THDay1Game2T1.Text = countryhome[1];
            THDay1Game2T2.Text = countryaway[1];
            THDay1Game2T1png.Source = ImageSource.FromFile(countryFlaghome[1]);
            THDay1Game2T2png.Source = ImageSource.FromFile(countryFlagaway[1]);
            THDay1Game2S1.Text = THGroupStage.scoreHome[1].ToString();
            THDay1Game2S2.Text = THGroupStage.scoreAway[1].ToString();

            THDay1Game3T1.Text = countryhome[2];
            THDay1Game3T2.Text = countryaway[2];
            THDay1Game3T1png.Source = ImageSource.FromFile(countryFlaghome[2]);
            THDay1Game3T2png.Source = ImageSource.FromFile(countryFlagaway[2]);
            THDay1Game3S1.Text = THGroupStage.scoreHome[2].ToString();
            THDay1Game3S2.Text = THGroupStage.scoreAway[2].ToString();

            THDay1Game4T1.Text = countryhome[3];
            THDay1Game4T2.Text = countryaway[3];
            THDay1Game4T1png.Source = ImageSource.FromFile(countryFlaghome[3]);
            THDay1Game4T2png.Source = ImageSource.FromFile(countryFlagaway[3]);
            THDay1Game4S1.Text = THGroupStage.scoreHome[3].ToString();
            THDay1Game4S2.Text = THGroupStage.scoreAway[3].ToString();

            THDay1Game5T1.Text = countryhome[4];
            THDay1Game5T2.Text = countryaway[4];
            THDay1Game5T1png.Source = ImageSource.FromFile(countryFlaghome[4]);
            THDay1Game5T2png.Source = ImageSource.FromFile(countryFlagaway[4]);
            THDay1Game5S1.Text = THGroupStage.scoreHome[4].ToString();
            THDay1Game5S2.Text = THGroupStage.scoreAway[4].ToString();

            THDay2Game1T1.Text = countryhome[5];
            THDay2Game1T2.Text = countryaway[5];
            THDay2Game1T1png.Source = ImageSource.FromFile(countryFlaghome[5]);
            THDay2Game1T2png.Source = ImageSource.FromFile(countryFlagaway[5]);
            THDay2Game1S1.Text = THGroupStage.scoreHome[5].ToString();
            THDay2Game1S2.Text = THGroupStage.scoreAway[5].ToString();

            THDay2Game2T1.Text = countryhome[6];
            THDay2Game2T2.Text = countryaway[6];
            THDay2Game2T1png.Source = ImageSource.FromFile(countryFlaghome[6]);
            THDay2Game2T2png.Source = ImageSource.FromFile(countryFlagaway[6]);
            THDay2Game2S1.Text = THGroupStage.scoreHome[6].ToString();
            THDay2Game2S2.Text = THGroupStage.scoreAway[6].ToString();

            THDay2Game3T1.Text = countryhome[7];
            THDay2Game3T2.Text = countryaway[7];
            THDay2Game3T1png.Source = ImageSource.FromFile(countryFlaghome[7]);
            THDay2Game3T2png.Source = ImageSource.FromFile(countryFlagaway[7]);
            THDay2Game3S1.Text = THGroupStage.scoreHome[7].ToString();
            THDay2Game3S2.Text = THGroupStage.scoreAway[7].ToString();

            THDay2Game4T1.Text = countryhome[8];
            THDay2Game4T2.Text = countryaway[8];
            THDay2Game4T1png.Source = ImageSource.FromFile(countryFlaghome[8]);
            THDay2Game4T2png.Source = ImageSource.FromFile(countryFlagaway[8]);
            THDay2Game4S1.Text = THGroupStage.scoreHome[8].ToString();
            THDay2Game4S2.Text = THGroupStage.scoreAway[8].ToString();

            THDay2Game5T1.Text = countryhome[9];
            THDay2Game5T2.Text = countryaway[9];
            THDay2Game5T1png.Source = ImageSource.FromFile(countryFlaghome[9]);
            THDay2Game5T2png.Source = ImageSource.FromFile(countryFlagaway[9]);
            THDay2Game5S1.Text = THGroupStage.scoreHome[9].ToString();
            THDay2Game5S2.Text = THGroupStage.scoreAway[9].ToString();

            THDay3Game1T1.Text = countryhome[10];
            THDay3Game1T2.Text = countryaway[10];
            THDay3Game1T1png.Source = ImageSource.FromFile(countryFlaghome[10]);
            THDay3Game1T2png.Source = ImageSource.FromFile(countryFlagaway[10]);
            THDay3Game1S1.Text = THGroupStage.scoreHome[10].ToString();
            THDay3Game1S2.Text = THGroupStage.scoreAway[10].ToString();

            THDay3Game2T1.Text = countryhome[11];
            THDay3Game2T2.Text = countryaway[11];
            THDay3Game2T1png.Source = ImageSource.FromFile(countryFlaghome[11]);
            THDay3Game2T2png.Source = ImageSource.FromFile(countryFlagaway[11]);
            THDay3Game2S1.Text = THGroupStage.scoreHome[11].ToString();
            THDay3Game2S2.Text = THGroupStage.scoreAway[11].ToString();

            THDay3Game3T1.Text = countryhome[12];
            THDay3Game3T2.Text = countryaway[12];
            THDay3Game3T1png.Source = ImageSource.FromFile(countryFlaghome[12]);
            THDay3Game3T2png.Source = ImageSource.FromFile(countryFlagaway[12]);
            THDay3Game3S1.Text = THGroupStage.scoreHome[12].ToString();
            THDay3Game3S2.Text = THGroupStage.scoreAway[12].ToString();

            THDay3Game4T1.Text = countryhome[13];
            THDay3Game4T2.Text = countryaway[13];
            THDay3Game4T1png.Source = ImageSource.FromFile(countryFlaghome[13]);
            THDay3Game4T2png.Source = ImageSource.FromFile(countryFlagaway[13]);
            THDay3Game4S1.Text = THGroupStage.scoreHome[13].ToString();
            THDay3Game4S2.Text = THGroupStage.scoreAway[13].ToString();

            THDay3Game5T1.Text = countryhome[14];
            THDay3Game5T2.Text = countryaway[14];
            THDay3Game5T1png.Source = ImageSource.FromFile(countryFlaghome[14]);
            THDay3Game5T2png.Source = ImageSource.FromFile(countryFlagaway[14]);
            THDay3Game5S1.Text = THGroupStage.scoreHome[14].ToString();
            THDay3Game5S2.Text = THGroupStage.scoreAway[14].ToString();

            string temp;
            if (OpeningPage.docFR.DocumentNode.SelectNodes("//*[@id='wrapper']/div[1]/div/div[4]/a[1]/div[4]/div[1]/div[1]/div/text()")[1].InnerText.Contains(FRGroupStage.home[0]))
            {
                var country1 = OpeningPage._countries[FRGroupStage.home[0]];
                var country2 = OpeningPage._countries[FRGroupStage.away[0]];
                FRDay1Game1T1.Text = country1.Abbreviation;
                FRDay1Game1T2.Text = country2.Abbreviation;
                FRDay1Game1T1png.Source = ImageSource.FromFile(country1.FlagLocation);
                FRDay1Game1T2png.Source = ImageSource.FromFile(country2.FlagLocation);

                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[1]/div[4]/div[1]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                if (index > 0)
                {
                    FRDay1Game1S1.Text = temp.Substring(index, 1);
                    xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[1]/div[4]/div[2]/div[2]";
                    temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                    regex = new Regex("[0-9]");
                    match = regex.Match(temp);
                    index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                    FRDay1Game1S2.Text = temp.Substring(index, 1);
                    if (int.Parse(FRDay1Game1S1.Text) > int.Parse(FRDay1Game1S2.Text))
                    {
                        FRDay1Game1S1Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                    else
                    {
                        FRDay1Game1S2Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                }
            }
            else
            {
                var country1 = OpeningPage._countries[FRGroupStage.home[0]];
                var country2 = OpeningPage._countries[FRGroupStage.away[0]];
                FRDay1Game1T1.Text = country1.Abbreviation;
                FRDay1Game1T2.Text = country2.Abbreviation;
                FRDay1Game1T1png.Source = ImageSource.FromFile(country1.FlagLocation);
                FRDay1Game1T2png.Source = ImageSource.FromFile(country2.FlagLocation);
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[1]/div[4]/div[2]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                if (index > 0)
                {
                    var tempo = temp.Substring(index, 1);
                    FRDay1Game1S1.Text = tempo;
                    xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[1]/div[4]/div[1]/div[2]";
                    temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                    regex = new Regex("[0-9]");
                    match = regex.Match(temp);
                    index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                    FRDay1Game1S2.Text = temp.Substring(index, 1);
                    if (int.Parse(FRDay1Game1S1.Text) > int.Parse(FRDay1Game1S2.Text))
                    {
                        FRDay1Game1S1Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                    else
                    {
                        FRDay1Game1S2Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                }
            }

            if (OpeningPage.docFR.DocumentNode.SelectNodes("//*[@id='wrapper']/div[1]/div/div[4]/a[2]/div[4]/div[1]/div[1]/div/text()")[1].InnerText.Contains(FRGroupStage.home[1]))
            {
                var country1 = OpeningPage._countries[FRGroupStage.home[1]];
                var country2 = OpeningPage._countries[FRGroupStage.away[1]];
                FRDay1Game2T1.Text = country1.Abbreviation;
                FRDay1Game2T2.Text = country2.Abbreviation;
                FRDay1Game2T1png.Source = ImageSource.FromFile(country1.FlagLocation);
                FRDay1Game2T2png.Source = ImageSource.FromFile(country2.FlagLocation);

                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[2]/div[4]/div[1]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                if (index > 0)
                {
                    FRDay1Game2S1.Text = temp.Substring(index, 1);
                    xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[2]/div[4]/div[2]/div[2]";
                    temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                    regex = new Regex("[0-9]");
                    match = regex.Match(temp);
                    index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                    FRDay1Game2S2.Text = temp.Substring(index, 1);
                    if (int.Parse(FRDay1Game2S1.Text) > int.Parse(FRDay1Game2S2.Text))
                    {
                        FRDay1Game2S1Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                    else
                    {
                        FRDay1Game1S2Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                }
            }
            else
            {
                var country1 = OpeningPage._countries[FRGroupStage.home[0]];
                var country2 = OpeningPage._countries[FRGroupStage.away[0]];
                FRDay1Game2T1.Text = country1.Abbreviation;
                FRDay1Game2T2.Text = country2.Abbreviation;
                FRDay1Game2T1png.Source = ImageSource.FromFile(country1.FlagLocation);
                FRDay1Game2T2png.Source = ImageSource.FromFile(country2.FlagLocation);
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[2]/div[4]/div[2]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                if (index > 0)
                {
                    var tempo = temp.Substring(index, 1);
                    FRDay1Game2S1.Text = tempo;
                    xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[2]/div[4]/div[1]/div[2]";
                    temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                    regex = new Regex("[0-9]");
                    match = regex.Match(temp);
                    index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                    FRDay1Game2S2.Text = temp.Substring(index, 1);
                    if (int.Parse(FRDay1Game2S1.Text) > int.Parse(FRDay1Game2S2.Text))
                    {
                        FRDay1Game2S1Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                    else
                    {
                        FRDay1Game2S2Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                }
            }

            if (OpeningPage.docFR.DocumentNode.SelectNodes("//*[@id='wrapper']/div[1]/div/div[4]/a[3]/div[4]/div[1]/div[1]/div/text()")[1].InnerText.Contains(FRGroupStage.home[2]))
            {
                var country1 = OpeningPage._countries[FRGroupStage.home[2]];
                var country2 = OpeningPage._countries[FRGroupStage.away[2]];
                FRDay1Game3T1.Text = country1.Abbreviation;
                FRDay1Game3T2.Text = country2.Abbreviation;
                FRDay1Game3T1png.Source = ImageSource.FromFile(country1.FlagLocation);
                FRDay1Game3T2png.Source = ImageSource.FromFile(country2.FlagLocation);

                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[3]/div[4]/div[1]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                if (index > 0)
                {
                    FRDay1Game3S1.Text = temp.Substring(index, 1);
                    xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[3]/div[4]/div[2]/div[2]";
                    temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                    regex = new Regex("[0-9]");
                    match = regex.Match(temp);
                    index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                    FRDay1Game3S2.Text = temp.Substring(index, 1);
                    if (int.Parse(FRDay1Game3S1.Text) > int.Parse(FRDay1Game3S2.Text))
                    {
                        FRDay1Game3S1Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                    else
                    {
                        FRDay1Game3S2Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                }
            }
            else
            {
                var country1 = OpeningPage._countries[FRGroupStage.home[2]];
                var country2 = OpeningPage._countries[FRGroupStage.away[2]];
                FRDay1Game3T1.Text = country1.Abbreviation;
                FRDay1Game3T2.Text = country2.Abbreviation;
                FRDay1Game3T1png.Source = ImageSource.FromFile(country1.FlagLocation);
                FRDay1Game3T2png.Source = ImageSource.FromFile(country2.FlagLocation);
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[3]/div[4]/div[2]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                if (index > 0)
                {
                    var tempo = temp.Substring(index, 1);
                    FRDay1Game3S1.Text = tempo;
                    xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[3]/div[4]/div[1]/div[2]";
                    temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                    regex = new Regex("[0-9]");
                    match = regex.Match(temp);
                    index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                    FRDay1Game3S2.Text = temp.Substring(index, 1);
                    if (int.Parse(FRDay1Game3S1.Text) > int.Parse(FRDay1Game3S2.Text))
                    {
                        FRDay1Game3S1Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                    else
                    {
                        FRDay1Game3S2Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                }
            }

            if (OpeningPage.docFR.DocumentNode.SelectNodes("//*[@id='wrapper']/div[1]/div/div[4]/a[4]/div[4]/div[1]/div[1]/div/text()")[1].InnerText.Contains(FRGroupStage.home[3]))
            {
                var country1 = OpeningPage._countries[FRGroupStage.home[3]];
                var country2 = OpeningPage._countries[FRGroupStage.away[3]];
                FRDay1Game4T1.Text = country1.Abbreviation;
                FRDay1Game4T2.Text = country2.Abbreviation;
                FRDay1Game4T1png.Source = ImageSource.FromFile(country1.FlagLocation);
                FRDay1Game4T2png.Source = ImageSource.FromFile(country2.FlagLocation);

                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[4]/div[4]/div[1]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                if (index > 0)
                {
                    FRDay1Game4S1.Text = temp.Substring(index, 1);
                    xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[4]/div[4]/div[2]/div[2]";
                    temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                    regex = new Regex("[0-9]");
                    match = regex.Match(temp);
                    index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                    FRDay1Game4S2.Text = temp.Substring(index, 1);
                    if (int.Parse(FRDay1Game4S1.Text) > int.Parse(FRDay1Game4S2.Text))
                    {
                        FRDay1Game4S1Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                    else
                    {
                        FRDay1Game4S2Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                }
            }
            else
            {
                var country1 = OpeningPage._countries[FRGroupStage.home[3]];
                var country2 = OpeningPage._countries[FRGroupStage.away[3]];
                FRDay1Game4T1.Text = country1.Abbreviation;
                FRDay1Game4T2.Text = country2.Abbreviation;
                FRDay1Game4T1png.Source = ImageSource.FromFile(country1.FlagLocation);
                FRDay1Game4T2png.Source = ImageSource.FromFile(country2.FlagLocation);
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[4]/div[4]/div[2]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                if (index > 0)
                {
                    var tempo = temp.Substring(index, 1);
                    FRDay1Game4S1.Text = tempo;
                    xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[4]/div[4]/div[1]/div[2]";
                    temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                    regex = new Regex("[0-9]");
                    match = regex.Match(temp);
                    index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                    FRDay1Game4S2.Text = temp.Substring(index, 1);
                    if (int.Parse(FRDay1Game4S1.Text) > int.Parse(FRDay1Game4S2.Text))
                    {
                        FRDay1Game4S1Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                    else
                    {
                        FRDay1Game4S2Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                }
            }

            if (OpeningPage.docFR.DocumentNode.SelectNodes("//*[@id='wrapper']/div[1]/div/div[4]/a[5]/div[4]/div[1]/div[1]/div/text()")[1].InnerText.Contains(FRGroupStage.home[4]))
            {
                var country1 = OpeningPage._countries[FRGroupStage.home[4]];
                var country2 = OpeningPage._countries[FRGroupStage.away[4]];
                FRDay1Game5T1.Text = country1.Abbreviation;
                FRDay1Game5T2.Text = country2.Abbreviation;
                FRDay1Game5T1png.Source = ImageSource.FromFile(country1.FlagLocation);
                FRDay1Game5T2png.Source = ImageSource.FromFile(country2.FlagLocation);

                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[5]/div[4]/div[1]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                if (index > 0)
                {
                    FRDay1Game5S1.Text = temp.Substring(index, 1);
                    xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[5]/div[4]/div[2]/div[2]";
                    temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                    regex = new Regex("[0-9]");
                    match = regex.Match(temp);
                    index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                    FRDay1Game5S2.Text = temp.Substring(index, 1);
                    if (int.Parse(FRDay1Game5S1.Text) > int.Parse(FRDay1Game5S2.Text))
                    {
                        FRDay1Game5S1Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                    else
                    {
                        FRDay1Game5S2Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                }
            }
            else
            {
                var country1 = OpeningPage._countries[FRGroupStage.home[4]];
                var country2 = OpeningPage._countries[FRGroupStage.away[4]];
                FRDay1Game5T1.Text = country1.Abbreviation;
                FRDay1Game5T2.Text = country2.Abbreviation;
                FRDay1Game5T1png.Source = ImageSource.FromFile(country1.FlagLocation);
                FRDay1Game5T1png.Source = ImageSource.FromFile(country2.FlagLocation);
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[5]/div[4]/div[2]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                if (index > 0)
                {
                    var tempo = temp.Substring(index, 1);
                    FRDay1Game5S1.Text = tempo;
                    xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[5]/div[4]/div[1]/div[2]";
                    temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                    regex = new Regex("[0-9]");
                    match = regex.Match(temp);
                    index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                    FRDay1Game5S2.Text = temp.Substring(index, 1);
                    if (int.Parse(FRDay1Game5S1.Text) > int.Parse(FRDay1Game5S2.Text))
                    {
                        FRDay1Game5S1Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                    else
                    {
                        FRDay1Game5S2Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                }
            }

            if (OpeningPage.docFR.DocumentNode.SelectNodes("//*[@id='wrapper']/div[1]/div/div[4]/a[6]/div[4]/div[1]/div[1]/div/text()")[1].InnerText.Contains(FRGroupStage.home[5]))
            {
                var country1 = OpeningPage._countries[FRGroupStage.home[5]];
                var country2 = OpeningPage._countries[FRGroupStage.away[5]];
                FRDay2Game1T1.Text = country1.Abbreviation;
                FRDay2Game1T2.Text = country2.Abbreviation;
                FRDay2Game1T1png.Source = ImageSource.FromFile(country1.FlagLocation);
                FRDay2Game1T2png.Source = ImageSource.FromFile(country2.FlagLocation);

                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[6]/div[4]/div[1]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                if (index > 0)
                {
                    FRDay2Game1S1.Text = temp.Substring(index, 1);
                    xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[6]/div[4]/div[2]/div[2]";
                    temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                    regex = new Regex("[0-9]");
                    match = regex.Match(temp);
                    index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                    FRDay2Game1S2.Text = temp.Substring(index, 1);
                    if (int.Parse(FRDay2Game1S1.Text) > int.Parse(FRDay2Game1S2.Text))
                    {
                        FRDay2Game1S1Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                    else
                    {
                        FRDay2Game1S2Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                }
            }
            else
            {
                var country1 = OpeningPage._countries[FRGroupStage.home[5]];
                var country2 = OpeningPage._countries[FRGroupStage.away[5]];
                FRDay2Game1T1.Text = country1.Abbreviation;
                FRDay2Game1T2.Text = country2.Abbreviation;
                FRDay2Game1T1png.Source = ImageSource.FromFile(country1.FlagLocation);
                FRDay2Game1T2png.Source = ImageSource.FromFile(country2.FlagLocation);
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[6]/div[4]/div[2]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                if (index > 0)
                {
                    var tempo = temp.Substring(index, 1);
                    FRDay2Game1S1.Text = tempo;
                    xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[6]/div[4]/div[1]/div[2]";
                    temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                    regex = new Regex("[0-9]");
                    match = regex.Match(temp);
                    index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                    FRDay2Game1S2.Text = temp.Substring(index, 1);
                    if (int.Parse(FRDay2Game1S1.Text) > int.Parse(FRDay2Game1S2.Text))
                    {
                        FRDay2Game1S1Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                    else
                    {
                        FRDay2Game1S2Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                }
            }
            if (OpeningPage.docFR.DocumentNode.SelectNodes("//*[@id='wrapper']/div[1]/div/div[4]/a[7]/div[4]/div[1]/div[1]/div/text()")[1].InnerText.Contains(FRGroupStage.home[6]))
            {
                var country1 = OpeningPage._countries[FRGroupStage.home[6]];
                var country2 = OpeningPage._countries[FRGroupStage.away[6]];
                FRDay2Game2T1.Text = country1.Abbreviation;
                FRDay2Game2T2.Text = country2.Abbreviation;
                FRDay2Game2T1png.Source = ImageSource.FromFile(country1.FlagLocation);
                FRDay2Game2T2png.Source = ImageSource.FromFile(country2.FlagLocation);

                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[7]/div[4]/div[1]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                if (index > 0)
                {
                    FRDay2Game2S1.Text = temp.Substring(index, 1);
                    xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[7]/div[4]/div[2]/div[2]";
                    temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                    regex = new Regex("[0-9]");
                    match = regex.Match(temp);
                    index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                    FRDay2Game2S2.Text = temp.Substring(index, 1);
                    if (int.Parse(FRDay2Game2S1.Text) > int.Parse(FRDay2Game2S2.Text))
                    {
                        FRDay2Game2S1Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                    else
                    {
                        FRDay2Game2S2Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                }
            }
            else
            {
                var country1 = OpeningPage._countries[FRGroupStage.home[6]];
                var country2 = OpeningPage._countries[FRGroupStage.away[6]];
                FRDay2Game2T1.Text = country1.Abbreviation;
                FRDay2Game2T2.Text = country2.Abbreviation;
                FRDay2Game2T1png.Source = ImageSource.FromFile(country1.FlagLocation);
                FRDay2Game2T2png.Source = ImageSource.FromFile(country2.FlagLocation);
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[7]/div[4]/div[2]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                if (index > 0)
                {
                    var tempo = temp.Substring(index, 1);
                    FRDay2Game2S1.Text = tempo;
                    xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[7]/div[4]/div[1]/div[2]";
                    temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                    regex = new Regex("[0-9]");
                    match = regex.Match(temp);
                    index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                    FRDay2Game2S2.Text = temp.Substring(index, 1);
                    if (int.Parse(FRDay2Game2S1.Text) > int.Parse(FRDay2Game2S2.Text))
                    {
                        FRDay2Game2S1Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                    else
                    {
                        FRDay2Game2S2Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                }
            }
            if (OpeningPage.docFR.DocumentNode.SelectNodes("//*[@id='wrapper']/div[1]/div/div[4]/a[8]/div[4]/div[1]/div[1]/div/text()")[1].InnerText.Contains(FRGroupStage.home[7]))
            {
                var country1 = OpeningPage._countries[FRGroupStage.home[7]];
                var country2 = OpeningPage._countries[FRGroupStage.away[7]];
                FRDay2Game3T1.Text = country1.Abbreviation;
                FRDay2Game3T2.Text = country2.Abbreviation;
                FRDay2Game3T1png.Source = ImageSource.FromFile(country1.FlagLocation);
                FRDay2Game3T2png.Source = ImageSource.FromFile(country2.FlagLocation);

                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[8]/div[4]/div[1]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                if (index > 0)
                {
                    FRDay2Game3S1.Text = temp.Substring(index, 1);
                    xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[8]/div[4]/div[2]/div[2]";
                    temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                    regex = new Regex("[0-9]");
                    match = regex.Match(temp);
                    index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                    FRDay2Game3S2.Text = temp.Substring(index, 1);
                    if (int.Parse(FRDay2Game3S1.Text) > int.Parse(FRDay2Game3S2.Text))
                    {
                        FRDay2Game3S1Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                    else
                    {
                        FRDay2Game3S2Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                }
            }
            else
            {
                var country1 = OpeningPage._countries[FRGroupStage.home[7]];
                var country2 = OpeningPage._countries[FRGroupStage.away[7]];
                FRDay2Game3T1.Text = country1.Abbreviation;
                FRDay2Game3T2.Text = country2.Abbreviation;
                FRDay2Game3T1png.Source = ImageSource.FromFile(country1.FlagLocation);
                FRDay2Game3T1png.Source = ImageSource.FromFile(country2.FlagLocation);
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[8]/div[4]/div[2]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                if (index > 0)
                {
                    var tempo = temp.Substring(index, 1);
                    FRDay2Game3S1.Text = tempo;
                    xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[8]/div[4]/div[1]/div[2]";
                    temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                    regex = new Regex("[0-9]");
                    match = regex.Match(temp);
                    index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                    FRDay2Game3S2.Text = temp.Substring(index, 1);
                    if (int.Parse(FRDay2Game3S1.Text) > int.Parse(FRDay2Game3S2.Text))
                    {
                        FRDay2Game3S1Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                    else
                    {
                        FRDay2Game3S2Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                }
            }

            if (OpeningPage.docFR.DocumentNode.SelectNodes("//*[@id='wrapper']/div[1]/div/div[4]/a[9]/div[4]/div[1]/div[1]/div/text()")[1].InnerText.Contains(FRGroupStage.home[8]))
            {
                var country1 = OpeningPage._countries[FRGroupStage.home[8]];
                var country2 = OpeningPage._countries[FRGroupStage.away[8]];
                FRDay2Game4T1.Text = country1.Abbreviation;
                FRDay2Game4T2.Text = country2.Abbreviation;
                FRDay2Game4T1png.Source = ImageSource.FromFile(country1.FlagLocation);
                FRDay2Game4T2png.Source = ImageSource.FromFile(country2.FlagLocation);

                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[9]/div[4]/div[1]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                if (index > 0)
                {
                    FRDay2Game4S1.Text = temp.Substring(index, 1);
                    xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[9]/div[4]/div[2]/div[2]";
                    temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                    regex = new Regex("[0-9]");
                    match = regex.Match(temp);
                    index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                    FRDay2Game4S2.Text = temp.Substring(index, 1);
                    if (int.Parse(FRDay2Game4S1.Text) > int.Parse(FRDay2Game4S2.Text))
                    {
                        FRDay2Game4S1Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                    else
                    {
                        FRDay2Game4S2Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                }
            }
            else
            {
                var country1 = OpeningPage._countries[FRGroupStage.home[8]];
                var country2 = OpeningPage._countries[FRGroupStage.away[8]];
                FRDay2Game4T1.Text = country1.Abbreviation;
                FRDay2Game4T2.Text = country2.Abbreviation;
                FRDay2Game4T1png.Source = ImageSource.FromFile(country1.FlagLocation);
                FRDay2Game4T2png.Source = ImageSource.FromFile(country2.FlagLocation);
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[9]/div[4]/div[2]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                if (index > 0)
                {
                    var tempo = temp.Substring(index, 1);
                    FRDay2Game4S1.Text = tempo;
                    xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[9]/div[4]/div[1]/div[2]";
                    temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                    regex = new Regex("[0-9]");
                    match = regex.Match(temp);
                    index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                    FRDay2Game4S2.Text = temp.Substring(index, 1);
                    if (int.Parse(FRDay2Game4S1.Text) > int.Parse(FRDay2Game4S2.Text))
                    {
                        FRDay2Game4S1Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                    else
                    {
                        FRDay2Game4S2Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                }
            }
            if (OpeningPage.docFR.DocumentNode.SelectNodes("//*[@id='wrapper']/div[1]/div/div[4]/a[10]/div[4]/div[1]/div[1]/div/text()")[1].InnerText.Contains(FRGroupStage.home[9]))
            {
                var country1 = OpeningPage._countries[FRGroupStage.home[9]];
                var country2 = OpeningPage._countries[FRGroupStage.away[9]];
                FRDay2Game5T1.Text = country1.Abbreviation;
                FRDay2Game5T2.Text = country2.Abbreviation;
                FRDay2Game5T1png.Source = ImageSource.FromFile(country1.FlagLocation);
                FRDay2Game5T2png.Source = ImageSource.FromFile(country2.FlagLocation);

                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[10]/div[4]/div[1]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                if (index > 0)
                {
                    FRDay2Game5S1.Text = temp.Substring(index, 1);
                    xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[10]/div[4]/div[2]/div[2]";
                    temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                    regex = new Regex("[0-9]");
                    match = regex.Match(temp);
                    index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                    FRDay2Game5S2.Text = temp.Substring(index, 1);
                    if (int.Parse(FRDay2Game5S1.Text) > int.Parse(FRDay2Game5S2.Text))
                    {
                        FRDay2Game5S1Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                    else
                    {
                        FRDay2Game5S2Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                }
            }
            else
            {
                var country1 = OpeningPage._countries[FRGroupStage.home[9]];
                var country2 = OpeningPage._countries[FRGroupStage.away[9]];
                FRDay2Game5T1.Text = country1.Abbreviation;
                FRDay2Game5T2.Text = country2.Abbreviation;
                FRDay2Game5T1png.Source = ImageSource.FromFile(country1.FlagLocation);
                FRDay2Game5T2png.Source = ImageSource.FromFile(country2.FlagLocation);
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[10]/div[4]/div[2]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                if (index > 0)
                {
                    var tempo = temp.Substring(index, 1);
                    FRDay2Game5S1.Text = tempo;
                    xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[10]/div[4]/div[1]/div[2]";
                    temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                    regex = new Regex("[0-9]");
                    match = regex.Match(temp);
                    index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                    FRDay2Game5S2.Text = temp.Substring(index, 1);
                    if (int.Parse(FRDay2Game5S1.Text) > int.Parse(FRDay2Game5S2.Text))
                    {
                        FRDay2Game5S1Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                    else
                    {
                        FRDay2Game5S2Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                }
            }

            if (OpeningPage.docFR.DocumentNode.SelectNodes("//*[@id='wrapper']/div[1]/div/div[4]/a[11]/div[4]/div[1]/div[1]/div/text()")[1].InnerText.Contains(FRGroupStage.home[10]))
            {
                var country1 = OpeningPage._countries[FRGroupStage.home[10]];
                var country2 = OpeningPage._countries[FRGroupStage.away[10]];
                FRDay3Game1T1.Text = country1.Abbreviation;
                FRDay3Game1T2.Text = country2.Abbreviation;
                FRDay3Game1T1png.Source = ImageSource.FromFile(country1.FlagLocation);
                FRDay3Game1T2png.Source = ImageSource.FromFile(country2.FlagLocation);

                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[11]/div[4]/div[1]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                if (index > 0)
                {
                    FRDay3Game1S1.Text = temp.Substring(index, 1);
                    xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[11]/div[4]/div[2]/div[2]";
                    temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                    regex = new Regex("[0-9]");
                    match = regex.Match(temp);
                    index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                    FRDay3Game1S2.Text = temp.Substring(index, 1);
                    if (int.Parse(FRDay3Game1S1.Text) > int.Parse(FRDay3Game1S2.Text))
                    {
                        FRDay3Game1S1Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                    else
                    {
                        FRDay3Game1S2Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                }
            }
            else
            {
                var country1 = OpeningPage._countries[FRGroupStage.home[10]];
                var country2 = OpeningPage._countries[FRGroupStage.away[10]];
                FRDay3Game1T1.Text = country1.Abbreviation;
                FRDay3Game1T2.Text = country2.Abbreviation;
                FRDay3Game1T1png.Source = ImageSource.FromFile(country1.FlagLocation);
                FRDay3Game1T2png.Source = ImageSource.FromFile(country2.FlagLocation);
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[11]/div[4]/div[2]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                if (index > 0)
                {
                    var tempo = temp.Substring(index, 1);
                    FRDay3Game1S1.Text = tempo;
                    xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[11]/div[4]/div[1]/div[2]";
                    temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                    regex = new Regex("[0-9]");
                    match = regex.Match(temp);
                    index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                    FRDay3Game1S2.Text = temp.Substring(index, 1);
                    if (int.Parse(FRDay3Game1S1.Text) > int.Parse(FRDay3Game1S2.Text))
                    {
                        FRDay3Game1S1Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                    else
                    {
                        FRDay3Game1S2Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                }
            }

            if (OpeningPage.docFR.DocumentNode.SelectNodes("//*[@id='wrapper']/div[1]/div/div[4]/a[12]/div[4]/div[1]/div[1]/div/text()")[1].InnerText.Contains(FRGroupStage.home[11]))
            {
                var country1 = OpeningPage._countries[FRGroupStage.home[11]];
                var country2 = OpeningPage._countries[FRGroupStage.away[11]];
                FRDay3Game2T1.Text = country1.Abbreviation;
                FRDay3Game2T2.Text = country2.Abbreviation;
                FRDay3Game2T1png.Source = ImageSource.FromFile(country1.FlagLocation);
                FRDay3Game2T2png.Source = ImageSource.FromFile(country2.FlagLocation);

                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[12]/div[4]/div[1]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                if (index > 0)
                {
                    FRDay3Game2S1.Text = temp.Substring(index, 1);
                    xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[12]/div[4]/div[2]/div[2]";
                    temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                    regex = new Regex("[0-9]");
                    match = regex.Match(temp);
                    index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                    FRDay3Game2S2.Text = temp.Substring(index, 1);
                    if (int.Parse(FRDay3Game2S1.Text) > int.Parse(FRDay3Game2S2.Text))
                    {
                        FRDay3Game2S1Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                    else
                    {
                        FRDay3Game2S2Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                }
            }
            else
            {
                var country1 = OpeningPage._countries[FRGroupStage.home[11]];
                var country2 = OpeningPage._countries[FRGroupStage.away[11]];
                FRDay3Game2T1.Text = country1.Abbreviation;
                FRDay3Game2T2.Text = country2.Abbreviation;
                FRDay3Game2T1png.Source = ImageSource.FromFile(country1.FlagLocation);
                FRDay3Game2T2png.Source = ImageSource.FromFile(country2.FlagLocation);
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[12]/div[4]/div[2]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                if (index > 0)
                {
                    var tempo = temp.Substring(index, 1);
                    FRDay3Game2S1.Text = tempo;
                    xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[12]/div[4]/div[1]/div[2]";
                    temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                    regex = new Regex("[0-9]");
                    match = regex.Match(temp);
                    index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                    FRDay3Game2S2.Text = temp.Substring(index, 1);
                    if (int.Parse(FRDay3Game2S1.Text) > int.Parse(FRDay3Game2S2.Text))
                    {
                        FRDay3Game2S1Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                    else
                    {
                        FRDay3Game2S2Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                }
            }

            if (OpeningPage.docFR.DocumentNode.SelectNodes("//*[@id='wrapper']/div[1]/div/div[4]/a[11]/div[4]/div[1]/div[1]/div/text()")[1].InnerText.Contains(FRGroupStage.home[12]))
            {
                var country1 = OpeningPage._countries[FRGroupStage.home[12]];
                var country2 = OpeningPage._countries[FRGroupStage.away[12]];
                FRDay3Game3T1.Text = country1.Abbreviation;
                FRDay3Game3T2.Text = country2.Abbreviation;
                FRDay3Game3T1png.Source = ImageSource.FromFile(country1.FlagLocation);
                FRDay3Game3T2png.Source = ImageSource.FromFile(country2.FlagLocation);

                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[13]/div[4]/div[1]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                if (index > 0)
                {
                    FRDay3Game3S1.Text = temp.Substring(index, 1);
                    xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[13]/div[4]/div[2]/div[2]";
                    temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                    regex = new Regex("[0-9]");
                    match = regex.Match(temp);
                    index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                    FRDay3Game3S2.Text = temp.Substring(index, 1);
                    if (int.Parse(FRDay3Game3S1.Text) > int.Parse(FRDay3Game3S2.Text))
                    {
                        FRDay3Game3S1Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                    else
                    {
                        FRDay3Game3S2Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                }
            }
            else
            {
                var country1 = OpeningPage._countries[FRGroupStage.home[12]];
                var country2 = OpeningPage._countries[FRGroupStage.away[12]];
                FRDay3Game3T1.Text = country1.Abbreviation;
                FRDay3Game3T2.Text = country2.Abbreviation;
                FRDay3Game3T1png.Source = ImageSource.FromFile(country1.FlagLocation);
                FRDay3Game3T2png.Source = ImageSource.FromFile(country2.FlagLocation);
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[13]/div[4]/div[2]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                if (index > 0)
                {
                    var tempo = temp.Substring(index, 1);
                    FRDay3Game3S1.Text = tempo;
                    xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[13]/div[4]/div[1]/div[2]";
                    temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                    regex = new Regex("[0-9]");
                    match = regex.Match(temp);
                    index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                    FRDay3Game3S2.Text = temp.Substring(index, 1);
                    if (int.Parse(FRDay3Game3S1.Text) > int.Parse(FRDay3Game3S2.Text))
                    {
                        FRDay3Game3S1Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                    else
                    {
                        FRDay3Game3S2Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                }
            }

            if (OpeningPage.docFR.DocumentNode.SelectNodes("//*[@id='wrapper']/div[1]/div/div[4]/a[14]/div[4]/div[1]/div[1]/div/text()")[1].InnerText.Contains(FRGroupStage.home[13]))
            {
                var country1 = OpeningPage._countries[FRGroupStage.home[13]];
                var country2 = OpeningPage._countries[FRGroupStage.away[13]];
                FRDay3Game4T1.Text = country1.Abbreviation;
                FRDay3Game4T2.Text = country2.Abbreviation;
                FRDay3Game4T1png.Source = ImageSource.FromFile(country1.FlagLocation);
                FRDay3Game4T2png.Source = ImageSource.FromFile(country2.FlagLocation);

                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[14]/div[4]/div[1]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                if (index > 0)
                {
                    FRDay3Game4S1.Text = temp.Substring(index, 1);
                    xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[14]/div[4]/div[2]/div[2]";
                    temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                    regex = new Regex("[0-9]");
                    match = regex.Match(temp);
                    index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                    FRDay3Game4S2.Text = temp.Substring(index, 1);
                    if (int.Parse(FRDay3Game4S1.Text) > int.Parse(FRDay3Game4S2.Text))
                    {
                        FRDay3Game4S1Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                    else
                    {
                        FRDay3Game4S2Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                }
            }
            else
            {
                var country1 = OpeningPage._countries[FRGroupStage.home[13]];
                var country2 = OpeningPage._countries[FRGroupStage.away[13]];
                FRDay3Game4T1.Text = country1.Abbreviation;
                FRDay3Game4T2.Text = country2.Abbreviation;
                FRDay3Game4T1png.Source = ImageSource.FromFile(country1.FlagLocation);
                FRDay3Game4T2png.Source = ImageSource.FromFile(country2.FlagLocation);
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[14]/div[4]/div[2]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                if (index > 0)
                {
                    var tempo = temp.Substring(index, 1);
                    FRDay3Game4S1.Text = tempo;
                    xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[14]/div[4]/div[1]/div[2]";
                    temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                    regex = new Regex("[0-9]");
                    match = regex.Match(temp);
                    index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                    FRDay3Game4S2.Text = temp.Substring(index, 1);
                    if (int.Parse(FRDay3Game4S1.Text) > int.Parse(FRDay3Game4S2.Text))
                    {
                        FRDay3Game4S1Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                    else
                    {
                        FRDay3Game4S2Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                }
            }
            if (OpeningPage.docFR.DocumentNode.SelectNodes("//*[@id='wrapper']/div[1]/div/div[4]/a[15]/div[4]/div[1]/div[1]/div/text()")[1].InnerText.Contains(FRGroupStage.home[14]))
            {
                var country1 = OpeningPage._countries[FRGroupStage.home[14]];
                var country2 = OpeningPage._countries[FRGroupStage.away[14]];
                FRDay3Game5T1.Text = country1.Abbreviation;
                FRDay3Game5T2.Text = country2.Abbreviation;
                FRDay3Game5T1png.Source = ImageSource.FromFile(country1.FlagLocation);
                FRDay3Game5T2png.Source = ImageSource.FromFile(country2.FlagLocation);

                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[15]/div[4]/div[1]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                if (index > 0)
                {
                    FRDay3Game5S1.Text = temp.Substring(index, 1);
                    xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[15]/div[4]/div[2]/div[2]";
                    temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                    regex = new Regex("[0-9]");
                    match = regex.Match(temp);
                    index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                    FRDay3Game5S2.Text = temp.Substring(index, 1);

                    if (int.Parse(FRDay3Game1S1.Text) > int.Parse(FRDay3Game1S2.Text))
                    {
                        FRDay3Game5S1Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                    else
                    {
                        FRDay3Game5S2Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                }
            }
            else
            {
                var country1 = OpeningPage._countries[FRGroupStage.home[14]];
                var country2 = OpeningPage._countries[FRGroupStage.away[14]];
                FRDay3Game5T1.Text = country1.Abbreviation;
                FRDay3Game5T2.Text = country2.Abbreviation;
                FRDay3Game5T1png.Source = ImageSource.FromFile(country1.FlagLocation);
                FRDay3Game5T2png.Source = ImageSource.FromFile(country2.FlagLocation);
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[15]/div[4]/div[2]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                if (index > 0)
                {
                    var tempo = temp.Substring(index, 1);
                    FRDay3Game5S1.Text = tempo;
                    xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[15]/div[4]/div[1]/div[2]";
                    temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                    regex = new Regex("[0-9]");
                    match = regex.Match(temp);
                    index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                    FRDay3Game5S2.Text = temp.Substring(index, 1);
                    if (int.Parse(FRDay3Game5S1.Text) > int.Parse(FRDay3Game5S2.Text))
                    {
                        FRDay3Game5S1Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                    else
                    {
                        FRDay3Game5S2Grid.BackgroundColor = Color.FromHex("bbc5cf");
                    }
                }
            }



        }
    }
}
