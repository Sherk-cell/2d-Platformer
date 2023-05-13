using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Lava : MonoBehaviour
{
    public PlayerData playerData;

    // Update is called once per frame
    void Update()
    {



    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            if (playerData.isInvincible == false)
            {
                Debug.Log("dead");
                SceneManager.LoadScene("Death");
            }


        }
    }


}