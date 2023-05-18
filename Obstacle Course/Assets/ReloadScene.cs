using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
    public GameObject Machinegun;
    public emove _Emove;
    public Timer _timer;
    public GameObject gameOverUI;
    public GameObject Timer;
    public GameManagerScript gameManager;
    public CharacterController controller;
    public Rigidbody rigid;
    public Spawner _Spawner;
    public RobloxianController _controller;
    public ThirdPersonCamera _Camera;
    public GameObject player;
    public GameObject other;
    public bool isGameOver = false;
    public Gun _Gun;
    private bool isPaused = false;
    public bool isDead;

    void Start()
    {
        _controller = GameObject.Find("Player").GetComponent<RobloxianController>();
        isDead = false;

    }
    void Update()
    {
       
    }
    IEnumerator OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Enemy"))
        {
            Destroy(rigid);
            Destroy(Machinegun);
            Destroy(_timer);
            Destroy(Timer);
            isPaused = true;
            Destroy(_Spawner);
            controller = GetComponent<CharacterController>();
            Destroy(_Gun);
            Destroy(_controller);
            Destroy(_Camera);
            isGameOver = true;
            Destroy(controller);
            Destroy(this);
            yield return new WaitForSeconds(2f);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            isDead = true;
            if(isDead = true)
            {
                gameManager.gameOver();
                gameOverUI.SetActive(true);

            }


        }
        
    }
}
