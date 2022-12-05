using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public float moveDuration = 5;
    public float stayTime = 3;
    
    public Vector3 targetPosition = new Vector3(0, 0, 5);
    Vector3 startPos;
    bool moveForward = true;


    void Start()
    {
        startPos = transform.position;
        StartCoroutine(MovePlatform());
    }

    // When reaching the position, stay for a certain amount of time and return back to start pos

    IEnumerator MovePlatform()
    {
        //Vector3 startPosition = transform.position;
        float timeLapsed = 0;

        while (timeLapsed < moveDuration)
        {
            if (moveForward)
            {
                transform.position = Vector3.Lerp(startPos, targetPosition, timeLapsed / moveDuration);

            }
            else
            {
                transform.position = Vector3.Lerp(targetPosition, startPos, timeLapsed / moveDuration);
            }
            
            timeLapsed += Time.deltaTime;
            yield return null;
        }
        moveForward = !moveForward;

        yield return new WaitForSeconds(3);
        StartCoroutine(MovePlatform());
    }
}
