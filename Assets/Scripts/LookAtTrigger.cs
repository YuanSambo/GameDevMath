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
    public Transform bTf;
    public float dot;
    [Range(0f,5f)]
    public float radius;
    [Range(0f,1f)]
    public float threshold;
    private void OnDrawGizmos()
    {
        Vector2 a = aTf.position;
        Vector2 b = bTf.position;
        Vector2 origin = transform.position;


        dot = Vector2.Dot(a.normalized, b.normalized);
        
        
        
        Gizmos.color = Color.green;
        Gizmos.DrawLine(a,origin);
        
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(b,origin);

        Handles.color = dot < threshold ? Color.red : Color.green;
        Handles.DrawWireDisc(origin,Vector3.forward, radius);
    }
}
