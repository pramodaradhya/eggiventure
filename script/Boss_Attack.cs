using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Attack : MonoBehaviour
{
    public int attackDamage = 1;
    public int enragedAttackDamage = 35;

    public Vector3 attackOffset;
    public float attackRange = 1f;
    public LayerMask attackMask;

/*    private void Attack(Collider2D collision)
    {
        Vector3 pos = transform.position;
        pos += transform.right * attackOffset.x;
        pos += transform.up * attackOffset.y;
        if (collision.gameObject.GetComponent<eggcontroller>() != null)
        {
            //Debug.Log("Player Colling");
            eggcontroller playerController = (eggcontroller)collision.gameObject.GetComponent<eggcontroller>();
            playerController.KillPlayer();

        }

    }*/
    public void Attack()
    {
        Vector3 pos = transform.position;
        pos += transform.right * attackOffset.x;
        pos += transform.up * attackOffset.y;


        Collider2D CollidInfo = Physics2D.OverlapCircle(pos, attackRange, attackMask);
        if (CollidInfo != null)
        {
            CollidInfo.GetComponent<PlayerHealth>().TakeDamage(attackDamage);
        }
    }
}
