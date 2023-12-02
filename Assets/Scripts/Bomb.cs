using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        var e = collision.GetComponent<SwordManager>();
        if (e != null)
        {
            FindObjectOfType<GameManager>().OnBombTrigger();
        }
        else return;

    }
}

