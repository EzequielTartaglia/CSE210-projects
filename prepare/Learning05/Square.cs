using System;

//Public class to can use in "other window"
public class Square : Shape // Square child class of Shape(form)
{
    //Protect class inside the propieties to not affect the working of the program (only the inherit class)
    //protected string _color;

    //Propieties from Square Class
    private double _side;

    //------------------ Constructors section (templates)--------------

    //The default Square when we create (only 1 parameter from Shape)
    public Square(string colorFromShape) : base(colorFromShape)
    {
        //Value from Square class (this class)
        _side = 0;
    }

    //Square with 2 parameters
    public Square(string colorFromShape, double sideDecimal) : base(colorFromShape)
    {
        //Value from Square class (this class)
        _side = sideDecimal;
    }
    //------------------ Constructors section (templates)--------------
    //----------------------- Getters and Setters ---------------------
    public double GetSide()
    {
        //Get the information of _side
        return _side;
    }
    public void SetSide(double sideToSet)
    {
        //Get the information of _side
        _side = sideToSet;
    }
    //----------------------- Getters and Setters ---------------------
    //-------------------------- Methods ------------------------------

    // Override auto-implemented property with ordinary property
    // to provide specialized accessor behavior.
    public override double GetArea(){

        //Formula about area from a Square        
        return _side * _side;
    }
}