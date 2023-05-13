using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timescript : MonoBehaviour
{
    public int myTime;
    public Text timeScore;
    



    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(CoinCollect());
    }
    private void Update()
    {
        timeScore.text = myTime.ToString();

        if (myTime == 0)
        {
            Debug.Log("AAAA");
            SceneManager.LoadScene("Death");
        }


    }
    public IEnumerator CoinCollect()
    {
        myTime -= 1;
        yield return new WaitForSeconds(1f);

        StartCoroutine(CoinCollect());

    }
}
