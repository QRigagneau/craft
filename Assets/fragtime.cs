using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fragtime : MonoBehaviour
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
      
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<CharacterMove>())
        {
            player.GetComponent<LifeController>().age -= 10;
            isUseCollectible();
        }
    }

    public void isUseCollectible()
    {
        gameObject.SetActive(false);
    }

    public void refreshCollectible()
    {
        gameObject.SetActive(true);
    }
}
