namespace F2PTelemetryModel
{
    public class StorageBuilding : Building 
    {
        public int currentStorage
        {
            get
            {
                if (levelUpStats != null)
                {
                    return levelUpStats[level].resourceStorage;
                }
                else return 0;
            }
        }
    }
}
