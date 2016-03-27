using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyModel
{
    class MarketStats
    {
        public static int costToBuild { get; set; } = 500;
        public static int timeToBuild { get; set; } = 12;

        public static Dictionary<int, int> productionPerSecondPerLevel { get; set; } = new Dictionary<int, int>()
        {
            { 1, 60 },
            { 2, 120 },
            { 3, 180 }
        };

        public static Dictionary<int, int> timeToUpgrade { get; set; } = new Dictionary<int, int>()
        {
            { 2, 60 },
            { 3, 180 }
        };

        public static Dictionary<int, int> costToUpgrade { get; set; } = new Dictionary<int, int>()
        {
            { 2, 1000 },
            { 3, 2000 }
        };
    }
}
