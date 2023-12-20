using UnityEngine;
using UnityEngine.UI;

public class Hindernis : MonoBehaviour
{
    public static int counter = 3;
    public Text txtCounterText;

    private void Start()
    {
        txtCounterText.text = counter.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
            counter--;
            txtCounterText.text = counter.ToString();
            gameObject.SetActive(false); 
        }
    }


