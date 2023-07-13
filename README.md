# DesignPatterns
  - Design patterns are common solutions for common problems in software design.
  - Each pattern represents an issue that keeps reoccuring.
  - The pattern is not specific piece of code.

### Design Patterns Classification
  - ``Creational Patterns`` are concerned with process of object creation.
  - ``Structural Patterns`` are concerned with how classes and objects composed.
  - ``Behavioral Patterns`` are concerned with algorithms.

    <h2> 1) Factory Pattern </h2> 

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

    <h2> 2) Singleton Pattern </h2> 
      
      - It is a creational pattern.
      - Lets ensure that a class has only one instance while providing a global access point to the instance.

    <h3>Advanteges</h3>

    
      - Globally access (With Singleton Pattern, we can access all the objects we create anywhere in the project.)      
      - Created only when requested.

        
    <h3>Problem</h3>
        For example, we want to list the tickets we created earlier ( no database in this code ). I don't want to wait for data to arrive every time I need it.

    <h3>Solutions</h3>
        On the first call, create an instance globally. After that, if we need this instance again, first check if there is an instance created before, if there is, use it, otherwise create again. This method is called Singleton Pattern.

    This is were we check.

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

    <h3>UML Diagram</h3>

    ![image](https://github.com/ErkanOzcanoglu/DesignPatterns/assets/98085368/225bb4d0-c93d-4961-b521-683791d126b4)

