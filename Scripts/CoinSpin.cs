using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpin : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 0, 80 * Time.deltaTime); //rotates 50 degrees per second around z axis
    }
}
