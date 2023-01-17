using System;

//Public class to can use in "other window"
public class Circle : Shape // Circle child class of Shape(form)
{
    //Protect class inside the propieties to not affect the working of the program (only the inherit class)
    //protected string _color;

    //Propieties from Circle Class
    private double π = Math.PI;
    private double _diameter;

    //------------------ Constructors section (templates)--------------

    //The default Circle when we create (only 1 parameter from Shape)
    public Circle(string colorFromShape) : base(colorFromShape)
    {
        //Value from Circle class (this class)
        _diameter = 0;
    }

    //Circle with 2 parameters
    public Circle(string colorFromShape, double diameterDecimal) : base(colorFromShape)
    {
        //Value from Circle class (this class)
        _diameter = diameterDecimal;
    }

    //------------------ Constructors section (templates)--------------
    //----------------------- Getters and Setters ---------------------
    public double GetDiameter()
    {
        //Get the information of _side
        return _diameter;
    }
    public void SetDiameter(double diameterToSet)
    {
        //Get the information of _side
        _diameter = diameterToSet;
    }

    //----------------------- Getters and Setters ---------------------
    //-------------------------- Methods ------------------------------

    // Override auto-implemented property with ordinary property
    // to provide specialized accessor behavior.
    public override double GetArea(){
        
        double radius = _diameter / 2;
        //Formula about area from a Circle 
        double resultOfArea = π * radius * radius;  
        //Round the number, to print with 2 decimals after the "."
        double roundedNumOfArea = Math.Round(resultOfArea, 2);  

        return roundedNumOfArea;
    }
}