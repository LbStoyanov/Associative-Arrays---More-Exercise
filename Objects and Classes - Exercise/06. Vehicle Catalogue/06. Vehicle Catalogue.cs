using System;
using System.Collections.Generic;

namespace _06._Vehicle_Catalogue
{
    class Catalog
    {
        public Catalog()
        {
            Vehicule = new List<Vehicle>();
        }
        public List<Vehicle> Vehicule { get; set; }
        public double CalculateTruckAverageHorsePower(Catalog vehicules, int horsePower)
        {
            var sumOfHorsePower = 0.0;
            var vehiculesCounter = 0.0;

            foreach (Vehicle vehicule in vehicules.Vehicule)
            {
                if (vehicule.TypeOfVehicle == "truck")
                {
                    sumOfHorsePower += vehicule.Horsepower;
                    vehiculesCounter++;
                }

            }
            double result = sumOfHorsePower / vehiculesCounter;
            return result;
        }

        public double CalculateCarAverageHorsePower(Catalog vehicules, int horsePower)
        {
            double sumOfHorsePower = 0.0;
            double vehiculesCounter = 0.0;

            foreach (Vehicle vehicule in vehicules.Vehicule)
            {
                if (vehicule.TypeOfVehicle == "car")
                {
                    sumOfHorsePower += vehicule.Horsepower;
                    vehiculesCounter++;
                }

            }
            double result = sumOfHorsePower / vehiculesCounter;
            return result;
        }
    }
    class Vehicle
    {
        public string TypeOfVehicle { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string vehiculesInfo = Console.ReadLine();
            Catalog catalog = new Catalog();

            while (vehiculesInfo != "End")
            {
                string[] currentVehiculeInfo = vehiculesInfo.Split(" ");
                string typeOfVehicule = currentVehiculeInfo[0];
                string model = currentVehiculeInfo[1];
                string color = currentVehiculeInfo[2];
                int horsepower = int.Parse(currentVehiculeInfo[3]);
                Vehicle vehicule = new Vehicle();
                vehicule.TypeOfVehicle = typeOfVehicule;
                vehicule.Model = model;
                vehicule.Color = color;
                vehicule.Horsepower = horsepower;
                catalog.Vehicule.Add(vehicule);
                vehiculesInfo = Console.ReadLine();
            }

            string vehiculeInformation = Console.ReadLine();

            while (vehiculeInformation != "Close the Catalogue")
            {
                foreach (Vehicle vehicule in catalog.Vehicule)
                {
                    if (vehiculeInformation == vehicule.Model && vehicule.TypeOfVehicle == "car")
                    {
                        Console.WriteLine($"Type: Car");
                        Console.WriteLine($"Model: {vehicule.Model}");
                        Console.WriteLine($"Color: {vehicule.Color}");
                        Console.WriteLine($"Horsepower: {vehicule.Horsepower}");
                    }
                    else if (vehiculeInformation == vehicule.Model && vehicule.TypeOfVehicle == "truck")
                    {
                        Console.WriteLine($"Type: Truck");
                        Console.WriteLine($"Model: {vehicule.Model}");
                        Console.WriteLine($"Color: {vehicule.Color}");
                        Console.WriteLine($"Horsepower: {vehicule.Horsepower}");
                    }
                }
                vehiculeInformation = Console.ReadLine();
            }

            foreach (Vehicle vehicule in catalog.Vehicule)
            {

                var averageCarHorsePower = catalog.CalculateCarAverageHorsePower(catalog, vehicule.Horsepower);
                Console.WriteLine($"Cars have average horsepower of: {averageCarHorsePower:f2}.");

                var averageTruckHorsePower = catalog.CalculateTruckAverageHorsePower(catalog, vehicule.Horsepower);
                Console.WriteLine($"Trucks have average horsepower of: {averageTruckHorsePower:f2}.");
                break;

            }
        }
    }
}
