using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStatItem : BaseItem
{
    private int Stamina;
    private int Endurance;
    private int Strength;
    private int Intellect;
    private int Agility;


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

}
