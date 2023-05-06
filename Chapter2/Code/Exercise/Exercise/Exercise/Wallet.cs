namespace Exercise
{
    /// <summary>財布</summary>
    internal class Wallet
    {
        /// <summary>一万円札の枚数</summary>
        public int CountOf10000Yen { get; } = 1;
        /// <summary>五千円札の枚数</summary>
        public int CountOf5000Yes { get; } = 3;
        /// <summary>千円札の枚数</summary>
        public int CountOf1000Yen { get; } = 3;

        /// <summary>合計金額</summary>
        public int Sum
        {
            get
            {
                return 10000 * CountOf10000Yen
                    + 5000 * CountOf5000Yes
                    + 1000 * CountOf1000Yen;
            }
        }
    }
}
