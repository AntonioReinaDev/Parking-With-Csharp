using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingWithCSharp.Models
{
    public class Parking
    {
        private readonly decimal InitialPrice = 0;
        private readonly decimal PricePerHour = 0;
        private readonly List<string> Vehicles = new List<string>();

        public Parking(decimal initialPrice, decimal pricePerHour)
        {
            InitialPrice = initialPrice;
            PricePerHour = pricePerHour;
        }

        public void AddVehicle()
        {
            Console.WriteLine("Enter vehicle license plate to park:");
            Vehicles.Add(Console.ReadLine());
        }

        public void RemoveVehicle()
        {
            Console.WriteLine("Enter vehicle license plate to remove:");

            string licensePlate;
            licensePlate = Console.ReadLine();

            if (Vehicles.Any(x => x.ToUpper() == licensePlate.ToUpper()))
            {
                int hours;
                decimal totalValue;
                Console.WriteLine("Enter the number of hours the vehicle was parked:");

                hours = int.Parse(Console.ReadLine());
                totalValue = InitialPrice + PricePerHour * hours;

                Vehicles.Remove(licensePlate);

                Console.WriteLine($"The vehicle {licensePlate} was removed and the total price was: R$ {totalValue}");
            }
            else
            {
                Console.WriteLine("Sorry, that vehicle is not parked here. Check if you typed the card correctly");
            }
        }

        public void ListVehicles()
        {
            if (Vehicles.Any())
            {
                Console.WriteLine("Parked vehicles are:");
                Vehicles.ForEach(vehicle => Console.WriteLine(vehicle));
            }
            else
            {
                Console.WriteLine("There are no parked vehicles.");
            }
        }
    }
}