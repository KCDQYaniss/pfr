namespace RootMotion.FinalIK;

public class IKSolverLimb : IKSolverTrigonometric
{
	internal struct AxisDirection
	{
		public Vector3 direction; //Field offset: 0x0
		public Vector3 axis; //Field offset: 0xC
		public float dot; //Field offset: 0x18

		public AxisDirection(Vector3 direction, Vector3 axis) { }

	}

	internal enum BendModifier
	{
		Animation = 0,
		Target = 1,
		Parent = 2,
		Arm = 3,
		Goal = 4,
		Custom = 5,
	}

	public AvatarIKGoal goal; //Field offset: 0xA8
	public BendModifier bendModifier; //Field offset: 0xAC
	[Range(0, 1)]
	public float maintainRotationWeight; //Field offset: 0xB0
	[Range(0, 1)]
	public float bendModifierWeight; //Field offset: 0xB4
	public Transform bendGoal; //Field offset: 0xB8
	private bool maintainBendFor1Frame; //Field offset: 0xC0
	private bool maintainRotationFor1Frame; //Field offset: 0xC1
	private Quaternion defaultRootRotation; //Field offset: 0xC4
	private Quaternion parentDefaultRotation; //Field offset: 0xD4
	private Quaternion bone3RotationBeforeSolve; //Field offset: 0xE4
	private Quaternion maintainRotation; //Field offset: 0xF4
	private Quaternion bone3DefaultRotation; //Field offset: 0x104
	private Vector3 _bendNormal; //Field offset: 0x114
	private Vector3 animationNormal; //Field offset: 0x120
	private AxisDirection[] axisDirectionsLeft; //Field offset: 0x130
	private AxisDirection[] axisDirectionsRight; //Field offset: 0x138

	private AxisDirection[] axisDirections
	{
		private get { } //Length: 25
	}

	public IKSolverLimb() { }

	public IKSolverLimb(AvatarIKGoal goal) { }

	private AxisDirection[] get_axisDirections() { }

	private Vector3 GetModifiedBendNormal() { }

	public void MaintainBend() { }

	public void MaintainRotation() { }

	protected virtual void OnInitiateVirtual() { }

	protected virtual void OnPostSolveVirtual() { }

	protected virtual void OnUpdateVirtual() { }

	public void PrepareParallelSolve(out Vector3 effectiveBendNormal, out Quaternion maintainRotationReference) { }

	public virtual void SetBendGoalPosition(Vector3 goalPosition, float weight) { }

	private void StoreAxisDirections(ref AxisDirection[] axisDirections) { }

}

