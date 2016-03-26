using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2PTelemetryModel
{
    static class Config
    {
        public static Dictionary<string, string> UpgradeCurrencies { get; set; }

        public static Dictionary<string, Dictionary<int, int>> MaxCastleLevelQuantities { get; set; }

        public static Dictionary<string, Dictionary<int, BuildingLevelStats>> BuildingStats { get; set; }

        public static Dictionary<int, int> BarracksQueueLength { get; set; }

        public static Dictionary<int, int> ManaWellProductionPerHour { get; set; }

        public static Dictionary<int, int> MarketProductionPerHour { get; set; }

        public static void Initialise(string config)
        {
            var o = JObject.Parse(config);

            UpgradeCurrencies = JsonConvert.DeserializeObject<Dictionary<string, string>>(o["upgradeCurrencies"].ToString());

            MaxCastleLevelQuantities = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<int, int>>>(o["maxQuantityPerCastleLevel"].ToString());

            BuildingStats = new Dictionary<string, Dictionary<int, BuildingLevelStats>>();

            foreach (var building in new string[] { "castle", "barracks", "bank", "carpenter", "manaStorage", "manaWell", "market" })
            {
                BuildingStats.Add(building, JsonConvert.DeserializeObject<Dictionary<int, BuildingLevelStats>>(o[building + "Stats"].ToString()));
            }

            BarracksQueueLength = JsonConvert.DeserializeObject<Dictionary<int, int>>(o["barracksQueueLength"].ToString());

            ManaWellProductionPerHour = JsonConvert.DeserializeObject<Dictionary<int, int>>(o["manaWellProductionPerHour"].ToString());

            MarketProductionPerHour = JsonConvert.DeserializeObject<Dictionary<int, int>>(o["marketProductionPerHour"].ToString());
        }
    }
}
