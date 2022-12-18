using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //Calls in the player movement script
    public PlayerMovement _PM;

    //Difficulty change = more damage to the multiplier. 
    public int damageMultiplier = 2;

    void Start()
    {
        _PM = GameObject.Find("Player").GetComponent<PlayerMovement>();

        Destroy(this.gameObject, 3);
    }

    //Send in the damage
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Hit Player");
            _PM.Damage(damageMultiplier);
        }
    }
}
