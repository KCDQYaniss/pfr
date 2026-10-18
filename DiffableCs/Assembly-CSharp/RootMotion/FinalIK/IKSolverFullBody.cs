namespace RootMotion.FinalIK;

public class IKSolverFullBody : IKSolver
{
	[Range(0, 10)]
	public int iterations; //Field offset: 0x58
	public FBIKChain[] chain; //Field offset: 0x60
	public IKEffector[] effectors; //Field offset: 0x68
	public IKMappingSpine spineMapping; //Field offset: 0x70
	public IKMappingBone[] boneMappings; //Field offset: 0x78
	public IKMappingLimb[] limbMappings; //Field offset: 0x80
	private int[] endEffectorIndices; //Field offset: 0x88
	private int[] nonEndEffectorIndices; //Field offset: 0x90
	public UpdateDelegate OnPreRead; //Field offset: 0x98
	public UpdateDelegate OnPreSolve; //Field offset: 0xA0
	public IterationDelegate OnPreIteration; //Field offset: 0xA8
	public IterationDelegate OnPostIteration; //Field offset: 0xB0
	public UpdateDelegate OnPreBend; //Field offset: 0xB8
	public UpdateDelegate OnPostSolve; //Field offset: 0xC0
	public UpdateDelegate OnStoreDefaultLocalState; //Field offset: 0xC8
	public UpdateDelegate OnFixTransforms; //Field offset: 0xD0

	public IKSolverFullBody() { }

	protected override void ApplyBendConstraints() { }

	private void CacheEffectorIndexes() { }

	public virtual void FixTransforms() { }

	public FBIKChain GetChain(Transform transform) { }

	public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex) { }

	public int GetChainIndex(Transform transform) { }

	public IKEffector GetEffector(Transform t) { }

	public Node GetNode(int chainIndex, int nodeIndex) { }

	public virtual Point GetPoint(Transform transform) { }

	public virtual Point[] GetPoints() { }

	public virtual bool IsValid(ref string message) { }

	protected virtual void OnInitiate() { }

	protected virtual void OnUpdate() { }

	protected override void ReadPose() { }

	protected override void Solve() { }

	public virtual void StoreDefaultLocalState() { }

	private void UpdateEndEffectors() { }

	private void UpdateNonEndEffectors() { }

	protected override void WritePose() { }

}

