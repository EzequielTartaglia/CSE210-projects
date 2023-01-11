using System;
//Public class to can use in "other window"

public class MathAssigment : Assigment
{
    //Protect class inside the propieties to not affect the working of the program (only the inherit class)
    
    //------Classes for the father class-------
    //protected string _studentName;
    //protected string _topic;
    //------Classes for the father class-------

    //Private classes for this class
    private string _textbookSection;
    private string _problems;
    //----------- Constructors section (templates)--------------

    //The default Assigment when we create
    public MathAssigment(string studentName, string studentSubject) :base(studentName,studentSubject) //base() are the propieties from Assaigment (base/father class)
    {
        //Default values
        _textbookSection = "Unknown";
        _problems = "Unknown";
    }

    //When the user only put 1 parameter
    //Create a book's name
    
    public MathAssigment(string textBookSection, string studentName, string studentSubject) :base(studentName,studentSubject) //base() are the propieties from Assaigment (base/father class)
    {
        
        //ex MathAssigment('Math101') is the same like "Math101 Unknown"
        _textbookSection = textBookSection;
        _problems = "Unknown"; //Authomatic assigment
    }
    
    //When the user only put 2 parameters
    //Create a book's name and the problems to resolve
    public MathAssigment(string textBookSection, string problemsName, string studentName, string studentSubject) :base(studentName,studentSubject) //base() are the propieties from Assaigment (base/father class)
    {
        //These parameters from the other class is like an attribute to this child & we could use these var to different things
        //ex Assigment('Ezequiel') is the same like "Ezequiel Unknown"
        _textbookSection = textBookSection;
        _problems = problemsName; //Authomatic assigment
    }
    //------------- Constructors section - end ------------------
    //------------- (Methods - Behaviors) -----------------------
    //----------------- Getter & Setter section -----------------
    public string GetTextbookSection(){
        //See the value of _textbookSection
        return _textbookSection;
    }

    public void SetTextbookSection(string textBookSection)
    {
        //Put the value of _textbookSection
        _textbookSection = textBookSection;
    }
     
     
        public string GetProblems()
    {
        //See the value of _problems
        return _problems;
    }

    public void SetProblems(string settedProblems)
    {
        //Put the value of _problems
        _problems = settedProblems;
    }
    //--------------- Getter & Setter section - end -------------
    //-------------------- Methods ------------------------------

    public string GetHomeworkList(){
        return $"Section {_textbookSection} Problems {_problems}";
    }
}