using UnityEngine;
using System.Collections;

public class DraftRunner : MonoBehaviour
{
    public BezierCurve _Draft;
    public float _speed;
    public float _distanceTraveled = 0f;

	
	void Update ()
    {
        _distanceTraveled += Time.deltaTime * _speed;
        transform.position =  _Draft.GetPosiion(_distanceTraveled);
	}

    //void OnValidate()
    //{
    //    Vector3 pos = _Draft.GetPosiion(_TestValue);

    //    transform.position = pos;
    //}
}
