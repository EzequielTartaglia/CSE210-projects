using System;
//Public class to can use in "other window"

// this class must also be declared as an abstract class (because have an abstract method inside).
public abstract class BasePlayerCharacter
{
    //Protect class inside the propieties to not affect the working of the program (only the inherit class)
    protected int _life;
    protected int _mana;
    protected int _experience;
    protected int _pointsToAssign; //Quantity of number of skills to improve
    protected int _lvl; //Determine the skills
    protected int _healpotion;
    protected int _manaPotion;
    protected int _physicalDamage; //Determine strengh of hit
    protected int _magicDamage; //Magical power (spells)
    protected int _attackSpeed; //Posibility to do "combos" (2 hits in the same turn for example)
    protected int _celerity; //Determine who start in the battle (speed to do the first attack)
    //List of items the PJ has
    protected List<string> _inventaryBag = new List<string>();

    //----------- Constructors section (templates)--------------

    //The default Goal when we create
    public BasePlayerCharacter()
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
    }

    //When the user only put 1 parameter
    public BasePlayerCharacter(int lifePoints)
    {

        _life = lifePoints;
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
    }
    //When the user only put 2 parameter
    public BasePlayerCharacter(int lifePoints, int manaPoints)
    {
        _life = lifePoints;
        _mana = manaPoints;
        _experience = 0;
        _healpotion = 0;
        _manaPotion = 0;
        _lvl = 1;
        _physicalDamage = 0;
        _magicDamage = 0;
        _attackSpeed = 0;
        _celerity = 0;
        _pointsToAssign = 0;
    }
    //When the user only put 3 parameter
    public BasePlayerCharacter(int lifePoints, int manaPoints, int experiencePoints)
    {
        _life = lifePoints;
        _mana = manaPoints;
        _experience = experiencePoints;
        _healpotion = 0;
        _manaPotion = 0;
        _lvl = 1;
        _physicalDamage = 0;
        _magicDamage = 0;
        _attackSpeed = 0;
        _celerity = 0;
        _pointsToAssign = 0;
    }
    //When the user only put 4 parameter
    public BasePlayerCharacter(int lifePoints, int manaPoints, int experiencePoints, int healPotions)
    {
        _life = lifePoints;
        _mana = manaPoints;
        _experience = experiencePoints;
        _healpotion = healPotions;
        _manaPotion = 0;
        _lvl = 1;
        _physicalDamage = 0;
        _magicDamage = 0;
        _attackSpeed = 0;
        _celerity = 0;
        _pointsToAssign = 0;
    }
    //When the user only put 5 parameter
    public BasePlayerCharacter(int lifePoints, int manaPoints, int experiencePoints, int healPotions, int manaPotions)
    {
        _life = lifePoints;
        _mana = manaPoints;
        _experience = experiencePoints;
        _healpotion = healPotions;
        _manaPotion = manaPotions;
        _lvl = 1;
        _physicalDamage = 0;
        _magicDamage = 0;
        _attackSpeed = 0;
        _celerity = 0;
        _pointsToAssign = 0;
    }
    //When the user only put 6 parameter
    public BasePlayerCharacter(int lifePoints, int manaPoints, int experiencePoints, int healPotions, int manaPotions, int level)
    {
        _life = lifePoints;
        _mana = manaPoints;
        _experience = experiencePoints;
        _healpotion = healPotions;
        _manaPotion = manaPotions;
        _lvl = level;
        _physicalDamage = 0;
        _magicDamage = 0;
        _attackSpeed = 0;
        _celerity = 0;
        _pointsToAssign = 0;
    }
    //When the user only put 7 parameter
    public BasePlayerCharacter(int lifePoints, int manaPoints, int experiencePoints, int healPotions, int manaPotions, int level, int physicalDamage)
    {
        _life = lifePoints;
        _mana = manaPoints;
        _experience = experiencePoints;
        _healpotion = healPotions;
        _manaPotion = manaPotions;
        _lvl = level;
        _physicalDamage = physicalDamage;
        _magicDamage = 0;
        _attackSpeed = 0;
        _celerity = 0;
        _pointsToAssign = 0;
    }
    //When the user only put 8 parameter
    public BasePlayerCharacter(int lifePoints, int manaPoints, int experiencePoints, int healPotions, int manaPotions, int level, int physicalDamage, int magicDamage)
    {
        _life = lifePoints;
        _mana = manaPoints;
        _experience = experiencePoints;
        _healpotion = healPotions;
        _manaPotion = manaPotions;
        _lvl = level;
        _physicalDamage = physicalDamage;
        _magicDamage = magicDamage;
        _attackSpeed = 0;
        _celerity = 0;
        _pointsToAssign = 0;
    }
    //When the user only put 9 parameter
    public BasePlayerCharacter(int lifePoints, int manaPoints, int experiencePoints, int healPotions, int manaPotions, int level, int physicalDamage, int magicDamage, int attackSpeed, int celerity)
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
        _pointsToAssign = 0;
    }
    //When the user only put 10 parameter
    public BasePlayerCharacter(int lifePoints, int manaPoints, int experiencePoints, int healPotions, int manaPotions, int level, int physicalDamage, int magicDamage, int attackSpeed, int celerity, int pointsToAssign)
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

    public int GetExperiencePoints()
    {
        //See the value of _experience
        return _experience;
    }
    public void SetExperiencePoints(int experiencePoints)
    {
        //Put the value of _experience
        _experience = experiencePoints;
    }

    public int GetHealPotions()
    {
        //See the value of _healpotion
        return _healpotion;
    }
    public void SetHealPotions(int healPotions)
    {
        //Put the value of _manaPotion
        _healpotion = healPotions;
    }

    public int GetManaPotions()
    {
        //See the value of _manaPotion
        return _manaPotion;
    }
    public void SetManaPotions(int manaPotions)
    {
        //Put the value of _life
        _manaPotion = manaPotions;
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

    public int GetPointsToAssign()
    {
        //See the value of _pointsToAssign
        return _pointsToAssign;
    }
    public void SetPointsToAssign(int pointsToAssign)
    {
        //Put the value of _pointsToAssign
        _pointsToAssign = pointsToAssign;
    }

    //----------------- Getter & Setter section -----------------
    public List<string> GetInventaryBag()
    {
        return _inventaryBag;
    }
    //Method to add one item to the inventary
    public void AddToInventaryBag(string item, int quantity)
    {
        //example to use
        //myObject.AddToInventaryBag("LifePotion", 3);
        
        bool itemExists = false;

        //Iteration of the list
        for (int i = 0; i < _inventaryBag.Count; i++)
        {
            //If the item exist in the inventary
            if (_inventaryBag[i].Contains(item))
            {
                string[] parts = _inventaryBag[i].Split(' ');
                int currentQuantity = int.Parse(parts[0]);
                _inventaryBag[i] = (currentQuantity + quantity) + " " + item;
                itemExists = true;
                break;
            }
        }
        //If the item not exist in the inventary
        if (!itemExists)
        {
            _inventaryBag.Add(quantity + " " + item);
        }
    }

    //Method to see the stats
    public virtual string GetAllStats(){
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

        return stats;

    }
}
