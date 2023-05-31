using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press 1 for car and 2 for boat");
            int Choice = Convert.ToInt32(Console.ReadLine());

            // a lot of questions that make up the users Vehicle Object
            if (Choice == 1)
            {
                Console.WriteLine("how many wheels does your car have");
                int CarWheelsChoice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Who Made Your Car?");
                String CarManChoice = Console.ReadLine();
                Console.WriteLine("what car model do you have?");
                string CarModelChoice = Console.ReadLine();
                Console.WriteLine("what color is it?");
                string CarColorChoice = Console.ReadLine();
                Console.WriteLine("when is it from?");
                int CarYearChoice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("how fast does it go in KM/H?");
                int CarSpeedChoice = Convert.ToInt32(Console.ReadLine());
                Car car1 = new Car(CarModelChoice, CarColorChoice, CarYearChoice, CarSpeedChoice, CarManChoice);
                car1.Drive();
                car1.VehicleSound();
                car1.Wheels = CarWheelsChoice;
                car1.NrWheels();

                
            }
            else if (Choice == 2)
            {
                Console.WriteLine("Who Made Your Boat?");
                String BoatManChoice = Console.ReadLine();
                Console.WriteLine("what Boat model do you have?");
                string BoatModelChoice = Console.ReadLine();
                Console.WriteLine("what color is it?");
                string BoatColorChoice = Console.ReadLine();
                Console.WriteLine("when is it from?");
                int BoatYearChoice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("how fast does it go in KM/H?");
                int BoatSpeedChoice = Convert.ToInt32(Console.ReadLine());
                //object
                Boat boat1 = new Boat(BoatModelChoice, BoatColorChoice, BoatYearChoice, BoatSpeedChoice, BoatManChoice);
                boat1.Drive();
                boat1.VehicleSound();
            }           
            
            
            Console.ReadKey();
        }
    }
}
