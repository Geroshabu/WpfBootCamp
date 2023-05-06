namespace Sample
{
    /// <summary>
    /// <see cref="MainWindow"/>に対応するビューモデル。
    /// </summary>
    internal class MainWindowViewModel
    {
        private readonly User model = new();

        /// <summary>名前</summary>
        public string Name
        {
            get
            {
                return model.Name;
            }
        }

        /// <summary>年齢</summary>
        public int Age
        {
            get
            {
                return model.Age;
            }
        }
    }
}
