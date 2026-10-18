namespace RootMotion.FinalIK;

[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Polygonal")]
[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
public class RotationLimitPolygonal : RotationLimit
{
	internal class LimitPoint
	{
		public Vector3 point; //Field offset: 0x10
		public float tangentWeight; //Field offset: 0x1C

		public LimitPoint() { }

	}

	internal class ReachCone
	{
		public Vector3[] tetrahedron; //Field offset: 0x10
		public float volume; //Field offset: 0x18
		public Vector3 S; //Field offset: 0x1C
		public Vector3 B; //Field offset: 0x28

		public Vector3 a
		{
			 get { } //Length: 53
		}

		public Vector3 b
		{
			 get { } //Length: 53
		}

		public Vector3 c
		{
			 get { } //Length: 53
		}

		public bool isValid
		{
			 get { } //Length: 15
		}

		public Vector3 o
		{
			 get { } //Length: 53
		}

		public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c) { }

		public void Calculate() { }

		public Vector3 get_a() { }

		public Vector3 get_b() { }

		public Vector3 get_c() { }

		public bool get_isValid() { }

		public Vector3 get_o() { }

	}

	[Range(0, 180)]
	public float twistLimit; //Field offset: 0x40
	[Range(0, 3)]
	public int smoothIterations; //Field offset: 0x44
	[HideInInspector]
	[SerializeField]
	public LimitPoint[] points; //Field offset: 0x48
	[HideInInspector]
	[SerializeField]
	public Vector3[] P; //Field offset: 0x50
	[HideInInspector]
	[SerializeField]
	public ReachCone[] reachCones; //Field offset: 0x58

	public RotationLimitPolygonal() { }

	[ContextMenu("Asset Store Thread")]
	private void ASThread() { }

	public void BuildReachCones() { }

	private int GetReachCone(Vector3 L) { }

	private float GetScalar(int k) { }

	protected virtual Quaternion LimitRotation(Quaternion rotation) { }

	private Quaternion LimitSwing(Quaternion rotation) { }

	[ContextMenu("Scrpt Reference")]
	private void OpenScriptReference() { }

	[ContextMenu("User Manual")]
	private void OpenUserManual() { }

	private Vector3 PointToTangentPlane(Vector3 p, float r) { }

	public void ResetToDefault() { }

	public void SetLimitPoints(LimitPoint[] points) { }

	private Vector3[] SmoothPoints() { }

	private void Start() { }

	[ContextMenu("Support Group")]
	private void SupportGroup() { }

	private Vector3 TangentPointToSphere(Vector3 q, float r) { }

}

