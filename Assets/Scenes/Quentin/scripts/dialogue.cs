using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogue : MonoBehaviour
{

    public bool IsTalking;

    // Start is called before the first frame update
    void Start()
    {
        IsTalking = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(IsTalking);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<png>())
        {
            IsTalking = true;
        }
    }
}
