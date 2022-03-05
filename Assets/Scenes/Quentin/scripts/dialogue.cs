using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogue : MonoBehaviour
{
    private GameObject gamemaster;

    // Start is called before the first frame update
    void Start()
    {
        gamemaster = GameObject.Find("GameMaster");
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<png>())
        {
            gamemaster.GetComponent<GameMaster>().IsTalking = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        gamemaster.GetComponent<GameMaster>().IsTalking = false;
    }
}
