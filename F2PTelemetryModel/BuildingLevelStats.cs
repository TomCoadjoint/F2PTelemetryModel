using System;

namespace F2PTelemetryModel
{
    public class BuildingLevelStats
    {
        public int resourceStorage { get; set; }
        public TimeSpan upgradeDuration { get; set; }
        public int minCastleLevel { get; set; }
        public int cost { get; set; }
    }
}
