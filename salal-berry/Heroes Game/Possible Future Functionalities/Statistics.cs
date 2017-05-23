namespace Main_Program
{
    using System;
    using System.Collections.Generic;

    class Statistics
    {
        public event EventHandler BattleEnded;

        //private HighScoreBoard highScore;

        protected virtual void OnBattleEnded(EventArgs e)
        {
            if (this.BattleEnded != null)
            {
                this.BattleEnded(this, e);
            }
        }

        public class BattleEndedEventArgs : EventArgs
        {
            public DateTime TimeReached { get; private set; }
        }

        public class HighScoreBoard : EventArgs
        {
            // The setter is not protected,
            // so the user can write his credentials
            public string HighScore { get; set; }
        }         
    }
}
