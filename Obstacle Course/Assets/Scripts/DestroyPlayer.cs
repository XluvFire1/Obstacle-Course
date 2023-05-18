using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Enemy")) //If thing hit is tagged "Obstacle"
        {
            Destroy(gameObject); //Then destroy the player
            
        }
    }
}
