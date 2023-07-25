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
                        return new Train(); // return a new Train object
                    }
                
                case "bus": case "1": {
                        return new Bus(); // return a new Bus object
                    }
                
                case "plane": case "3": {
                        return new Plane(); // return a new Plane object
                    }

                default: {
                        throw new ArgumentException("Invalid Transportation Type");
                    }
            }
        }
    }
}
