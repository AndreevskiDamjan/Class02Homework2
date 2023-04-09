using Class02Homework2.Interfaces;

namespace Class02Homework2.Entities
{
    public class GasPump : IGasPump
    {
        public void PumpGas()
        {
            Console.WriteLine("Pumping fuel...pump pump pump...");
        }
    }
}
