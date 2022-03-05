using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressenter : MonoBehaviour
{

    private GameObject dialoguemanager;
    private GameObject gamemaster;

    // Start is called before the first frame update
    void Start()
    {
        dialoguemanager = GameObject.Find("DialogueManager");
        gamemaster = GameObject.Find("GameMaster");
    }

    // Update is called once per frame
    void Update()
    {
        if(gamemaster.GetComponent<GameMaster>().IsTalking)
        {
            Debug.Log("coucou");
        }
    }
}
