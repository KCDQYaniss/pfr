namespace BezierSplineTools;

public class SplineDecorator : MonoBehaviour
{
	public BezierSpline spline; //Field offset: 0x20
	public int frequency; //Field offset: 0x28
	public bool lookForward; //Field offset: 0x2C
	public Transform[] items; //Field offset: 0x30

	public SplineDecorator() { }

	private void Awake() { }

}

