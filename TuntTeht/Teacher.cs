using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Teacher : Person
    {
        public string Room { get; set; }

        // default constructor
        public Teacher()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public Teacher(string firstName, string lastName, string room) 
            : base(firstName,lastName)
        {
            Room = room;
        }
        
        // just one method what Teacher can do 
        public void TeacherMethod()
        {
            Console.WriteLine("This method belongs to Teacher!");
        }

        //Person-luokan Tostring + Room
        //Firstname + Lastname ... + Room
        //base viittaa tliluokkaan eli nyt Person-luokkaan
        public override string ToString()
        {
            return base.ToString() + " " + Room;
        }
    }
}
