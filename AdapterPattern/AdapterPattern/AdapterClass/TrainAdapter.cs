using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.AdapterClass
{
    public class TrainAdapter : INewTravelTicket
    {
        private readonly Train train;

        public TrainAdapter()
        {
            train = new();
        }
        public void SetDistance(int distance)
        {
            train.SetDistance(distance);
        }
        public void SetMeal(string wantMeal)
        {
            train.SetMeal(wantMeal);
        }
        public void CalculatePrice()
        {
            train.CalculatePrice();
        }
        public void PrintTicket()
        {
            Console.WriteLine("\n     Here is your new ticket");
            train.PrintTicket();
        }
    }
}
