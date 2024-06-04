using System;

class Program
{
    static void Main(string[] args)
    {
        
        Address address1 = new Address("123 Main St", "Springfield", "IL", "United States");
        Lecture event1 = new Lecture("The Future of AI", "Exploring the advancements and implications of artificial intelligence in modern society.", "15/08/2024", "10:00", "Dr. Alan Turing", 200, address1);
        Console.WriteLine($"\n{event1.GetStandardDetails()}");
        Console.WriteLine(event1.GetFullDetails());
        Console.WriteLine(event1.GetShortDescription());


        Address address2 = new Address("456 Oak St", "Los Angeles", "CA", "United States");
        Reception event2 = new Reception("John and Mary's Wedding", "A celebration filled with love and joy", "30/06/2024", "18:00", address2, "johnandmary@example.com");
        Console.WriteLine($"\n{event2.GetStandardDetails()}");
        Console.WriteLine(event2.GetFullDetails());
        Console.WriteLine(event2.GetShortDescription());

        Address address3 = new Address("789 Maple Ave", "Portland", "OR", "United States");
        OutdoorGathering event3 = new OutdoorGathering("Summer BBQ", "A fun gathering with friends and family", "15/07/2024", "14:00", address3, "Sunny");
        Console.WriteLine($"\n{event3.GetStandardDetails()}");
        Console.WriteLine(event3.GetFullDetails());
        Console.WriteLine(event3.GetShortDescription());
    }   
}