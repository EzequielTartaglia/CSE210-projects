using System;

class Program
{
    static void Main(string[] args)
    {
        /* Get the magic number and convert to intenger */
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);
        int guessNumberConverted; //Declarate the variable to work inside the scope 

        do
        {
        /* Get a guess and convert to intenger */
        Console.Write("What is your guess? ");
        string guessNumber = Console.ReadLine();
        guessNumberConverted = int.Parse(guessNumber);

        
            if (magicNumber > guessNumberConverted){
                Console.WriteLine("Higher");
            }

            else if (magicNumber < guessNumberConverted){
                Console.WriteLine("Lower");
            }
        } 

        //Loop to repeat the guest until guess the correct number
        while (magicNumber != guessNumberConverted);
        
        //Final message
        Console.WriteLine("You guessed it!");
        Console.WriteLine(); //Space
    }
}