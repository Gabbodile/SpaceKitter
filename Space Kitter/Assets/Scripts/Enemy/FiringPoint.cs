using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiringPoint : MonoBehaviour
{
    //Calls the object
    public GameObject bulletPrefab;
    public float bulletSpeed = 1000f;

    void Start()
    {
        InvokeRepeating("fireBullet", 2, 2);
    }
    void fireBullet()
    {
        GameObject bulletInstance;
        bulletInstance = Instantiate(bulletPrefab, transform.position, transform.rotation);
        bulletInstance.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
    }
}
