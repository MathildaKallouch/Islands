using UnityEngine;
using System.Collections;

public class DraftRunner : MonoBehaviour
{
    public BezierCurve _Draft;
    public float _speed;
    //public float _TestValue = 0f;

    private float m_startTime;

    public float TimePassed
    {
        get { return Time.time - m_startTime; }
    }

	void Start ()
	{
        m_startTime = Time.time;
	}
	
	void Update ()
	{
        transform.position =  _Draft.GetPosiion(TimePassed * _speed);
	}

    //void OnValidate()
    //{
    //    Vector3 pos = _Draft.GetPosiion(_TestValue);

    //    transform.position = pos;
    //}
}
