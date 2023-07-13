using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern {
    public class TicketFactory {
        public ITravelTicket CreateTicket(string transportation) {
            switch (transportation) {
                
                case "train": case "2": {
                        return new Train();
                    }
                
                case "bus": case "1": {
                        return new Bus();
                    }
                
                case "plane": case "3": {
                        return new Plane();
                    }

                default: {
                        throw new ArgumentException("Invalid Transportation Type");
                    }
            }
        }
    }
}
