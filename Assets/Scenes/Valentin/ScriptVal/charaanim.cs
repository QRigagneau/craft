using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charaanim : MonoBehaviour
{

    public float speed = 2.5f;
    Rigidbody2D rb;
    Vector2 dir;
    Animator anim;
    int age = 40;

    public bool age40_60 = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");

        rb.MovePosition(rb.position + dir * speed * Time.fixedDeltaTime);
        setParam();
    }

    void setParam()
    {
        if (dir.x == 0 && dir.y == 0 && age == 40)//static
        {
            anim.SetInteger("dir", 0);
            anim.SetInteger("age", 0);
        }
        else if (dir.y < 0) //bas
        {
            anim.SetInteger("dir", 1);
            anim.SetInteger("age", 0);
        }
        else if (dir.y > 0) //haut
        { 
            anim.SetInteger("dir", 3);
            anim.SetInteger("age", 0);
        }
        else if (dir.x > 0) //droite
        {
            anim.SetInteger("dir", 2);
            anim.SetInteger("age", 0);
            GetComponent<SpriteRenderer>().flipX = false;
        }

        else if (dir.x < 0) //gauche
        {
            anim.SetInteger("dir", 2);
            GetComponent<SpriteRenderer>().flipX = true;
        }
    }
}