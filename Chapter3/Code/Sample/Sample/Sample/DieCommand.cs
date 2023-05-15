using System;
using System.Windows.Input;

namespace Sample
{
    /// <summary>死ぬコマンド</summary>
    internal class DieCommand : ICommand
    {
        private readonly Player player;

        public DieCommand(Player player)
        {
            this.player = player;
        }

        /// <inheritdoc cref="ICommand.CanExecuteChanged"/>
        public event EventHandler? CanExecuteChanged;

        /// <inheritdoc cref="ICommand.CanExecute(object?)"/>
        public bool CanExecute(object? parameter) => true;

        /// <inheritdoc cref="ICommand.Execute(object?)"/>
        public void Execute(object? parameter)
        {
            player.Die();
        }
    }
}
