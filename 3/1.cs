using System;

class MovieClass {
    private string name;
    private int ticketPrice;
    public string Name {
        get {return name;}
        set {name = value;}
    }

    public int TicketPrice {
        get {return ticketPrice;}
        set {ticketPrice = (value > 80) ? 80 : value;}
    }

    public MovieClass(string name, int price) {
        this.Name = name;
        this.TicketPrice = price;
    }
}

struct MovieStruct {
    private string name;
    private int ticketPrice;
    public string Name {
        get { return name;}
        set {name = value; }
    }
    public int TicketPrice {
        get {return ticketPrice;}
        set {ticketPrice = value > 80 ? 80 : value;}
    }
    public MovieStruct (string name, int price) {
        this.Name = name;
        this.TicketPrice = price;
    }
}




class Program
{
    static void Main()
    {
        MovieClass movieClass1 = new MovieClass("Titanic", 100);
        MovieStruct movieStruct1 = new MovieStruct("Titanic", 100);

        Console.WriteLine(movieClass1.TicketPrice);   // 80
        Console.WriteLine(movieStruct1.TicketPrice);  // 80

        MovieClass movieClass2 = movieClass1;
        MovieStruct movieStruct2 = movieStruct1;

        movieClass2.TicketPrice = 40;
        movieStruct2.TicketPrice = 40;

        Console.WriteLine(movieClass1.TicketPrice);  
        Console.WriteLine(movieStruct1.TicketPrice);  
    }
}
