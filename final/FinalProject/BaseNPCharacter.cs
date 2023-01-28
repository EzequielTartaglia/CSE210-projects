using System;
//Public class to can use in "other window"

// this class must also be declared as an abstract class (because have an abstract method inside).
public abstract class BaseNPCharacter
{
   //Protect class inside the propieties to not affect the working of the program (only the inherit class)
    protected int _life;
    protected int _mana;
    protected int _lvl; //Determine the skills
    protected int _physicalDamage; //Determine strengh of hit
    protected int _magicDamage; //Magical power (spells)
    protected int _attackSpeed; //Posibility to do "combos" (2 hits in the same turn for example)
    protected int _celerity; //Determine who start in the battle (speed to do the first attack)

    //----------- Constructors section (templates)--------------

    //The default Goal when we create
    public BaseNPCharacter()
    {
        //Default values
        _life = 1;
        _mana = 0;
        _lvl = 1;
        _physicalDamage = 0;
        _magicDamage = 0;
        _attackSpeed = 0;
        _celerity = 0;
    }
    //When the user only put 1 parameter
    public BaseNPCharacter(int lifePoints)
    {

        _life = lifePoints;
        _mana = 0;
        _lvl = 1;
        _physicalDamage = 0;
        _magicDamage = 0;
        _attackSpeed = 0;
        _celerity = 0;
    }
    //When the user only put 2 parameter
    public BaseNPCharacter(int lifePoints, int manaPoints)
    {
        _life = lifePoints;
        _mana = manaPoints;
        _lvl = 1;
        _physicalDamage = 0;
        _magicDamage = 0;
        _attackSpeed = 0;
        _celerity = 0;
    }
    //When the user only put 3 parameter
    public BaseNPCharacter(int lifePoints, int manaPoints,int level)
    {
        _life = lifePoints;
        _mana = manaPoints;
        _lvl = level;
        _physicalDamage = 0;
        _magicDamage = 0;
        _attackSpeed = 0;
        _celerity = 0;
    }
    //When the user only put 4 parameter
    public BaseNPCharacter(int lifePoints, int manaPoints, int level, int physicalDamage)
    {
        _life = lifePoints;
        _mana = manaPoints;
        _lvl = level;
        _physicalDamage = physicalDamage;
        _magicDamage = 0;
        _attackSpeed = 0;
        _celerity = 0;
    }
    //When the user only put 5 parameter
    public BaseNPCharacter(int lifePoints, int manaPoints, int level, int physicalDamage, int magicDamage)
    {
        _life = lifePoints;
        _mana = manaPoints;
        _lvl = level;
        _physicalDamage = physicalDamage;
        _magicDamage = magicDamage;
        _attackSpeed = 0;
        _celerity = 0;
    }
    //When the user only put 6 parameter
    public BaseNPCharacter(int lifePoints, int manaPoints, int level, int physicalDamage, int magicDamage, int attackSpeed)
    {
        _life = lifePoints;
        _mana = manaPoints;
        _lvl = level;
        _physicalDamage = physicalDamage;
        _magicDamage = magicDamage;
        _attackSpeed = attackSpeed;
        _celerity = 0;
    }
    //When the user only put 7 parameter
    public BaseNPCharacter(int lifePoints, int manaPoints, int level, int physicalDamage, int magicDamage, int attackSpeed, int celerity)
    {
        _life = lifePoints;
        _mana = manaPoints;
        _lvl = level;
        _physicalDamage = physicalDamage;
        _magicDamage = magicDamage;
        _attackSpeed = attackSpeed;
        _celerity = celerity;
    }
    //----------- Constructors section (templates)--------------
    //------------- (Methods - Behaviors) -----------------------
    //----------------- Getter & Setter section -----------------
    public int GetlifePoints()
    {
        //See the value of _life
        return _life;
    }
    public void SetlifePoints(int lifePoints)
    {
        //Put the value of _life
        _life = lifePoints;
    }

    public int GetManaPoints()
    {
        //See the value of _mana
        return _mana;
    }
    public void SetManaPoints(int manaPoints)
    {
        //Put the value of _mana
        _mana = manaPoints;
    }
    public int GetLevel()
    {
        //See the value of _lvl
        return _lvl;
    }
    public void SetLevel(int level)
    {
        //Put the value of _lvl
        _lvl = level;
    }

    public int GetPhysicalDamage()
    {
        //See the value of _life
        return _physicalDamage;
    }
    public void SetPhysicalDamage(int physicalDamage)
    {
        //Put the value of _life
        _physicalDamage = physicalDamage;
    }

    public int GetMagicDamage()
    {
        //See the value of _magicDamage
        return _magicDamage;
    }
    public void SetMagicDamage(int magicDamage)
    {
        //Put the value of _magicDamage
        _magicDamage = magicDamage;
    }

    public int GetAttackSpeed()
    {
        //See the value of _attackSpeed
        return _attackSpeed;
    }
    public void SetAttackSpeed(int attackSpeed)
    {
        //Put the value of _attackSpeed
        _attackSpeed = attackSpeed;
    }

    public int GetCelerity()
    {
        //See the value of _celerity
        return _celerity;
    }
    public void SetCelerity(int celerity)
    {
        //Put the value of _celerity
        _celerity = celerity;
    }
    //----------------- Getter & Setter section -----------------
}
