using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Walk : StateMachineBehaviour
{

    Transform Player;
    Rigidbody2D rbboss;
    public float speed = 2.5f;
    Boss_Flip boss_Flip;
    public float Attackrange = 3f;
   
    //private float range = 1f;
    //private Space anonymous;


    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        rbboss = animator.GetComponent<Rigidbody2D>();
        boss_Flip = animator.GetComponent<Boss_Flip>();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        boss_Flip.LookAtPlayer();
       
        Vector2 target = new Vector2(Player.position.x, rbboss.position.y);
        Vector2 newpos = Vector2.MoveTowards(rbboss.position, target, speed * Time.fixedDeltaTime);
        rbboss.MovePosition(newpos);

        if(Vector2.Distance(Player.position, rbboss.position) <=Attackrange)
        {
            animator.SetTrigger("Attack");
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.ResetTrigger("Attack");
    }

}
