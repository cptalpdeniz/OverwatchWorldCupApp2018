using OWWC.MULTI.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OWWC.MULTI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsContent4 : ContentPage
    {
        public NewsContent4()
        {
            InitializeComponent();

            webBrowser1.Source = ConstantsClass.NewsUrl[3];
        }

    }
}