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


        
        //Create an Rectangle and assign the values //First parameter color, second width and third lenght
        Rectangle rectangle = new("Red", 5,8);        
        /* 
        //To see the value of the color
        Console.WriteLine(rectangle.GetColor()); 
        */
        //Print the value of the area (abstract from the father class (in the declaration and method) and override in the child)
        Console.WriteLine($"The area of a rectangle with {rectangle.GetWidth()} width and {rectangle.GetLenght()} lenght is {rectangle.GetArea()}");



        //Create an Rectangle and assign the values //First parameter color, second width and third lenght
        Circle circle = new("Blue", 5);        
        /* 
        //To see the value of the color
        Console.WriteLine(rectangle.GetColor()); 
        */
        //Print the value of the area (abstract from the father class (in the declaration and method) and override in the child)
        Console.WriteLine($"The area of a circle with {circle.GetDiameter()} diameter is {circle.GetArea()}");

    }
}