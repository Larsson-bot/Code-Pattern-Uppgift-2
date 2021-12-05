using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    class SimulatedDatabase
    {
        internal static string Load(string v)
        {
            return v;
        }

        internal static void Save(string data)
        {
            Console.WriteLine($"Saving data \"{data}\"");
        }
    }
}
