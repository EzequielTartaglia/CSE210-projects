using System;

//Public class to can use in "other window"
public class Fraction
{
    //Private class inside the propieties to not affect the working of the program
    private int _top;
    private int _bottom;

    //------------------ Constructors section (templates)--------------

    //The default Fraction when we create
    public Fraction()
    {
        //Default values
        _top = 1;
        _bottom = 1;
    }

    //When the user only put 1 parameter
    //Create an intenger number(bottom is 1)
    public Fraction(int topNumber)
    {
        
        //ex Fraction(5) is the same like 5/1
        _top = topNumber;
        _bottom = 1; //Authomatic assigment
    }

    //When the user only put 2 parameters
    //Create a Fraction could be manipulated _top and _bottom
    public Fraction(int topNumber, int bottomNumber)
    {
        _top = topNumber;
        _bottom = bottomNumber;
    }

    //--------------------- Constructors section - end -------------------

    //--------------------- (Methods - Behaviors) ------------------------
    //--------------------- Getter & Setter section ----------------------
    public int GetTop(){
        //See the value of _top
        return _top;
    }

    public void SetTop(int topNumber)
    {
        //Put the value of _top
        _top = topNumber;
    }
     
     
        public int GetBottom()
    {
        //See the value of _top
        return _bottom;
    }

    public void SetBottom(int bottomNumber)
    {
        //Put the value of _top
        _bottom = bottomNumber;
    }
    //--------------------- Getter & Setter section - end ----------------

    //--------------------- Methods (functions) --------------------------
    public string GetFractionString()
    {
        //Print the string (ex. return 2/4)
        string fractionText = $"{_top}/{_bottom}";
        return fractionText;
    }
    public double GetDecimalValue()
    {
        //Print the result of the divition (ex. 2/4 return 0.5)
        return (double)_top / (double)_bottom;
    }
    //--------------------- Methods (functions) --------------------------
    //--------------------- (Methods - Behaviors) - End ------------------
}