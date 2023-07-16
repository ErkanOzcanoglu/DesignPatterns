# Singleton Pattern 
      
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
