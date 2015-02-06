using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BezierCurve : MonoBehaviour
{
    public BezierPoint[] _points;
    public bool _displayPoints = true;
    public bool _loop = true;
    public float _curveSpeed;

    public Vector3 GetPosiion(float percent)
    {
        float realPercent = percent - (int)percent;
        float step = _loop ? (float)(1f / _points.Length) : (float)(1f / (_points.Length - 1));

        if (realPercent < 0) { realPercent = 1 - Mathf.Abs(realPercent); }

        int currP = (int)(realPercent / step);
        currP -= _loop ? _points.Length * (int)(currP / _points.Length) : (_points.Length - 1) * (int)(currP / (_points.Length - 1));

        realPercent = (realPercent -(step * currP)) / step;

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
                else if(_loop)
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
