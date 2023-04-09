namespace Class02Homework2.Entities
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int YearOfProduction { get; set; }

        public int HorsePower { get; set; }

        public abstract void Drive();
    }
}
