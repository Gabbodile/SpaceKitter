using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakablePlatform : MonoBehaviour
{
    public GameObject platform;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("PlayerDetected");

        if (other.CompareTag("Player"))
        {
            Destroy(platform, 1);
        }
    }
}
