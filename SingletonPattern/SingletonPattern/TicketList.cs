using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern {
    public class TicketList {

        private static TicketList instance; // create a static instance of the class
        public static TicketList Instance { 
            get {
                if (instance is not null) { 
                    return instance; // return the instance if it is not null
                } else {
                    instance = new TicketList(); // create a new instance if it is null
                    return instance;
                }
            }
            set => instance = value;
        }

        private new List<Ticket> Tickets { get; set; } // create a list of tickets
        public List<Ticket> GetTickets() // create a method to get the tickets
            {

            if (Tickets is null) { // if the list is null, create a new list
                int time = 2000;
                Thread.Sleep(time); // wait for 2 seconds
                Tickets = new List<Ticket>()
                {
                    new Ticket(){TransportationType = "Bus", SetMeal = 1, Distance = 200, Price = 115 },
                    new Ticket(){TransportationType = "Bus", SetMeal = 2, Distance = 200, Price = 100 },
                    new Ticket(){TransportationType = "Train", SetMeal = 1, Distance = 200, Price = 180 },
                    new Ticket(){TransportationType = "Train", SetMeal = 2, Distance = 200, Price = 160 },
                    new Ticket(){TransportationType = "Plane", SetMeal = 1, Distance = 200, Price = 240 },
                    new Ticket(){TransportationType = "Plane", SetMeal = 2, Distance = 200, Price = 200 }
                };
        }
            return Tickets;
        }
    }
}
