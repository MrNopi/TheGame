using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Evolution : MonoBehaviour
{
    public GameObject gs;
    Canvas group;
    public BaseCharacterClass PlayerClass;
    int lvl = BaseCharacterClass.Level ;
   /* public Button Mage;
    public Button Warrior;
    public Button Rogue;*/
    bool showev;
    // Use this for initialization
    void Start()
    {
        int lvl = gameInformation.Playerlevel;
        //Debug.Log(lvl);
    }

    public void Update()
    {

        group = gameObject.GetComponentInChildren<Canvas>();

        if (lvl > 14)
            showev = true;
      /*  if(showev)
            gameObject.GetComponent<CanvasGroup>().alpha= 1F;
            */
        
    }
    public void Mage()
    {
        PlayerClass = new BaseMageClass() ;
        BasePlayer.PlayerClass = PlayerClass;
        Debug.Log(PlayerClass);
        //gameObject.GetComponent<CanvasGroup>().alpha = 0F;
        GameObject.Destroy(gs);
    }
    public void Warrior()
    {
        PlayerClass = new BaseWarriorClass();
        BasePlayer.PlayerClass = PlayerClass;
        Debug.Log(PlayerClass);
        GameObject.Destroy(gs);
        //gameObject.GetComponent<CanvasGroup>().alpha = 0F;
    }

    public void Rogue()

    {
        PlayerClass = new BaseRogueClass();
        BasePlayer.PlayerClass = PlayerClass;
        Debug.Log(PlayerClass);
        GameObject.Destroy(gs);
        //gameObject.GetComponent<CanvasGroup>().alpha = 0F;
    }

}

