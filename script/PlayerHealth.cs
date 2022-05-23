using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int health ;
    public int numofhearts;
    
    //public int eggheart;

    public Image[] hearts;
    public Sprite fullHearts;
    public Sprite emptyHearts;
    public PlaySound playSound;
    //public eggcontroller eggcontroller;
    //public GameOverController gameOverController;
    
    void Update()
    {
        Updatehealth();
    }


    public  void Updatehealth()
    {
        if (health <= 0)
        {
            eggcontroller.PlayerDeathAnimation();
            //gameObject.SetActive(true);
        }
        if (health >numofhearts)
        {
            health = numofhearts;
        }
       
        for (int i = 0; i < hearts.Length; i++)
        {
            if(i<health)
            {
                hearts[i].sprite = fullHearts;
            }else
            {
                hearts[i].sprite = emptyHearts;
            }
            if (i<numofhearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }

    internal void TakeDamage(int attackDamage)
    {
        // eggheart = numofhearts;
        
        int takedamage = health - attackDamage;
        playSound.Play(0);
    }

}