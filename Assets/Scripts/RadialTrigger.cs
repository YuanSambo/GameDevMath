using UnityEditor;
using UnityEngine;


// Try to not look back at the stream, see if you can remember the concepts
// Use OnDrawGizmos to draw a circle representing the radius
// Detect if an object's location is inside or outside the radial trigger
// Draw the gizmo green if inside, red if outside
// The trigger should be able to be placed at any location (ie, not just at 0,0)

public class RadialTrigger : MonoBehaviour
{
    public Transform player;

    [Range(0f,10f)]
    public float radius = 1f;
    private void OnDrawGizmos()
    {
        Vector2 origin = transform.position;

        var distance = Vector2.Distance(origin, player.position);

        Handles.color = distance > radius ? Color.green : Color.red;
        Handles.DrawWireDisc(origin,Vector3.forward, radius);
    }
}
