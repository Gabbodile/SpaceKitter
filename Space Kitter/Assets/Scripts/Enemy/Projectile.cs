using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public PlayerMovement _PM;

    public int damageMultiplier = 2;

    void Start()
    {
        _PM = GameObject.Find("Player").GetComponent<PlayerMovement>();

        Destroy(this.gameObject, 3);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Hit Player");
            _PM.Damage(damageMultiplier);
        }
    }
}
