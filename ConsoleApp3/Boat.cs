using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Boat : Vehicle
    {
        //constructor
        public Boat(string Model, string Color, int Year, int Speed, string Manufactorer)
        {
            this.Manufactorer = Manufactorer;
            this.Model = Model;
            this.Color = Color;
            this.Year = Year;
            this.Speed = Speed;
        }
        //an override of vehicle sound that is named the same in all inherited classes of Vehicle But with diffrent values
        public override void VehicleSound()
        {
            Console.WriteLine("The Boat goes splash");
        }

        // a basic method that can be run by an object
        public void Drive()
        {
            Console.WriteLine($"You drive the {Manufactorer} {Model} that goes {Speed}km/h and is from the year {Year}");
        }
    }
}
