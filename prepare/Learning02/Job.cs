using System;

public class Job
    {
       //Propieties
       public string _jobTitle= "";
       public string _company = "";
       public int _startYear;
       public int _endYear;

       //Methods
       public void Display(){
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        //exaample: Software Engineer (Microsoft) 2019-2022
        }
    
    }