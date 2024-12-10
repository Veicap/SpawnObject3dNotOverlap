using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public float radius = 1f;
    public Vector3 regionSize = Vector3.one;
    public int rejectionSamples = 30;
    public float displayRadius = 0.5f;

    List<Vector3> points;

    void OnValidate()
    {
        points = PoissonDiscSampling3D.GeneratePoints(radius, regionSize, rejectionSamples);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireCube(regionSize / 2, regionSize);

        if (points != null)
        {   
            Gizmos.color = Color.red;
            foreach (Vector3 point in points)
            {
                Gizmos.DrawSphere(point, displayRadius);
            }
        }
    }
}
