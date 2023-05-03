using DCT.UI.Base;
using DCT.UI.Models;
using System.Collections.ObjectModel;

namespace DCT.UI.ViewModels
{
    /// <summary>
    /// Class that represents view model that used in coin info window. Currency info with markets
    /// </summary>
    public class CoinWindowViewModel : BaseViewModel
    {
        #region Properties
        private readonly CoinWindowModel _model = new CoinWindowModel();

        private string _id;
        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        private string _symbol;
        public string Symbol
        {
            get
            {
                return _symbol;
            }
            set
            {
                _symbol = value;
                OnPropertyChanged(nameof(Symbol));
            }
        }
        private string _volumeUsd24Hr;
        public string VolumeUsd24Hr
        {
            get
            {
                return _volumeUsd24Hr;
            }
            set
            {
                _volumeUsd24Hr = value;
                OnPropertyChanged(nameof(VolumeUsd24Hr));
            }
        }
        private string _changePercent24Hr;
        public string ChangePercent24Hr
        {
            get
            {
                return _changePercent24Hr;
            }
            set
            {
                _changePercent24Hr = value;
                OnPropertyChanged(nameof(ChangePercent24Hr));
            }
        }
        private string _price;
        public string PriceUsd
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
                OnPropertyChanged(nameof(PriceUsd));
            }
        }
        public ObservableCollection<MarketViewModel> Markets { get; set; } = new ObservableCollection<MarketViewModel>();
        #endregion Properties
    }
}
