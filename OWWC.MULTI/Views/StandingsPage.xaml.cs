using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using OWWC.MULTI.ViewModels;
using OWWC.MULTI.Countries;
using HtmlAgilityPack;

namespace OWWC.MULTI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StandingsPage : ContentPage
    {
        public ObservableCollection<GroupedCountriesModel> Grouped { get; set; }

        CountriesViewModel viewModel;
        public StandingsPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new CountriesViewModel();

            var web = new HtmlWeb();
            string[] data2 = new string[2];

            Grouped = new ObservableCollection<GroupedCountriesModel>();
            var skgroup = new GroupedCountriesModel() { LongName = "South Korea Group Stage", ShortName = "SK" };
            var usgroup = new GroupedCountriesModel() { LongName = "United States Group Stage", ShortName = "US" };
            var thgroup = new GroupedCountriesModel() { LongName = "Thailand Group Stage", ShortName = "TH" };
            var frgroup = new GroupedCountriesModel() { LongName = "France Group Stage", ShortName = "FR" };
            for (int j = 0; j < 6; j++)
            {
                Country country1 = OpeningPage._countries[SKGroupStage.GetStandings()[j]];
                skgroup.Add(new CountriesViewModel() { Name = SKGroupStage.GetStandings()[j], FlagLocation = country1.FlagLocation, SeriesScore = country1.Score[0], MapScore = country1.Score[1] });
            }
            for (int i = 0; i < 6; i++)
            {
                Country country1 = OpeningPage._countries[LAGroupStage.GetStandings()[i]];
                usgroup.Add(new CountriesViewModel() { Name = LAGroupStage.GetStandings()[i], FlagLocation = country1.FlagLocation, SeriesScore = country1.Score[0], MapScore = country1.Score[1] });
            }
            for (int i = 0; i < 6; i++)
            {
                Country country1 = OpeningPage._countries[THGroupStage.GetStandings()[i]];
                thgroup.Add(new CountriesViewModel() { Name = THGroupStage.GetStandings()[i], FlagLocation = country1.FlagLocation, SeriesScore = country1.Score[0], MapScore = country1.Score[1] });
            }
            for (int i = 0; i < 6; i++)
            {
                Country country1 = OpeningPage._countries[FRGroupStage.GetStandings()[i]];
                frgroup.Add(new CountriesViewModel() { Name = FRGroupStage.GetStandings()[i], FlagLocation = country1.FlagLocation, SeriesScore = country1.Score[0], MapScore = country1.Score[1] });
            }
            Grouped.Add(skgroup);
            Grouped.Add(usgroup);
            Grouped.Add(thgroup);
            Grouped.Add(frgroup);
            list.ItemsSource = Grouped;
            list.GroupHeaderTemplate = new DataTemplate(typeof(HeaderCell));

            //list.HasUnevenRows = true;
            string[] countries = { "Australia", "Austria", "Brazil", "Canada", "China", "Denmark", "Finland", "France", "Germany", "Hong Kong", "Italy", "Japan", "Netherlands", "Norway", "Poland", "Russia", "South Korea", "Spain", "Sweden", "Switzerland", "Taiwan", "Thailand", "United Kingdom", "United States" };

        }
        public class HeaderCell : ViewCell
        {
            public HeaderCell()
            {
                this.Height = 36;
                var title = new Label
                {
                    TextColor = Color.White,
                    VerticalOptions = LayoutOptions.Center
                };

                title.SetBinding(Label.TextProperty, "LongName");

                var stadiumImage = new Image
                {
                    Source = "stadium.png",
                    HeightRequest = 30

                };

                View = new StackLayout
                {
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    HeightRequest = 34,
                    BackgroundColor = Color.FromRgb(61, 66, 77),
                    Padding = 5,
                    Orientation = StackOrientation.Horizontal,
                    Children = { stadiumImage, title }
                };
            }
        }

        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
