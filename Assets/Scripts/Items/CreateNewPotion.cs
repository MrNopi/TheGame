using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewPotion : MonoBehaviour {

    private BasePotion newPotion;
    // potions name
    string[] PotionType = new string[5] { "Potion of Speed", "Healing Potion","Mana Potion", "Potion of Strength","Potion of Intellect" };


	// Use this for initialization
	void Start () {
        CreatePotion();


        Debug.Log(newPotion.ItemName);
        Debug.Log(string.Format("The best {0} ever!", newPotion.ItemName).ToUpper());
        Debug.Log(newPotion.ItemName);
        Debug.Log(newPotion.ItemID.ToString());
        //STATS

        //     Debug.Log("Strength: " + newPotion.strength.ToString());
        //   Debug.Log("Intellect: " + newPotion.intellect.ToString());
        // Debug.Log("Agility: " + newPotion.agility.ToString());
        //Debug.Log("Stamina: " + newPotion.stamina.ToString());
        //Debug.Log("Endurance: " + newPotion.endurance.ToString());
    }



    private void CreatePotion() {

        newPotion = new BasePotion();
        newPotion.ItemName = PotionType[Random.Range(0,PotionType.Length)];
        newPotion.ItemDescription = string.Format("The Greatest {0}", newPotion.ItemName);
        newPotion.ItemID = Random.Range(0, 101);


        ChoosePotionType();



    }


    private void ChoosePotionType() {
        int randomTemp = Random.Range(0, 7);
        switch (randomTemp) {

                                                    //MAIN STATS
            case 0:
                newPotion.PotionType = BasePotion.PotionsTypes.HEALTH;
                break;
            case 3:
                newPotion.PotionType = BasePotion.PotionsTypes.MP;
                break;
            case 5:
                newPotion.PotionType = BasePotion.PotionsTypes.STAMINA;
                break;
            case 6:
                newPotion.PotionType = BasePotion.PotionsTypes.ENDURANCE;
                break;
            //STATS
            case 1:
                newPotion.PotionType = BasePotion.PotionsTypes.STRENGTH;
                break;
            case 2:
                newPotion.PotionType = BasePotion.PotionsTypes.AGILITY;
                break;
            case 4:
                newPotion.PotionType = BasePotion.PotionsTypes.INTELLECT;
                break;
         
            
        }
    }
}
