using DCT.UI.Base;
using DCT.UI.Commands;
using DCT.UI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace DCT.UI.ViewModels
{
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
        private async void GetTopCurrencies()
        {
            CoinModels.Clear();
            var coinsViewModels = await Model.GetTopCoins();
            
            foreach (var coin in coinsViewModels)
            {
                CoinModels.Add(coin);
            }
        }

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
