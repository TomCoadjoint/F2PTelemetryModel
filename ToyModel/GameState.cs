using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyModel
{
    class GameStateEdge
    {
        public int[] markets { get; set; } = new int[2];
        public int[] practiceYards { get; set; } = new int[1];

        public int[] upgradingMarkets { get; set; } = new int[2]; //time in 5 second intervals until upgrade is complete
        public int[] upgradingPracticeYards { get; set; } = new int[2];

        public bool hasGoldForCastle { get; set; } = false;

        public int goldForCastle { get; set; } = 10000;

        public int lastMission { get; set; } = 0;

        public int _gold { get; set; }
        public int gold
        {
            get
            {
                return _gold;
            }
            set
            {
                if(value > 10000)
                {
                    hasGoldForCastle = true;
                }

                _gold = value;

            }
        }

        public override string ToString()
        {
            return string.Format("{M:{0},PY:{1},MC:{2},PYC:{3},G:{4},Mi:{5}", 
                "{" + string.Join(",", markets.Select(x => x.ToString()).ToArray()) + "}",
                "{" + string.Join(",", practiceYards.Select(x => x.ToString()).ToArray()) + "}",
                "{" + string.Join(",", upgradingMarkets.Select(x => x.ToString()).ToArray()) + "}",
                "{" + string.Join(",", upgradingPracticeYards.Select(x => x.ToString()).ToArray()) + "}",
                gold.ToString(),
                lastMission.ToString());
        }

        public GameStateEdge(GameStateUpdate gsu)
        {

        }

        public GameStateEdge() { }

        public List<GameStateEdge> Neighbours()
        {


            return null;
        }

    }
}
