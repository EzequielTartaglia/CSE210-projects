using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
    //Job class propieties and methods (objects) - Start
        
        
        //Job 1 (professional experience 1 - propieties)
        Job job1 = new Job();//Use the constructor of class Job
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        //Job 2 (professional experience 2 - propieties)
        Job job2 = new Job();//Use the constructor of class Job
        job2._jobTitle = "Tech lead";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        //Display the Job information (method)
            //job1.Display();
            //job2.Display();

    //Job class propieties and methods (objects) - End

    //Resume class propieties and methods (objects) - Start
        
        Resume myResume = new Resume();//Use the constructor of class Resume
        myResume._name = "Ezequiel Matias Tartaglia";
        
        //Add to the empty list the jobs (because if you don'n add, you couldn't display the information)
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        
        //Display the Resume information (method)
        myResume.Display();

        //Add the jobs to the list Resume
    //Resume class propieties and methods (objects) - End
    }
}