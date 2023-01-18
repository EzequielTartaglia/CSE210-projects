using System;

class Program
{
    static void Main(string[] args)
    {
        //Variables
        int userPoints = 0; //user's point (started with 0)
        int option = 0; //user's choose menu options (started with 0)
        List<string> listOfGoals = new List<string>(); //Create a list of objetcts


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
                //---- If the user decide to "[1] Create a New Goal" -----
                case 1:
                    Console.Clear();
                    Console.WriteLine("The type of Goals are: ");
                    Console.WriteLine("[1] Simple Goal");
                    Console.WriteLine("[2] Eternal Goal ");
                    Console.WriteLine("[3] Checklist Goal ");
                    Console.Write("Which type of goal would you like to create? ");
                    int goalOption = int.Parse(Console.ReadLine());
                    switch (goalOption)
                    {
                        //-------------- [1] Simple Goal ----------------
                        case 1:
                            Console.Clear();
                            //Get the values of the goal from the user
                            Console.Write("What is the name of your goal? ");
                            string simpleGoalName = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            string simpleGoalDescription = Console.ReadLine();
                            Console.Write("What is the amount assosiated to this goal? ");
                            int simpleGoalPoints = int.Parse(Console.ReadLine());
                            //Create the object and add the values got from the user
                            SimpleGoal simpleGoal = new(simpleGoalName, simpleGoalDescription, simpleGoalPoints);
                            //Add to the list
                            string simpleGoalToList = simpleGoal.GetGoalInformation();
                            listOfGoals.Add(simpleGoalToList);
                            break;
                        //------------- [1] Simple Goal - End ------------

                        case 2:
                            break;

                        case 3:
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Wrong. Please choose another option.");
                            break;
                    }

                    break;
                //------------ "[1] Create a New Goal" - end ------------ 



                //------------------ "[2] List Goal"  ------------------- 
                case 2:
                    Console.Clear();
                    //Show all the elements in the list
                    int count = 1; //Counter to put an index
                    foreach (var goal in listOfGoals)
                    {
                        Console.WriteLine(count + ". " + goal);
                        count++;
                    }
                    break;
                //--------------- "[2] List Goal" - End ----------------- 

                case 5:
                    //FALTA TRABAJARLO// (dejo codigo)

                    /*                     
                    Console.WriteLine("Ingresa el número del elemento que deseas eliminar:");
                    int numberToDelete = int.Parse(Console.ReadLine());
                    int indexToDelete = numberToDelete - 1;
                    if(indexToDelete >= 0 && indexToDelete < listOfGoals.Count)
                    {
                        userPoints += listOfGoals[indexToDelete]._pointsToComplete;
                        listOfGoals.RemoveAt(indexToDelete);
                        Console.WriteLine("Elemento eliminado correctamente. Total de puntos: " + userPoints);
                    }
                    else
                    {
                        Console.WriteLine("El número ingresado no es válido");
                    } 
                    */

                    break;

                //------------------ "[6] Quit"  ------------------------ 
                case 6:
                    break;
                //------------------ "[6] Quit" - End ------------------- 


                //Default case (when the user wrong) 
                default:
                    Console.Clear();
                    Console.WriteLine("Wrong. Please choose another option.");
                    break;
            }

        }
    }
}