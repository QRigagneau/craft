using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIWin : MonoBehaviour
{
    private GameObject value;
    public GameObject nbloop;
    public GameObject timer;

    // Start is called before the first frame update
    void Start()
    {
        value = GameObject.Find("Value");
    }

    // Update is called once per frame
    void Update()
    {
        nbloop.GetComponent<UnityEngine.UI.Text>().text = "nombre de boucle : " + value.GetComponent<ValueSceneTransfere>().getLoop().ToString();
        timer.GetComponent<UnityEngine.UI.Text>().text = "Timer : " + value.GetComponent<ValueSceneTransfere>().getTimer().ToString();
    }
}
