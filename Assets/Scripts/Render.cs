using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Render : MonoBehaviour {
    public Renderer Mage;
    public Renderer Warrior;
    public Renderer Rogue;

    private void Start()
    {
        Disabling();
    }
    public void Disabling()
    {
        string charClass = HeroGUI.CharClass;
        if(charClass == "Mage")
        {
            Destroy(Warrior);
            Destroy(Rogue);

        }
        if (charClass == "Warrior")
        {
            Destroy(Mage);
            Destroy(Rogue);
        }
        if (charClass == "Rogue")
        {
            Destroy(Mage);
            Destroy(Warrior);
        }

    }

}
