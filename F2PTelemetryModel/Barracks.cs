using System.Collections.Generic;

namespace F2PTelemetryModel
{
    public class Barracks : Building
    {
        public int currentQueueSize
        {
            get
            {
                if (queueLevelStats != null)
                {
                    return queueLevelStats[level];
                }
                else return 0;
            }
        }

        public Dictionary<int, int> queueLevelStats { get; set; }
    }
}