using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class eggcontroller : MonoBehaviour
{
   // public Transform player;
   // public Vector3 offset;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    internal void KillPlayer()
    {
        Debug.Log("player killed by enemy");
        ReloadLevel();
    }

    private void ReloadLevel()
    {
        SceneManager.LoadScene(0);
    }


    // Update is called once per frame
    private void Update()
    {
       
        float dirx = Input.GetAxis("Horizontal");
        if (dirx >=1)
        {
            float degree = -12;
            gameObject.transform.Rotate(0, 0, degree, Space.Self);
        }else if(dirx <= -1)
        {
            float degree = 12;
            gameObject.transform.Rotate(0, 0, degree, Space.Self);
        }
            
        
        rb.velocity = new Vector2(dirx * 6f, rb.velocity.y);
       

        if (Input.GetButtonDown("Jump"))
        {
            
            rb.velocity = new Vector2(rb.velocity.x, 6f);
        }
     //  transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, offset.z); // Camera follows the player with specified offset position

    }


}

