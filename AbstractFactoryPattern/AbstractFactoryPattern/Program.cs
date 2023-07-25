using AbstractFactoryPattern.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern {
    public class Program {
        static void Main(string[] args) {
            User user1 = new User(new ElegantClothesFactory());
            user1.GetClothes();
            Console.WriteLine("User1: {0}", user1.GetClothes());

            User user2 = new User(new CasualClothesFactory());
            user2.GetClothes();
            Console.WriteLine("User2: {0}", user2.GetClothes());

            Console.ReadKey();
        }
    }
}
