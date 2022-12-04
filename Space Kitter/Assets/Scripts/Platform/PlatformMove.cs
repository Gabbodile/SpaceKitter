using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public float moveDuration = 5;
    public float stayTime = 3;
    
    public Vector3 targetPosition = new Vector3(0, 0, 5);
    Vector3 startPos;

    bool moved = false;


    void Start()
    {
        startPos = transform.position;
        StartCoroutine(MovePlatform(targetPosition));
    }

    // When reaching the position, stay for a certain amount of time and return back to start pos
    void ReturnToStartPos()
    {
        if (moved == true)
        {
            StartCoroutine(MovePlatform(startPos));
        }
    }

    IEnumerator MovePlatform(Vector3 position)
    {
        Vector3 startPosition = transform.position;
        float timeLapsed = 0;

        while (timeLapsed < moveDuration)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, timeLapsed / moveDuration);
            timeLapsed += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPosition;
        moved = true;
    }
}
