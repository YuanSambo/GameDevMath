using UnityEditor;
using UnityEngine;

// Make a look-at-trigger
// Detect whether or not an object is looking at the trigger
// Have a threshold range from 0 to 1 where:
// 1 = you have to look exactly toward the trigger to activate it
// 0 = you have to look perpendicular or closer to activate it (facing away counts as outside)
// Draw a line gizmo green if looking closely enough, red if looking too away from it

public class LookAtTrigger : MonoBehaviour
{
    public Transform aTf;
    [Range(0f,1f)]
    public float threshold;
    
    private float _dot;

    private void OnDrawGizmos()
    {
        Vector2 a = aTf.position;
        Vector2 origin = transform.position;
        
        Vector2 lookDirection = aTf.right;
        Vector2 aToOriginDirection = (origin - a).normalized;

        _dot = Vector2.Dot(lookDirection, aToOriginDirection);
        Gizmos.DrawLine(a,a+lookDirection);

        bool isLooking = threshold < _dot;
        
        Gizmos.color = isLooking? Color.green : Color.red;
        Gizmos.DrawLine(a,a+aToOriginDirection);


    }
}
