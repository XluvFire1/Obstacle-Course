using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class EnemyFollowing1 : MonoBehaviour

{

    public int speed;

    public GameObject player;

    void Start()

    {

        transform.Rotate(180, 0, 0);

    }

    void Update()

    {

        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);

    }

}