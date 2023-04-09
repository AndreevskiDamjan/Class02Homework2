using Class02Homework2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02Homework2.Entities
{
    public class CarCenter : ICarWash, IGasPump, IRepairService
    {
        public void CheckVehicle()
        {
            Console.WriteLine("Checking the vehicles from the lot...");
        }

        public void FixVehicle()
        {
            Console.WriteLine("Fixing broken vehicles...");
        }

        public void PumpGas()
        {
            Console.WriteLine("Refueling...");
        }

        public void WashCar()
        {
            Console.WriteLine("Washing the dirty cars...");
        }

        public void WashTrailer()
        {
            Console.WriteLine("Washing the trailer....");
        }
    }
}
