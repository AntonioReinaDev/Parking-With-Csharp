using ParkingWithCSharp.Models;
using System;

namespace ParkingWithCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal initialPrice = 0;
            decimal pricePerHour = 0;

            Console.WriteLine("Welcome to the parking system!");
            Console.WriteLine("Enter the starting price: ");
            initialPrice = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Now enter the hourly price:");
            pricePerHour = Convert.ToDecimal(Console.ReadLine());

            Parking parking = new Parking(initialPrice, pricePerHour);

            string option = string.Empty;
            bool displayMenu = true;

            while (displayMenu)
            {
                Console.Clear();
                Console.WriteLine("Enter your option:");
                Console.WriteLine("1 - Register vehicle");
                Console.WriteLine("2 - Remove vehicle");
                Console.WriteLine("3 - List vehicles");
                Console.WriteLine("4 - Close");

                switch (Console.ReadLine())
                {
                    case "1":
                        parking.AddVehicle();
                        break;
                    case "2":
                        parking.RemoveVehicle();
                        break;
                    case "3":
                        parking.ListVehicles();
                        break;
                    case "4":
                        displayMenu = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

                Console.WriteLine("Press a key to continue.");
                Console.ReadKey();
            }

            Console.WriteLine("The program has closed.");
        }
    }
}