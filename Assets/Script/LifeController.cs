using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    public int age;
    public float timeCycleAge;
    public GameObject gameMaster;
    public HealthBar healthBar;

    private float timerCount = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        age = 40;
        healthBar.SetMaxHealth(90);
    }

    // Update is called once per frame
    void Update()
    {
        RefreshAge();
        checkAge();
        JaugeRefresh();
        //Debug.Log(age);

        JaugeRefresh();
    }

    void JaugeRefresh()
    {
        healthBar.SetHealth(age);
    }

    public void resetLife()
    {
        age = 40;
        timerCount = 0.0f;
    }

    public void getCollectible(int timeTravel)
    {
        age -= timeTravel;
    }

    void RefreshAge()
    {
        if (!gameMaster.GetComponent<GameMaster>().pause)
        {
            timerCount += Time.deltaTime;
            if (timerCount >= 0.2f) //5.0 s 
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
