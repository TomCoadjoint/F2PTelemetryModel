using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyModel
{
    class MissionArray
    {
        public static int costPerSamurai { get; set; } = 180;

        public static Mission[] missionList { get; set; } = new Mission[5] {
            new Mission
            {
                samuraiRequired = 5,
                goldReward = 360
            },
            new Mission
            {
                samuraiRequired = 12,
                goldReward = 1200
            },
            new Mission
            {
                samuraiRequired = 20,
                goldReward = 1500
            },
            new Mission
            {
                samuraiRequired = 25,
                goldReward = 2400
            },
            new Mission
            {
                samuraiRequired = 30,
                goldReward = 3000
            },
        };
    }
}
