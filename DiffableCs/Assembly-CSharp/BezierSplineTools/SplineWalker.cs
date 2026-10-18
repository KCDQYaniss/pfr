namespace BezierSplineTools;

public class SplineWalker : MonoBehaviour
{
	public BezierSpline spline; //Field offset: 0x20
	public float duration; //Field offset: 0x28
	public bool lookForward; //Field offset: 0x2C
	public SplineWalkerMode mode; //Field offset: 0x30
	private float progress; //Field offset: 0x34
	private bool goingForward; //Field offset: 0x38

	public SplineWalker() { }

	private void Update() { }

}

