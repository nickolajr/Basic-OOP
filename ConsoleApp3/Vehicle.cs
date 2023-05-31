using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    
    class Vehicle
    {
        public string Manufactorer;
        public string Color;
        public string Model;
        public int Year;
        public int Speed;
        public virtual void VehicleSound()
        {
            Console.WriteLine("The Vehicle Makes Sound");
        }
            
        }
    
}
