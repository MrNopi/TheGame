using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewEquipment : MonoBehaviour {
    private BaseEquipment newEquipment;
    private string[] itemNames = new string[4] { "Common", "Great", "Amazing" , "Insane" };
    private string[] itemDes = new string[2] {"A new cool item" , "A new not-so-cool item" };
    private void Start()
    {
        CreateEquipment();
          Debug.Log(newEquipment.ItemName);
        Debug.Log(string.Format("The best {0} armor ever!", newEquipment.EquipmentType).ToUpper());
        Debug.Log(newEquipment.EquipmentType);
        Debug.Log("Strength: "+newEquipment.strength.ToString());
        Debug.Log("Intellect: "+newEquipment.intellect.ToString());
        Debug.Log("Agility: "+newEquipment.agility.ToString());
        Debug.Log("Stamina: "+newEquipment.stamina.ToString());
        Debug.Log("Endurance: "+newEquipment.endurance.ToString());
        Debug.Log(newEquipment.ItemID.ToString());
    }

    public void CreateEquipment() {
        newEquipment = new BaseEquipment();
        newEquipment.ItemName = itemNames[Random.Range(0, 3)] + " Item";
        newEquipment.ItemID = Random.Range(0, 101);
        newEquipment.ItemDescription = itemDes[Random.Range(0, itemDes.Length)];
        // newEquipment.ItemDescription = newEquipment.ItemName + "of a POWER";
        ChooseItemType();
                                                    //stats
        newEquipment.strength = Random.Range(1, 28);            //strength
        newEquipment.stamina = Random.Range(1, 28);            //stamina
        newEquipment.intellect = Random.Range(1, 28);          //intellect
        newEquipment.agility = Random.Range(1, 28);             //agility
        newEquipment.endurance = Random.Range(1, 28);          //endurance
    }

    private void ChooseItemType() {
        int randomTemp = Random.Range(1,9);
        switch (randomTemp) {
            case 1:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.HEAD;
                break;
            case 2:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.SHOULDERS;
                break;
            case 3:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.CHEST;
                break;
            case 4:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.ARMS;
                break;
            case 5:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.NECK;
                break;
            case 6:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.FINGER;
                break;
            case 7:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.LEGS;
                break;
            case 8:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.FEET;
                break;



        }


    }

}
