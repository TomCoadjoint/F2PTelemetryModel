using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2PTelemetryModel
{
    class Player
    {
        public float interest { get; set; }
        public float spendPropensity { get; set; }

        public float gold { get; set; }
        public float mana { get; set; }
        public float diamonds { get; set; }

        public Base myBase { get; set; }
    }
}
