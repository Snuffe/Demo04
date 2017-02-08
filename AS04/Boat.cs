using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS04
{
    class Boat
    {
        public int SeatCount { get; set; }
        public string BoatType { get; set; }

        public Boat()
        {

        }

        public Boat(string name, string model, int year, string color, int seatcount, string boattype)
            : base(name, model, year, color)
        {
            SeatCount = seatcount;
            BoatType = boattype;
        }

        public override string ToString()
        {
            return base.ToString() + ", Seat Count: " + SeatCount + ", Boat Type: " + BoatType;
        }
    }
}
