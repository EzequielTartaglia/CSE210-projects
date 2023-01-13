using System;
//Public class to can use in "other window"

public class Activity{

    //Protect class inside the propieties to not affect the working of the program (only the inherit class)
    protected string _activityName;
    protected int _activityDuration;
    protected string _activityDescription;
    protected string _finalActivityMessage;

    //----------- Constructors section (templates)--------------

    //The default Activity when we create
    public Activity()
    {
        //Default values
        _activityName = "Unknown";
        _activityDescription = "Unknown";
        _finalActivityMessage = "Unknown";
    }

    //When the user only put 1 parameter
    //Create a Activity name
    public Activity(string activityName)
    {
        //Default values except the name of the activity (Breathing,Listening,Reflection)
        _activityName = activityName;
        _activityDescription = "Unknown";
        _finalActivityMessage = "Unknown";
    }
    
    //When the user only put 2 parameters
    //Create a Activity name and description
    public Activity(string activityName, string activityDescription)
    {
        //Default values except the name of the activity (Breathing,Listening,Reflection), duration and description
        _activityName = activityName;
        _activityDescription = activityDescription;
        _finalActivityMessage = "Unknown";
    }    
    
    //When the user complete the 3th parameter
    //Create a Activity
    public Activity(string activityName, string activityDescription, string activityFinalMessage)
    {
        //All the values 
        _activityName = activityName;
        _activityDescription = activityDescription;
        _finalActivityMessage = activityFinalMessage;
    }    
    
    //------------- Constructors section - end ------------------
    //------------- (Methods - Behaviors) -----------------------
    //----------------- Getter & Setter section -----------------
    public string GetActivityName(){
        //See the value of _activityName
        return _activityName;
    }

    public void SetActivityName(string activityName)
    {
        //Put the value of _activityName
        _activityName = activityName;
    }
     
    public int GetActivityDuration()
    {
        //See the value of _activityDuration
        return _activityDuration;
    }

    public void SetActivityDuration(int activityDuration)
    {
        //Put the value of _activityDuration
        _activityDuration = activityDuration;
    }
    public string GetActivityDescription(){
        //See the value of _activityDescription
        return _activityDescription;
    }

    public void SetActivityDescription(string activityDescription)
    {
        //Put the value of _activityDescription
        _activityDescription = activityDescription;
    }
     
    public string GetFinalActivityMessage()
    {
        //See the value of _finalActivityMessage
        return _finalActivityMessage;
    }

    public void SetFinalActivityMessage(string finalActivityMessage)
    {
        //Put the value of _finalActivityMessage
        _finalActivityMessage = finalActivityMessage;
    }
    //--------------- Getter & Setter section - end -------------
    //-------------------- Methods ------------------------------
    public string GetActivityNameDisplay(){
        return $"Welcome to the {_activityName}.";
    }
    public string GetActivityDescriptionDisplay(){
        return $"{_activityDescription}";
    }
    public string GetActivityDurationDisplay(){
        Console.Write("How long, in seconds, would you like for your session? ");
        string result = Console.ReadLine();
        return result;
        
    }

    public string GetFinalActivityMessageDisplay(){
        Console.WriteLine("Well done.");
        Console.WriteLine();
        Convert.ToString(_activityDuration);
        return $"You have completed another {_activityDuration} seconds of the {_activityName}.";
    }

}