using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.AdapterClass
{
    public interface INewTravelTicket
    {
        void SetDistance(int distance);
        void SetMeal(string wantMeal);
        void CalculatePrice();
        void PrintTicket();
    }
}
