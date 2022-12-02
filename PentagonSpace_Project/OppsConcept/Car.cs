using System;
using System.Collections.Generic;
using System.Text;

namespace PentagonSpace_Project.OppsConcept
{
    class Car
    {
        string name;
        int Model;
        int price;
        string colour;
        public void AcceptDetails(String carname, int carmodel, int carprice, String carcolour)
        {
            name = carname;
            Model = carmodel;
            price = carprice;
            colour = carcolour;
        }
        public void Display()
        {
            Console.WriteLine("Name of car "+ name);
            Console.WriteLine("Model NNumber " + Model);
            Console.WriteLine("Price of car is " + price);
            Console.WriteLine("Car colour is " + colour);
        }
        static void Main(string[] args)
        {
            Car c = new Car();
            c.AcceptDetails("manhindra", 101, 78915, "red");
            c.Display();

            Console.WriteLine("//////////////////////////////////");

            Car c1 = new Car();
            c1.AcceptDetails("Tata", 102, 848475, "Balck");
            c1.Display();
            Console.WriteLine("///////////////////////////////////////");

            Car c2 = new Car();
            c2.AcceptDetails("safari", 103, 98546, "yellow");
            c2.Display();
        }
    }
}
