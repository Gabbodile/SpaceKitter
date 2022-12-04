using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public bool endScreen;

    //End Level
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            endScreen = enabled;
            Debug.Log("You have ended level");

            //show endscreen
            
        }
    }
}
