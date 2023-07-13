namespace FactoryPattern {
    internal class Program {
        static void Main(string[] args) {

            // 1. Create the ticket factory
            TicketFactory ticketFactory = new TicketFactory();

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
            Console.WriteLine("\n     Do you want to add a meal?");
            Console.WriteLine("     1. Yes");
            Console.WriteLine("     2. No");
            Console.Write("     Your choice: ");
            string setmeal = Console.ReadLine().ToLower();
            travelTicket.SetMeal(setmeal);
            
            // 4. Choose the distance
            Console.WriteLine("\n     What is the distance want to go: ");
            Console.Write("     Your choice: ");
            int distance = Convert.ToInt32(Console.ReadLine());
            travelTicket.SetDistance(distance);

            // 5. Calculate the price and print the ticket
            travelTicket.CalculatePrice();
            travelTicket.PrintTicket();

        }
    }
}