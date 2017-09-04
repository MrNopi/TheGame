using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseRogueClass : BaseCharacterClass
{

    public BaseRogueClass()
    {

        CharacterClassName = "Rogue";
        CharacterClassDescription = "The most agile hero in this game (to be honest, he's just one, who agile) who can dodge every hit and have fast attack speed, good luck (well,thats hero is for noobs too, so I even don't know , what to do PROgamers)";
        stamina = 12;
        endurance = 15;
        strength = 9;
        intellect = 8;
        agility = 12;
        Level = 15;
    }
}
