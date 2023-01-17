using System;
//Public class to can use in "other window"

// this class must also be declared as an abstract class (because have an abstract method inside).
public abstract class Shape //Shape = form
{
    //Protect class inside the propieties to not affect the working of the program (only the inherit class)
    protected string _color;

    //------------------ Constructors section (templates)--------------

    //The default Shape when we create
    public Shape()
    {
        //Default values
        _color = "";
    }

    //When the user only put 1 parameter
    //Create a Shape with the color
    public Shape(string colorShape)
    {

        //ex Shape("Blue") assign the color blue to the shape
        _color = colorShape;
    }

    //------------------ Constructors section (templates)--------------
    //----------------------- Getters and Setters ---------------------
    public string GetColor(){
        //Get the color of the shape
        return _color;
    }
    public void SetColor(string colorToSet){
        //Set the value of shape's color
        _color = colorToSet;
    }
    //----------------------- Getters and Setters ---------------------
    //-------------------------- Methods ------------------------------

    // virtual auto-implemented property. Overrides can only
    // provide specialized behavior if they implement get and set accessors.
    public abstract double GetArea();

}