using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {
    public int health = 80 + (GameInformation.Playerlevel * 5);
    public int xp = 30 + (GameInformation.Playerlevel * 5);
public void Die()
    {
        Destroy(this.gameObject);
        Moving.Xp += xp;
    }
}
