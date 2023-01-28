using System;

class Program
{
    static void Main(string[] args)
    {
        //Variables
        int userExperiencePoints = 0; //user's point (started with 0)
        int userPointsToAssign = 0; //The points the user has to assign to his skills
        int option = 0; //user's choose menu options (started with 0)
        //string fileName = "goals.txt";
        List<BasePlayerCharacter> inventary = new List<BasePlayerCharacter>(); //Create a list of objects (Necesary put <BasePlayerCharacter> the father class to avoid problems)

        while (option != 3)
        {

            //Display the menu
            Console.WriteLine();
            Console.WriteLine($"You have {userExperiencePoints} experience points.");
            Console.WriteLine($"You have {userPointsToAssign} points to assign.");
            Console.WriteLine();
            Console.WriteLine("[1] New game");
            Console.WriteLine("[2] Load game");
            Console.WriteLine("[3] Quit");
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    break;

                case 2:
                    break;

                //------------------ "[3] Quit"  ------------------------ 
                case 3:
                    break;
                //------------------ "[3] Quit" - End ------------------- 

                //Default case (when the user wrong) 
                default:
                    Console.Clear();
                    Console.WriteLine("Wrong. Please choose another option.");
                    break;
            }
        }
    }
}