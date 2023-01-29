using System;

class Program
{
    static void Main(string[] args)
    {
        //Variables
        int userExperiencePoints = 0; //user's point (started with 0)
        int userPointsToAssign = 0; //The points the user has to assign to his skills
        int option = 0; //user's choose menu options (started with 0)
        int optionSubMenu = 0; //user's choose menu options (started with 0)
        //string fileName = "goals.txt";
        List<BasePlayerCharacter> inventary = new List<BasePlayerCharacter>(); //Create a list of objects (Necesary put <BasePlayerCharacter> the father class to avoid problems)

        while (option != 3)
        {

            //Display the menu
            Console.Clear();
            Console.WriteLine($"You have {userExperiencePoints} experience points.");
            Console.WriteLine($"You have {userPointsToAssign} points to assign.");
            Console.WriteLine();
            Console.WriteLine("[1] New game");
            Console.WriteLine("[2] Load game");
            Console.WriteLine("[3] Quit");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                //------------------ "[1] New game"  -------------------- 
                case 1:
                    optionSubMenu = 0;
                    Console.Clear();
                    while (optionSubMenu != 4)
                    {

                        Console.WriteLine("Choose your character");
                        Console.WriteLine();
                        Console.WriteLine("[1] Archer");
                        Console.WriteLine("[2] Knight");
                        Console.WriteLine("[3] Wizard");
                        Console.WriteLine("[4] Return to main menu");
                        Console.WriteLine();
                        Console.Write("Select a choice from the menu: ");
                        optionSubMenu = int.Parse(Console.ReadLine());
                        switch (optionSubMenu)
                        {
                            //--- "[1] Archer" --- 
                            case 1:
                                //Reset the variables
                                userPointsToAssign = 0;
                                userExperiencePoints = 0;
                                //Create the Character
                                PJArcher archer = new(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0);
                                //Define the skills (Use this method to control the stats)
                                archer.SetlifePoints(200);
                                archer.SetManaPoints(300);
                                archer.SetExperiencePoints(0);
                                archer.SetPointsToAssign(5);
                                userPointsToAssign = 5;
                                archer.SetLevel(1);
                                archer.SetHealPotions(2);
                                archer.SetManaPotions(2);
                                archer.SetPhysicalDamage(30);
                                archer.SetMagicDamage(20);
                                archer.SetAttackSpeed(20);
                                archer.SetCelerity(10);
                                archer.SetSpecialMoveTitle("Raining Arrows");
                                archer.SetSpecialMoveDamage(60);
                                //List of objects
                                List<BasePlayerCharacter> archerInventary = new List<BasePlayerCharacter>();

                                break;
                            //--- "[1] Archer - End" --- 


                            //--- "[2] Knight" --- 
                            case 2:
                                //Reset the variables
                                userPointsToAssign = 0;
                                userExperiencePoints = 0;
                                //Create the Character
                                PJKnight knight = new(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0);
                                //Define the skills (Use this method to control the stats)
                                knight.SetlifePoints(400);
                                knight.SetManaPoints(150);
                                knight.SetExperiencePoints(0);
                                knight.SetPointsToAssign(5);
                                userPointsToAssign = 5;
                                knight.SetLevel(1);
                                knight.SetHealPotions(2);
                                knight.SetManaPotions(2);
                                knight.SetPhysicalDamage(50);
                                knight.SetMagicDamage(5);
                                knight.SetAttackSpeed(15);
                                knight.SetCelerity(20);
                                knight.SetSpecialMoveTitle("Piercing thrust");
                                knight.SetSpecialMoveDamage(60);
                                //List of objects
                                List<BasePlayerCharacter> knightInventary = new List<BasePlayerCharacter>();

                                break;
                            //--- "[2] Knight - End" --- 


                            //--- "[3] Wizard" --- 
                            case 3:
                                //Reset the variables
                                userPointsToAssign = 0;
                                userExperiencePoints = 0;
                                //Create the Character
                                PJWizard wizard = new(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0);
                                //Define the skills (Use this method to control the stats)
                                wizard.SetlifePoints(200);
                                wizard.SetManaPoints(400);
                                wizard.SetExperiencePoints(0);
                                wizard.SetPointsToAssign(5);
                                userPointsToAssign = 5;
                                wizard.SetLevel(1);
                                wizard.SetHealPotions(2);
                                wizard.SetManaPotions(2);
                                wizard.SetPhysicalDamage(10);
                                wizard.SetMagicDamage(50);
                                wizard.SetAttackSpeed(15);
                                wizard.SetCelerity(30);
                                wizard.SetSpecialMoveTitle("Ruler of the elements");
                                wizard.SetSpecialMoveDamage(80);
                                //List of objects
                                List<BasePlayerCharacter> wizardInventary = new List<BasePlayerCharacter>();
                                
                                break;
                            //--- "[3] Wizard - End" --- 


                            //--- "[4] Return to main menu"  --- 
                            case 4:
                                break;
                            //--- "[4] Return to main menu - End" --- 
                            default:
                                Console.Clear();
                                Console.WriteLine("Wrong. Please choose another option.");
                                break;
                        }
                    }
                    break;
                //-------------- "[1] New game - End"  ------------------ 

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