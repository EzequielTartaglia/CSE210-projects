using System;

//Public class to can use in "other window"
public class SimpleGoal : Goal // SimpleGoal child class of Goal
{
    //Protect class inside the propieties to not affect the working of the program (only the inherit class)
    //Protect class inside the propieties to not affect the working of the program (only the inherit class)
    //protected string _title;
    //protected string _description;
    //protected int _pointsToComplete;
    //protected List<string> _listOfGoals = new List<string>();
    private bool _checked = false;
    //------------------ Constructors section (templates)--------------

    //The default SimpleGoal when we create (all the parameters from Goal)
    public SimpleGoal(string goalName, string goalDescription, int pointsArchieved, bool checkedGoal = false) : base(goalName,goalDescription,pointsArchieved)
    {
        //Default values
        _title = goalName;
        _description = goalDescription;
        _pointsToComplete = pointsArchieved;
        _checked = checkedGoal;
    }
    //------------------ Constructors section (templates)--------------
    //-------------------------- Methods ------------------------------

    // Override auto-implemented property with ordinary property
    // to provide specialized accessor behavior.

    //Method to set this value to a list
    public override string GetGoalInformation(){
        return $"[ ] {_title} ({_description})";
    }

    //Method to remplace the other information when the user complete 
    //Add the points to the total
    public override int GetGoalCompleted(int indexToDelete, int totalPoints){
        //Change checked to true
        _checked = true;

        if (_checked == true)
        {
        int index = indexToDelete;
        string newGoalInformation = $"[X] {_title} ({_description})";
        _listOfGoals.RemoveAt(index);
        _listOfGoals.Insert(index, newGoalInformation);

        //totalpoints is the global variable userPoints
        totalPoints = totalPoints + _pointsToComplete;
        return totalPoints;
        }
        return totalPoints;
    }    
    
    //Method to convert the object in a string (to save in an external file)
    public override string GetStringRepresentation()
    {
        return "SimpleGoal:" + _title + "," + _description + "," + _pointsToComplete + "," + _checked;
    }
}

