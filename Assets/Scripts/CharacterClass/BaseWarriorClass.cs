using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWarriorClass : BaseCharacterClass
{

    public BaseWarriorClass() {

        CharacterClassName = "Warrior";
        CharacterClassDescription = "He's brute power , is all, what he have, but don't may him to fool you, his strength is so amazing, and he look awesome (you are still noob, if you want to pick him)";
        stamina = 12;
        endurance = 15;
        strength = 13;
        intellect = 8;
        agility = 9;
        Level = 15;
    }
}
