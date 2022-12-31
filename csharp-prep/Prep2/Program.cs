using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine(); /* Space */

        /* Input */
        Console.Write("What was your final grade? ");
        string grade = Console.ReadLine();
        float grade_converted = float.Parse(grade); /* Convert the var to float */
       
        Console.WriteLine(); /* Space */


       /* Conditionals depends of final calification */
        string letterGrade = null; /* Initial var */

       if (grade_converted >= 90){
        letterGrade = "A";
       }
       else if (grade_converted >= 80){
        letterGrade = "B";
       }
       else if (grade_converted >= 70){
        letterGrade = "C";
       }
       else if (grade_converted >= 60){
        letterGrade = "D";
       }
       else{
        letterGrade = "F";
       }

       /* Output message with the final grade */
       Console.WriteLine($"You got a '{letterGrade}' grade in the course"); /* Space */

       /* Condition to success the course or not */
        if (grade_converted >= 70){
            Console.WriteLine("Congratulations, You passed the course!");
        }
        else{
            Console.WriteLine("Sorry, your final score wasn't the neccesary to success the course, you need to do it again.");
        }

        Console.WriteLine(); /* Space */

    }
}