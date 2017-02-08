using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS03
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Toni Tohtori", "Tohtori", 5000);
            Console.WriteLine("Employee:\n- " + employee.ToString());

            Boss boss = new Boss("Pomo Päällikkö", "Pomon pomo", 9000, "Ferrari", 20000);
            Console.WriteLine("Boss:\n- " + boss.ToString());

            employee.Salary = 6000;
            Console.WriteLine("Employee:\n- " + employee.ToString());
        }
    }
}
