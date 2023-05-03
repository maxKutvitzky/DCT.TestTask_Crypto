using DCT.UI.Models;
using DCT.UI.Views;

namespace DCT.UI.Utils
{
    /// <summary>
    /// Utility class for window management
    /// </summary>
    public static class WindowUtils
    {
        /// <summary>
        /// Open currency info window
        /// </summary>
        /// <param name="coinId"> Currency id </param>
        public static async void OpenCoinWindow(string coinId)
        {
            CoinWindowModel model = new CoinWindowModel();
            var coinViewModel = await model.GetCurrency(coinId);
            var window = new CoinWindow();
            window.DataContext = coinViewModel;
            window.Show();
        }
    }
}
