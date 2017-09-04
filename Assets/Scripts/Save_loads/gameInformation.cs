using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameInformation : MonoBehaviour {

    //public int Health = 120 + (Strength * 5) + Endurance;
    //public int Mana = 120 + (Intellect * 3) + Stamina;
    public void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
    public static string PlayerName { get; set; }
    public static int Playerlevel { get; set; }
    public static BaseCharacterClass PlayerClass { get; set; }
    public static int Intellect { get; set; }
    public static int Strength { get; set; }
    public static int Agility { get; set; }
    public static int Endurance {
        get { return Endurance;}
    set { Endurance = value + (Strength * 6);}
    }
    public static int Stamina { get {return Stamina ;} set {Stamina = value + (Intellect * 4) ;} }

}
