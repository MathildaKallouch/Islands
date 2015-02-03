using UnityEngine;
using System.Collections;

public class BezierPoint : MonoBehaviour
{
    public float _drawSphereRadius = 0.2f;
    public Transform _frontBracket;
    public Transform _backBracket;

    public void DisplayPoint()
    {

        Gizmos.color = Color.magenta;

        Gizmos.DrawSphere(transform.position ,_drawSphereRadius);

        Gizmos.color = Color.grey;

        if(_frontBracket != null)
        {
            Gizmos.DrawLine(transform.position, _frontBracket.position);
            Gizmos.DrawSphere(_frontBracket.position, _drawSphereRadius);
        }
        if(_backBracket != null)
        {
            Gizmos.DrawLine(transform.position, _backBracket.position);
            Gizmos.DrawSphere(_backBracket.position, _drawSphereRadius);
        }
    }
}
