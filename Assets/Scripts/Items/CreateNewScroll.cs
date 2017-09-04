using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewScroll : MonoBehaviour {

    private BaseScroll newScroll;

    private void CreateScroll()
    {
        newScroll = new BaseScroll();
        newScroll.ItemName = "Scroll";
        newScroll.ItemDescription = "Powerfull Scroll of {0}";
        newScroll.ItemID = Random.Range(0, 101);
        newScroll.spellEffectID = Random.Range(500, 1001);
    }

    private void Start()
    {
        CreateScroll();
        Debug.Log(newScroll.ItemName);
        Debug.Log(string.Format("The best {0} ever!", newScroll.ItemName).ToUpper());
        Debug.Log(newScroll.ItemName);
        Debug.Log(newScroll.ItemID.ToString());

    }
}

