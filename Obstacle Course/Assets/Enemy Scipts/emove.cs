using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class emove : MonoBehaviour
{
    private int ZombiesKilled = 0;

    public TextMeshProUGUI ZombiesText;
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
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Enemy")
        {

            ZombiesKilled++;
            ZombiesText.text = "Enemy: " + ZombiesKilled.ToString();
            Debug.Log(ZombiesKilled);
            // Destroy(other.gameObject);
        }
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