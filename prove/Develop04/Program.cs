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
        //Set the value to the object (string) to use the methon GetFinalActivityMessageDisplay()
        activity.SetActivityDuration(durationString);
        Console.WriteLine(activity.GetFinalActivityMessageDisplay());
    }
}