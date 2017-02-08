using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS04
    {
        class Bike : Vehicle
        {
            public bool GearWheels { get; set; }
            public string GearName { get; set; }

            public Bike()
            {

            }

            public Bike(string name, string model, int year, string color, string gearname)
                : base(name, model, year, color)
            {
                GearName = gearname;
                if (GearName != "")
                {
                    GearWheels = true;
                }
                else
                {
                    GearWheels = false;
                }
            }

            public override string ToString()
            {
                return base.ToString() + ", GearWheels: " + GearWheels + ", Gear Name: " + GearName;
            }
        }
    }
