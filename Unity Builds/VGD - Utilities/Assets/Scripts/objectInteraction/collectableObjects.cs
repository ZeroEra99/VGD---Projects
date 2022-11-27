using System;
using UnityEngine;

public class collectableObjects : MonoBehaviour
{
    //private statManager _statManager;

    private float verticalSpeed;
    private float verticalRange;

    private void FixedUpdate()
    {
        //Make it move up and down and rotate around itself
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(this.CompareTag("healthCollectable"))
            {
                //Heal player -> References to _statManager
                Destroy(gameObject);
                Debug.Log("Player has collected health");
            };
            if (this.CompareTag("manaCollectable"))
            {
                //Add mana to player -> References to _statManager
                Destroy(gameObject);
                Debug.Log("Player has collected mana");
            }
        }
    }
}

