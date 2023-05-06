using System;
using System.Windows;
using System.Windows.Input;

namespace Sample
{
    /// <summary>
    /// メッセージを表示するコマンド
    /// </summary>
    internal class ShowMessageCommand : ICommand
    {
        /// <inheritdoc cref="ICommand.CanExecuteChanged"/>
        public event EventHandler? CanExecuteChanged;

        /// <inheritdoc cref="ICommand.CanExecute(object?)"/>
        public bool CanExecute(object? parameter) => true;

        /// <inheritdoc cref="ICommand.Execute(object?)"/>
        public void Execute(object? parameter)
        {
            MessageBox.Show("ボタンが押されました。");
        }
    }
}
