using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public PlayerHealth _playerHealth;
    public int damageMultiplier = 2;


    void Start()
    {
        _playerHealth = GameObject.Find("Player").GetComponent<PlayerHealth>();
        Destroy(this.gameObject, 3);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Hit Player");
            _playerHealth.Damage(damageMultiplier);
        }
    }
}
