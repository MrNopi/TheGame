using UnityEngine;
using System.Collections;

[System.Serializable]
public class Game
{

    public static Game current;
    public BaseCharacterClass knight;
    public BaseCharacterClass rogue;
    public BaseCharacterClass wizard;

    public Game()
    {
        knight = new BaseCharacterClass();
        rogue = new BaseCharacterClass();
        wizard = new BaseCharacterClass();
    }


}