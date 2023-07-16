using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern {
    public class PlaneAdapter: ITravelTicket {
        private readonly Plane plane;

        public PlaneAdapter() {
            plane = new();
        }
        public void SetDistance(int distance) {
            plane.SetDistance(distance);
        }
        public void SetMeal(string wantMeal) {
            plane.SetMeal(wantMeal);
        }
        public void CalculatePrice() {
            plane.CalculatePrice();
        }
        public void PrintTicket() {
            Console.WriteLine("\n     Here is your new ticket");
            plane.PrintTicket();
        }
    }
}
