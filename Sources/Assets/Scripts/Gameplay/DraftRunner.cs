using UnityEngine;
using System.Collections;

public class DraftRunner : MonoBehaviour
{
    public BezierCurve _draft;

    private float m_speed;
    private float m_distanceTraveled = 0f;

    public BezierCurve Draft
    {
        get { return _draft; }
        set 
        { 
            _draft = value;
            m_speed = _draft._curveSpeed;
        }
    }

    public virtual void Start()
    {
        m_speed = _draft._curveSpeed;
    }
	
	public virtual void Update ()
    {
        m_distanceTraveled += Time.deltaTime * m_speed;
        transform.position =  _draft.GetPosiion(m_distanceTraveled);
	}

    public virtual void Ability()
    {
    }

}
