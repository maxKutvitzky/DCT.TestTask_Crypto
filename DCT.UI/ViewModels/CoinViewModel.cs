using DCT.UI.Base;

namespace DCT.UI.ViewModels
{
    public class CoinViewModel : BaseViewModel
    {
        #region Properties
        private uint _index;
        public uint Index
        {
            get
            {
                return _index;
            }
            set
            {
                _index = value;
                OnPropertyChanged(nameof(Index));
            }
        }

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
        #endregion Properties
    }
}
