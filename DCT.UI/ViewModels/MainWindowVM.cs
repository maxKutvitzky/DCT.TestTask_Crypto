using DCT.UI.Base;
using DCT.UI.Commands;
using DCT.UI.Models;
using System.Collections.ObjectModel;

namespace DCT.UI.ViewModels
{
    /// <summary>
    /// Class that represents view model that used in main window. Currencies top, search of currencies
    /// </summary>
    public class MainWindowVM : BaseViewModel
    {
        #region Properties
        public SearchCommand SearchCommand { get; set; }
        
        public ObservableCollection<CoinViewModel> CoinModels { get; set; } = new ObservableCollection<CoinViewModel>();
        
        private MainWindowModel _model;
        public MainWindowModel Model
        {
            get { return _model; }
            set
            {
                _model = value;
                OnPropertyChanged(nameof(Model));
            }
        }
        private string _search;
        public string SearchText
        {
            get
            {
                return _search;
            }
            set
            {
                _search = value;
                OnPropertyChanged(nameof(SearchText));
            }
        }

        #endregion Properties

        #region Public Methods
        public MainWindowVM()
        {
            Model = new MainWindowModel();
            SearchCommand = new SearchCommand(SearchCurrency);
            GetTopCurrencies();
        }
        #endregion Public Methods

        #region Private Methods
        /// <summary>
        /// Get top 10 currencies and update currencies collection
        /// </summary>
        private async void GetTopCurrencies()
        {
            CoinModels.Clear();
            var coinsViewModels = await Model.GetTopCoins();
            
            foreach (var coin in coinsViewModels)
            {
                CoinModels.Add(coin);
            }
        }
        
        /// <summary>
        /// Search currency and update currencies collection
        /// </summary>
        private async void SearchCurrency()
        {
            CoinModels.Clear();
            var coinViewModel = await Model.SearchCoin(_search);

            if(coinViewModel == null)
            {
                GetTopCurrencies();
                return;
            }

            CoinModels.Add(coinViewModel);
        }
        #endregion Private Methods

    }
}
