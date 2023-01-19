using System;
//Public class to can use in "other window"
public class CheckListGoal : Goal // SimpleGoal child class of Goal
{
    //Protect class inside the propieties to not affect the working of the program (only the inherit class)
    //Protect class inside the propieties to not affect the working of the program (only the inherit class)
    //protected string _title;
    //protected string _description;
    //protected int _pointsToComplete;
    //protected List<string> _listOfGoals = new List<string>();

    //This class propieties
    private int _currentlyCounter;
    private int _verificationCounter;
    private int _bonusGoalCompleted;

    //------------------ Constructors section (templates)--------------

    //The default CheckList when we create (all the parameters from Goal)
    public CheckListGoal(string goalName, string goalDescription, int pointsArchieved) : base(goalName, goalDescription, pointsArchieved)
    {
        //Default values
        _title = goalName;
        _description = goalDescription;
        _pointsToComplete = pointsArchieved;
    }

    //When the user only put 1 add parameter
    //Create a CheckList 
    public CheckListGoal(string goalName, string goalDescription, int pointsArchieved, int verificationCounter, int currentCounter = 0) : base(goalName, goalDescription, pointsArchieved)
    {
        //The normal propieties and the check-counter
        _title = goalName;
        _description = goalDescription;
        _pointsToComplete = pointsArchieved;
        _verificationCounter = verificationCounter;
        _currentlyCounter = currentCounter;
    }

    //When the user only put 2 add parameters
    //Create a CheckList and bonus
    public CheckListGoal(string goalName, string goalDescription, int pointsArchieved, int verificationCounter, int bonusGoalCompleted,int currentCounter = 0) : base(goalName, goalDescription, pointsArchieved)
    {
        //The normal propieties, the check-counter and the bonus when complete the goal
        _title = goalName;
        _description = goalDescription;
        _pointsToComplete = pointsArchieved;
        _verificationCounter = verificationCounter;
        _bonusGoalCompleted = bonusGoalCompleted;
        _currentlyCounter = currentCounter;
    }
    //----------- Constructors section (templates)--------------
    //------------- (Methods - Behaviors) -----------------------
    //----------------- Getter & Setter section -----------------
    public int GetVerificationCounter()
    {
        return _verificationCounter;
    }
    public void SetVerificationCounter(int verificationCounterToSet)
    {
        _verificationCounter= verificationCounterToSet;
    }
    public int GetBonusGoalCompleted()
    {
        return _bonusGoalCompleted;
    }
    public void SetBonusGoalCompleted(int bonusGoalCompletedToSet)
    {
        _bonusGoalCompleted= bonusGoalCompletedToSet;
        
    }   
    public int GetCurrentlyCounter()
    {
        return _currentlyCounter;
    }
    public void SetCurrentlyCounter(int currenlyCounterToSet)
    {
        _currentlyCounter= currenlyCounterToSet;
        
    }      //----------------- Getter & Setter section -----------------
    //-------------------------- Methods ------------------------------

    // Override auto-implemented property with ordinary property
    // to provide specialized accessor behavior.

    //Method to set this value to a list
    public override string GetGoalInformation(){
        return $"[ ] {_title} ({_description}) -- Currently completed {GetCurrentlyCounter()}/{_verificationCounter}";
    }

    //Method to remplace the other information when the user complete 
    //Add the points to the total
    public override int GetGoalCompleted(int indexToDelete, int totalPoints){
        
        //When the counter is the same to the final check-counter
        if (_verificationCounter == _currentlyCounter){
        int index = indexToDelete;
        string newGoalInformation = $"[X] {_title} ({_description}) -- Currently completed {GetCurrentlyCounter()}/{_verificationCounter}";
        _listOfGoals.RemoveAt(index);
        _listOfGoals.Insert(index, newGoalInformation);

        //totalpoints is the global variable userPoints
        totalPoints = totalPoints + _pointsToComplete;
        //Add the bonus to complete all the checks
        totalPoints = totalPoints + _bonusGoalCompleted;
        return totalPoints;
        }

        //When the user complete a part of the goal
        else
        {
        //Add one counter for each "check"
        _currentlyCounter =_currentlyCounter + 1;
        int currentlyCounter = _currentlyCounter;
        SetCurrentlyCounter(currentlyCounter);

        int index = indexToDelete;
        string newGoalInformation = $"[ ] {_title} ({_description}) -- Currently completed {GetCurrentlyCounter()}/{_verificationCounter}";
        _listOfGoals.RemoveAt(index);
        _listOfGoals.Insert(index, newGoalInformation);

        //totalpoints is the global variable userPoints
        totalPoints = totalPoints + _pointsToComplete;
        return totalPoints;
        }
        
    }    

    //Method to convert the object in a string (to save in an external file)
    public override string GetStringRepresentation()
    {
        return "CheckListGoal:" + _title + "," + _description + "," + _pointsToComplete + "," + _bonusGoalCompleted + "," + _verificationCounter + "," + _currentlyCounter;
    }
}