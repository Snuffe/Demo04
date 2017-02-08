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
            Console.Write("Elevator is now in floor 1 \n");
            do
            {
                Console.Write("Give a new floor number (1-5) > ");
                e.Floor = int.Parse(Console.ReadLine());
                Console.Write("Elevator is now in floor " + e.Floor + "\n");


            } while (e.Floor > 0 && e.Floor < 6);
        }
    }
}
