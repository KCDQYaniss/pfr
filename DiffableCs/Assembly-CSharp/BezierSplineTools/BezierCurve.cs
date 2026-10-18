namespace BezierSplineTools;

public class BezierCurve : MonoBehaviour
{
	public Vector3[] points; //Field offset: 0x20

	public BezierCurve() { }

	public Vector3 GetDirection(float t) { }

	public Vector3 GetPoint(float t) { }

	public Vector3 GetVelocity(float t) { }

	public void Reset() { }

}

