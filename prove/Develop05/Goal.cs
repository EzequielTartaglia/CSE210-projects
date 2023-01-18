using System;
//Public class to can use in "other window"

// this class must also be declared as an abstract class (because have an abstract method inside).
public abstract class Goal
{

    //Protect class inside the propieties to not affect the working of the program (only the inherit class)
    protected string _title;
    protected string _description;
    protected int _pointsToComplete;

    protected List<string> _listOfGoals = new List<string>();

    //----------- Constructors section (templates)--------------

    //The default Goal when we create
    public Goal()
    {
        //Default values
        _title = "";
        _description = "";
        _pointsToComplete = 0;
    }

    //When the user only put 1 parameter
    //Create a Goal name
    public Goal(string goalName)
    {
        //Default values except the name of the Goal
        _title = goalName;
        _description = "";
        _pointsToComplete = 0;
    }

    //When the user put 2 parameters
    //Create a Goal name and description
    public Goal(string goalName, string goalDescription)
    {
        //Default values except the name and the description of the Goal
        _title = goalName;
        _description = goalDescription;
        _pointsToComplete = 0;
    }

    //When the user put 3 parameters
    //Create a complete Goal object
    public Goal(string goalName, string goalDescription, int pointsArchieved)
    {
        //All the values with values
        _title = goalName;
        _description = goalDescription;
        _pointsToComplete = pointsArchieved;
    }

    //----------- Constructors section (templates)--------------
    //------------- (Methods - Behaviors) -----------------------
    //----------------- Getter & Setter section -----------------
    public string GetGoalName()
    {
        //See the value of _title
        return _title;
    }

    public void SetGoalName(string goalName)
    {
        //Put the value of _title
        _title = goalName;
    }

    public string GetGoalDescription()
    {
        //See the value of _description
        return _description;
    }

    public void SetGoalDescription(string goalDescription)
    {
        //Put the value of _description
        _description = goalDescription;
    }

    public int GetGoalPoints()
    {
        //See the value of _pointsToComplete
        return _pointsToComplete;
    }

    public void SetGoalPoints(int goalPointsToComplete)
    {
        //Put the value of _pointsToComplete
        _pointsToComplete = goalPointsToComplete;
    }
    //----------------- Getter & Setter section -----------------

    //Method to set this value to a list
    public virtual string GetGoalInformation(){
        return $"[] {_title} ({_description})";
    }
    
    //Method to remplace the other information when the user complete 
    //Add the points to the total
    public virtual int GetGoalCompleted(int indexToDelete, int totalPoints){
        int index = indexToDelete;
        string newGoalInformation = $"[X] {_title} ({_description})";
        _listOfGoals.RemoveAt(index);
        _listOfGoals.Insert(index, newGoalInformation);

        //totalpoints is the global variable userPoints
        totalPoints = totalPoints + _pointsToComplete;
        return totalPoints;
    }    
}