using System;
//Public class to can use in "other window"

public class WrittingAssigment : Assigment
{
    //Protect class inside the propieties to not affect the working of the program (only the inherit class)
    
    //------Classes for the father class-------
    //protected string _studentName;
    //protected string _topic;
    //------Classes for the father class-------

    //Private class for this class
    private string _title;
    
    //----------- Constructors section (templates)--------------

    //The default Assigment when we create
    public WrittingAssigment(string studentName, string studentSubject) :base(studentName,studentSubject) //base() are the propieties from Assaigment (base/father class)
    {
        //Default values
        _title = "Unknown";
       
    }

    //When the user only put 1 parameter
    //Create a WrittingAssigment (2 parameters from Assigment and 1 from WrittingAssigment)
    public WrittingAssigment(string studentName, string studentSubject, string titleWritting):base(studentName,studentSubject)//base() are the propieties from Assaigment (base/father class)
    {
        //value of the _title change to the parameter (receive the complete information)
        _title = titleWritting;
    }
    //------------- Constructors section - end ------------------
    //------------- (Methods - Behaviors) -----------------------
    //----------------- Getter & Setter section -----------------
    public string GetTitle(){
        //See the value of _title
        return _title;
    }

    public void SetTitle(string settedTitle)
    {
        //Put the value of _title
        _title = settedTitle;
    }

    //----------------- Getter & Setter section -----------------
    //-------------------- Methods ------------------------------
    public string GetWritingInformation()
    {
       return  $"{_title} by {_studentName}"; 
    }


}