using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern {
    public class TicketFactory {
        public ITravelTicket CreateTicket(string transportation) {
            switch (transportation) {
                
                case "train": case "Train": case "2": {
                        return new Train();
                    }
                
                case "bus":   case "Bus":   case "1": {
                        return new Bus();
                    }
                
                case "plane": case "Plane": case "3": {
                        return new Plane();
                    }

                default: {
                        throw new ArgumentException("Invalid Transportation Type");
                    }
            }
        }
    }
}
