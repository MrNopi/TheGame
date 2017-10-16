using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public Object coins_obj;
    public Coins[] coins;
    private void Start()
    {
        //coins = (Coins[])Resources.LoadAll("ScriptableObjects") as Coins[];
        coins_obj = Resources.Load("Items/Coin 1");
        for (int i = 0; i != coins.Length - 1; i++)
        {
            Instantiate(coins_obj, new Vector3(transform.position.x, transform.position.y), Quaternion.identity);
            
        }
    }
}
