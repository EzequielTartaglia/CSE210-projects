using System;

public class Entry
    {
       //Propieties
       public string _message  = "";
       public string _response= "";
       public string _date = DateTime.Now.ToString("dd-MM-yyyy");


       //Methods
       public void Display(){
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Question: {_message}");
        Console.WriteLine($"Your answer: {_response}");
        //exaample: 
        //Date: 04/01/2023
        //Question: You did your journay today?
        //Your answer: Yes, this day was amazing.

        }
    
    }