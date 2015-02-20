using UnityEngine;
using System.Collections;

public class DraftRunner : MonoBehaviour
{
    public BezierCurve _draft;

    private float m_speed;
    private float m_distanceTraveled = 0f;

    public float DistanceTraveled
    {
        get { return m_distanceTraveled; }
        set { m_distanceTraveled = value; }
    }

    public float Speed
    {
        get { return m_speed; }
        set { m_speed = value; }
    }

    public virtual void Start()
    {
        _draft.Register(this);
    }

    public virtual void Ability()
    {
    }

}
