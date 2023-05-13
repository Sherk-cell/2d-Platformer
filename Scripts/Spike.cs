using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public PlayerData playerData;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {

            StartCoroutine(playerData.TakeDamage());
            
            Debug.Log("Take damage plz");
        }
    }
}

