using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewPlayer : MonoBehaviour {
    private bool IsMageClass = false;
    private bool IsWarriorClass = false;
    private bool IsRogueClass = false;

    public void Start() {

    }

    public void Update() {

    }


    public void OnGUI() {
        if(GUILayout.Toggle(IsMageClass, "Mage Class"))
        {
            IsMageClass = true;
        }
        if(GUILayout.Toggle(IsMageClass, "Warrior Class"))
        {
            IsWarriorClass = true;
        }
        if(GUILayout.Toggle(IsMageClass, "Rogue Class"))
        {
            IsRogueClass = true;
        }
    }
}

