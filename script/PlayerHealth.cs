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

    
    void Update()
    {
        Updatehealth();
    }
    public void Updatehealth()
    {
        if(health >numofhearts)
        {
            health = numofhearts;
        }
        if(health <=0)
        {
            eggcontroller.PlayerDeathAnimation();
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

        if(health == 0)
        {
            Debug.Log("player died");
        }
    }
}