using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{

    public int health;
    public int numOfHearts;

    public Sprite fullHeart;
    public Sprite emptyHeart;

    void Update()
    {

      
    }

    public void Damaged()
    {
        health -= 1;
        if (health < numOfHearts)
        {
            
        }

    }
}
