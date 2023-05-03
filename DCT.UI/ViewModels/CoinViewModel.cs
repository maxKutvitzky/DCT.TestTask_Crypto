using DCT.UI.Base;
using DCT.UI.Commands;
using DCT.UI.Utils;

namespace DCT.UI.ViewModels
{
    /// <summary>
    /// Class that represents view model that used in main window. Top currencies info
    /// </summary>
    public class CoinViewModel : BaseViewModel
    {
        #region Properties
        public OpenCoinCommand OpenCoinCommand { get; set; }
        public CoinViewModel()
        {
            OpenCoinCommand = new OpenCoinCommand(OpenCoin);
        }
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

        #region Private Methods
        /// <summary>
        /// Open new currency info window
        /// </summary>
        private void OpenCoin(string id)
        {
            WindowUtils.OpenCoinWindow(id);
        }
        #endregion Private Methods
    }
}
