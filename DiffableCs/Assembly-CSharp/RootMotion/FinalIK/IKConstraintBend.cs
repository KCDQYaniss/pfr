namespace RootMotion.FinalIK;

public class IKConstraintBend
{
	public Transform bone1; //Field offset: 0x10
	public Transform bone2; //Field offset: 0x18
	public Transform bone3; //Field offset: 0x20
	public Transform bendGoal; //Field offset: 0x28
	public Vector3 direction; //Field offset: 0x30
	public Quaternion rotationOffset; //Field offset: 0x3C
	[Range(0, 1)]
	public float weight; //Field offset: 0x4C
	public Vector3 defaultLocalDirection; //Field offset: 0x50
	public Vector3 defaultChildDirection; //Field offset: 0x5C
	public float clampF; //Field offset: 0x68
	private int chainIndex1; //Field offset: 0x6C
	private int nodeIndex1; //Field offset: 0x70
	private int chainIndex2; //Field offset: 0x74
	private int nodeIndex2; //Field offset: 0x78
	private int chainIndex3; //Field offset: 0x7C
	private int nodeIndex3; //Field offset: 0x80
	[CompilerGenerated]
	private bool <initiated>k__BackingField; //Field offset: 0x84

	public private bool initiated
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public IKConstraintBend() { }

	public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3) { }

	[CompilerGenerated]
	public bool get_initiated() { }

	public Vector3 GetDir(IKSolverFullBody solver) { }

	public void Initiate(IKSolverFullBody solver) { }

	public bool IsValid(IKSolverFullBody solver, Logger logger) { }

	public void LimitBend(float solverWeight, float positionWeight) { }

	private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent) { }

	private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent) { }

	[CompilerGenerated]
	private void set_initiated(bool value) { }

	public void SetBones(Transform bone1, Transform bone2, Transform bone3) { }

	public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last) { }

}

