using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    public static int age;
    public static float timeCycleAge;
    public GameObject gameMaster;
    public HealthBar healthBar;
    public static bool change = false;

    public GameObject playerJeune;
    public GameObject playerMedium;
    public GameObject playerVieux;

    private GameObject currentSprite = null;
    private GameObject nextSprite = null;

    private static float timerCount = 0.0f;

    public float agingSpeed = 5.0f;


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
        checkStateLife();
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
            if (timerCount >= agingSpeed) //5.0 s 
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
        
    public int envoiAge()
    {
        return age;
    }

    public void setAge(int time)
    {
        age += time;
    }

    public void checkStateLife()
    {
        if (age < 40)
        {
            nextSprite = playerJeune;
        }
        if(age >= 40 && age < 60 )
        {
            nextSprite = playerMedium;
        }
        if(age >= 60)
        {
            nextSprite = playerVieux;
        }

        if (nextSprite != currentSprite)
        {
            if (currentSprite)
                currentSprite.SetActive(false);

            currentSprite = nextSprite;

            if (currentSprite)
                currentSprite.SetActive(true);
        }

    
    }


    public GameObject GetCurrentPlayerSprite()
    {
        return currentSprite;
    }
}
