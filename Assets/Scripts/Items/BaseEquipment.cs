using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEquipment : BaseStatItem {
    private int SpellEffectID;
    public enum EquipmentTypes {
        HEAD,
        CHEST,
        SHOULDERS,
        LEGS,
        FEET,
        ARMS,
        NECK,
        FINGER
    }
    private EquipmentTypes equipmentTypes;
      
    public EquipmentTypes EquipmentType {
        get { return equipmentTypes;}
        set { equipmentTypes = value;}
    }
    public int spellEffectID {
        get { return SpellEffectID; }
        set { SpellEffectID = value; }
    }
}
