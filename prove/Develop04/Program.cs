using System;

class Program
{
    static void Main(string[] args)
    {
        //Function to show the spiner & text
        void ShowSpinnerWithText(string text, string position = "left")
        {
            string activityName = text;
            int x = Console.CursorLeft;
            int y = Console.CursorTop;
            if (position == "left")
            {
                while (true)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("| " + activityName);

                    Thread.Sleep(500);

                    Console.SetCursorPosition(x, y);
                    Console.Write("/ " + activityName);

                    Thread.Sleep(500);

                    Console.SetCursorPosition(x, y);
                    Console.Write("— " + activityName);

                    Thread.Sleep(500);

                    Console.SetCursorPosition(x, y);
                    Console.Write("\\ " + activityName);

                    Thread.Sleep(500);

                    //If the user press 'Enter'
                    if (Console.KeyAvailable && Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        Console.SetCursorPosition(x + activityName.Length, y);
                        Console.Write("   ");
                        Console.WriteLine();
                        break;
                    }
                }
            }
            if (position == "right")
            {
                while (true)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(activityName + " |");

                    Thread.Sleep(500);

                    Console.SetCursorPosition(x, y);
                    Console.Write(activityName + " /");

                    Thread.Sleep(500);

                    Console.SetCursorPosition(x, y);
                    Console.Write(activityName + " —");

                    Thread.Sleep(500);

                    Console.SetCursorPosition(x, y);
                    Console.Write(activityName + " \\");

                    Thread.Sleep(500);

                    //If the user press 'Enter'
                    if (Console.KeyAvailable && Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        Console.SetCursorPosition(x + activityName.Length, y);
                        Console.Write("   ");
                        Console.WriteLine();
                        break;
                    }
                }
            }
        }

        ShowSpinnerWithText("activity.GetActivityNameDisplay()", "right");

        //The parameters of this object is an example
        Activity activity = new("NameOfActivity", "Description of activity", "Final Message");

        //Display the started activity menu (name & description)
        Console.Write(activity.GetActivityNameDisplay());
        Console.WriteLine(activity.GetActivityDescriptionDisplay());

        //Get the duration in seconds
        string durationString = activity.GetActivityDurationDisplay();
        int durationNumber = int.Parse(durationString);
        //Set the value to the object (string) to use the methon GetFinalActivityMessageDisplay()
        activity.SetActivityDuration(durationNumber);
        Console.WriteLine(activity.GetFinalActivityMessageDisplay());


        //------------------------------ User decide for Breathe Activity -----------------------
        BreathingActivity breatheActivity = new("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", "Final Message");
        //Display the started Breathing Activity menu (name & description)
        Console.WriteLine(breatheActivity.GetActivityNameDisplay());
        Console.WriteLine();
        Console.WriteLine(breatheActivity.GetActivityDescriptionDisplay());
        Console.WriteLine();
        string durationStringBreathe = breatheActivity.GetActivityDurationDisplay();
        int durationNumberBreathe = int.Parse(durationStringBreathe);
        //Save the variable as a copy (to use the cooldown without affect the original)
        int copyOfDurationBA = durationNumberBreathe;
        Console.Clear();
        breatheActivity.GetCooldownBreatheActivity(copyOfDurationBA);
        //Final output (reset the value of the activity's duration)
        breatheActivity.SetActivityDuration(durationNumberBreathe);
        Console.WriteLine(breatheActivity.GetFinalActivityMessageDisplay());
        ShowSpinnerWithText("");
        Console.Clear();
        //------------------------------ User decide for Breathe Activity -----------------------


        //------------------------------ User decide for Reflection Activity --------------------
        ReflectionActivity reflectionActivity = new("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "Final Message");
        //Create a list to save the phases, then choose one random
        ReflectionActivity phrasesReflectionList = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "Final Message");
        phrasesReflectionList.AddPhaseToList("Think of a time when you stood up for someone else.");
        phrasesReflectionList.AddPhaseToList("Think of a time when you did something really difficult.");
        phrasesReflectionList.AddPhaseToList("Think of a time when you helped someone in need.");
        phrasesReflectionList.AddPhaseToList("Think of a time when you did something truly selfless.");
        //List to save the phrases into.
        List<string> listaToUsePhrases = new List<string> { };
        listaToUsePhrases.AddRange(phrasesReflectionList.GetAllReflectionPhases());
        //Create a list to save the questions, then
        ReflectionActivity questionsReflectionList = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "Final Message");
        questionsReflectionList.AddPhaseToList("Why was this experience meaningful to you?");
        questionsReflectionList.AddPhaseToList("Have you ever done anything like this before?");
        questionsReflectionList.AddPhaseToList("How did you get started?");
        questionsReflectionList.AddPhaseToList("How did you feel when it was complete?");
        questionsReflectionList.AddPhaseToList("What made this time different than other times when you were not as successful?");
        questionsReflectionList.AddPhaseToList("What is your favorite thing about this experience?");
        questionsReflectionList.AddPhaseToList("What could you learn from this experience that applies to other situations?");
        questionsReflectionList.AddPhaseToList("What did you learn about yourself through this experience?");
        questionsReflectionList.AddPhaseToList("How can you keep this experience in mind in the future?");
        //List to save the phrases into.
        List<string> listaToUseQuestions = new List<string> { };
        listaToUseQuestions.AddRange(questionsReflectionList.GetAllReflectionPhases());
        //Display the started Breathing Activity menu (name & description)
        Console.WriteLine(reflectionActivity.GetActivityNameDisplay());
        Console.WriteLine();
        Console.WriteLine(reflectionActivity.GetActivityDescriptionDisplay());
        Console.WriteLine();
        string durationStringReflection = reflectionActivity.GetActivityDurationDisplay();
        int durationNumberReflection = int.Parse(durationStringReflection);
        //Save the variable as a copy (to use the cooldown without affect the original)
        int copyOfDurationRA = durationNumberReflection;
        reflectionActivity.GetCooldownReflectionActivity(copyOfDurationRA, listaToUsePhrases, listaToUseQuestions);
        Console.WriteLine();
        //Final output (reset the value of the activity's duration)
        reflectionActivity.SetActivityDuration(durationNumberReflection);
        Console.WriteLine(reflectionActivity.GetFinalActivityMessageDisplay());
        ShowSpinnerWithText("");
        Console.Clear();
        //------------------------------ User decide for Reflection Activity --------------------

    }
}