using AbstractFactoryPattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Factories {
    class CasualClothesFactory : ClothesFactory {
        public override Shirt CreateShirt() {
            return new PoloShirt();
        }

        public override Trouser CreateTrouser() {
            return new Jeans();
        }
    }
}
