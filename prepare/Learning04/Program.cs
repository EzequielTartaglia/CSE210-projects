using System;

class Program
{
    static void Main(string[] args)
    {
        //Print the assigment example
        Assigment simpleAssigment = new("Ezequiel Tartaglia","Multiplication");
        Console.WriteLine(simpleAssigment.GetSumary());

        Console.WriteLine();

        //Example with MathAssigment
        MathAssigment simpleMathAssigment = new("7.3", "8-19","Roberto Rodriguez", "Fractions");
        Console.WriteLine(simpleMathAssigment.GetSumary());
        Console.WriteLine(simpleMathAssigment.GetHomeworkList());

        //Example with WrittingAssigment
        WrittingAssigment simpleWrittingAssigment = new("Mary Waters","European History","The Causes of World War II");
        Console.WriteLine(simpleWrittingAssigment.GetSumary());
        Console.WriteLine(simpleWrittingAssigment.GetWritingInformation());
        
    }
}