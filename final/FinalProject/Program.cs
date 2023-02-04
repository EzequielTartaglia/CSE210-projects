using System;

class Program
{
    static void Main(string[] args)
    {

        //  -------------------------------------------------------- Functions to clean the code (repeat in 3 stories) --------------------------------------------------------
        void GetDungeonIntroduction()
        {
            Console.WriteLine("Welcome to the dungeon of the underworld");
            Console.WriteLine();

            Console.WriteLine("You have entered a place of mystery and danger, where danger lurks around every corner and treasure awaits the bravest of heroes.");
            Console.WriteLine("This treacherous dungeon is filled with ferocious monsters and ancient relics, and it is said that only the bravest of heroes have returned alive.");
            Console.WriteLine();

            Console.WriteLine("A long time ago, this dungeon was built by an evil sorcerer who enjoyed seeing how far he could reach the heroes' ability in an environment full of challenges like the one he prepared.");
            Console.WriteLine("Over the years, this dungeon has become a place of legend, drawing adventurers from far and wide in search of riches and fame.");
            Console.WriteLine("But beware, many have entered and few have returned, as the dangers of this dungeon are unlike anything you have faced before.");
            Console.WriteLine();

            Console.WriteLine("Do you have what it takes to survive Underworld's Dungeon? Let the adventure begin!");
            Console.WriteLine();

        };

        //  -------------------------------------------------------- Functions to clean the code (repeat in 3 stories) --------------------------------------------------------


        //Variables
        int userExperiencePoints = 0; //user's point (started with 0)
        int userPointsToAssign = 0; //The points the user has to assign to his skills
        int option = 0; //user's choose menu options (started with 0)
        int optionSubMenu = 0; //user's choose menu options (started with 0)
        int currentlyGameArcher = 0; //user's choose menu story options (started with 0)
        int storyOptions = 0; //user's choose menu options (started with 0)
        int chargedOptions = 0; //user's load menu options (started with 0)

        //Variables to create the Load (option 2 in the first menu)
        string PJToLoad = "";
        bool fileCharged = false;

        //Samples to charge a PJ
        PJArcher archer = new(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0);
        PJKnight knight = new(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0);
        PJWizard wizard = new(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0);
        //Sample of inventory
        Inventory archerInventory = new Inventory();
        Inventory knightInventory = new Inventory();
        Inventory wizardInventory = new Inventory();

        while (option != 3)
        {
            //If the option was 2 before
            if (fileCharged)
            {
                option = 1;
            }

            //Normal flow
            else
            {
                //Reset the switch
                option = 0;

                //Display the menu
                Console.Clear();
                Console.WriteLine("Dungeon of the underworld");
                Console.WriteLine();
                Console.WriteLine("[1] New game");
                Console.WriteLine("[2] Load game");
                Console.WriteLine("[3] Quit");
                Console.WriteLine();
                Console.Write("Select a choice from the menu: ");
                option = int.Parse(Console.ReadLine());
            }


            switch (option)
            {

                //------------------ "[1] New game"  -------------------- 
                case 1:

                    if (fileCharged)
                        optionSubMenu = 0;
                    Console.Clear();

                    while (optionSubMenu != 4)
                    {
                        //If the option was 2 before
                        if (fileCharged)
                        {
                            //Conditionals to manipulate dynamically the menu (loaded game in option 2 - main menu)
                            if (fileCharged && PJToLoad == "archer")
                            {
                                optionSubMenu = 1;
                            }
                            else if (fileCharged && PJToLoad == "knight")
                            {
                                optionSubMenu = 2;
                            }
                            else if (fileCharged && PJToLoad == "wizard")
                            {
                                optionSubMenu = 3;
                            }
                        }

                        //Normal flow
                        else
                        {
                            Console.WriteLine("Dungeon of the underworld");
                            Console.WriteLine();
                            Console.WriteLine("Choose your character");
                            Console.WriteLine();
                            Console.WriteLine("[1] Archer");
                            Console.WriteLine("[2] Knight");
                            Console.WriteLine("[3] Wizard");
                            Console.WriteLine("[4] Return to main menu");
                            Console.WriteLine();
                            Console.Write("Select a choice from the menu: ");
                            optionSubMenu = int.Parse(Console.ReadLine());
                        }


                        switch (optionSubMenu)
                        {
                            //--- "[1] Archer" --- 
                            case 1:

                                Console.Clear();

                                if (fileCharged)
                                {

                                }

                                //Normal flow
                                else
                                {
                                    //Reset the variables
                                    userPointsToAssign = archer.GetPointsToAssign();
                                    userExperiencePoints = archer.GetExperiencePoints();

                                    //Create the Character
                                    //PJArcher archer = new(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0);

                                    //Define the skills (Use this method to control the stats)
                                    archer.SetlifePoints(200);
                                    archer.SetManaPoints(300);
                                    archer.SetExperiencePoints(0);
                                    archer.SetPointsToAssign(5);
                                    userPointsToAssign = archer.GetPointsToAssign();
                                    archer.SetLevel(1);
                                    archer.SetHealPotions(2);
                                    archer.SetManaPotions(2);
                                    archer.SetPhysicalDamage(30);
                                    archer.SetMagicDamage(20);
                                    archer.SetAttackSpeed(20);
                                    archer.SetCelerity(10);
                                    archer.SetSpecialMoveTitle("Raining Arrows");
                                    archer.SetSpecialMoveDamage(60);

                                    //Example to add a item to the inventary

                                    //Item ejemplo  = new("Ejemplo",8);
                                    //archerInventory.AddItemToInventory(ejemplo);

                                }

                                //Presentation
                                GetDungeonIntroduction();
                                Console.Write("Press any key to return to continue ");
                                Console.ReadLine();

                                while (currentlyGameArcher == 0)
                                {

                                    while (storyOptions != 7)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Dungeon of the underworld");
                                        Console.WriteLine();
                                        Console.WriteLine($"You have {archer.GetExperiencePoints()} experience points.");
                                        Console.WriteLine($"You have {archer.GetPointsToAssign()} points to assign.");
                                        Console.WriteLine();
                                        Console.WriteLine("[1] Battle");
                                        Console.WriteLine("[2] Display stats");
                                        Console.WriteLine("[3] Display inventory");
                                        Console.WriteLine("[4] Upgrade skills");
                                        Console.WriteLine("[5] Save game");
                                        Console.WriteLine("[6] Load game");
                                        Console.WriteLine("[7] Quit");
                                        Console.WriteLine();
                                        Console.Write("Select a choice from the menu: ");
                                        storyOptions = int.Parse(Console.ReadLine());
                                        switch (storyOptions)
                                        {
                                            //----------------- "[1] Battle"  ---------------- 
                                            case 1:

                                                //Reset the switcher
                                                int battleMenuOptions = 0;

                                                //Enemy's custom
                                                int enemyLevel = 1;
                                                int enemyType = 1; //Get a default orc enemy


                                                while (battleMenuOptions != 4)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Dungeon of the underworld");
                                                    Console.WriteLine();
                                                    Console.WriteLine("[1] Start battle");
                                                    Console.WriteLine("[2] Change enemy's type");
                                                    Console.WriteLine("[3] Change enemy's level");
                                                    Console.WriteLine("[4] Return to main menu");
                                                    Console.WriteLine();
                                                    Console.Write("Select a choice from the menu: ");
                                                    battleMenuOptions = int.Parse(Console.ReadLine());
                                                    switch (battleMenuOptions)
                                                    {
                                                        //--------- Battle Start ------------
                                                        case 1:
                                                            break;
                                                        //--------- Battle Start ------------


                                                        //--------- Custom enemy's type ------------
                                                        case 2:
                                                            string enemyTypeString = ""; //Variable to help the user to show the enemy's type

                                                            Console.Clear();
                                                            Console.WriteLine();
                                                            Console.WriteLine("[1] Orc");
                                                            Console.WriteLine("[2] Banshe");
                                                            Console.WriteLine("[3] Skull warrior");
                                                            Console.WriteLine("[4] Return to main menu");
                                                            Console.WriteLine();
                                                            Console.Write("Select the level of the enemy: ");
                                                            string settingCustomType = Console.ReadLine();

                                                            //Try if the user put a number
                                                            if (int.TryParse(settingCustomType, out int customType))
                                                            {
                                                                if (settingCustomType == "1") { enemyTypeString = "orc"; }
                                                                else if (settingCustomType == "2") { enemyTypeString = "banshe"; }
                                                                else if (settingCustomType == "3") { enemyTypeString = "skull warrior"; }

                                                                Console.WriteLine($"The type was changed to {enemyTypeString} sucessfully.");
                                                                Console.Write("To redirect you to the battle menu again, press enter ");

                                                                enemyType = customType;
                                                                Console.ReadLine();
                                                            }
                                                            else
                                                            {
                                                                Console.Write("Incorrect answer, to redirect you to the battle menu again, press enter");
                                                                Console.ReadLine();
                                                            }
                                                            break;
                                                        //-------- Custom enemy's type - End --------


                                                        //--------- Custom enemy's level ------------
                                                        case 3:
                                                            Console.Clear();
                                                            Console.Write("Select the level of the enemy: ");
                                                            string settingCustomLevel = Console.ReadLine();

                                                            //Try if the user put a number
                                                            if (int.TryParse(settingCustomLevel, out int customLevel))
                                                            {
                                                                Console.WriteLine($"The level was changed to {customLevel} sucessfully.");
                                                                Console.Write("To redirect you to the battle menu again, press enter ");

                                                                enemyLevel = customLevel;
                                                                Console.ReadLine();
                                                            }
                                                            else
                                                            {
                                                                Console.Write("Incorrect answer, to redirect you to the battle menu again, press enter");
                                                                Console.ReadLine();
                                                            }
                                                            break;
                                                        //-------- Custom enemy's level - End --------


                                                        case 4:
                                                            storyOptions = 0;
                                                            break;


                                                        default:
                                                            Console.Clear();
                                                            Console.WriteLine("Wrong. Please choose another option.");
                                                            break;
                                                    }
                                                }
                                                break;
                                            //------------ "[1] Battle - End"  --------------- 

                                            //----------------- "[2] Stats"  ---------------- 
                                            case 2:
                                                Console.Clear();
                                                Console.WriteLine(archer.GetAllStats());
                                                Console.WriteLine();
                                                Console.Write("Press any key to return to main menu ");
                                                Console.ReadLine();
                                                break;
                                            //------------- "[2] Stats - End"  -------------- 



                                            //----------------- "[3] Inventory"  ---------------- 
                                            case 3:
                                                Console.Clear();
                                                archerInventory.Display();
                                                Console.WriteLine();
                                                Console.Write("Press any key to return to main menu ");
                                                Console.ReadLine();
                                                break;
                                            //------------- "[3] Inventory - End"  -------------- 


                                            //----------------- "[4] Upgrade skills"  ---------------- 
                                            case 4:
                                                Console.Clear();
                                                archer.UpgradeSkills(archer.GetPointsToAssign());
                                                break;
                                            //------------- "[4] Upgrade skills - End"  -------------- 


                                            //------------------ "[5] Save Stats"  ------------------- 
                                            case 5:
                                                Console.Clear();
                                                Console.Write("What is the filename for the game file (ex: GameSavedFile.csv)? ");
                                                string fileName = Console.ReadLine();
                                                using (StreamWriter outputFile = new StreamWriter(fileName))
                                                {
                                                    // You can add userExperiencePoints in the moment
                                                    // You can add userPointsToAssign in the moment
                                                    outputFile.WriteLine(archer.GetExperiencePoints());
                                                    outputFile.WriteLine(archer.GetPointsToAssign());


                                                    //Save the current stats
                                                    outputFile.WriteLine(archer.GetlifePoints());
                                                    outputFile.WriteLine(archer.GetManaPoints());
                                                    outputFile.WriteLine(archer.GetExperiencePoints());
                                                    outputFile.WriteLine(archer.GetPointsToAssign());
                                                    outputFile.WriteLine(archer.GetLevel());
                                                    outputFile.WriteLine(archer.GetHealPotions());
                                                    outputFile.WriteLine(archer.GetManaPotions());
                                                    outputFile.WriteLine(archer.GetPhysicalDamage());
                                                    outputFile.WriteLine(archer.GetMagicDamage());
                                                    outputFile.WriteLine(archer.GetAttackSpeed());
                                                    outputFile.WriteLine(archer.GetCelerity());
                                                    outputFile.WriteLine(archer.GetSpecialMoveTitle());
                                                    outputFile.WriteLine(archer.GetSpecialMoveDamage());

                                                    //For each item inside the list, save a line with different formats(override in the class)
                                                    foreach (var item in archerInventory._items)
                                                    {
                                                        //Save all the items inside the list
                                                        outputFile.WriteLine(item._name + "," + item._quantity);

                                                    }


                                                }
                                                break;
                                            //------------------ "[5] Save Stats"- End --------------- 


                                            //------------------ "[6] Load Stats"- End --------------- 
                                            case 6:
                                                Console.Clear();
                                                //Charge the information
                                                archer.ChargeInformation(archer, userExperiencePoints, userPointsToAssign, archerInventory);
                                                break;
                                            //------------------ "[6] Load Stats"- End --------------- 


                                            //--------------- [7] Quit ---------------------
                                            case 7:
                                                currentlyGameArcher = 1;
                                                break;
                                            //--------------- [7] Quit ---------------------


                                            default:
                                                Console.WriteLine("Wrong.Choose another option");
                                                break;
                                        }

                                        //Finish the program (close all the loops)
                                        optionSubMenu = 4;
                                        option = 3;
                                        break;
                                    }
                                }


                                break;
                            //--- "[1] Archer - End" --- 


                            //--- "[2] Knight" --- 
                            case 2:

                                if (fileCharged)
                                {

                                }

                                //Normal flow
                                else
                                {
                                    Console.Clear();

                                    //Reset the variables
                                    userPointsToAssign = knight.GetPointsToAssign();
                                    userExperiencePoints = knight.GetExperiencePoints();

                                    //Create the Character
                                    //PJKnight knight = new(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0);

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

                                }

                                //Example to add a item to the inventary

                                //Item ejemplo  = new("Ejemplo",8);
                                //archerInventory.AddItemToInventory(ejemplo);

                                //Presentation
                                GetDungeonIntroduction();
                                Console.Write("Press any key to return to continue ");
                                Console.ReadLine();

                                break;
                            //--- "[2] Knight - End" --- 


                            //--- "[3] Wizard" --- 
                            case 3:

                                if (fileCharged)
                                {

                                }

                                //Normal flow
                                else
                                {
                                    Console.Clear();

                                    //Reset the variables
                                    userPointsToAssign = wizard.GetPointsToAssign();
                                    userExperiencePoints = wizard.GetExperiencePoints();

                                    //Create the Character
                                    //PJWizard wizard = new(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0);

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
                                }

                                //Example to add a item to the inventary

                                //Item ejemplo  = new("Ejemplo",8);
                                //archerInventory.AddItemToInventory(ejemplo);

                                //Presentation
                                GetDungeonIntroduction();
                                Console.Write("Press any key to return to continue ");
                                Console.ReadLine();

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

                    chargedOptions = 0;
                    Console.Clear();

                    while (chargedOptions != 4)
                    {

                        //Charge the information
                        Console.Clear();
                        Console.WriteLine("Dungeon of the underworld");
                        Console.WriteLine();
                        Console.WriteLine("[1] Archer");
                        Console.WriteLine("[2] Knight");
                        Console.WriteLine("[3] Wizard");
                        Console.WriteLine("[4] Return to main menu");
                        Console.WriteLine();
                        Console.Write("Select a choice from the menu: ");

                        int chargedStoryOption = int.Parse(Console.ReadLine());

                        switch (chargedStoryOption)
                        {
                            case 1:

                                bool testArcherGameLoad = false;
                                testArcherGameLoad = archer.ChargeInformation(archer, userExperiencePoints, userPointsToAssign, archerInventory);

                                //If the method ChargeInformation return true change all the variables
                                if (testArcherGameLoad)
                                {
                                    chargedOptions = 4;
                                    fileCharged = true;
                                    PJToLoad = "archer";
                                }

                                break;

                            case 2:

                                bool testKnightGameLoad = false;
                                testKnightGameLoad = knight.ChargeInformation(knight, userExperiencePoints, userPointsToAssign, knightInventory);

                                //If the method ChargeInformation return true change all the variables
                                if (testKnightGameLoad)
                                {
                                    chargedOptions = 4;
                                    fileCharged = true;
                                    PJToLoad = "knight";

                                }

                                break;

                            case 3:

                                bool testWizardGameLoad = false;
                                testWizardGameLoad = wizard.ChargeInformation(wizard, userExperiencePoints, userPointsToAssign, wizardInventory);

                                //If the method ChargeInformation return true change all the variables
                                if (testWizardGameLoad)
                                {
                                    chargedOptions = 4;
                                    fileCharged = true;
                                    PJToLoad = "wizard";

                                }
                                break;

                            case 4:

                                //The flow turns different depends the fileCharged
                                if (fileCharged)
                                {
                                    fileCharged = true;
                                    chargedOptions = 4;
                                }

                                else
                                {
                                    fileCharged = false;
                                    chargedOptions = 4;
                                }

                                break;

                            default:

                                Console.Clear();
                                Console.WriteLine("Wrong. Please choose another option.");
                                break;
                        }
                    }

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