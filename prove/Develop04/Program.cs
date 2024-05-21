using System;
// Added functionality to view the entered list of responses as part of enhancing creativity, accessible through 
// option 3 in the ListingActivity, allowing users to engage with their input and explore their reflections
class Program
{
    static void Main(string[] args)
    {
        var choise = "";
        do
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("     1. Start Breathing activity");
            Console.WriteLine("     2. Start Reflecting activity");
            Console.WriteLine("     3. Start Listing activuty");
            Console.WriteLine("     4. QUIT");
            Console.Write("SELECT A CHOISE FROM THE MENU:  ");
            choise = Console.ReadLine();
            if (choise == "1" )
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                
                breathingActivity.Run();
                
                
                
            }
            else if (choise == "2" )
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else  if (choise == "3" )
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            else if (choise == "4" )
            {
                Console.WriteLine("GOODBYE");
            }
            else
            {
                Console.WriteLine("Select a valid Choise");
            }

        }while(choise != "4");
    }
}