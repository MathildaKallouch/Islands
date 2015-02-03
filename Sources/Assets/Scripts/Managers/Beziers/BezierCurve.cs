using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BezierCurve : MonoBehaviour
{
    public BezierPoint[] _points;
    public bool _displayPoints = true;
    public bool m_loop = true;

    public Vector3 GetPosiion(float percent)
    {
        float realPercent = percent - (int)percent;
        float step = m_loop ? (float)(1f / _points.Length) : (float)(1f / (_points.Length - 1));
        int currP = 0;

        while (realPercent >= 0)
        {
            realPercent -= step;
            if (realPercent >= 0)
            {
                currP += 1;
            }
        }
        realPercent += step;
        realPercent /= step;

        while (currP >= 0)
        {
            currP -= m_loop ? _points.Length : _points.Length - 1;
        }
        currP += m_loop ? _points.Length : _points.Length - 1;

        if (currP < _points.Length - 1)
        {
            return Bezier.CubicBezier(_points[currP].transform.position, _points[currP]._frontBracket.position, _points[currP + 1]._backBracket.position, _points[currP + 1].transform.position, realPercent);
        }
        else
        {
            return Bezier.CubicBezier(_points[currP].transform.position, _points[currP]._frontBracket.position, _points[0]._backBracket.position, _points[0].transform.position, realPercent);
        }
    }

    public virtual void OnDrawGizmos()
    {

        if(_points.Length < 2)
        {
            return;
        }

        for (int i = 0; i < _points.Length; i++)
        {

            Gizmos.color = Color.green;

            Vector3 lastPos,currentPos;

            lastPos = _points[i].transform.position;

            for (int j = 1; j < 101; j++)
            {

                if (i < _points.Length - 1)
                {
                    currentPos = Bezier.CubicBezier(_points[i].transform.position, _points[i]._frontBracket.position, _points[i+1]._backBracket.position, _points[i+1].transform.position, (j / 100f));

                    Gizmos.DrawLine(lastPos, currentPos);
                    lastPos = currentPos;
                }
                else if(m_loop)
                {
                    currentPos = Bezier.CubicBezier(_points[i].transform.position, _points[i]._frontBracket.position, _points[0]._backBracket.position, _points[0].transform.position, (j / 100f));

                    Gizmos.DrawLine(lastPos, currentPos);
                    lastPos = currentPos;
                }

            }

            if(_displayPoints)
            {
                _points[i].DisplayPoint();
            }
        }
    }
	
}
