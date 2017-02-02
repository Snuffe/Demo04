using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS01
{
    class Elevator
    {
        private int minFloor = 1;
        private int maxFloor = 5;
        private int floor;
        public int Floor
        {
            get {
                return floor;
            }

            set {
                if (value <= maxFloor && value >= minFloor) floor = value;
                else {
                    Console.WriteLine("nut pussible");
                }
            }
        }
        
    }
}
