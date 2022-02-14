using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadialTrigger : MonoBehaviour
{
    public Transform triggerInteractionObject;

    [Range (0f, 6f)]
    public float radius = 0;

    private void OnDrawGizmos()
    {
        Vector2 triggerPosition = triggerInteractionObject.position;
        Vector2 origin = transform.position;

        float distance = Vector2.Distance(triggerPosition, origin);

        bool insideTrigger = distance < radius;

        if (insideTrigger)
        {
            Gizmos.color = Color.green;
        }
        else
        {
            Gizmos.color = Color.red;
        }

        Gizmos.DrawSphere(origin, radius);
    }
}
