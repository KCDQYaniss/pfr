namespace RootMotion.FinalIK;

public class IKSolverHeuristic : IKSolver
{
	public Transform target; //Field offset: 0x58
	public float tolerance; //Field offset: 0x60
	public int maxIterations; //Field offset: 0x64
	public bool useRotationLimits; //Field offset: 0x68
	public bool XY; //Field offset: 0x69
	public Bone[] bones; //Field offset: 0x70
	protected Vector3 lastLocalDirection; //Field offset: 0x78
	protected float chainLength; //Field offset: 0x84

	protected override bool allowCommonParent
	{
		 get { } //Length: 3
	}

	protected override bool boneLengthCanBeZero
	{
		 get { } //Length: 3
	}

	protected override Vector3 localDirection
	{
		 get { } //Length: 522
	}

	protected override int minBones
	{
		 get { } //Length: 6
	}

	protected float positionOffset
	{
		 get { } //Length: 110
	}

	public IKSolverHeuristic() { }

	public void AddBone(Transform bone) { }

	public virtual void FixTransforms() { }

	protected override bool get_allowCommonParent() { }

	protected override bool get_boneLengthCanBeZero() { }

	protected override Vector3 get_localDirection() { }

	protected override int get_minBones() { }

	protected float get_positionOffset() { }

	public virtual Point GetPoint(Transform transform) { }

	public virtual Point[] GetPoints() { }

	protected Vector3 GetSingularityOffset() { }

	protected void InitiateBones() { }

	public virtual bool IsValid(ref string message) { }

	protected virtual void OnInitiate() { }

	protected virtual void OnUpdate() { }

	public bool SetChain(Transform[] hierarchy, Transform root) { }

	private bool SingularityDetected() { }

	public virtual void StoreDefaultLocalState() { }

}

