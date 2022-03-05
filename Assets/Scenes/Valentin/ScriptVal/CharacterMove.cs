using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{

    private AudioSource perso_AudioSource; 

    public float speed = 2.5f;
    Rigidbody2D rb;
    Vector2 dir;
    public AudioClip deplacement;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        perso_AudioSource = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");

        rb.MovePosition(rb.position + dir * speed * Time.fixedDeltaTime);
        perso_AudioSource.PlayOneShot(deplacement);
    }
}
