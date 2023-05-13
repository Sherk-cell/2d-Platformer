using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coinscore : MonoBehaviour
{
  
    public int score;
    public Text myScore;


    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        myScore.text = score.ToString();
    }



    public void AddSCore(int value)
    {
        score += value;
        
    }


}
