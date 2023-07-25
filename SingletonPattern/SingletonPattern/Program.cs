using System.Diagnostics;

namespace SingletonPattern {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine(DateTime.Now.ToLongTimeString()); // get the current time
            var ticketList = TicketList.Instance.GetTickets(); // get the tickets
            foreach (var ticket in ticketList) {
                Console.WriteLine("\n---------- {0} Ticket ----------", ticket.TransportationType);
                Console.WriteLine("Distance: {0}km", ticket.Distance);
                if (ticket.SetMeal > 0) {
                    Console.WriteLine("Meal Price: {0}$", ticket.SetMeal);
                    Console.WriteLine("Total Price: {0} + {1} = {2}$", ticket.Price, ticket.SetMeal, ticket.Price + ticket.SetMeal);
                } else {
                    Console.WriteLine("No Meal Service");
                    Console.WriteLine("Total Price: {0}$", ticket.Price);
                };
                Console.WriteLine("--------------------------------");

            }

            var ticketList2 = TicketList.Instance.GetTickets(); // get the tickets
            Console.WriteLine(DateTime.Now.ToLongTimeString()); // get the current time
            foreach (var ticket in ticketList) {
                Console.WriteLine("\n---------- {0} Ticket ----------", ticket.TransportationType);
                Console.WriteLine("Distance: {0}km", ticket.Distance);
                if (ticket.SetMeal > 0) {
                    Console.WriteLine("Meal Price: {0}$", ticket.SetMeal);
                    Console.WriteLine("Total Price: {0} + {1} = {2}$", ticket.Price, ticket.SetMeal, ticket.Price + ticket.SetMeal);
                } else {
                    Console.WriteLine("No Meal Service");
                    Console.WriteLine("Total Price: {0}$", ticket.Price);
                };
                Console.WriteLine("--------------------------------");

            }
        }
    }
}