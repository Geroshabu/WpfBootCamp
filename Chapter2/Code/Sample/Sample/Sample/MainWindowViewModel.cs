using System.Windows.Input;

namespace Sample
{
    /// <summary>
    /// MainWindow に対するビューモデル
    /// </summary>
    internal class MainWindowViewModel
    {
        /// <summary>
        /// ボタンが押されたときのコマンド
        /// </summary>
        public ICommand DoSomethingCommand { get; } = new ShowMessageCommand();
    }
}
