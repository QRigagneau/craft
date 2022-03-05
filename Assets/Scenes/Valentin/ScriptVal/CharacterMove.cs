using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{

    public  AudioSource AudioDeplacement;

    public float speed = 2.5f;
    Rigidbody2D rb;
    Vector2 dir;
    Animator anim;

    private bool inmove;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        inmove = false;
    }


    void Update()
    {
        setSound(inmove);
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");

        rb.MovePosition(rb.position + dir * speed * Time.fixedDeltaTime);
        setParam();
    }

    void setSound(bool val)
    {
        gameObject.GetComponent<AudioSource>().enabled = val;
        gameObject.GetComponent<AudioSource>().playOnAwake = true;
    }

    void setParam()
    {
        inmove = false;
        if (dir.x == 0 && dir.y == 0)//static
        {
            anim.SetInteger("dir", 0);
        }
        else if (dir.y < 0) //bas
        {
            anim.SetInteger("dir", 1);
            inmove = true;
        }
            
        else if (dir.y > 0) //haut
        {
            anim.SetInteger("dir", 3);
            inmove = true;
        }
        else if (dir.x > 0) //droite
        {
            anim.SetInteger("dir", 2);
            GetComponent<SpriteRenderer>().flipX = false;
            inmove = true;
        }
        else if (dir.x < 0) //gauche
        {
            anim.SetInteger("dir", 2);
            GetComponent<SpriteRenderer>().flipX = true;
            inmove = true;
        }

        //gameObject.PlayOneShoot(gameObject.GetComponent<AudioSource>());
    }
}