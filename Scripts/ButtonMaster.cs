using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonMaster : MonoBehaviour
{
   public void StartScreen()
    {
        SceneManager.LoadScene("Start");
    }
    public void DeathScreen()
    {
        SceneManager.LoadScene("Death");
    }
    public void WinScreen()
    {
        SceneManager.LoadScene("Win");
    }
    public void GameplayScreen()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
