        void GetFRGameScores()
        {
            if (isTwelveHourFormat)
            {
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

            string temp;
            if (OpeningPage.docFR.DocumentNode.SelectNodes("//*[@id='wrapper']/div[1]/div/div[4]/a[1]/div[4]/div[1]/div[1]/div/text()")[1].InnerText.Contains(FRGroupStage.home[0]))
            {
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
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[1]/div[4]/div[2]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                var tempo = temp.Substring(index, 1);
                FRDay1Game1S1.Text = temp;
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
                    FRDay1Game1S1Grid.BackgroundColor = Color.FromHex("bbc5cf");
                }
            }

            if (OpeningPage.docFR.DocumentNode.SelectNodes("//*[@id='wrapper']/div[1]/div/div[4]/a[2]/div[4]/div[1]/div[1]/div/text()")[1].InnerText.Contains(FRGroupStage.home[1]))
            {
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[2]/div[4]/div[1]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
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
            else
            {
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[2]/div[4]/div[2]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                var tempo = temp.Substring(index, 1);
                FRDay1Game2S1.Text = temp;
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

            if (OpeningPage.docFR.DocumentNode.SelectNodes("//*[@id='wrapper']/div[1]/div/div[4]/a[3]/div[4]/div[1]/div[1]/div/text()")[1].InnerText.Contains(FRGroupStage.home[2]))
            {
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[3]/div[4]/div[1]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
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
            else
            {
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[3]/div[4]/div[2]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                var tempo = temp.Substring(index, 1);
                FRDay1Game3S1.Text = temp;
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

            if (OpeningPage.docFR.DocumentNode.SelectNodes("//*[@id='wrapper']/div[1]/div/div[4]/a[4]/div[4]/div[1]/div[1]/div/text()")[1].InnerText.Contains(FRGroupStage.home[3]))
            {
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[4]/div[4]/div[1]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
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
            else
            {
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[4]/div[4]/div[2]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                var tempo = temp.Substring(index, 1);
                FRDay1Game4S1.Text = temp;
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

            if (OpeningPage.docFR.DocumentNode.SelectNodes("//*[@id='wrapper']/div[1]/div/div[4]/a[5]/div[4]/div[1]/div[1]/div/text()")[1].InnerText.Contains(FRGroupStage.home[4]))
            {
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[5]/div[4]/div[1]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
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
            else
            {
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[5]/div[4]/div[2]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                var tempo = temp.Substring(index, 1);
                FRDay1Game5S1.Text = temp;
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

            if (OpeningPage.docFR.DocumentNode.SelectNodes("//*[@id='wrapper']/div[1]/div/div[4]/a[6]/div[4]/div[1]/div[1]/div/text()")[1].InnerText.Contains(FRGroupStage.home[5]))
            {
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[6]/div[4]/div[1]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
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
            else
            {
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[6]/div[4]/div[2]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                var tempo = temp.Substring(index, 1);
                FRDay2Game1S1.Text = temp;
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
            if (OpeningPage.docFR.DocumentNode.SelectNodes("//*[@id='wrapper']/div[1]/div/div[4]/a[7]/div[4]/div[1]/div[1]/div/text()")[1].InnerText.Contains(FRGroupStage.home[6]))
            {
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[7]/div[4]/div[1]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
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
            else
            {
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[7]/div[4]/div[2]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                var tempo = temp.Substring(index, 1);
                FRDay2Game2S1.Text = temp;
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
            if (OpeningPage.docFR.DocumentNode.SelectNodes("//*[@id='wrapper']/div[1]/div/div[4]/a[8]/div[4]/div[1]/div[1]/div/text()")[1].InnerText.Contains(FRGroupStage.home[7]))
            {
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[8]/div[4]/div[1]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
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
            else
            {
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[8]/div[4]/div[2]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                var tempo = temp.Substring(index, 1);
                FRDay2Game3S1.Text = temp;
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

            if (OpeningPage.docFR.DocumentNode.SelectNodes("//*[@id='wrapper']/div[1]/div/div[4]/a[9]/div[4]/div[1]/div[1]/div/text()")[1].InnerText.Contains(FRGroupStage.home[8]))
            {
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[9]/div[4]/div[1]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
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
            else
            {
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[9]/div[4]/div[2]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                var tempo = temp.Substring(index, 1);
                FRDay2Game4S1.Text = temp;
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
            if (OpeningPage.docFR.DocumentNode.SelectNodes("//*[@id='wrapper']/div[1]/div/div[4]/a[10]/div[4]/div[1]/div[1]/div/text()")[1].InnerText.Contains(FRGroupStage.home[9]))
            {
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[10]/div[4]/div[1]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
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
            else
            {
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[10]/div[4]/div[2]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                var tempo = temp.Substring(index, 1);
                FRDay2Game5S1.Text = temp;
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

            if (OpeningPage.docFR.DocumentNode.SelectNodes("//*[@id='wrapper']/div[1]/div/div[4]/a[11]/div[4]/div[1]/div[1]/div/text()")[1].InnerText.Contains(FRGroupStage.home[10]))
            {
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[11]/div[4]/div[1]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
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
            else
            {
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[11]/div[4]/div[2]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                var tempo = temp.Substring(index, 1);
                FRDay3Game1S1.Text = temp;
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

            if (OpeningPage.docFR.DocumentNode.SelectNodes("//*[@id='wrapper']/div[1]/div/div[4]/a[12]/div[4]/div[1]/div[1]/div/text()")[1].InnerText.Contains(FRGroupStage.home[11]))
            {
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[12]/div[4]/div[1]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
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
            else
            {
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[12]/div[4]/div[2]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                var tempo = temp.Substring(index, 1);
                FRDay3Game2S1.Text = temp;
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

            if (OpeningPage.docFR.DocumentNode.SelectNodes("//*[@id='wrapper']/div[1]/div/div[4]/a[11]/div[4]/div[13]/div[1]/div/text()")[1].InnerText.Contains(FRGroupStage.home[12]))
            {
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[13]/div[4]/div[1]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
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
            else
            {
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[13]/div[4]/div[2]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                var tempo = temp.Substring(index, 1);
                FRDay3Game3S1.Text = temp;
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

            if (OpeningPage.docFR.DocumentNode.SelectNodes("//*[@id='wrapper']/div[1]/div/div[4]/a[14]/div[4]/div[1]/div[1]/div/text()")[1].InnerText.Contains(FRGroupStage.home[13]))
            {
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[14]/div[4]/div[1]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
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
            else
            {
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[14]/div[4]/div[2]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                var tempo = temp.Substring(index, 1);
                FRDay3Game4S1.Text = temp;
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

            if (OpeningPage.docFR.DocumentNode.SelectNodes("//*[@id='wrapper']/div[1]/div/div[4]/a[15]/div[4]/div[1]/div[1]/div/text()")[1].InnerText.Contains(FRGroupStage.home[14]))
            {
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[15]/div[4]/div[1]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
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
            else
            {
                var xpath = "//*[@id='wrapper']/div[1]/div/div[4]/a[15]/div[4]/div[2]/div[2]";
                temp = OpeningPage.docFR.DocumentNode.SelectNodes(xpath)[0].InnerText;
                var regex = new Regex("[0-9]");
                var match = regex.Match(temp);
                var index = temp.IndexOf(match.ToString(), StringComparison.Ordinal);
                var tempo = temp.Substring(index, 1);
                FRDay3Game5S1.Text = temp;
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