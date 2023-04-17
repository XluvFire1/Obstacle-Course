using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{
    public float TimeToLive = 1f;
    public float life = 3;

    private void Start()
    {
        Destroy(gameObject, TimeToLive);
    }
    void awake()
    {
        Destroy(gameObject, life);
    }
       
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject); 
            Destroy(gameObject); 
        }
    }
}
