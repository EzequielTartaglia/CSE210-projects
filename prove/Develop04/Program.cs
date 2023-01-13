using System;

class Program
{
    static void Main(string[] args)
    {
        //Activity Object Finished

        //The parameters of this object is an example
        Activity activity = new("NameOfActivity","Description of activity","Final Message");
        
        //Display the started activity menu (name & description)
        Console.WriteLine(activity.GetActivityNameDisplay());
        Console.WriteLine(activity.GetActivityDescriptionDisplay());

        //Get the duration in seconds
        string durationString = activity.GetActivityDurationDisplay();
        int durationNumber = int.Parse(durationString);
        //Set the value to the object (string) to use the methon GetFinalActivityMessageDisplay()
        activity.SetActivityDuration(durationNumber);
        Console.WriteLine(activity.GetFinalActivityMessageDisplay());


        //------------------------------ User decide for Breathe Activity -----------------------
        BreathingActivity breatheActivity = new("Breathing Activity","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.","Final Message");
        //Display the started Breathing Activity menu (name & description)
        Console.WriteLine(breatheActivity.GetActivityNameDisplay());
        Console.WriteLine();
        Console.WriteLine(breatheActivity.GetActivityDescriptionDisplay());    
        Console.WriteLine();
        string durationStringBreathe = breatheActivity.GetActivityDurationDisplay();
        int durationNumberBreathe = int.Parse(durationString);
        //Save the variable as a copy (to use the cooldown without affect the original)
        int copyOfDuration = durationNumberBreathe;
        breatheActivity.Cooldown(copyOfDuration);
        //Final output (reset the value of the activity's duration)
        breatheActivity.SetActivityDuration(durationNumberBreathe);
        Console.WriteLine(breatheActivity.GetFinalActivityMessageDisplay());
        //------------------------------ User decide for Breathe Activity -----------------------
    }
}