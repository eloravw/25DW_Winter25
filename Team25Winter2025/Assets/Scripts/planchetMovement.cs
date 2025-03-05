using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class planchetMovement : MonoBehaviour
{
    public float speed;

    private float lerpTime;

    private Vector2 targetDirection;



    void Update()
    {
        lerpTime += Time.deltaTime*speed;

        transform.position = Vector2.Lerp(transform.position, targetDirection, lerpTime);

    }

    public void MoveToTarget(GameObject target)
    {
        targetDirection = target.transform.position;
        lerpTime = 0;
    }

    public void ReturnToCenter()
    {
        lerpTime = 0;
        targetDirection = new Vector2(0, -5);
    }
}
