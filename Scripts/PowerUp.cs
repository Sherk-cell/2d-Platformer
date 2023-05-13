using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public PlayerData playerData;
    public Movement movementStats;
    public CircleCollider2D cC2d;
    public SpriteRenderer sR;
    public AudioSource powerUpSound;
    public Coinscore coinScore;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            coinScore.AddSCore(100);
            StartCoroutine(PowerUpCollect());
            Destroy(cC2d);
            Destroy(sR);
            

        }
    }

    public IEnumerator PowerUpCollect()
    {
        powerUpSound.Play();
        playerData.isInvincible = true;
        movementStats.speed = 28;
        movementStats.jumpingPower = 26;
        movementStats.dashingPower = 30;
        Debug.Log("Should Start");
        yield return new WaitForSeconds(13f);
        playerData.isInvincible = false;
        movementStats.speed = 18;
        movementStats.jumpingPower = 22;
        movementStats.dashingPower = 24;
        Debug.Log("Should end");


    }




}
