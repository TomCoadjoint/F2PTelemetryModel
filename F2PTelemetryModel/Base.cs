using System.Collections.Generic;

namespace F2PTelemetryModel
{    
    public class Base
    {
        public Castle castle { get; set; }
        public List<Barracks> barracks { get; set; }
        public List<Market> markets { get; set; }
        public List<Bank> banks { get; set; }
        public List<ManaStorage> manaStorages { get; set; }
        public List<ManaWell> manaWell { get; set; }

        //Offensive Troop Count
        public int soldierCount { get; set; }
        //Defensive Troop Count
        public int archerCount { get; set; }
        
    }
}