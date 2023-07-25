using AbstractFactoryPattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Factories {
    class ElegantClothesFactory : ClothesFactory {
        public override Shirt CreateShirt() {
            return new DressShirt();
        }

        public override Trouser CreateTrouser() {
            return new SuitTrousers();
        }
    }
}
