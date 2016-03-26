using System.Collections.Generic;

namespace ToyModel
{
    public class GameStateUpdate
    {
        public List<bool> marketUpgrade { get; set; }
        public List<bool> practiceYardUpgrade { get; set; }
        public int goldAdded { get; set; }

        public bool builtMarket { get; set; }
        public bool builtPracticeYard { get; set; }
    }
}