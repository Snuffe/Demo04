using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS05
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio r = new AS05.Radio();
            r.Power(true);
            r.SetFrequency(15700.6);
            r.SetFrequency(1900);
            r.SetFrequency(26001);
            r.SetVolume(5);
            r.SetVolume(-1);
            r.SetVolume(10);
            Console.WriteLine("Radio info\n- " + r.ToString());
        }
    }
}
