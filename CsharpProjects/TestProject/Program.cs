// See https://aka.ms/new-console-template for more information
using System;

using System;

class DiceGame
{
    static void Main()
    {
        // Introduction and instructions for the game
        Console.WriteLine("Welcome to the Dice Game!");
        Console.WriteLine("Rules of Engagement:");
        Console.WriteLine("1. Press Enter to roll each dice.");
        Console.WriteLine("2. If you roll two of the same number, you get a bonus of +2 points.");
        Console.WriteLine("3. If you roll three of the same number, you get a bonus of +6 points.");
        Console.WriteLine("4. If your total is 15 or more, you win!");
        Console.WriteLine("Press Enter to start the game...");

        // Wait for the user to press Enter to start the game
        Console.ReadLine();

        // Create an instance of the Random class
        Random dice = new Random();

        // Roll the first dice
        Console.WriteLine("Press Enter to roll the first dice...");
        Console.ReadLine();
        int roll1 = dice.Next(1, 7);
        Console.WriteLine($"You rolled a {roll1}!");

        // Roll the second dice
        Console.WriteLine("Press Enter to roll the second dice...");
        Console.ReadLine();
        int roll2 = dice.Next(1, 7);
        Console.WriteLine($"You rolled a {roll2}!");

        // Roll the third dice
        Console.WriteLine("Press Enter to roll the third dice...");
        Console.ReadLine();
        int roll3 = dice.Next(1, 7);
        Console.WriteLine($"You rolled a {roll3}!");

        // Calculate the total of the three rolls
        int total = roll1 + roll2 + roll3;

        // Determine bonus points
        if (roll1 == roll2 && roll2 == roll3)
        {
            total += 6; // Add 6 if all three dice are the same
            Console.WriteLine("All three dice are the same! You get a +6 bonus!");
        }
        else if (roll1 == roll2 || roll1 == roll3 || roll2 == roll3)
        {
            total += 2; // Add 2 if two of the dice are the same
            Console.WriteLine("Two of the dice are the same! You get a +2 bonus!");
        }

        // Display the total and the results
        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        // Determine if the player wins or loses
        if (total >= 15)
        {
            Console.WriteLine("Congratulations! You Win!");
        }
        else
        {
            Console.WriteLine("Sorry! You Lose!");
        }
    }
}




