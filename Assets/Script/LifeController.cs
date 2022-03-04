using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    public int age;
    public float timeCycleAge;
    public GameObject gameMaster;

    private float timerCount = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        age = 40;
    }

    // Update is called once per frame
    void Update()
    {
        RefreshAge();
        checkAge();
        JaugeRefresh();
        //Debug.Log(age);
    }

    void JaugeRefresh()
    {

    }

    public void resetLife()
    {
        age = 40;
        timerCount = 0.0f;
    }

    void RefreshAge()
    {
        if (!gameMaster.GetComponent<GameMaster>().pause)
        {
            timerCount += Time.deltaTime;
            if (timerCount >= 5.0f)
            {
                age += 1;
                timerCount = 0.0f;
            }
        }
    }

    void checkAge()
    {
        if (age == 90)
        {
            gameMaster.GetComponent<GameMaster>().isDead();
        }
    }

}
