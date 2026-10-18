namespace RootMotion.FinalIK;

public class IKSolverTrigonometric : IKSolver
{
	internal class TrigonometricBone : Bone
	{
		private Quaternion targetToLocalSpace; //Field offset: 0x80
		private Vector3 defaultLocalBendNormal; //Field offset: 0x90

		public Vector3 DefaultLocalBendNormal
		{
			 get { } //Length: 25
		}

		public Quaternion TargetToLocalSpace
		{
			 get { } //Length: 14
		}

		public TrigonometricBone() { }

		public Vector3 get_DefaultLocalBendNormal() { }

		public Quaternion get_TargetToLocalSpace() { }

		public Vector3 GetBendNormalFromCurrentRotation() { }

		public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal) { }

		public void Initiate(Vector3 childPosition, Vector3 bendNormal) { }

	}

	public Transform target; //Field offset: 0x58
	[Range(0, 1)]
	public float IKRotationWeight; //Field offset: 0x60
	public Quaternion IKRotation; //Field offset: 0x64
	public Vector3 bendNormal; //Field offset: 0x74
	public TrigonometricBone bone1; //Field offset: 0x80
	public TrigonometricBone bone2; //Field offset: 0x88
	public TrigonometricBone bone3; //Field offset: 0x90
	protected Vector3 weightIKPosition; //Field offset: 0x98
	protected bool directHierarchy; //Field offset: 0xA4

	public bool DirectHierarchy
	{
		 get { } //Length: 8
	}

	public IKSolverTrigonometric() { }

	public virtual void FixTransforms() { }

	public bool get_DirectHierarchy() { }

	protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal) { }

	private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2) { }

	public Quaternion GetIKRotation() { }

	public float GetIKRotationWeight() { }

	public virtual Point GetPoint(Transform transform) { }

	public virtual Point[] GetPoints() { }

	private void InitiateBones() { }

	private bool IsDirectHierarchy() { }

	public virtual bool IsValid(ref string message) { }

	protected virtual void OnInitiate() { }

	protected override void OnInitiateVirtual() { }

	protected override void OnPostSolveVirtual() { }

	protected virtual void OnUpdate() { }

	protected override void OnUpdateVirtual() { }

	public override void SetBendGoalPosition(Vector3 goalPosition, float weight) { }

	public void SetBendGoalPosition(Vector3 goalPosition, Vector3 ikPos) { }

	public void SetBendPlaneToCurrent() { }

	public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root) { }

	public void SetIKRotation(Quaternion rotation) { }

	public void SetIKRotationWeight(float weight) { }

	public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight) { }

	public static void SolveVirtual(Bone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight) { }

	public static void SolveVirtualPositions(Bone bone1, Bone bone2, Bone bone3, Vector3 targetPosition, Vector3 bendNormal, float weight) { }

	public virtual void StoreDefaultLocalState() { }

}

