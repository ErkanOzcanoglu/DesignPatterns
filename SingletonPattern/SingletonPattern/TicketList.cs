using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern {
    public class TicketList {

        private static TicketList instance;
        public static TicketList Instance {
            get {
                if (instance is not null) {
                    return instance;
                } else {
                    instance = new TicketList();
                    return instance;
                }
            }
            set => instance = value;
        }
        private new List<Ticket> Tickets { get; set; }
        public List<Ticket> GetTickets() 
            {

            if (Tickets is null) {
                int time = 2000;
                Thread.Sleep(time);
                Tickets = new List<Ticket>()
                {
                    new Ticket(){TransportationType = "Bus", SetMeal = 1, Distance = 200, Price = 115 },
                    //new Ticket(){TransportationType = "Bus", SetMeal = 2, Distance = 200, Price = 100 },
                    new Ticket(){TransportationType = "Train", SetMeal = 1, Distance = 200, Price = 180 },
                    //new Ticket(){TransportationType = "Train", SetMeal = 2, Distance = 200, Price = 160 },
                    new Ticket(){TransportationType = "Plane", SetMeal = 1, Distance = 200, Price = 240 },
                    //new Ticket(){TransportationType = "Plane", SetMeal = 2, Distance = 200, Price = 200 }
                };
        }
            return Tickets;
        }
    }
}
