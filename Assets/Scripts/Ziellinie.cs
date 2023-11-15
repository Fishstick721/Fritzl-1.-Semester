using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ziellinie : MonoBehaviour
{
    public Text txtBestTime;
    float time = 0;
    float bestTime = float.MaxValue;
    


    void Update()
    {
        time += Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (time < bestTime)
        {
            bestTime = time;
            txtBestTime.text = "Best Time : " + bestTime.ToString("0.##") + " Sekunden";
        }
       
        time = 0;
    }

}
