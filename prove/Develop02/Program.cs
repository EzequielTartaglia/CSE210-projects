//Unit 02 Develop: Journal Program

using System;
using System.Collections.Generic;
using System.IO; 
class Program
{
    static void Main(string[] args)
    {

        //------------------------------------- Get the user data - Start -------------------------------------------------------------------------------------
        
        //Get from the user the name and assign to the propiety _name
            Console.Write("Enter your full name: ");
            string userName = Console.ReadLine();   
            Journal myJournal = new Journal();//Use the constructor of class Journal
            myJournal._name = userName;

        //--------------------------------------- Get the user data - End -------------------------------------------------------------------------------------




        //--------------------------------------- Information about the file.csv --------------------------------------------------------------------------------------------
       
       //Reading Text Files
       //string filename = "myFile.csv";
       // Create a string array with the lines of text
       List<string> localStorageList = new List<string>();

        //--------------------------------------- Information about the file.csv --------------------------------------------------------------------------------------------
        bool exitProgram = false;
        while(!exitProgram){

    
            //List of notifications()
            List<string> notificationsList = new List<string>()
            {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is the most difficult thing i am trying to accomplish today?",
            "What is one small example of how i have “personalized” your life for the better?"
            };

            //Display the menu
            Console.WriteLine("Please select one of the following choices?");
            Console.WriteLine("[1] Write");
            Console.WriteLine("[2] Display");
            Console.WriteLine("[3] Load");
            Console.WriteLine("[4] Save");
            Console.WriteLine("[5] Quit");
            Console.Write("What do you like to do? ");
            string optionChooseS = Console.ReadLine();
            int opctionChoose = int.Parse(optionChooseS);

            switch (opctionChoose)
            {

            //------------------------------------------------------------- Write option - Start -------------------------------------------------------------------------------
                    case 1:

                    //------------------------------Entry class propieties and methods (objects) - Start------------------------------------------------------------------------
                    //Function to random the elements inside the list
                    Random random = new Random();
                    int num = random.Next(0, 6);//Number min 0 and max 6
                    //Entry (entry of journal 1 - propieties)
                    Entry entry1 = new Entry();//Use the constructor of class Entry
                    //Console.WriteLine(notificationsList[num]); //Number random between the elements 0-6
                    entry1._message = notificationsList[num];
                    Console.WriteLine(entry1._message);
                    //Get from the user the answer and assign to the propiety _response
                    Console.Write("Enter your response: ");
                    string userentryResponse = Console.ReadLine();
                    entry1._response = userentryResponse;
                    //Add to the empty list the entries (because if you don'n add, you couldn't display the information)
                    myJournal._entries.Add(entry1);
                    localStorageList.Add(entry1._message);
                    localStorageList.Add(entry1._response);

                    //Display the Entry information (method)
                    //entry1.Display()
                    //-------------------------------Entry class propieties and methods (objects) - End--------------------------------------------------------------------------
                    break;
            //------------------------------------------------------------- Write option - End --------------------------------------------------------------------------



            // ---------------------------------------------------------------- Display the journal - Start----------------------------------------------------------------------
                case 2:
                    //Display the Journal information (method)
                    myJournal.Display();//Add the entries to the list Journal
                    break;
            // ---------------------------------------------------------------- Display the journal - End ------------------------------------------------------------------------


            
                case 3:
                    Console.WriteLine("Has elegido la opción 3");
                    
                    //Get the file to load from the outline
                    Console.Write("What is the file's name? (Ex. myFile.csv) ");
                    string answerFileToLoad = Console.ReadLine();


                    break;


            
            // ---------------------------------------------------------------- Save the journal - Start----------------------------------------------------------------------
                case 4:

                    //Get the file to send the outline
                    Console.Write("What is the file's name? (Ex. myFile.csv) ");
                    string answerFileToSave = Console.ReadLine();
                    
                    //Save the data to the ourline (to the file "myFile.csv" in this case)
                    using (StreamWriter outputFile = new StreamWriter(answerFileToSave))
                    {  
                    //Display outline start

                        outputFile.WriteLine("------------------------------------------------------");
                        outputFile.WriteLine($"Name: {myJournal._name}");
                        outputFile.WriteLine($"Date: {DateTime.Now.ToString("dd-MM-yyyy")}");                        

                        //For each entry in the myJournal
                        foreach (string entry in localStorageList)
                        {
                            outputFile.WriteLine(entry);
                        }; 
                        outputFile.WriteLine("------------------------------------------------------");
                        
                        //Clear the data save in the list ("temporaly memory")
                        localStorageList.Clear();

                    //Display outline end    
                    }
                    
                    break;
            // ---------------------------------------------------------------- Save the journal - End --------------------------------------------------------------------------


            
            // ----------------------------------------------------------------  Exit  -------------------------------------------------------------------------------------------
                case 5:
                    exitProgram = true;
                    break;
            // ----------------------------------------------------------------  Exit  -------------------------------------------------------------------------------------------
                default:
                    Console.WriteLine("Wrong. Please choose another option.");
                    break;
            }
        
            }
           

        
        
    }
}