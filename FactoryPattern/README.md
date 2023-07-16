# Factory Pattern 
  
  - It is a creational pattern.
  - It define an interface for creating an object. Factory Method lets a class defer instantiation to subclass.
  - Advantages of Factory Pattern is, allows the subclasses to choose the type of the objects to create.
  
  <h3>Problem</h3>
        We are creating a ticket sales system. It gets the transport type from user. After that, the user indicates whether he/she wants to eat or not. Finally, he/she entres the distance to go. 
  
  <h3>Solution</h3>
        With factory pattern we replace direct object constructor calls with calls to a special factory method.
      Here is the Factory class.

      
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
  
  <h3>UML Diagram</h3>
  
  ![image](https://github.com/ErkanOzcanoglu/DesignPatterns/assets/98085368/a6628756-4f51-4095-9357-cabf2d24bda3)
