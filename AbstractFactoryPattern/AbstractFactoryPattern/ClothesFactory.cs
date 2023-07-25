using AbstractFactoryPattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern {
    abstract class ClothesFactory  {
        public abstract Shirt CreateShirt();
        public abstract Trouser CreateTrouser();
    }
}
