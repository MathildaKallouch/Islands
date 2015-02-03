using UnityEngine;
using System.Collections;

public static class Bezier
{
	public static Vector3 CubicBezier(Vector3 origin, Vector3 originBracket, Vector3 targetBracket, Vector3 target, float t)
	{
        //var p0 = origin;
        //var p1 = origin + originBracket;
        //var p2 = target + targetBracket;
        //var p3 = target;

        var p0 = origin;
        var p1 = originBracket;
        var p2 = targetBracket;
        var p3 = target;

		var t2 = t*t;
		var oneMinusT = 1-t;
		var oneMinusT2 = (1-t) * (1-t);
		
		return p0*oneMinusT2*oneMinusT + 3*p1*t*oneMinusT2 + 3*p2*t2*oneMinusT + p3*t2*t;

	}
	
	public static Quaternion CubicBezier(Quaternion origin, Vector3 originAngularSpeed, Quaternion target, Vector3 targetAngularSpeed, float t)
	{
		var p0 = origin;
		var p1 = origin * Quaternion.Euler (originAngularSpeed / 3);
		var p2 = target * Quaternion.Euler (-targetAngularSpeed / 3);
		var p3 = target;
		
		var slerp12 = Quaternion.Slerp (p1, p2, t);
		
		return Quaternion.Slerp (
			Quaternion.Slerp (Quaternion.Slerp (p0, p1, t), slerp12, t),
			Quaternion.Slerp (slerp12, Quaternion.Slerp (p2, p3, t), t),
			t);
		
	}
	
	public static Vector3 CubicBezierSpeed(Vector3 origin, Vector3 originBracket, Vector3 targetBracket, Vector3 target, float t)
	{
		var p0 = origin;
		var p1 = origin + originBracket;
		var p2 = target - targetBracket;
		var p3 = target;

		var t2 = t*t;
		var oneMinusT = 1-t;
		var oneMinusT2 = oneMinusT * oneMinusT;
		
		return (3 * (oneMinusT2*(p1-p0) + 2*t*oneMinusT*(p2-p1) + t2*(p3-p2) ) );
	}
	
	
}
