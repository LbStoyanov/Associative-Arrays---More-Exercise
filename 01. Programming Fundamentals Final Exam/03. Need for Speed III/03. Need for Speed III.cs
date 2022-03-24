using System;
using System.Collections.Generic;

namespace _03._Need_for_Speed_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            Dictionary<string, List<int>> carsInfo = new Dictionary<string, List<int>>();

            for (int i = 0; i < numberOfCars; i++)
            {
                var currentCarInfo = Console.ReadLine().Split('|');
                var currCarModel = currentCarInfo[0];
                var mileage = int.Parse(currentCarInfo[1]);
                var fuel = int.Parse(currentCarInfo[2]);
                List<int> carCondition = new List<int>();
                carCondition.Add(mileage);
                carCondition.Add(fuel);
                carsInfo.Add(currCarModel, carCondition);
            }

            string commands = Console.ReadLine();

            while (commands != "Stop")
            {
                string[] currAction = commands.Split(" : ");
                string mainComand = currAction[0];
                if (mainComand == "Drive")
                {
                    string car = currAction[1];
                    int distance = int.Parse(currAction[2]);
                    int fuel = int.Parse(currAction[3]);
                    carsInfo = DriveCar(carsInfo, car, distance, fuel);
                }
                else if (mainComand == "Refuel")
                {
                    string car = currAction[1];
                    int fuel = int.Parse(currAction[2]);
                    carsInfo = RefuelCar(carsInfo, car, fuel);
                }
                else
                {
                    string car = currAction[1];
                    int kilometersToBeReverted = int.Parse(currAction[2]);
                    carsInfo = RevertCar(carsInfo, car, kilometersToBeReverted);
                }

                commands = Console.ReadLine();
            }

            foreach (var car in carsInfo)
            {
                var currCar = car.Key;
                var currMilage = carsInfo[currCar][0];
                var currFuel = carsInfo[currCar][1];

                Console.WriteLine($"{currCar} -> Mileage: {currMilage} kms, Fuel in the tank: {currFuel} lt.");
            }
        }
        static Dictionary<string, List<int>> RevertCar(Dictionary<string, List<int>> carsInfo, string car, int kilometersToBeReverted)
        {
            carsInfo[car][0] -= kilometersToBeReverted;
            
            if (carsInfo[car][0] < 10000)
            {
                carsInfo[car][0] = 10000;
            }
            else
            {
                Console.WriteLine($"{car} mileage decreased by {kilometersToBeReverted} kilometers");
            }
            return carsInfo;
        }
        static Dictionary<string, List<int>> RefuelCar(Dictionary<string, List<int>> carsInfo, string car, int fuel)
        {
            int carTank = carsInfo[car][1];
            if (carTank + fuel > 75)
            {
                int refueldQuantity = 75 - carTank;
                carsInfo[car][1] = 75;
                
                Console.WriteLine($"{car} refueled with {refueldQuantity} liters");
            }
            else
            {
                Console.WriteLine($"{car} refueled with {fuel} liters");
                carsInfo[car][1] += fuel;
            }
            return carsInfo;
        }
        static Dictionary<string, List<int>> DriveCar(Dictionary<string, List<int>> carsInfo, string car, int distance, int fuel)
        {
            
            int fuelInTheTank = carsInfo[car][1];

            if (fuelInTheTank < fuel)
            {
                Console.WriteLine($"Not enough fuel to make that ride");
            }
            else
            {
                carsInfo[car][0] += distance;
                carsInfo[car][1] -= fuel;

                int drivenDistance = carsInfo[car][0];
                
                if (drivenDistance > 100000)
                {
                    Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                    Console.WriteLine($"Time to sell the {car}!");
                    carsInfo.Remove(car);
                }
                else
                {
                    Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                }
            }

            return carsInfo;
        }
    }
}
