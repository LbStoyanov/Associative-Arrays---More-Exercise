using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Catalog
    {
        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }

    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }
    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = Console.ReadLine();

            Catalog catalog = new Catalog();
            

            while (data != "end")
            {
                var currentData = data.Split("/").ToArray();

                string type = currentData[0];
                string brand = currentData[1];
                string model = currentData[2];

                if (type == "Car")
                {
                    string horsePower = currentData[3];
                    Car currentCar = new Car();
                    currentCar.Brand = brand;
                    currentCar.Model = model;
                    currentCar.HorsePower = horsePower;
                    catalog.Cars.Add(currentCar);
                }
                else
                {
                    string weight = currentData[3];
                    Truck currentTruck = new Truck();
                    currentTruck.Brand = brand;
                    currentTruck.Model = model;
                    currentTruck.Weight = weight;
                    catalog.Trucks.Add(currentTruck);
                }
                
            }

            var orderedCarCatalog = catalog.Cars.OrderBy(x=> x.Brand).ToList();
            var orderedTruckCatalog = catalog.Trucks.OrderBy(x=> x.Brand).ToList();
            Console.WriteLine("Cars:");
            Console.WriteLine(String.Join(Environment.NewLine,orderedCarCatalog.Select(x => $"{x.Brand}: {x.Model} - {x.HorsePower}hp")));
            Console.WriteLine("Trucks:");
            Console.WriteLine(String.Join(Environment.NewLine,orderedTruckCatalog.Select(x =>$"{x.Brand}: {x.Model} - {x.Weight}kg")));
        }
    }
}
