using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Reference class
        Reference reference = new Reference("1 Nephi", 6, 3);

        // Text from the Book of Mormon (just an example, you can use real text)
        string text = "And it mattereth not to me that I am particular to give a full account of all the things of my father, for they cannot be written upon athese plates, for I desire the room that I may write of the things of God.";

        // Create an instance of the Scripture class
        Scripture scripture = new Scripture(reference, text);

        // Display the initial text in the console
        Console.WriteLine("Press Enter to start hiding words or type 'quit' to finish the game:\n");
        Console.WriteLine(scripture.GetDisplayText());

        // Loop to wait for the user to press Enter or type "quit"
        string input;
        while (true)
        {
            // Wait for the user to type something and press Enter
            input = Console.ReadLine();

            // If the user types "quit", exit the loop
            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Game over!");
                break;
            }

            // Hide two random words
            scripture.HideRandomWords(2);

            // Display the updated text in the console
            Console.WriteLine(scripture.GetDisplayText());

            // Check if all words are hidden, then end the game
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. Game over!");
                break;
            }
        }
    }
}

// As a creativity criterion, I added the capability for the program to convert the word "quit" to lowercase, thus avoiding errors when typing in uppercase. Additionally, I flagged when the program finishes.