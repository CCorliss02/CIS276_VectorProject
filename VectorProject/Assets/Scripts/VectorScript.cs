using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorScript : MonoBehaviour
{
    public Transform A;
    public Transform B;
    public float abDistance;

    private void OnDrawGizmos()
    {
        Vector2 point = transform.position;
        Vector2 pointA = A.position;
        Vector2 pointB = B.position;

        Vector2 aToB = pointB - pointA;
        Vector2 aToBDir = aToB.normalized;

        abDistance = Vector2.Distance(pointA, pointB);

        Gizmos.DrawLine(pointA, pointA + aToBDir);
        Gizmos.DrawLine(Vector2.zero, point);
    }
}
