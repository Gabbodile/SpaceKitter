using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //Calls in scripts
    public PlayerMovement _PM;
    public DifficultyChanger _difficulty;

    //Difficulty change = more damage to the multiplier. 
    public int damageMultiplier;

    void Start()
    {
        _PM = GameObject.Find("Player").GetComponent<PlayerMovement>();
        _difficulty = GetComponent<DifficultyChanger>();

        Destroy(this.gameObject, 3);
    }

    //Send in the damage
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Hit Player");
            Destroy(this.gameObject);
            _PM.Damage(damageMultiplier);
        }
    }
}
