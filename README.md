# DesignPatterns
  - Design patterns are common solutions for common problems in software design.
  - Each pattern represents an issue that keeps reoccuring.
  - The pattern is not specific piece of code.

### Design Patterns Classification
  - ``Creational Patterns`` are concerned with process of object creation.
  - ``Structural Patterns`` are concerned with how classes and objects composed
  - ``Behavioral Patterns`` are concerned with algorithms

    <h2> 1) Factory Pattern </h2> 

      - It is a creational pattern.
      - It define an interface for creating an object. Factory Method lets a class defer instantiation to subclass.
      - Advantages of Factory Pattern is, allows the subclasses to choose the type of the objects to create.

    <h3>Problem</h3>
      We are creating a ticket sales system. It gets the transport type from user. After that, the user indicates whether he/she wants to eat or not. Finally, he/she entres the distance to go. 
    
    <h3>Solution</h3>
      With factory pattern we replace direct object constructor calls with calls to a special factory method:
      
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

    ![image](https://github.com/ErkanOzcanoglu/DesignPatterns/assets/98085368/bbf896a6-6718-458f-a026-13d6f5536a42)




    
    
