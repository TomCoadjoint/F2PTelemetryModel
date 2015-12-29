using System.Collections.Generic;

namespace F2PTelemetryModel
{
    public class Building
    {
        public int level { get; set; }
        public Dictionary<int, BuildingLevelStats> levelUpStats { get; set; }
        public Dictionary<int, int> maxQuantityPerCastleLevel { get; set; }
    }
}
