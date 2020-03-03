using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using OWWC.MULTI.Views;
using OWWC.MULTI.Services;
using System.Threading;
using System;
using System.Threading.Tasks;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace OWWC.MULTI
{
    public partial class App : Application
    {
        private static Label labelScreen;
        private static bool hasInternet;
        private static Page currentpage;
        private static Timer timer;
        private static bool noInterShow;

        public App()
        {
            InitializeComponent();
        }

        protected override async void OnStart()
        {
            MainPage = new LoadPage();
            await Task.Yield();

            while (true)
            {
                if (!CheckIfInternet().Result)
                {
                    await Task.Delay(500);
                    await MainPage.DisplayAlert("Connection Error", "Unfortunately this app requires internet connection to update its data realtime", "Retry");
                }
                else
                {
                    break;
                }
            }
            TwitchClass.MainAsync().Wait();

            await Task.Delay(1000);
            MainPage = new OpeningPage();
            //Color color = new Color(225, 225, 225);
            //MainPage.SetValue(NavigationPage.BarBackgroundColorProperty, color);
            //Start liveStreamMonitor Service here

        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public static void StartCheckIfInternet(Label label, Page page)
        {
            labelScreen = label;
            label.Text = ConstantsClass.NoInternetText;
            label.IsVisible = false;
            hasInternet = true;
            currentpage = page;
            if (timer == null)
            {
                timer = new Timer((e) =>
                {
                    CheckIfInternetOverTime();
                }, null, 10, (int)TimeSpan.FromSeconds(60).TotalMilliseconds);
            }
        }

        private static void CheckIfInternetOverTime()
        {
            var networkConnection = DependencyService.Get<INetworkConnection>();
            networkConnection.CheckNetworkConnection();
            if (!networkConnection.IsConnected)
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    if (hasInternet)
                    {
                        if (!noInterShow)
                        {
                            hasInternet = false;
                            labelScreen.IsVisible = true;
                            await ShowDisplayAlert();
                        }
                    }
                });
            }
            else
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    hasInternet = true;
                    labelScreen.IsVisible = false;
                });
            }
        }

        public static async Task<bool> CheckIfInternet() //use for quick internet checks
        {
            var networkConnection = DependencyService.Get<INetworkConnection>();
            networkConnection.CheckNetworkConnection();
            if (!networkConnection.IsConnected)
            {
                return false;
            }
            return true;
        }

        public static async Task<bool> CheckIfInternetAlertAsync()
        {
            var networkConnection = DependencyService.Get<INetworkConnection>();
            networkConnection.CheckNetworkConnection();
            if (!networkConnection.IsConnected)
            {
                if (!noInterShow)
                {
                    await ShowDisplayAlert();
                }
                return false;
            }
            return true;
        }

        private static async Task ShowDisplayAlert()
        {
            noInterShow = false;
            await currentpage.DisplayAlert("Connection Error", "Unfortunately this app requires internet connection to update its data realtime", "Retry");
            noInterShow = false;
        }

    }
}
