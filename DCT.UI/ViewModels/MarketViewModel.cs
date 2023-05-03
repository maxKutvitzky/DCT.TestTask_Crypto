using DCT.UI.Base;

namespace DCT.UI.ViewModels
{
    /// <summary>
    /// Class that represents view model that used in coin info window data grid. Info about specific market
    /// </summary>
    public class MarketViewModel : BaseViewModel
    {
        #region Properties

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
        private string _fromSymbol;
        public string FromSymbol
        {
            get
            {
                return _fromSymbol;
            }
            set
            {
                _fromSymbol = value;
                OnPropertyChanged(nameof(FromSymbol));
            }
        }
        private string _toSymbol;
        public string ToSymbol
        {
            get
            {
                return _toSymbol;
            }
            set
            {
                _toSymbol = value;
                OnPropertyChanged(nameof(ToSymbol));
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
        
        private string _priceUsd;
        public string PriceUsd
        {
            get
            {
                return _priceUsd;
            }
            set
            {
                _priceUsd = value;
                OnPropertyChanged(nameof(PriceUsd));
            }
        }

        #endregion Properties
    }
}
