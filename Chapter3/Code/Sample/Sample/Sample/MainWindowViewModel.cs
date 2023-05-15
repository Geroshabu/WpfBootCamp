using System;
using System.ComponentModel;
using System.Windows.Input;

namespace Sample
{
    /// <summary>
    /// <see cref="MainWindow"/>の ViewModel
    /// </summary>
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        private readonly Player model;

        /// <inheritdoc cref="INotifyPropertyChanged.PropertyChanged"/>
        public event PropertyChangedEventHandler? PropertyChanged;

        public int Life => model.Life;

        /// <summary>死ぬコマンドを取得</summary>
        public ICommand DieCommand { get; }

        public MainWindowViewModel()
        {
            model = new Player();
            DieCommand = new DieCommand(model);

            model.LifeChanged += handleLifeChanged;
        }

        private void handleLifeChanged(object? sender, EventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Life)));
        }
    }
}
