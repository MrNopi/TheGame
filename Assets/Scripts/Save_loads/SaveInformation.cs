using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInformation : MonoBehaviour {

public static void SaveAllInformation(){

                                            //MAIN INFO
        PlayerPrefs.SetInt("PLAYERLEVEL", gameInformation.Playerlevel);
        PlayerPrefs.SetString("PLAYERNAME", gameInformation.PlayerName); 
       

                                                    //MAIN ATTRIBUTES
            PlayerPrefs.SetInt("PLAYERINTELLECT", gameInformation.Intellect);
            PlayerPrefs.SetInt("PLAYERSTRENGTH", gameInformation.Strength);
            PlayerPrefs.SetInt("PLAYERAGILITY", gameInformation.Agility);
                                

                                            //ATTRIBUTES
        PlayerPrefs.SetInt("PLAYERSTAMINA", gameInformation.Stamina);
        PlayerPrefs.SetInt("PLAYERENDURANCE", gameInformation.Endurance);

        Debug.Log("Its Saved Now");
        }
}
