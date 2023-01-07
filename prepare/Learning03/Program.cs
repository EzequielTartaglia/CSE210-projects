using System;

class Program
{
    static void Main(string[] args)
    {
       //Create the default object
       Fraction fraction1 = new Fraction();
       Console.WriteLine(fraction1.GetFractionString());//1/1
        
       //Create the default object
       Fraction fraction2 = new Fraction();
       Console.WriteLine(fraction1.GetDecimalValue());//1

       //Create the constructor with 1 parameter
       Fraction fraction3 = new Fraction(5); 
       Console.WriteLine(fraction3.GetFractionString());//5/1
        
       //Create the default object
       Fraction fraction4 = new Fraction();
       //Set the value of top
       fraction4.SetTop(5);
       Console.WriteLine(fraction4.GetDecimalValue());//5

       //Create the constructor with 2 parameter
       Fraction fraction5 = new Fraction(3,4); 
       Console.WriteLine(fraction5.GetFractionString());//3/4
        
       //Create the default object
       Fraction fraction6 = new Fraction();
       //Set the value of top
       fraction6.SetTop(3);
       //Set the value of bottom
       fraction6.SetBottom(4);       
       Console.WriteLine(fraction6.GetDecimalValue());//0.75

       //Create the default object
       Fraction fraction7 = new Fraction();
       fraction7.SetBottom(3);
       Console.WriteLine(fraction7.GetFractionString());//1/3
        
       //Create the default object
       Fraction fraction8 = new Fraction();
       //Set the value of bottom
       fraction8.SetBottom(3);       
       Console.WriteLine(fraction8.GetDecimalValue());//0.333

       
    }
}