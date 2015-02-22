using UnityEngine;
using System.Collections;

public class DraftRunner : MonoBehaviour
{
    public BezierCurve _draft;
    public float _switchLaneTime;

    private float m_speed;
    private float m_distanceTraveled = 0f;

    private Timer m_timer;
    private Vector3 m_start;
    private Vector3 m_end;

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
        m_timer = new Timer();
        renderer.sortingOrder = 1;
    }

    public virtual void Update()
    {

        if(m_timer.IsElapsedOnce)
        {
            _draft.Register(this);
        }

        if(m_timer.IsElapsedLoop)
        {
            return;
        }

        transform.position = Vector3.Lerp(m_start, m_end, (1 - m_timer.CurrentNormalized));

    }

    public virtual void SwitchCurve(bool next)
    {
        if ((next && _draft._nextCurve == null) || (!next && _draft._previousCurve == null))
        {
            return;
        }


        _draft.Unregister(this);
        m_start = _draft.GetPosition(m_distanceTraveled);
        _draft = next ? _draft._nextCurve : _draft._previousCurve;
        m_end = _draft.GetPosition(m_distanceTraveled);

        m_timer.Reset(_switchLaneTime);

    }

    public virtual void Ability()
    {
    }

}
