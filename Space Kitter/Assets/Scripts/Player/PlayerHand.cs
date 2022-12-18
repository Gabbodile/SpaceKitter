using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    public GameObject collectKey;
    public float projectileSpeed = 100;
    public Transform playerHand;

    public float pickupDistance = 3;
    public bool hasKey;

    public List<Transform> key;

    // Find any object with the "key" tag
    void Start()
    {
        GameObject[] temp = GameObject.FindGameObjectsWithTag("Key");
        foreach (GameObject go in temp)
        {
            key.Add(go.transform);
        }
    }

    // pick up the object
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (hasKey)
            {
                collectKey.GetComponent<Rigidbody>().isKinematic = false;
                collectKey.GetComponent<Rigidbody>().AddForce(playerHand.forward * projectileSpeed);
                hasKey = false;
                collectKey.transform.SetParent(null);
            }
            else
            {
                if (Vector3.Distance(transform.position, GetClosestKey(key).position) < pickupDistance)
                {
                    hasKey = true;
                    collectKey = GetClosestKey(key).gameObject;
                    collectKey.transform.position = transform.position;
                    collectKey.transform.SetParent(this.transform);
                    collectKey.GetComponent<Rigidbody>().isKinematic = true;
                }
            }
        }
    }

    //Put the closest key on the player's "hand"
    Transform GetClosestKey(List<Transform> _key)
    {
        Transform bestTarget = null;
        float closestDistanceSqr = Mathf.Infinity;
        Vector3 currentPosition = transform.position;
        foreach (Transform potentialTarget in _key)
        {
            Vector3 directionToTarget = potentialTarget.position - currentPosition;
            float dSqrToTarget = directionToTarget.sqrMagnitude;
            if (dSqrToTarget < closestDistanceSqr)
            {
                closestDistanceSqr = dSqrToTarget;
                bestTarget = potentialTarget;
            }
        }
        return bestTarget;
    }
}
