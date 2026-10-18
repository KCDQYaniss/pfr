namespace RootMotion.FinalIK;

public class FBIKChain
{
	internal class ChildConstraint
	{
		public float pushElasticity; //Field offset: 0x10
		public float pullElasticity; //Field offset: 0x14
		[SerializeField]
		private Transform bone1; //Field offset: 0x18
		[SerializeField]
		private Transform bone2; //Field offset: 0x20
		[CompilerGenerated]
		private float <nominalDistance>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		private bool <isRigid>k__BackingField; //Field offset: 0x2C
		private float crossFade; //Field offset: 0x30
		private float inverseCrossFade; //Field offset: 0x34
		private int chain1Index; //Field offset: 0x38
		private int chain2Index; //Field offset: 0x3C

		public private bool isRigid
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public private float nominalDistance
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			private set { } //Length: 6
		}

		public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0, float pullElasticity = 0) { }

		[CompilerGenerated]
		public bool get_isRigid() { }

		[CompilerGenerated]
		public float get_nominalDistance() { }

		public void Initiate(IKSolverFullBody solver) { }

		public void OnPreSolve(IKSolverFullBody solver) { }

		[CompilerGenerated]
		private void set_isRigid(bool value) { }

		[CompilerGenerated]
		private void set_nominalDistance(float value) { }

		public void Solve(IKSolverFullBody solver) { }

	}

	internal enum Smoothing
	{
		None = 0,
		Exponential = 1,
		Cubic = 2,
	}

	private const float maxLimbLength = 0.99999; //Field offset: 0x0
	[Range(0, 1)]
	public float pin; //Field offset: 0x10
	[Range(0, 1)]
	public float pull; //Field offset: 0x14
	[Range(0, 1)]
	public float push; //Field offset: 0x18
	[Range(-1, 1)]
	public float pushParent; //Field offset: 0x1C
	[Range(0, 1)]
	public float reach; //Field offset: 0x20
	public Smoothing reachSmoothing; //Field offset: 0x24
	public Smoothing pushSmoothing; //Field offset: 0x28
	public Node[] nodes; //Field offset: 0x30
	public int[] children; //Field offset: 0x38
	public ChildConstraint[] childConstraints; //Field offset: 0x40
	public IKConstraintBend bendConstraint; //Field offset: 0x48
	private float rootLength; //Field offset: 0x50
	private bool initiated; //Field offset: 0x54
	private float length; //Field offset: 0x58
	private float distance; //Field offset: 0x5C
	private Point p; //Field offset: 0x60
	private float reachForce; //Field offset: 0x68
	private float pullParentSum; //Field offset: 0x6C
	private float[] crossFades; //Field offset: 0x70
	private float sqrMag1; //Field offset: 0x78
	private float sqrMag2; //Field offset: 0x7C
	private float sqrMagDif; //Field offset: 0x80

	public FBIKChain() { }

	public FBIKChain(float pin, float pull, Transform[] nodeTransforms) { }

	private void BackwardReach(Vector3 position) { }

	private void CalculateBoneLengths(IKSolverFullBody solver) { }

	public void ForwardReach(Vector3 position) { }

	protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude) { }

	public int GetNodeIndex(Transform boneTransform) { }

	public void Initiate(IKSolverFullBody solver) { }

	public bool IsValid(ref string message) { }

	public Vector3 Push(IKSolverFullBody solver) { }

	public void Reach(IKSolverFullBody solver) { }

	public void ReadPose(IKSolverFullBody solver, bool fullBody) { }

	public void SetNodes(Transform[] boneTransforms) { }

	private void SolveChildConstraints(IKSolverFullBody solver) { }

	public void SolveConstraintSystems(IKSolverFullBody solver) { }

	private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length) { }

	private void SolveLinearConstraint(Node node1, Node node2, float crossFade, float distance) { }

	public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false) { }

	public void Stage1(IKSolverFullBody solver) { }

	public void Stage2(IKSolverFullBody solver, Vector3 position) { }

}

