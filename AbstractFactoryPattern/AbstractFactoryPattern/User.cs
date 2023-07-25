using AbstractFactoryPattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern {
     class User {
        private readonly Shirt shirt;
        private readonly Trouser trouser;
    
        public User(ClothesFactory factory) {
            shirt = factory.CreateShirt();
            trouser = factory.CreateTrouser();
        }

        public string GetClothes() {
            return string.Format("I'm wearing {0} and {1}", shirt.GetType().Name, trouser.GetType().Name);
        }

    }
}
