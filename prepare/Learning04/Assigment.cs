using System;
//Public class to can use in "other window"

public class Assigment
{
    //Protect class inside the propieties to not affect the working of the program (only the inherit class)
    protected string _studentName;
    protected string _topic;

    //----------- Constructors section (templates)--------------

    //The default Assigment when we create
    public Assigment()
    {
        //Default values
        _studentName = "Unknown";
        _topic = "Unknown";
    }

    //When the user only put 1 parameter
    //Create a student name
    
    public Assigment(string studentName)
    {
        
        //ex Assigment('Ezequiel') is the same like "Ezequiel Unknown"
        _studentName = studentName;
        _topic = "Unknown"; //Authomatic assigment
    }
    
    //When the user only put 2 parameters
    //Create a student name and the subject
    public Assigment(string studentName, string subjectName)
    {
        
        //ex Assigment('Ezequiel') is the same like "Ezequiel Unknown"
        _studentName = studentName;
        _topic = subjectName; //Authomatic assigment
    }
    //------------- Constructors section - end ------------------
    //------------- (Methods - Behaviors) -----------------------
    //----------------- Getter & Setter section -----------------
    public string GetStudentName(){
        //See the value of _top
        return _studentName;
    }

    public void SetStudentName(string setStudentName)
    {
        //Put the value of _top
        _studentName = setStudentName;
    }
     
     
        public string GetTopic()
    {
        //See the value of _top
        return _topic;
    }

    public void SetTopic(string setSubjectName)
    {
        //Put the value of _top
        _topic = setSubjectName;
    }
    //--------------- Getter & Setter section - end -------------

    //---------------- Methods (functions) ----------------------
    public string GetSumary(){
        return $"{_studentName} - {_topic}";
    }
}