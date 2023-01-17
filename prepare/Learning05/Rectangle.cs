using System;

//Public class to can use in "other window"
public class Rectangle : Shape // Square child class of Shape(form)
{
    //Protect class inside the propieties to not affect the working of the program (only the inherit class)
    //protected string _color;

    //Propieties from Square Class
    private double _width;
    private double _lenght;

    //------------------ Constructors section (templates)--------------

    //The default Rectangle when we create (only 1 parameter from Shape)
    public Rectangle(string colorFromShape) : base(colorFromShape)
    {
        //Value from Rectangle class (this class)
        _width = 0;
        _lenght = 0;
    }

    //Rectangle with 2 parameters
    public Rectangle(string colorFromShape, double widthDecimal) : base(colorFromShape)
    {
        //Value from Rectangle class (this class)
        _width = widthDecimal;
        _lenght = 0;
    }

    //Rectangle with 3 parameters
    public Rectangle(string colorFromShape, double widthDecimal,double lenghtDecimal) : base(colorFromShape)
    {
        //Value from Rectangle class (this class)
        _width = widthDecimal;
        _lenght = lenghtDecimal;
    }    //------------------ Constructors section (templates)--------------
    //----------------------- Getters and Setters ---------------------
    public double GetWidth()
    {
        //Get the information of _side
        return _width;
    }
    public void SetWidth(double widthToSet)
    {
        //Get the information of _side
        _width = widthToSet;
    }
    public double GetLenght()
    {
        //Get the information of _side
        return _lenght;
    }
    public void SetLenght(double lenghtToSet)
    {
        //Get the information of _side
        _lenght = lenghtToSet;
    }    //----------------------- Getters and Setters ---------------------
    //-------------------------- Methods ------------------------------

    // Override auto-implemented property with ordinary property
    // to provide specialized accessor behavior.
    public override double GetArea(){

        //Formula about area from a Square        
        return _width * _lenght;
    }
}