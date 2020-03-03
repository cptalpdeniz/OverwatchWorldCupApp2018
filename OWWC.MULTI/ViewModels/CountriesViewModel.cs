using System.Collections.ObjectModel;

namespace OWWC.MULTI.ViewModels
{
    public class CountriesViewModel
    {
        public string Name { get; set; }
        public string FlagLocation { get; set; }
        public string SeriesScore { get; set; }
        public string MapScore { get; set; }
        public CountriesViewModel()
        {
        }
    }
    public class GroupedCountriesModel : ObservableCollection<CountriesViewModel>
    {
        public string LongName { get; set; }
        public string ShortName { get; set; }
    }
}