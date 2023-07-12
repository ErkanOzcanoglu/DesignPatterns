using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern {
    public class Bus : ITravelTicket {

        private int distance;

        private double price;

        private int setmeal;

        public void SetDistance(int distance) {
            this.distance = distance;
        }

        public void SetMeal(string setMeal) {
            if (setMeal == "1" || setMeal == "Yes" || setMeal == "yes") {
                this.setmeal = 15;
            } else if (setMeal == "2" || setMeal == "No" || setMeal == "no") {
                this.setmeal = 0;
            } else {
                Console.WriteLine("     Please enter a valid choice.");
                throw new ArgumentException("Invalid Meal Choice");
            }
        }

        public void CalculatePrice() {
            this.price = distance * 0.5;
        }

        public void PrintTicket() {
            Console.WriteLine("\n--------- Train Ticket ---------");
            Console.WriteLine("Distance: {0}km", distance);
            if (setmeal > 0) {
                Console.WriteLine("Meal Price: {0}$", setmeal);
                Console.WriteLine("Total Price: {0} + {1} = {2}$", price, setmeal, price + setmeal);
            } else {
                Console.WriteLine("No Meal Service");
                Console.WriteLine("Total Price: {0}$", price);
            };
            Console.WriteLine("--------------------------------");
        }
    }
}
