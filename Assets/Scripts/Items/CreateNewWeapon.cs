using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewWeapon : MonoBehaviour {


    private void Start()
    {
        CreateWeapon();
        Debug.Log(newWeapon.ItemName);
        Debug.Log(string.Format("The best {0} weapon ever!", newWeapon.WeaponType).ToUpper());
        Debug.Log(newWeapon.WeaponType);
        Debug.Log("Strength: "+newWeapon.strength.ToString());
        Debug.Log("Intellect: "+newWeapon.intellect.ToString());
        Debug.Log("Agility: "+newWeapon.agility.ToString());
        Debug.Log("Stamina: "+newWeapon.stamina.ToString());
        Debug.Log("Endurance: "+newWeapon.endurance.ToString());
        Debug.Log(newWeapon.ItemID.ToString());
    }


    private BaseWeapon newWeapon;
    public void CreateWeapon() {
        newWeapon = new BaseWeapon();   //assign name
        newWeapon.ItemName = "W " + Random.Range(1, 101);
        newWeapon.ItemDescription = "This is new Weapon";
        //    newWeapon.ItemDescription =("This is the best weapon").ToUpper();       //assign description
        newWeapon.ItemID = Random.Range(1, 101);    //assign ID
                                            //stats
        newWeapon.strength = Random.Range(1, 28);            //strength
        newWeapon.stamina = Random.Range(1, 28);            //stamina
        newWeapon.intellect = Random.Range(1, 28);          //intellect
        newWeapon.agility= Random.Range(1, 28);             //agility
        newWeapon.endurance = Random.Range(1, 28);          //endurance


        ChooseWeaponType();


        newWeapon.SpellEffectID = Random.Range(1, 101);

    }
    public void ChooseWeaponType() {
        int randomTemp = Random.Range(1, 7);
        switch (randomTemp)
        {                   //WARRIOR
            case 1:
                newWeapon.WeaponType = BaseWeapon.WeaponTypes.SWORD;
                break;
            case 5:
                newWeapon.WeaponType = BaseWeapon.WeaponTypes.SHIELD;
                break;
                                    //WIZARD
            case 2:
                newWeapon.WeaponType = BaseWeapon.WeaponTypes.STAFF;
                break;
            case 4:
                newWeapon.WeaponType = BaseWeapon.WeaponTypes.ORB;
                break;
                                    //ROGUE
            case 3:
                newWeapon.WeaponType = BaseWeapon.WeaponTypes.DAGGER;
                break;
            case 6:
                newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOW;
                break;
          
            
            
        }


    }


}
