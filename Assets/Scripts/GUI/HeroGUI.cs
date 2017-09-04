using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroGUI : MonoBehaviour
{
    GameObject MageStats;
    GameObject WarriorStats;
    GameObject RogueStats;
    public BaseCharacterClass Mage = new BaseMageClass();
    public BaseCharacterClass Warrior = new BaseWarriorClass();
    public BaseCharacterClass Rogue = new BaseRogueClass();
    public static string CharClass;
    private string playerName = "EnterName";
    public static BasePlayer newPlayer;
    private void Start()
    {
        newPlayer = new BasePlayer();
        MageStats = GameObject.Find ("BaseMageCharacter");
        WarriorStats = GameObject.Find("BaseMageCharacter");
        RogueStats = GameObject.Find("BaseMageCharacter");
        BaseMageClass mageScript = MageStats.GetComponent<BaseMageClass>();
    }

    private void OnGUI()
    {
        playerName = GUILayout.TextArea(playerName, 16);
        GUILayout.Space(50);

        //Mage
        GUILayout.Label(Mage.CharacterClassName);
        GUILayout.Label(Mage.CharacterClassDescription);
        GUILayout.Label("The main attribute is intellect :" + Mage.intellect);
        GUILayout.Space(50);
        GUILayout.BeginArea(new Rect(((Screen.width / 2) - 200), (Screen.height / 2 - 150), 400, 100));

        if (GUILayout.Button("Choose Mage" /*, GUILayout.MaxWidth(400)*/))
        {
            newPlayer.playerClass = new BaseMageClass();
            Application.LoadLevel("Level_1");
            Attribute();
            CharClass = "Mage";

        }
        GUILayout.EndArea();
        GUILayout.Space(50);

        //Warrior
        GUILayout.Label(Warrior.CharacterClassName);
        GUILayout.Label(Warrior.CharacterClassDescription);
        GUILayout.Label("The main attribute is strength : " + Warrior.strength.ToString());
        GUILayout.Space(50);
        GUILayout.BeginArea(new Rect(((Screen.width / 2) - 200), (Screen.height / 2 + 20), 400, 100));
        if (GUILayout.Button("Choose Warrior"/*, GUILayout.MaxWidth(400)*/))
        {
            newPlayer.playerClass = new BaseWarriorClass();
            Application.LoadLevel("Level_1");
            Attribute();
            CharClass = "Warrior";
        }
        GUILayout.EndArea();
        GUILayout.Space(50);
        //Rogue

        GUILayout.Label(Rogue.CharacterClassName);
        GUILayout.Label(Rogue.CharacterClassDescription);
        GUILayout.Label("The main attribute is agility : " + Rogue.agility.ToString());
        GUILayout.Space(50);
        GUILayout.BeginArea(new Rect(((Screen.width / 2) - 200), (Screen.height / 2 + 230), 400, 100));
        if (GUILayout.Button("Choose Rogue"/*, GUILayout.MaxWidth(400)*/))
        {
            newPlayer.playerClass = new BaseRogueClass();
            Application.LoadLevel("Level_1");
            Attribute();
            CharClass = "Rogue";
        }
        GUILayout.EndArea();



    }
    public void Attribute()
    {
        newPlayer.Playerlevel = 15;
        newPlayer.PlayerName = playerName;

        //HERO ATTRIBUTE
        newPlayer.Stamina = newPlayer.playerClass.stamina;
        newPlayer.Endurance = newPlayer.playerClass.endurance;

        //MAIN HERO ATTRIBUTE

        newPlayer.Intellect = newPlayer.playerClass.intellect;
        newPlayer.Agility = newPlayer.playerClass.agility;
        newPlayer.Strength = newPlayer.playerClass.strength;
        StoreInfo();
        SaveInformation.SaveAllInformation();

        //MAIN INFO
        Debug.Log("Player Class: " + newPlayer.playerClass.CharacterClassName);
        Debug.Log("Player Level: " + newPlayer.Playerlevel);
        Debug.Log("Player Name is: " + newPlayer.PlayerName);

        //MAIN ATTRIBUTES
        Debug.Log("Player Intellect: " + newPlayer.Intellect);
        Debug.Log("Player Strength: " + newPlayer.Strength);
        Debug.Log("Player Agility: " + newPlayer.Agility);

        //ATTRIBUTES
        Debug.Log("Player Stamina: " + newPlayer.Stamina);
        Debug.Log("Player Endurance: " + newPlayer.Endurance);



    }
    private void StoreInfo()
    {
        gameInformation.PlayerName = newPlayer.PlayerName;
        gameInformation.Intellect = newPlayer.playerClass.intellect;
        gameInformation.Agility = newPlayer.playerClass.agility;
        gameInformation.Strength = newPlayer.playerClass.strength;
        gameInformation.Intellect = newPlayer.playerClass.intellect;
        gameInformation.Agility = newPlayer.playerClass.agility;
        gameInformation.Strength = newPlayer.playerClass.strength;
        gameInformation.Stamina = newPlayer.playerClass.stamina;
        gameInformation.Endurance = newPlayer.playerClass.endurance;
        gameInformation.Playerlevel = newPlayer.Playerlevel;


    }

}