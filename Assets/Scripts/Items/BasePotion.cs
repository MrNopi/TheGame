using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePotion : BaseStatItem
{
    private PotionsTypes potionType;
    private int SpellEffectID;
    public enum PotionsTypes {
        HEALTH,
        MP,
        STRENGTH,
        INTELLECT,
        AGILITY ,
        ENDURANCE,
        STAMINA
    }
    public PotionsTypes PotionType {
        get { return potionType; }
        set { potionType = value; }

    }

}
