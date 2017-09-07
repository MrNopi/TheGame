using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer  {
    private string playerName;
    public static int PlayerLevel;
    public static BaseCharacterClass PlayerClass;
                                            //PLAYER STATS
    public static int intellect;
    public static int agility;
    public static int strength;
                                            //MAIN STATS
    private int health;
    private int stamina;

                                            //MAIN INFO
    public string PlayerName {
        get { return playerName; }
        set { playerName = value; } 
    }
    public int Playerlevel
    {
        get { return PlayerLevel; }
        set { PlayerLevel = value; }
    }
    public BaseCharacterClass playerClass
    {
        get { return PlayerClass; }
        set { PlayerClass = value; }
    }

                                             //MAIN STATS

    public int Stamina
    {
        get { return stamina; }
        set { stamina = value; }
    }
    public int Health
    {
        get { return health; }
        set { health = value; }
    }

                                            //HERO STATS


    public int Intellect
    {
        get { return intellect; }
        set { intellect = value; }
    }

    public int Strength
    {
        get { return strength; }
        set { strength = value; }
    }
    public int Agility
    {
        get { return agility; }
        set { agility = value; }
    }

}
