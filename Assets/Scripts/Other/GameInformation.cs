using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInformation : MonoBehaviour {
    
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
    public static int Endurance { get; set; }
    public static int Stamina { get; set; }
}
