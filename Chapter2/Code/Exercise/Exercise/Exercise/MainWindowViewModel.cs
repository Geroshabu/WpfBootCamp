using System.Windows.Input;

namespace Exercise
{
    /// <summary>
    /// メイン画面の ViewModel
    /// </summary>
    internal class MainWindowViewModel
    {
        private readonly Wallet wallet = new();

        /// <summary>一万円札の枚数</summary>
        public int CountOf10000Yen => wallet.CountOf10000Yen;

        /// <summary>五千円札の枚数</summary>
        public int CountOf5000Yen => wallet.CountOf5000Yes;

        /// <summary>千円札の枚数</summary>
        public int CountOf1000Yen => wallet.CountOf1000Yen;

        public MainWindowViewModel()
        {
            ShowSumCommand = new ShowSumCommand(wallet);
        }

        /// <summary>合計表示ボタンのコマンド</summary>
        public ICommand ShowSumCommand { get; }
    }
}
