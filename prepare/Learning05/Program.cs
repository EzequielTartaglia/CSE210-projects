using System;

class Program
{
    static void Main(string[] args)
    {
        //Create an square and assign the values
        Square square = new("Black", 5);
        
        /* 
        //To see the value of the color
        Console.WriteLine(square.GetColor()); 
        */

        //Print the value of the area (abstract from the father class (in the declaration and method) and override in the child)
        Console.WriteLine($"The area of a square with {square.GetSide()} is {square.GetArea()}");
    }
}