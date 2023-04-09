using Class02Homework2.Interfaces;

namespace Class02Homework2.Entities
{
    public class CarWash : ICarWash
    {
        public void WashCar()
        {
            Console.WriteLine("Washing the car... ");
        }

        public void WashTrailer()
        {
            Console.WriteLine("A clean trailer is a good trailer.");
        }
    }
}
