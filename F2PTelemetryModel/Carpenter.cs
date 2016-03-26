using System.Collections.Generic;

namespace F2PTelemetryModel
{
    public class Carpenter : Building
    {
        public int totalCarpenters
        {
            get
            {
                return level;
            }
        }

        public int carpentersAvailable
        {
            get
            {
                return level - carpentersInUse;
            }
        }

        public int carpentersInUse { get; set; }
    }
}