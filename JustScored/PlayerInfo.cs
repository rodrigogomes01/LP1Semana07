using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustScored
{
    public class PlayerInfo
    {
        private float maxScore;
        private int gamesPlayed;
        private int gamesWon;

        public float MaxScore
        {
            get { return maxScore; }

            set
            {
                maxScore = value;
                // Set max score if it is higher than the current max score
                if (value > maxScore)
                {
                    maxScore = value;
                }
            }
        }
        public string Name { get; }

        public float RateOfSuccess
        {
            get
            {
                if (gamesPlayed == 0)
                    return 0;
                else
                    return (float)gamesWon / gamesPlayed;
            }
        }
    }
}




