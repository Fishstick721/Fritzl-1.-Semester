using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ziellinie : MonoBehaviour
{
    public Text txtBestTime;
    public Text counterText; 
    public GameObject[] hindernisse; 
    float time = 0;
    float bestTime = float.MaxValue;

    void Start()
    {
        
        hindernisse = GameObject.FindGameObjectsWithTag("Hindernis");
    }

    void Update()
    {
        time += Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            if (time < bestTime)
            {
                bestTime = time;
                txtBestTime.text = "Best Time : " + bestTime.ToString("0.##") + " Sekunden";
            }
            time = 0;
            time = 0;

           
            Hindernis.counter = 3;
            counterText.text = Hindernis.counter.ToString();

            
            foreach (GameObject hindernis in hindernisse)
            {
                hindernis.SetActive(true);
            }
        }
    }
}
