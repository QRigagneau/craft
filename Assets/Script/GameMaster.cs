using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

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
        png = GameObject.Find("png_maman");
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
        //replace Player            PlayerController
        player.GetComponent<LifeController>().resetLife();
        //reset inventaire          inventairController

        //kill and replace Item                 ItemController
        foreach (GameObject go in collectibles as List<GameObject>)
        {
            go.GetComponent<CollectibleController>().refreshCollectible();
        }

    }

    List<GameObject> GetAllCollectible()
    {
        List<GameObject> objectsInScene = new List<GameObject>();
        List<GameObject> listcollectibles = new List<GameObject>();

        foreach (GameObject go in Resources.FindObjectsOfTypeAll(typeof(GameObject)) as GameObject[])
        {
            if (!EditorUtility.IsPersistent(go.transform.root.gameObject) && !(go.hideFlags == HideFlags.NotEditable || go.hideFlags == HideFlags.HideAndDontSave))
                objectsInScene.Add(go);
        }

        foreach (GameObject go in objectsInScene as List<GameObject>)
        {
            if (go.GetComponent<CollectibleController>())
                listcollectibles.Add(go);
        }

        return listcollectibles;
    }

}
