namespace RootMotion.FinalIK;

public class IKSolverFABRIK : IKSolverHeuristic
{
	public IterationDelegate OnPreIteration; //Field offset: 0x88
	private bool[] limitedBones; //Field offset: 0x90
	private Vector3[] solverLocalPositions; //Field offset: 0x98

	protected virtual bool boneLengthCanBeZero
	{
		 get { } //Length: 3
	}

	public IKSolverFABRIK() { }

	private void BackwardReach(Vector3 position) { }

	private void BackwardReachLimited(Vector3 position) { }

	private void BackwardReachUnlimited(Vector3 position) { }

	private void ForwardReach(Vector3 position) { }

	protected virtual bool get_boneLengthCanBeZero() { }

	public virtual Vector3 GetIKPosition() { }

	private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed) { }

	private Vector3 GetParentSolverPosition(int index) { }

	private Quaternion GetParentSolverRotation(int index) { }

	private void LimitForward(int rotateBone, int limitBone) { }

	private void MapToSolverPositions() { }

	private void MapToSolverPositionsLimited() { }

	protected virtual void OnInitiate() { }

	private void OnPostSolve() { }

	private void OnPreSolve() { }

	protected virtual void OnUpdate() { }

	private void Solve(Vector3 targetPosition) { }

	public void SolveBackward(Vector3 position) { }

	public void SolveForward(Vector3 position) { }

	private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length) { }

	private void SolverMove(int index, Vector3 offset) { }

	private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation) { }

	private void SolverRotate(int index, Quaternion rotation, bool recursive) { }

	private void SolverRotateChildren(int index, Quaternion rotation) { }

}

