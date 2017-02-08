using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS04
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike bike = new AS04.Bike("Jopo", "Street", 1970, "Green", "");
            Console.WriteLine("Bike Info\n- " + bike.ToString());

            Boat boat = new AS04.Boat("Suvi", "S900", 2000, "Blue", 5, "RowBoat");
            Console.WriteLine("Boat Info\n- " + boat.ToString());
        }
    }
}
