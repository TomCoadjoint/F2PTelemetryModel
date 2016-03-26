using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace F2PTelemetryModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Config.Initialise(File.ReadAllText(@"../../../config.json"));

            Console.WriteLine("Execution Complete");

            Console.ReadKey();
        }
    }
}
