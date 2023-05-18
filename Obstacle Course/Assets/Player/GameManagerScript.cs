using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject gameOverUI;
    public bool isDead;
    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gameOver()
    {
        gameOverUI.SetActive(true);
    }
    IEnumerator OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Enemy"))
        {
            yield return new WaitForSeconds(0.1f);
            isDead = true;
            gameOverUI.SetActive(true);

        }
    }
}
