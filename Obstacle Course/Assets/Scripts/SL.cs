using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SL : MonoBehaviour
{ 
    private Button _button;
    private GameManager _gameManager;

    // Start is called before the first frame update
    void Start()
    {
        _gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        _button = GetComponent<Button>();
        _gameManager.StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
