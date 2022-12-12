using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    public GameObject key;

    void Start()
    {
        if (other.CompareTag("Player"))
        {
            
            Destroy(this);
        }
    }

    void Update()
    {
        
    }
}
