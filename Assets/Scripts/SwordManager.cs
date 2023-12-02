using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordManager : MonoBehaviour
{
    public Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        FollowMouse();
    }

    private void FollowMouse()
    {   
        var position = Input.mousePosition;
        position.z = 10;
        rb2d.position = Camera.main.ScreenToWorldPoint(position);
    }


}
