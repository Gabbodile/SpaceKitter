using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameObject endScreen;
    private void Start()
    {
        endScreen.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("You have ended level");
            Time.timeScale = 0;
            endScreen.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
