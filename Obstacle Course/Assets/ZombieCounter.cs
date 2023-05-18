using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ZombieCounter : MonoBehaviour
{


    private int ZombiesKilled = 0;

    public TextMeshProUGUI ZombiesText;


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
}