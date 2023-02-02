using System;
//Public class to can use in "other window"

public class PJKnight : BasePlayerCharacter // PJKnight child class of BasePlayerCharacter
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

    //The default PJKnight when we create
    public PJKnight(int lifePoints, int manaPoints, int experiencePoints, int healPotions, int manaPotions, int level, int physicalDamage, int magicDamage, int attackSpeed, int celerity, int pointsToAssign) : base(lifePoints, manaPoints, experiencePoints, healPotions, manaPoints, level, physicalDamage, magicDamage, attackSpeed, celerity, pointsToAssign)
    {
        //Default values
        _life = lifePoints;
        _mana = manaPoints;
        _experience = experiencePoints;
        _healpotion = healPotions;
        _manaPotion = manaPotions;
        _lvl = level;
        _physicalDamage = physicalDamage;
        _magicDamage = magicDamage;
        _attackSpeed = attackSpeed;
        _celerity = celerity;
        _pointsToAssign = pointsToAssign;

        _specialMoveTitle = "";
        _specialMoveDamage = 0;
    }

    //With 1 parameter
    public PJKnight(int lifePoints, int manaPoints, int experiencePoints, int healPotions, int manaPotions, int level, int physicalDamage, int magicDamage, int attackSpeed, int celerity, int pointsToAssign, string specialMoveTitle) : base(lifePoints, manaPoints, experiencePoints, healPotions, manaPoints, level, physicalDamage, magicDamage, attackSpeed, celerity, pointsToAssign)
    {
        _life = lifePoints;
        _mana = manaPoints;
        _experience = experiencePoints;
        _healpotion = healPotions;
        _manaPotion = manaPotions;
        _lvl = level;
        _physicalDamage = physicalDamage;
        _magicDamage = magicDamage;
        _attackSpeed = attackSpeed;
        _celerity = celerity;
        _pointsToAssign = pointsToAssign;

        _specialMoveTitle = specialMoveTitle;
        _specialMoveDamage = 0;
    }

    //With 2 parameter
    public PJKnight(int lifePoints, int manaPoints, int experiencePoints, int healPotions, int manaPotions, int level, int physicalDamage, int magicDamage, int attackSpeed, int celerity, int pointsToAssign, string specialMoveTitle, int specialMoveDamage) : base(lifePoints, manaPoints, experiencePoints, healPotions, manaPoints, level, physicalDamage, magicDamage, attackSpeed, celerity, pointsToAssign)
    {
        _life = lifePoints;
        _mana = manaPoints;
        _experience = experiencePoints;
        _healpotion = healPotions;
        _manaPotion = manaPotions;
        _lvl = level;
        _physicalDamage = physicalDamage;
        _magicDamage = magicDamage;
        _attackSpeed = attackSpeed;
        _celerity = celerity;
        _pointsToAssign = pointsToAssign;

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
    //Method to see the stats
    public override string GetAllStats()
    {
        //Create the variable to return all the stats
        string stats = "";
        //Add all the stats
        stats = stats + $"Life: {GetlifePoints()}" + "\n";
        stats = stats + $"Mana: {GetManaPoints()}" + "\n";
        stats = stats + $"Lvl: {GetLevel()}" + "\n";
        stats = stats + $"Physical Damage: {GetPhysicalDamage()}" + "\n";
        stats = stats + $"Magical Damage: {GetMagicDamage()}" + "\n";
        stats = stats + $"Attack Speed: {GetAttackSpeed()}" + "\n";
        stats = stats + $"Celerity: {GetCelerity()}" + "\n";
        stats = stats + $"Special move: ['{GetSpecialMoveTitle()}' : {GetSpecialMoveDamage()} damage]" + "\n";

        return stats;

    }
}