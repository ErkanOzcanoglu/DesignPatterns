using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern {
    public class Plane : ITravelTicket {

        private int distance;

        private double price;

        private int setmeal;

        private string? roundedPrice; // Nullable type

        public void SetDistance(int distance) {
            this.distance = distance;
        }

        public void SetMeal(string wantMeal) {
            if (wantMeal == "1" || wantMeal == "yes") {
                this.setmeal = 40;
            } else if (wantMeal == "2" || wantMeal == "no") {
                this.setmeal = 0;
            } else {
                Console.WriteLine("     Please enter a valid choice.");
                throw new ArgumentException("Invalid Meal Choice");
            }
        }

        public void CalculatePrice() {
            this.price = ( distance * 1 );
            roundedPrice = price.ToString("0.00");
        }

        public void PrintTicket() {
            Console.WriteLine("\n     --------- Plane Ticket ---------");
            Console.WriteLine("     Distance: {0}km", distance);
            if (setmeal > 0) {
                Console.WriteLine("     Meal Price: {0}$", setmeal);
                Console.WriteLine("     Total Price: {0} + {1} = {2}$", roundedPrice, setmeal, price + setmeal);
            } else {
                Console.WriteLine("     No Meal Service");
                Console.WriteLine("     Total Price: {0}$", roundedPrice);
            };
            Console.WriteLine("     --------------------------------");
        }
    }
}
