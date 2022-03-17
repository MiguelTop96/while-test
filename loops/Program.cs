using System;

class playDice{
    
    static void Main(string[] arg){
        Console.ForegroundColor = ConsoleColor.Green;
        
        Random genNum = new Random();
        int Roll1 = 0;
        int Roll2 = 1;
        int attempts = 0;

        Console.WriteLine("Press any key to play the dice");
        Console.ReadKey();

        while(Roll1 != Roll2){
            Roll1 = genNum.Next(1, 7);
            Roll2 = genNum.Next(1, 7);
            attempts++;
            Console.WriteLine("dice 1: " + Roll1 + "\ndice 2: " + Roll2 + "\n");
        }

        Console.WriteLine("the dice has roll " + attempts + " times");
        
        Console.ReadKey();
    }
}