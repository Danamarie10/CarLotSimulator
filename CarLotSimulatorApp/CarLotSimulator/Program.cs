using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLot = new CarLot();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            var car1 = new Car();
            car1.Make = "Ford";
            car1.Model = "Bronco";
            car1.Year = 2015;
            car1.IsDrivable = true;
            car1.EngineNoise = "Vroom";
            car1.HonkNoise = "Beep Beep";
            carLot.ParkingLot.Add(car1);
            var car2 = new Car();
            car2.Make = "Honda";
            car2.Model = "Civic";
            car2.Year = 2023;
            car2.IsDrivable = true;
            car2.EngineNoise = "Vroom";
            car2.HonkNoise = "Honk";
            carLot.ParkingLot.Add(car2);
            var car3 = new Car();
            car3.Make = "Chevy";
            car3.Model = "TrailBlazer";
            car3.Year = 2018;
            car3.IsDrivable = true;
            car3.EngineNoise = "Vroom";
            car3.HonkNoise = "Beep";
            carLot.ParkingLot.Add(car3);

            foreach(var car in carLot.ParkingLot)
            {
                Console.WriteLine($"This is a {car.Make} {car.Model} and the year is {car.Year}.");
            }

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
