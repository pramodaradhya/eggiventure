using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<eggcontroller>() !=null)
        {
            eggcontroller eggController = collision.gameObject.GetComponent<eggcontroller>();
              eggController.KillPlayer();
            
        }
    }

}