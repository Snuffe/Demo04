using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS01
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator e = new Elevator();
            do
            {
                Console.Write("Give a floor (1-5) > ");
                int e.Floor = Console.ReadLine();


            } while (e = true);
        }
    }
}
