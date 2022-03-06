using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fragtime : MonoBehaviour
{
    public int timetravel;

    public int agerandom;
    private int timerandom;
    private GameObject PlayerPack;

    private GameObject collectiblesound;

    public AudioClip collectible;
    public AudioSource audiosource;

    // Start is called before the first frame update
    void Start()
    {
        timerandom = Random.Range(-10, 10);
        PlayerPack = GameObject.Find("PlayerPack");
        collectiblesound = GameObject.Find("collectiblesound");
        audiosource = collectiblesound.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<CharacterMove>())
        {
            if(this.gameObject.CompareTag("random"))
            {
                PlayerPack.GetComponent<LifeController>().age += timerandom;
                isUseCollectible();
            }

            else
            {
                PlayerPack.GetComponent<LifeController>().age += agerandom + timerandom;
                isUseCollectible();
            }
        }
        PlayCollectibleSound();
    }

    public void isUseCollectible()
    {
        gameObject.SetActive(false);
    }

    public void refreshCollectible()
    {
        gameObject.SetActive(true);
    }

    public void PlayCollectibleSound()
    {
        audiosource.PlayOneShot(collectible);
    }
}
