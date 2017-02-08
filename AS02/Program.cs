using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS02
{
    class Program
    {
        static void Main(string[] args)
        {
            int user_volume;
            int new_volume;
            Amp amp = new Amp();

            do
            {
                Console.Write("Give a new volume value (0-100) > ");
                user_volume = int.Parse(Console.ReadLine());
                new_volume = amp.SetVolume(user_volume);
                Console.Write("-> Amplifier volume is set to : " + new_volume + "\n");
            } while (user_volume != -1);
        }
    }
}
