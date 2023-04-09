using Class02Homework2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02Homework2.Entities
{
    public class Car : Vehicle, ICarWash
    {
        public override void Drive()
        {
            Console.WriteLine("I am a car and I can drive on a road!");
        }

        public void WashCar()
        {
            Console.WriteLine($"Washing the {Brand} {Model}");
        }


       
        public void WashTrailer()
        {
            Console.WriteLine("Washing the trailer...");
        }
    }
}
