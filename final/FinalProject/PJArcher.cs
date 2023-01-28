using System;
//Public class to can use in "other window"

public class PJArcher : BasePlayerCharacter // PJArcher child class of BasePlayerCharacter
{
    //Protect class inside the propieties to not affect the working of the program (only the inherit class)
    //protected int _life;
    //protected int _mana;
    //protected int _experience;
    //protected int _pointsToAssign; //Quantity of number of skills to improve
    //protected int _lvl; //Determine the skills
    //protected int _healpotion;
    //protected int _manaPotion;
    //protected int _physicalDamage; //Determine strengh of hit
    //protected int _magicDamage; //Magical power (spells)
    //protected int _attackSpeed; //Posibility to do "combos" (2 hits in the same turn for example)
    //protected int _celerity; //Determine who start in the battle (speed to do the first attack)
    //List of items the PJ has
    //protected List<string> _inventaryBag = new List<string>();
    private string _specialMoveTitle;
    private int _specialMoveDamage;

    //----------- Constructors section (templates)--------------

    //The default Goal when we create
    public PJArcher(int lifePoints, int manaPoints, int level, int physicalDamage, int magicDamage, int attackSpeed, int celerity) :base(lifePoints,manaPoints,level,physicalDamage,magicDamage,attackSpeed,celerity)
    {
        //Default values
        _life = 1;
        _mana = 0;
        _experience = 0;
        _healpotion = 0;
        _manaPotion = 0;
        _lvl = 1;
        _physicalDamage = 0;
        _magicDamage = 0;
        _attackSpeed = 0;
        _celerity = 0;
        _pointsToAssign = 0;

        _specialMoveTitle = "";
        _specialMoveDamage = 0;
    }

    //With 1 parameter
    public PJArcher(int lifePoints, int manaPoints, int level, int physicalDamage, int magicDamage, int attackSpeed, int celerity, string specialMoveTitle) :base(lifePoints,manaPoints,level,physicalDamage,magicDamage,attackSpeed,celerity)
    {
        _life = 1;
        _mana = 0;
        _experience = 0;
        _healpotion = 0;
        _manaPotion = 0;
        _lvl = 1;
        _physicalDamage = 0;
        _magicDamage = 0;
        _attackSpeed = 0;
        _celerity = 0;
        _pointsToAssign = 0;
        
        _specialMoveTitle = specialMoveTitle;
        _specialMoveDamage = 0;
    }

    //With 2 parameter
    public PJArcher(int lifePoints, int manaPoints, int level, int physicalDamage, int magicDamage, int attackSpeed, int celerity, string specialMoveTitle, int specialMoveDamage) :base(lifePoints,manaPoints,level,physicalDamage,magicDamage,attackSpeed,celerity)
    {
        _life = 1;
        _mana = 0;
        _experience = 0;
        _healpotion = 0;
        _manaPotion = 0;
        _lvl = 1;
        _physicalDamage = 0;
        _magicDamage = 0;
        _attackSpeed = 0;
        _celerity = 0;
        _pointsToAssign = 0;
        
        _specialMoveTitle = specialMoveTitle;
        _specialMoveDamage = specialMoveDamage;
    }
    
    //----------- Constructors section (templates)--------------
    //------------- (Methods - Behaviors) -----------------------
    //----------------- Getter & Setter section -----------------
    public string GetSpecialMoveTitle()
    {
        //See the value of _specialMoveTitle
        return _specialMoveTitle;
    }
    public void SetSpecialMoveTitle(string specialMoveTitle)
    {
        //Put the value of _specialMoveTitle
        _specialMoveTitle = specialMoveTitle;
    }
       public int GetSpecialMoveDamage()
    {
        //See the value of _specialMoveDamage
        return _specialMoveDamage;
    }
    public void SetSpecialMoveDamage(int specialMoveDamage)
    {
        //Put the value of _specialMoveDamage
        _specialMoveDamage = specialMoveDamage;
    } 
    //----------------- Getter & Setter section -----------------

    }