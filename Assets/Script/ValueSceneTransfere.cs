using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueSceneTransfere : MonoBehaviour
{
    private static int loop;
    private static float timer;

    private GameObject gameMaster;
    // Start is called before the first frame update
    void Start()
    {
        gameMaster = GameObject.Find("GameMaster");
    }
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        if (gameMaster)
        {
            loop = gameMaster.GetComponent<GameMaster>().countOfLoop;
            timer = gameMaster.GetComponent<GameMaster>().valTimer;
        }
        
    }
    public float getTimer()
    {
        return timer;
    }

    public float getLoop()
    {
        return loop;
    }

}
