using System;
using System.Collections.Generic;
using System.Text;

namespace C_Objects
{
    internal class Human
    {
        public String name;
        public int age;

        public void eat()
        {
            Console.WriteLine(name + " is eating");
        }
        public void sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
        public void yearsOld()
        {
            Console.WriteLine(name + " is " + age + " years old");
        }
    }
}
