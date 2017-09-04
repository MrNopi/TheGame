using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInformation :MonoBehaviour {
    public static void LoadAllInformation() {
        gameInformation.PlayerName = PlayerPrefs.GetString("PLAYERNAME");
        //MAIN INFO
        gameInformation.Playerlevel=PlayerPrefs.GetInt("PLAYERLEVEL");



        //MAIN ATTRIBUTES
        gameInformation.Intellect = PlayerPrefs.GetInt("PLAYERINTELLECT");
        gameInformation.Strength = PlayerPrefs.GetInt("PLAYERSTRENGTH");
        gameInformation.Agility = PlayerPrefs.GetInt("PLAYERAGILITY");


        //ATTRIBUTES
        gameInformation.Stamina = PlayerPrefs.GetInt("PLAYERSTAMINA");
        gameInformation.Endurance = PlayerPrefs.GetInt("PLAYERENDURANCE");
    }
}


