using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public float valTimer = 0;
    public bool pause = false;
    public int countOfLoop;
    public bool IsTalking;

    public GameObject png;
    public GameObject player;

    private List<GameObject> collectibles = new List<GameObject>();

    //public GameObject timertext;


    // Start is called before the first frame update
    void Start()
    {
        collectibles = GetAllCollectible();
    }

    // Update is called once per frame
    void Update()
    {
        if (!pause)
        {
            valTimer += Time.deltaTime;
            //timertext.GetComponent<UnityEngine.UI.Text>().text = timerfinal.ToString() + "s";
            //Debug.Log(timerfinal.ToString() + "s");
        }
        else
        {
            //timertext.GetComponent<UnityEngine.UI.Text>().text = timerfinal.ToString() + "s";
            //Debug.Log(timerfinal.ToString() + "s");
        }

        if(IsTalking)
        {
            png.GetComponent<DialogueTrigger>().TriggerDialogue();
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

        player.GetComponent<LifeController>().resetLife();

        //replace Player
        player.transform.position = new Vector2(0.0f,0.0f);

        //kill and replace collectible
        foreach (GameObject go in collectibles as List<GameObject>)
        {
            go.GetComponent<fragtime>().refreshCollectible();
        }

    }

    List<GameObject> GetAllCollectible()
    {
        List<GameObject> objectsInScene = new List<GameObject>();
        List<GameObject> listcollectibles = new List<GameObject>();

        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();


        foreach (GameObject go in allObjects)
        {
            if (go.GetComponent<fragtime>())
                listcollectibles.Add(go);
        }

        return listcollectibles;
    }

   

}
