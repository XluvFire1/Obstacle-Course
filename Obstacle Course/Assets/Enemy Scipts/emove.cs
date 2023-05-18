using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emove : MonoBehaviour
{
   
    CharacterController _controller;
    Transform target;
    GameObject Player;
    public GameObject Enemy;

    [SerializeField]
    float _moveSpeed = 5.0f;
    public bool isDead;


    // Use this for initialization
    void Start()
    {
        isDead = false;
        
       
       

        Player = GameObject.FindWithTag("Player");
        target = Player.transform;



        _controller = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
     if(isDead = true)
        {
            //Destroy(this);
           
           
        }
       
        Vector3 direction = target.position - transform.position;

        direction = direction.normalized;

        Vector3 velocity = direction * _moveSpeed;

        _controller.Move(velocity * Time.deltaTime);
        if (target != null)
        {
            transform.LookAt(target);
        }
    }
}