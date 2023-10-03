# Adapter Pattern
  - It is a structural pattern.
  - Convert the interface of a class into another interface clients expect.
  - Adapter pattern lets classes work together.

    <h3>Problem</h3>
        We would like to add an option to change the ticket to the previously used ticket purchasing system.

    <h3>Solutions</h3>
        If the user wants to change his ticket, we first get the name of the vehicle he wants to change. then we print the new ticket on the screen with the features selected while buying the ticket.

        public class BusAdapter : INewTravelTicket
    {
        private readonly Bus bus;

        public BusAdapter()
        {
            bus = new();
        }
        public void SetDistance(int distance)
        {
            bus.SetDistance(distance);
        }
        public void SetMeal(string wantMeal)
        {
            bus.SetMeal(wantMeal);
        }
        public void CalculatePrice()
        {
            bus.CalculatePrice();
        }
        public void PrintTicket()
        {
            Console.WriteLine("\n     Here is your new ticket");
            bus.PrintTicket();
        }
    }

    <h3>UML Diagram</h3>

    ![image](https://github.com/ErkanOzcanoglu/DesignPatterns/assets/98085368/c90331bb-8e2b-45be-ae6b-d0a370f611bb)
