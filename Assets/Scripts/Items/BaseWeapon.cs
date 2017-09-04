 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWeapon : BaseStatItem
{
    private int spellEffectID;

    public enum WeaponTypes {
        SWORD,
        STAFF,
        DAGGER,
        BOW,
        SHIELD,
        ORB
    }
    private WeaponTypes weaponType;
    public WeaponTypes WeaponType
    {
        get {return weaponType; }
        set {weaponType = value; }
    }

    

    public int SpellEffectID
    {
        get { return spellEffectID; }
        set { spellEffectID = value; }
    }
    
}
