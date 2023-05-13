using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerData : MonoBehaviour
{

    public int hp;
    public float invincibleTime;
    public bool isInvincible;
    private GameObject currentChecktpoint;
    public GameObject live1;
    public GameObject live2;
    public GameObject live3;
    public GameObject live4;
    public GameObject live5;
    public Rigidbody2D rb2D;
    public AudioSource dmgAudio;



    void Update()
    {
        switch (hp)
        {
            case 5:
                live1.SetActive(true);
                live2.SetActive(true);
                live3.SetActive(true);
                live4.SetActive(true);
                live5.SetActive(true);
                break;
            case 4:

                live1.SetActive(true);
                live2.SetActive(true);
                live3.SetActive(true);
                live4.SetActive(true);
                live5.SetActive(false);
                break;
            case 3:
                live1.SetActive(true);
                live2.SetActive(true);
                live3.SetActive(true);
                live4.SetActive(false);
                live5.SetActive(false);
                break;
            case 2:
                live1.SetActive(true);
                live2.SetActive(true);
                live3.SetActive(false);
                live4.SetActive(false);
                live5.SetActive(false);
                break;
            case 1:
                live1.SetActive(true);
                live2.SetActive(false);
                live3.SetActive(false);
                live4.SetActive(false);
                live5.SetActive(false);
                break;
            case 0:

                live1.SetActive(false);
                live2.SetActive(false);
                live3.SetActive(false);
                live4.SetActive(false);
                live5.SetActive(false);
                Debug.Log("Should be dead");
                SceneManager.LoadScene("Death");

                break;








        }

    
    }



    public IEnumerator TakeDamage()
    {
        if (!isInvincible)
        {
            //Als ik die pijn mario effect wil doen
            //rb2D.AddForce(new Vector2(0, 20), ForceMode2D.Impulse);
            hp -= 1;
            dmgAudio.Play();
            isInvincible = true;
            yield return new WaitForSeconds(3f);
            isInvincible = false;

        }
    }








    /*public void TakeDamage()
    {
        if (!isInvincible)
        {
            hp -= 1;
            Debug.Log("A");
            isInvincible = true;
        }
    }
*/
}
