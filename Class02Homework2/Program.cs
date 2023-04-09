using Class02Homework2.Entities;

Car car = new Car()
{
    Brand = "Alfa Romeo",
    HorsePower = 100,
    Model = "156",
    YearOfProduction = 2006
};
car.Drive();

Truck truck = new Truck()
{
    Brand = "Volvo",
    Model = "T105",
    YearOfProduction = 2023,
    HorsePower = 200
};
car.WashCar();