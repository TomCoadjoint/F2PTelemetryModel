using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyModel
{
    class GameStateEdge
    {
        public static int goldForCastle { get; set; } = 10000;

        public int[] markets { get; set; } = new int[2];
        public int[] practiceYards { get; set; } = new int[1];

        public int[] upgradingMarkets { get; set; } = new int[2]; //time in 5 second intervals until upgrade is complete
        public int[] upgradingPracticeYards { get; set; } = new int[2];

        public bool carpenterFree
        {
            get
            {
                return upgradingMarkets.Sum() + upgradingPracticeYards.Sum() == 0;
            }
        }

        public bool hasGoldForCastle
        {
            get
            {
                return gold >= goldForCastle;
            }
        }
        
        public int lastMission { get; set; } = 0;

        public int gold { get; set; }

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
        
        public GameStateEdge Copy()
        {
            return new GameStateEdge()
            {
                markets = new int[2]
                {
                    markets[0],
                    markets[1]
                },
                practiceYards = new int[2]
                {
                    practiceYards[0],
                    practiceYards[1]
                },
                upgradingMarkets = new int[2]
                {
                    upgradingMarkets[0],
                    upgradingMarkets[1]
                },
                upgradingPracticeYards = new int[2]
                {
                    upgradingPracticeYards[0],
                    upgradingPracticeYards[1]
                },
                lastMission = lastMission,
                gold = gold
            };
        }
        
        public List<Tuple<GameStateEdge, int>> Neighbours()
        {
            // Description of possible states:
            // If sum of all upgrading vectors is 0 then:
            // can build practice yard if you have one practice yard
            // can upgrade a practice yard if level < 3
            // can build market if you have one market
            // can upgrade a market if level < 3
            // else: 
            // can do mission if total practice yard space > mission requirements and you have enough gold to build all the troops
            // if building/upgrading, can wait until building/upgrading is complete
            // can wait one turn to just gain gold
            // once moved to a state, must add on gold from market production

            List<Tuple<GameStateEdge, int>> neighbours = new List<Tuple<GameStateEdge, int>>();

            if (carpenterFree)
            {
                if(markets[1] == 0 && gold >= MarketStats.costToBuild)
                {
                    var buildMarket = Copy();

                    buildMarket.gold -= MarketStats.costToBuild;
                    buildMarket.upgradingPracticeYards[1] = MarketStats.timeToBuild;
                    
                    neighbours.Add()
                }
            }

            return neighbours;
        }

    }
}
