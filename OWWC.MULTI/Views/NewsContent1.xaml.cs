using OWWC.MULTI.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OWWC.MULTI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsContent1 : ContentPage
    {
        public NewsContent1()
        {
            InitializeComponent();

            webBrowser1.Source = ConstantsClass.NewsUrl[0];
        }

    }
}