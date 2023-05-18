using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Bullet2 : MonoBehaviour
{
    
    public GameObject Enemy;
    public float TimeToLive = 1f;
    public float life = 3;
    public TextMeshProUGUI ZombiesText;

    private int ZombiesKilled = 0;


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
            ZombiesKilled++;
            ZombiesText.text = "Enemy: " + ZombiesKilled.ToString();
            Debug.Log(ZombiesKilled);
            //Destroy(other.gameObject);
            //Destroy(other.gameObject); 
            //Destroy(gameObject); 
        }
    }
}
