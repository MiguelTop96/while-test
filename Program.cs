using System;

class program{
    static void Main(string[] arg){
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("press a bottom to roll the die");
        Console.ReadKey();

        Random genNum = new Random();

        int firstRoll = 0;
        int secondRoll = 0;
        int attempts = 0;

        while(firstRoll != 6 || secondRoll != 5){
            firstRoll = genNum.Next(1, 7);
            secondRoll = genNum.Next(1, 7);
            Console.WriteLine("you rolled: " + firstRoll + "\nyou rolled: " + secondRoll + "\n");
            attempts++;
        }

        Console.WriteLine("the dice has rolled: " + attempts + " times");

        Console.ReadKey();
    }
}