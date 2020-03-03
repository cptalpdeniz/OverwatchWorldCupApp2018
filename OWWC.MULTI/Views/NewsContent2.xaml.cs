using OWWC.MULTI.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OWWC.MULTI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsContent2 : ContentPage
    {
        public NewsContent2()
        {
            InitializeComponent();

            webBrowser1.Source = ConstantsClass.NewsUrl[1];
        }

    }
}