using System;

class Program
{
    static void Main(string[] args)
    {
        //Variables
        int userPoints = 0; //user's point (started with 0)
        int option = 0; //user's choose menu options (started with 0)


        while (option != 6)
        {
        
        //Display the menu
        Console.WriteLine();
        Console.WriteLine($"You have {userPoints} points.");
        Console.WriteLine();
        Console.WriteLine("[1] Create a New Goal");
        Console.WriteLine("[2] List Goals");
        Console.WriteLine("[3] Save Goals");
        Console.WriteLine("[4] Load Goals");
        Console.WriteLine("[5] Record Event");
        Console.WriteLine("[6] Quit");
        Console.Write("Select a choice from the menu: ");
        option = int.Parse(Console.ReadLine());

        
        switch (option)
        {
            case 1:
            break;


            //Option to quit the program
            case 6:
            break;
            
            //Default case (when the user wrong) 
            default: 
            Console.Clear();
            Console.WriteLine("Wrong. Please choose another option.");
            break;
        }
        
    }
    }
}