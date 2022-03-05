using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleController : MonoBehaviour
{
    public int timeTravel;
    public void isUseCollectible()
    {
        gameObject.SetActive(false);
    }

    public void refreshCollectible()
    {
        gameObject.SetActive(true);
    }
}
