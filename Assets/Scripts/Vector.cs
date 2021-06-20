using UnityEngine;

public class Vector : MonoBehaviour
{
   // Distance - displacement between two points
   // Length - length of a  point

   public Transform aTf;
   public Transform bTf;
   public float abDist;
    private void OnDrawGizmos()
    {
        Vector2 a = aTf.position;
        Vector2 b = bTf.position;

        
        // Gizmos.DrawLine(a,b);
        abDist = Vector2.Distance(a, b);

        Vector2 atoB = b - a;
        Vector2 atoBDir = atoB.normalized;
        
       Gizmos.DrawLine(a,a+atoBDir);
        
        // Vector2.Distance(a,b);
        // (a-b).magnitude
        // sqrt((a.x-b.x)^2 + (a.y-b.y)^2)
        
        // Vector2 dirToPt = pt.normalized;
        // Gizmos.DrawLine(Vector2.zero,dirToPt);
    }
}
