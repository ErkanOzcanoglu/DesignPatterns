using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern {
    public class TicketFactory {

        public ITravelTicket CreateTicket(string transportation) {
            switch (transportation) {

                case "train":
                case "2": {
                        return new Train();
                    }

                case "bus":
                case "1": {
                        return new Bus();
                    }

                case "plane":
                case "3": {
                        return new Plane();
                    }

                default: {
                        throw new ArgumentException("Invalid Transportation Type");
                    }
            }
        }

        public ITravelTicket ChangeTicket(string type,string setmeal,int distance) {

            switch(type) {
            
                case "train":
                case "2": {
                        return new TrainAdapter();
                    }
                case "bus":
                case "1": {
                        return new BusAdapter();
                    }
                case "plane":
                case "3": {
                        return new PlaneAdapter();
                    }
                default:
                    throw new ArgumentException("Invalid ticket type.");
            }
        }
    }
}
