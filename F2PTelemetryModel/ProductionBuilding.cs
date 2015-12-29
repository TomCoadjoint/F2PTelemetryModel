using System.Collections.Generic;

namespace F2PTelemetryModel
{
    public class ProductionBuilding : Building
    {
        public int currentProductionPerHour
        {
            get
            {
                if (productionLevelStats != null)
                {
                    return productionLevelStats[level];
                }
                else return 0;            
            }
        }

        public Dictionary<int, int> productionLevelStats { get; set; }
    }
}
