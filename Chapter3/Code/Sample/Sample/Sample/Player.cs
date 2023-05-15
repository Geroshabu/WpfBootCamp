using System;

namespace Sample
{
    /// <summary>
    /// ゲームのプレイヤー
    /// </summary>
    internal class Player
    {
        private int life = 3;
        /// <summary>残機</summary>
        public int Life
        {
            get => life;
            private set
            {
                life = value;
                LifeChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        /// <summary>
        /// <see cref="Life"/>プロパティが変更されたときに発生する。
        /// </summary>
        public event EventHandler? LifeChanged;

        /// <summary>
        /// このプレイヤーが一回死ぬ。
        /// </summary>
        public void Die()
        {
            Life -= 1;
        }
    }
}
