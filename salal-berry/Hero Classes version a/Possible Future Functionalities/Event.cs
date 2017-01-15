namespace Main_Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EventThrower
    {
        public delegate void EventHandler(object sender, EventArgs args);
        public event EventHandler ThrowEvent = delegate { };

        public void BattleEnded()
        {
            ThrowEvent(this, new EventArgs());
        }
    }
    public class EventSubscriber
    {
        public class Score
        {
            private string player;
            private ulong points;
            public IList<Score> scores;

            public string Player
            {
                get
                {
                    return player;
                }

                set
                {
                    player = value;
                }
            }

            public ulong Points
            {
                get
                {
                    return points;
                }

                set
                {
                    points = value;
                }
            }

            public Score(string player, ulong points)
            {
                this.player = player;
                this.points = points;
            }

            private EventThrower eventThrower;

            public void EventSubscriber()
            {
                eventThrower = new EventThrower();
                eventThrower.ThrowEvent += (sender, args) => { AddToScoreBoard(); };
            }

            private void AddToScoreBoard()
            {
                //TODO: Not working!
                //scores.AddRange(this.Player, this.Points);
                //scores.Add(new Score( ){ player = this.Player, points = this.Points }));
            }
        }
    }
}