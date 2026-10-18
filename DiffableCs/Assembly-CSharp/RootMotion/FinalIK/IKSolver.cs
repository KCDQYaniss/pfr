namespace RootMotion.FinalIK;

public abstract class IKSolver
{
	internal class Bone : Point
	{
		public float length; //Field offset: 0x58
		public float sqrMag; //Field offset: 0x5C
		public Vector3 axis; //Field offset: 0x60
		private RotationLimit _rotationLimit; //Field offset: 0x70
		private bool isLimited; //Field offset: 0x78

		public RotationLimit rotationLimit
		{
			 get { } //Length: 519
			 set { } //Length: 302
		}

		public Bone() { }

		public Bone(Transform transform) { }

		public Bone(Transform transform, float weight) { }

		public RotationLimit get_rotationLimit() { }

		public Quaternion GetSolverSwing(Vector3 swingTarget, float weight = 1) { }

		public void set_rotationLimit(RotationLimit value) { }

		public void SetToSolverPosition() { }

		public void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1) { }

		public void Swing(Vector3 swingTarget, float weight = 1) { }

		public void Swing2D(Vector3 swingTarget, float weight = 1) { }

	}

	internal sealed class IterationDelegate : MulticastDelegate
	{

		public IterationDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int i, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int i) { }

	}

	internal class Node : Point
	{
		public float length; //Field offset: 0x58
		public float effectorPositionWeight; //Field offset: 0x5C
		public float effectorRotationWeight; //Field offset: 0x60
		public Vector3 offset; //Field offset: 0x64

		public Node() { }

		public Node(Transform transform) { }

		public Node(Transform transform, float weight) { }

	}

	internal class Point
	{
		public Transform transform; //Field offset: 0x10
		[Range(0, 1)]
		public float weight; //Field offset: 0x18
		public Vector3 solverPosition; //Field offset: 0x1C
		public Quaternion solverRotation; //Field offset: 0x28
		public Vector3 defaultLocalPosition; //Field offset: 0x38
		public Quaternion defaultLocalRotation; //Field offset: 0x44

		public Point() { }

		public void FixTransform() { }

		public void StoreDefaultLocalState() { }

		public void UpdateSolverLocalPosition() { }

		public void UpdateSolverLocalState() { }

		public void UpdateSolverPosition() { }

		public void UpdateSolverState() { }

	}

	internal sealed class UpdateDelegate : MulticastDelegate
	{

		public UpdateDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	public bool Quick; //Field offset: 0x10
	[HideInInspector]
	public Vector3 IKPosition; //Field offset: 0x14
	[Range(0, 1)]
	public float IKPositionWeight; //Field offset: 0x20
	[CompilerGenerated]
	private bool <initiated>k__BackingField; //Field offset: 0x24
	public UpdateDelegate OnPreInitiate; //Field offset: 0x28
	public UpdateDelegate OnPostInitiate; //Field offset: 0x30
	public UpdateDelegate OnPreUpdate; //Field offset: 0x38
	public UpdateDelegate OnPostUpdate; //Field offset: 0x40
	protected bool firstInitiation; //Field offset: 0x48
	[HideInInspector]
	[SerializeField]
	protected Transform root; //Field offset: 0x50

	public private bool initiated
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	protected IKSolver() { }

	public static Transform ContainsDuplicateBone(Bone[] bones) { }

	public abstract void FixTransforms() { }

	[CompilerGenerated]
	public bool get_initiated() { }

	public override Vector3 GetIKPosition() { }

	public float GetIKPositionWeight() { }

	public abstract Point GetPoint(Transform transform) { }

	public abstract Point[] GetPoints() { }

	public Transform GetRoot() { }

	public static bool HierarchyIsValid(Bone[] bones) { }

	public void Initiate(Transform root) { }

	public abstract bool IsValid(ref string message) { }

	public bool IsValid() { }

	protected void LogWarning(string message) { }

	protected abstract void OnInitiate() { }

	protected abstract void OnUpdate() { }

	protected static float PreSolveBones(ref Bone[] bones) { }

	[CompilerGenerated]
	private void set_initiated(bool value) { }

	public void SetIKPosition(Vector3 position) { }

	public void SetIKPositionWeight(float weight) { }

	public static void SolverRotate(Bone[] bones, int index, Quaternion rotation) { }

	public static void SolverRotateBonesAroundPoint(Bone[] bones, int index, Vector3 point, Quaternion rotation) { }

	public abstract void StoreDefaultLocalState() { }

	public void Update() { }

}

