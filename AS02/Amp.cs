using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS02
{
    class Amp
    {
        private int Volume;
        private int minVolume = 0;
        private int maxVolume = 100;

        public int SetVolume(int volume)
        {
            if (volume <= maxVolume && volume >= minVolume)
            {
                Volume = volume;
            }
            else if (volume < minVolume)
            {
                Volume = minVolume;
                Console.Write("-> Too low volume - Amplifier volume is sot the minimum : 0");
            }
            else if (volume > maxVolume)
            {
                Volume = maxVolume;
                Console.Write("-> Too much volume - Amplifier volume is set to maximum : 100");
            }
            return Volume;
        }
    }
}
