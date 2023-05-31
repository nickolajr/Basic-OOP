using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    
    
    class Car : Vehicle
    {
        //Constructor
        public Car(string Model, string Color, int Year, int Speed, string Manufactorer)
        {
            this.Manufactorer = Manufactorer;
            this.Model = Model;
            this.Color = Color;
            this.Year = Year;
            this.Speed = Speed;
                 
        }
        private int wheels;
        public int Wheels
        {
            get { return wheels; }//Read
            set { wheels = value; }// Write
        }


        public void NrWheels()
        {
            Console.WriteLine($"your car has {wheels} wheels");
        }
        //an override of vehicle sound that is named the same in all inherited classes of Vehicle But with diffrent values
        public override void VehicleSound()
        {
            Console.WriteLine("The Car goes Wroom");
        }
        public void Drive()
                {
                    Console.WriteLine($"You drive the {Manufactorer} {Model} that goes {Speed}km/h and is from the year {Year}");
                }
            }
}

