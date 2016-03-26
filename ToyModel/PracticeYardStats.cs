using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyModel
{
    class PracticeYardStats
    {
        public static int costToBuild { get; set; } = 900;

        public static Dictionary<int, int> maximumCapacity { get; set; } = new Dictionary<int, int>()
        {
            { 1, 10 },
            { 2, 20 },
            { 3, 30 }
        };

        public static Dictionary<int, int> timeToUpgrade { get; set; } = new Dictionary<int, int>()
        {
            { 1, 60 },
            { 2, 720 },
            { 3, 2160 }
        };

        public static Dictionary<int, int> costToUpgrade { get; set; } = new Dictionary<int, int>()
        {
            { 2, 3000 },
            { 3, 6000 }
        };
    }
}
