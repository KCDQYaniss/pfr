namespace RootMotion.FinalIK;

public class IKSolverFABRIKRoot : IKSolver
{
	public int iterations; //Field offset: 0x58
	[Range(0, 1)]
	public float rootPin; //Field offset: 0x5C
	public FABRIKChain[] chains; //Field offset: 0x60
	private bool zeroWeightApplied; //Field offset: 0x68
	private bool[] isRoot; //Field offset: 0x70
	private Vector3 rootDefaultPosition; //Field offset: 0x78

	public IKSolverFABRIKRoot() { }

	private void AddPointsToArray(ref Point[] array, FABRIKChain chain) { }

	public virtual void FixTransforms() { }

	private Vector3 GetCentroid() { }

	public virtual Point GetPoint(Transform transform) { }

	public virtual Point[] GetPoints() { }

	private bool IsRoot(int index) { }

	public virtual bool IsValid(ref string message) { }

	protected virtual void OnInitiate() { }

	protected virtual void OnUpdate() { }

	public virtual void StoreDefaultLocalState() { }

}

