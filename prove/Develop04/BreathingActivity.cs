using System;
//Public class to can use in "other window"

public class BreathingActivity : Activity {
    //Protect class inside the propieties to not affect the working of the program (only the inherit class)
    
    //Classes from the base Class (father)
    //protected string _startingMessage;
    //protected string _activityDuration;
    //protected string _descripciónActivity;
    //protected string _finalActivityMessage;
    
    private DateTime _cooldownTime;

    //----------- Constructors section (templates)--------------

    //The default BreathingActivity when we create
    public BreathingActivity(string activityName, string activityDescription, string activityFinalMessage) :base(activityName,activityDescription,activityFinalMessage) //base() are the propieties from Activity (base/father class)
    {
        //Default values
        DateTime startTime = DateTime.Now;
        _cooldownTime = startTime.AddSeconds(0);
    }
    //The default BreathingActivity when we create
    public BreathingActivity(string activityName, string activityDescription, string activityFinalMessage, int cooldownTimeActivity) :base(activityName,activityDescription,activityFinalMessage) //base() are the propieties from Activity (base/father class)
    {
        //Default values
        //Add 3 zero to the right
        string cooldownTimeString  = cooldownTimeActivity.ToString().PadRight(3, '0');
        DateTime startTime = DateTime.Now;
        _cooldownTime = startTime.AddSeconds(int.Parse(cooldownTimeString));
    }   
    
    //------------- Constructors section - end ------------------

    //------------- (Methods - Behaviors) -----------------------
    //----------------- Getter & Setter section -----------------

    public DateTime GetCooldown(){
        //See the value of _cooldownTime
        return _cooldownTime;
    }

    public void SetTitle(DateTime settedCooldown)
    {
        //Put the value of _cooldownTime
        string cooldownTimeString  = settedCooldown.ToString().PadRight(3, '0');
        DateTime startTime = DateTime.Now;
        _cooldownTime = startTime.AddSeconds(int.Parse(cooldownTimeString));         

    }

    //----------------- Getter & Setter section -----------------
    //-------------------- Methods ------------------------------
    
    
    //Después del mensaje de inicio, se muestra al usuario una serie de mensajes que alternan entre "Inhalar..." y "Exhalar..."
    //Después de cada mensaje, el programa debe hacer una pausa de varios segundos y mostrar una cuenta atrás.
    //Debe continuar hasta que haya alcanzado el número de segundos que el usuario especificó para la duración.

   public int Cooldown(int seconds)
{
    int original = seconds;
    int copy = original;
    // inicializar variables
    int remaining = seconds;
    bool toggle = true;
    string message = "Breathe in...";
    int countdown = 3;
    // mientras queden segundos en el cooldown
    while (remaining > 0)
    {
        Console.Clear();

        //For each breathe loop
        while(countdown>0 && remaining>0){
            Console.Clear();
          Console.WriteLine($"{message} {countdown}");
          
          Thread.Sleep(1000);
          
          //Rest 1 for each iteration
          countdown--;
          remaining--;
          
        }
        //Depends if the breathe is in or out
        if (message == "Breathe in...")
        {
            countdown = 6;
            Console.Clear();
        }
        if (message == "Now Breathe out...")
        {
            countdown = 3;
            Console.Clear();
        }

        //Change the state of the variable (if is true, change to false and reverse)
        toggle = !toggle;
        message = toggle ? "Breathe in..." : "Now Breathe out...";
    }
        
        //Return the quantity of seconds the user spend in this activity
        return original;
}

    }