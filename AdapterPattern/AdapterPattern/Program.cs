using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterPattern.AdapterClass;

namespace AdapterPattern
{
    public static class Program {
        public static void Main(string[] args) {

            // 1. Create the ticket factory
            TicketFactory ticketFactory = new();

            // 2. Choose the transportation type (Bus, Train, Plane)
            Console.WriteLine("------------------------------------------------------------------------------\n");
            Console.WriteLine("     1. Bus");
            Console.WriteLine("     2. Train");
            Console.WriteLine("     3. Plane\n");
            Console.WriteLine("     Which vehicle do you prefer for the ticket?");
            Console.WriteLine("\n------------------------------------------------------------------------------");
            Console.Write("     Your choice: ");
            string transportation = Console.ReadLine().ToLower();
            ITravelTicket travelTicket = ticketFactory.CreateTicket(transportation);

            // 3. Choose the setmeal
            Console.WriteLine("------------------------------------------------------------------------------\n");
            Console.WriteLine("\n     Do you want to add a meal?");
            Console.WriteLine("     1. Yes");
            Console.WriteLine("     2. No");
            Console.WriteLine("\n------------------------------------------------------------------------------");
            Console.Write("     Your choice: ");
            string setmeal = Console.ReadLine().ToLower();
            travelTicket.SetMeal(setmeal);

            // 4. Choose the distance
            Console.WriteLine("------------------------------------------------------------------------------\n");
            Console.WriteLine("\n     What is the distance want to go: ");
            Console.WriteLine("\n------------------------------------------------------------------------------");
            Console.Write("     Your choice: ");
            int distance = Convert.ToInt32(Console.ReadLine());
            travelTicket.SetDistance(distance);

            // 5. Calculate the price and print the ticket
            travelTicket.CalculatePrice();
            travelTicket.PrintTicket();

            Console.WriteLine("------------------------------------------------------------------------------\n");
            Console.WriteLine("     1. Buy");
            Console.WriteLine("     2. Change");
            Console.WriteLine("     3. Quit");
            Console.WriteLine("\n------------------------------------------------------------------------------");
            Console.Write("     Your choice: ");
            string secim = Console.ReadLine().ToLower();
            Console.WriteLine("------------------------------------------------------------------------------\n");
            TicketFactory newTicket = new TicketFactory();
            switch (secim) {
                case "buy":
                case "1": {
                        travelTicket.PrintTicket();
                        break;
                    }
                case "change":
                case "2": {
                        Console.WriteLine("------------------------------------------------------------------------------\n");
                        Console.WriteLine("     1. Bus");
                        Console.WriteLine("     2. Train");
                        Console.WriteLine("     3. Plane\n");
                        Console.WriteLine("     Which vehicle do you prefer for the ticket?");
                        Console.WriteLine("\n------------------------------------------------------------------------------");
                        Console.Write("     Your choice: ");
                        string? newTransportation = Console.ReadLine();
                        INewTravelTicket newticket = newTicket.ChangeTicket(newTransportation, setmeal, distance);
                        newticket.SetMeal(setmeal);
                        newticket.SetDistance(distance);
                        newticket.CalculatePrice();
                        newticket.PrintTicket();
                        break;
                    }
                case "quit":
                case "3": {
                        Console.WriteLine("bye.");
                        break;
                    }
                default:
                    Console.WriteLine("...");
                    break;
            }
        }
    }
}
