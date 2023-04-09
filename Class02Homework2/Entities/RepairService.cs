using Class02Homework2.Interfaces;

namespace Class02Homework2.Entities
{
    public class RepairService : IRepairService
    {
        public void CheckVehicle()
        {
            Console.WriteLine("Vehicle undergoing checkup!");
        }

        public void FixVehicle()
        {
            Console.WriteLine("Fixing the vehicle...might take a while...");
        }
    }
}
