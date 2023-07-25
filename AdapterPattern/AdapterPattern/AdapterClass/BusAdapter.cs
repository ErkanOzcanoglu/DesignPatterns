using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.AdapterClass
{
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
}
