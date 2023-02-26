using System;

class SimpleAIProgram {
    static void Main() {
        Console.WriteLine("Welcome to Simple AI Program");
        
        Console.WriteLine("Please enter your name:");
        string name = Console.ReadLine();
        
        Console.WriteLine($"Hello {name}, are you happy today? (yes/no)");
        string answer = Console.ReadLine();
        
        if (answer.ToLower() == "yes") {
            Console.WriteLine("That's great to hear! Keep it up.");
        } else if (answer.ToLower() == "no") {
            Console.WriteLine("I'm sorry to hear that. Do you want to talk about it? (yes/no)");
            string talkAboutIt = Console.ReadLine();
            
            if (talkAboutIt.ToLower() == "yes") {
                Console.WriteLine("Okay, what's bothering you?");
                string problem = Console.ReadLine();
                Console.WriteLine($"I'm sorry to hear that {name}, I hope things get better for you soon.");
            } else if (talkAboutIt.ToLower() == "no") {
                Console.WriteLine($"Okay {name}, take care.");
            } else {
                Console.WriteLine("Invalid input. Please try again.");
            }
        } else {
            Console.WriteLine("Invalid input. Please try again.");
        }
        
        Console.WriteLine("Thank you for using Simple AI Program!");
    }
}
