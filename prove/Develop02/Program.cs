using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("WELCOME");
        String choice;
        PromptGenerator promptGenerator = new PromptGenerator();

        promptGenerator.AddPrompt("What's your favorite childhood memory?");
        promptGenerator.AddPrompt("If you could travel anywhere in the world, where would you go?");
        promptGenerator.AddPrompt("What is your biggest dream for the future?");

        Journal journal = new Journal(); // Instancia única del diario
        
        do
        {
            Console.WriteLine("Please select one of the following choises bellow");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            choice = Console.ReadLine();
            
            if (choice == "1")
            {
                
                
                string prompt = promptGenerator.GetRandomPrompt(); // Obtener una pregunta aleatoria
                Console.WriteLine(prompt); // Mostrar la pregunta al usuario
                string answer = Console.ReadLine(); // Leer la respuesta del usuario
                journal.AddEntry(prompt, answer); // Agregar la entrada al diario

                // body
            }
            else if (choice == "2")
            {
                // body
                Console.WriteLine("\nEntries:");
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Enter the file name to load:");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);

            }
            else if (choice == "4")
            {
                Console.WriteLine("Enter the file name to save:");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }
            else 
            {
                Console.WriteLine("Goodbye");
            }

        }while(choice != "5");
    
    }
}   