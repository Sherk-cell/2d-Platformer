using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public int thisScore;
    public Coinscore coinScore;
    public AudioSource myCoin;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            myCoin.Play();
            Debug.Log("Bahh");
            coinScore.AddSCore(thisScore);
            Destroy(gameObject);
        }
    }
}
