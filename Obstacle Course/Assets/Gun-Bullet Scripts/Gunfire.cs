using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunfire : MonoBehaviour
{
    private AudioSource gunshot;
    private bool hasGunFired = false;
    [SerializeField] float gunFireDelay;

    void Start()
    {
        gunshot = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            if(hasGunFired == false)
            {
                StartCoroutine(FireGun());
            }
        }
    }

    IEnumerator FireGun()
    {
        hasGunFired = true;
        gunshot.Play();
        yield return new WaitForSeconds(gunFireDelay);
        hasGunFired = false;
    }
}

