using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    private float valTimer = 0;
    private float timerfinal;
    
    public bool pause = false;
    public int countOfLoop;
    public GameObject player;

    //public GameObject timertext;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!pause)
        {
            valTimer += Time.deltaTime;
            timerfinal = valTimer;
            //timertext.GetComponent<UnityEngine.UI.Text>().text = timerfinal.ToString() + "s";
            //Debug.Log(timerfinal.ToString() + "s");
        }
        else
        {
            //timertext.GetComponent<UnityEngine.UI.Text>().text = timerfinal.ToString() + "s";
            //Debug.Log(timerfinal.ToString() + "s");
        }

        //Debug.Log(countOfLoop);
    }

    public void unSetPause()
    {
        pause = true;
    }
    public void setPause()
    {
        pause = false;
    }

    public void isDead()
    {
        countOfLoop += 1;
        //replace Player            PlayerController
        player.GetComponent<LifeController>().resetLife();
        //reset inventaire          inventairController

        //kill and replace Item                 ItemController
        //kill and replace Collectible          CollectibleController

    }



}
