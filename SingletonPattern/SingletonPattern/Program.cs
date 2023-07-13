namespace SingletonPattern {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine(DateTime.Now.ToLongTimeString());
            var ticketList = TicketList.Instance.GetTickets();
            foreach (var ticket in ticketList) {
                Console.WriteLine("Transportation Type: {0}, Set Meal: {1}, Distance: {2}, Price: {3}", ticket.TransportationType, ticket.SetMeal, ticket.Distance, ticket.Price);
            }

            var ticketList2 = TicketList.Instance.GetTickets();
            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }
    }
}