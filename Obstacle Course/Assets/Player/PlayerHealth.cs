using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public bool isDead;
    public GameManagerScript gameManager;
    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isDead = true)
        {
            gameManager.gameOver();
            Debug.Log("Dead");
        }
        
    }
}
