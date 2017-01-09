using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Program
{
    class Enemy : Creature
    {
        // properties
        public Difficulty Rank { get; internal set; }
        public int ScoreReward { get; internal set; }

        // constructors
        public Enemy(Difficulty rank, int scoreReward)
        {
            this.Rank = rank;
            this.ScoreReward = scoreReward;
        }
    }
}
