using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHide : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer rend;
    //private bool canHide = false;
    private bool hiding = false;
    // Start is called before the first frame update
   private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.H))
        {
            hiding = true;
            Physics2D.IgnoreLayerCollision(8, 9, true);
            rend.sortingOrder = 0;
        }else
        {
            Physics2D.IgnoreLayerCollision(8, 9, false);
            rend.sortingOrder = 1;
            hiding = false;
        }
    }
    private void FixedUpdate()
    {
        if (hiding)
        {
            rb.velocity = Vector2.zero;
        }
        else
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y);
    }
}
