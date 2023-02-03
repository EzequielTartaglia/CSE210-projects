using System;
//Public class to can use in "other window"

public class PJWizard : BasePlayerCharacter // PJWizard child class of BasePlayerCharacter
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

    //The default PJWizard when we create
    public PJWizard(int lifePoints, int manaPoints, int experiencePoints, int healPotions, int manaPotions, int level, int physicalDamage, int magicDamage, int attackSpeed, int celerity, int pointsToAssign) : base(lifePoints, manaPoints, experiencePoints, healPotions, manaPoints, level, physicalDamage, magicDamage, attackSpeed, celerity, pointsToAssign)
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
    public PJWizard(int lifePoints, int manaPoints, int experiencePoints, int healPotions, int manaPotions, int level, int physicalDamage, int magicDamage, int attackSpeed, int celerity, int pointsToAssign, string specialMoveTitle) : base(lifePoints, manaPoints, experiencePoints, healPotions, manaPoints, level, physicalDamage, magicDamage, attackSpeed, celerity, pointsToAssign)
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
    public PJWizard(int lifePoints, int manaPoints, int experiencePoints, int healPotions, int manaPotions, int level, int physicalDamage, int magicDamage, int attackSpeed, int celerity, int pointsToAssign, string specialMoveTitle, int specialMoveDamage) : base(lifePoints, manaPoints, experiencePoints, healPotions, manaPoints, level, physicalDamage, magicDamage, attackSpeed, celerity, pointsToAssign)
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

       //Method to upgrade the skills
    public override int UpgradeSkills(int pointsToAssign)
    {
        Console.Clear();
        _pointsToAssign = pointsToAssign;

        //Check if there are points to assign
        if (_pointsToAssign <= 0)
        {
            Console.WriteLine("No points to assign");
            return _pointsToAssign;
        }

        Console.WriteLine("Write the number of the skill to upgrade.");
        Console.WriteLine("[1] Life points");
        Console.WriteLine("[2] Mana points");
        Console.WriteLine("[3] Physical damage");
        Console.WriteLine("[4] Magic damage");
        Console.WriteLine("[5] Attack speed");
        Console.WriteLine("[6] Celerity");
        Console.WriteLine("[7] Special skill");
        Console.WriteLine("[8] Back menu");

        Console.Write("Select a choice from the menu: ");
        int skillToUpgrade = int.Parse(Console.ReadLine());

        //Loop until a valid option is selected
        while (skillToUpgrade < 1 || skillToUpgrade > 8)
        {
            Console.WriteLine("Invalid option, try again");
            Console.Write("Select a choice from the menu: ");
            skillToUpgrade = int.Parse(Console.ReadLine());
        }

        //Add one point to the stats and change the propieties of the character
        //Then subtract 1 point to assign
        switch (skillToUpgrade)
        {
            case 1:
                SetlifePoints(GetlifePoints() + 50);
                _pointsToAssign--;
                break;

            case 2:
                SetManaPoints(GetManaPoints() + 50);
                _pointsToAssign--;
                break;

            case 3:
                SetPhysicalDamage(GetPhysicalDamage() + 5);
                _pointsToAssign--;
                break;

            case 4:
                SetMagicDamage(GetMagicDamage() + 5);
                _pointsToAssign--;
                break;

            case 5:
                SetAttackSpeed(GetAttackSpeed() + 5);
                _pointsToAssign--;
                break;

            case 6:
                SetCelerity(GetCelerity() + 5);
                _pointsToAssign--;
                break;

            case 7:
                SetSpecialMoveDamage(GetSpecialMoveDamage() + 20);
                _pointsToAssign--;
                break;

            case 8:
                break;
        }
        SetPointsToAssign(_pointsToAssign);
        return _pointsToAssign;
    }

}