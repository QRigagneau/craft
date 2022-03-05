using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPlayerController : MonoBehaviour
{

    public GameObject player;
    public GameObject gameMaster;

    public GameObject textLoop;
    public GameObject textTimer;
    public GameObject textAge;


    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textTimer.GetComponent<UnityEngine.UI.Text>().text = "timer : " + Mathf.Round(gameMaster.GetComponent<GameMaster>().valTimer).ToString() + " s";
        textLoop.GetComponent<UnityEngine.UI.Text>().text = "Loop : " + gameMaster.GetComponent<GameMaster>().countOfLoop.ToString();
        textAge.GetComponent<UnityEngine.UI.Text>().text = "Age : " + player.GetComponent<LifeController>().envoiAge().ToString();
    }

}
