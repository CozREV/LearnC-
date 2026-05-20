using System;
using System.Collections.Generic;
using System.Text;

namespace C_Constructors
{
    internal class Car
    {
        String make;
        String model;
        int year;
        String color;

        public Car(String make, String model, int year, String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public void Drive()
        {
            Console.WriteLine($"You are driving the {color} {make} {model} {year}.");
        }
    }
}
