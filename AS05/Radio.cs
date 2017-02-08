using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS05
{
    class Radio
    {

        public double Frequency { get; set; }
        public bool isOn { get; set; }
        public int Volume { get; set; }

        public void Power(bool PowerSwitch)
        {
            isOn = PowerSwitch;
        }

        public void SetFrequency(double value)
        {
            if (value <= 26000.0 && value >= 2000.0)
            {
                Frequency = value;
            }
        }

        public void SetVolume(int value)
        {
            if (value >= 1 && value <= 9)
            {
                Volume = value;
            }
        }

        public override string ToString()
        {
            return "Power: " + isOn + ", Volume: " + Volume + ", Frequency: " + Frequency;
        }

    }
}
