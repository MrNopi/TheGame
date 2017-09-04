using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacterClass {
                //Main Info
    private string characterClassName;
    private string characterClassDescription;
                //Stats
    public static int Stamina;
    public static int Endurance;
    public static int Strength;
    public static int Intellect;
    public static int Agility;
    public static int Level;

    public int level
    {
        get { return Level; }
        set { Level = value; }
    }

    public int stamina
    {
        get { return Stamina; }
        set { Stamina = value; }
    }
    
    public int endurance
    {
        get { return Endurance; }
        set { Endurance = value; }
    }
    public int strength
    {
        get { return Strength; }
        set { Strength = value; }
    }
    public int intellect
    {
        get { return Intellect; }
        set { Intellect = value; }
    }

           public int agility
    {
        get { return Agility; }
        set { Agility = value; }
    }

           public string CharacterClassName
    {
        get { return characterClassName; }
        set { characterClassName = value; }
    }

    public string CharacterClassDescription
    {
        get { return characterClassDescription; }
        set { characterClassDescription = value; }
    }

}
