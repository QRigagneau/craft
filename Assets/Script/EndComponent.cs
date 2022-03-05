using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndComponent : MonoBehaviour
{

    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        if(player.GetComponent<LifeController>().age <= 0)
        {
            Debug.Log("oui");
            play();
        }
    }

    public void play()
    {
        SceneManager.LoadScene("WinScene");
    }
}
