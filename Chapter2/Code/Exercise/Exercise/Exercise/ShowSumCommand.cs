using System;
using System.Windows;
using System.Windows.Input;

namespace Exercise
{
    /// <summary>
    /// 合計金額を表示するコマンド
    /// </summary>
    internal class ShowSumCommand : ICommand
    {
        private readonly Wallet wallet;

        /// <inheritdoc cref="CanExecuteChanged"/>
        public event EventHandler? CanExecuteChanged;

        public ShowSumCommand(Wallet wallet)
        {
            this.wallet = wallet;
        }

        /// <inheritdoc cref="CanExecute(object?)"/>
        public bool CanExecute(object? parameter) => true;

        /// <inheritdoc cref="Execute(object?)"/>
        public void Execute(object? parameter)
        {
            MessageBox.Show($"合計: {wallet.Sum}円");
        }
    }
}
