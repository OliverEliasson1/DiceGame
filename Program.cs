using System.Net;
using System.Runtime.InteropServices;

namespace DiceGame;

class Program
{
    private static Random rnd = new Random();
    static void Main()
    {
        Console.WriteLine("Dice throw!");
        
        while (true)
        {
            Console.WriteLine("Throwing dice...");
            Thread.Sleep(500);
            DiceThrow();
            
            Console.WriteLine("Do you want to play again? (y/n)");
            string key = Console.ReadLine().ToLower();
                 
            if(key == "n")
            {
                Console.WriteLine("Exiting the game...");
                break;
            }
            else if (key != "y")
            {
                Console.WriteLine("Invalid choice, exiting game...");
                break;
            }
            
        }
    }

    public static void DiceThrow()
    {
        
        int dice1 = rnd.Next(1,7);
        int dice2 = rnd.Next(1,7);

        if (dice1 + dice2 == 12)
        {
            Console.WriteLine($"Congratulations! You got {dice1} and {dice2} (sum {dice1 + dice2})"); 
        }
        else
        {
            Console.WriteLine($"Sorry, you got {dice1} and {dice2}... sum {dice1 + dice2}");
        }
    }
}

