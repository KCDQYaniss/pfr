namespace BezierSplineTools;

public class BezierSpline : MonoBehaviour
{
	internal sealed class DeselectedSplineEvent : MulticastDelegate
	{

		public DeselectedSplineEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(PathSpline spline, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(PathSpline spline) { }

	}

	internal sealed class SelectedSplineEvent : MulticastDelegate
	{

		public SelectedSplineEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(PathSpline spline, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(PathSpline spline) { }

	}

	public SelectedSplineEvent SplineSelectedEvent; //Field offset: 0x20
	public DeselectedSplineEvent SplineDeselectedEvent; //Field offset: 0x28
	[SerializeField]
	private Vector3[] points; //Field offset: 0x30
	[SerializeField]
	private BezierControlPointMode[] modes; //Field offset: 0x38
	[SerializeField]
	private bool loop; //Field offset: 0x40
	private List _curvesLengthCache; //Field offset: 0x48
	private float _totalCurvesLength; //Field offset: 0x50

	public int ControlPointCount
	{
		 get { } //Length: 26
	}

	public int CurveCount
	{
		 get { } //Length: 42
	}

	public bool Loop
	{
		 get { } //Length: 5
		 set { } //Length: 113
	}

	public Vector3[] Points
	{
		 get { } //Length: 76
	}

	public BezierSpline() { }

	public void AddCurve(Vector3 position, bool toEnd) { }

	public void AddCurve() { }

	public void AddCurveNearPoint(int pointIndex) { }

	public void AddCurveToStartLine() { }

	public float ClosestTimeOnBezier(Vector3 aP, float min, float step, float max) { }

	public void CreateCurvesLengthCache(float sensitivity) { }

	public void DeletePoint(int index) { }

	private void EnforceMode(int index) { }

	public int get_ControlPointCount() { }

	public int get_CurveCount() { }

	public bool get_Loop() { }

	public Vector3[] get_Points() { }

	public Vector3 GetControlPoint(int index) { }

	public BezierControlPointMode GetControlPointMode(int index) { }

	private void GetCurveIndexAndTime(float t, out int index, out float curveTime) { }

	private float GetCurveLengthApproximately(int index, float sensitivity, ref float deltaTime) { }

	private Vector3 GetCurvePoint(int index, float t) { }

	public Vector3 GetDirection(float t) { }

	public Vector3 GetDirectionWithCurvesLengthCache(float t) { }

	public float GetLengthApproximately(float sensitivity) { }

	public float GetLengthFromChache() { }

	public Vector3 GetPoint(float t) { }

	public Tuple GetPointAndDirection(float t) { }

	public Vector3 GetPointByOneSpeed(float t) { }

	public Vector3 GetPointForBackwardsHomogeneousMovement(float currentDistance, float targetDistance, float precision, ref float currentTime) { }

	public Vector3 GetPointForHomogeneousMovement(float currentDistance, float targetDistance, float precision, ref float currentTime) { }

	public Vector3 GetPointWithCurvesLengthCache(float t) { }

	public Vector3 GetVelocity(float t) { }

	public Vector3 GetVelocityWithCurvesLengthCache(float t) { }

	public void Reset() { }

	public void set_Loop(bool value) { }

	public void SetControlPoint(int index, Vector3 point) { }

	public void SetControlPointMode(int index, BezierControlPointMode mode) { }

}

