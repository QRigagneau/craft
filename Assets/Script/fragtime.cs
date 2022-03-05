using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fragtime : MonoBehaviour
{
    public int timetravel;
    private GameObject player;

    private GameObject collectiblesound;

    public AudioClip collectible;
    public AudioSource audiosource;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
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
<<<<<<< HEAD
            player.GetComponent<LifeController>().setAge(timetravel);
            isUseCollectible();
=======
            player.GetComponent<LifeController>().age += timetravel;
            isUseCollectible();            
>>>>>>> a4df131a2232b0e3b4a19448b6a655f8d61ec257
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
