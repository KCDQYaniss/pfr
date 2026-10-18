namespace RootMotion.FinalIK;

public class IKSolverCCD : IKSolverHeuristic
{
	public IterationDelegate OnPreIteration; //Field offset: 0x88

	public IKSolverCCD() { }

	public void FadeOutBoneWeights() { }

	protected virtual void OnInitiate() { }

	protected virtual void OnUpdate() { }

	private void Solve(Vector3 targetPosition) { }

	public static void SolveVirtual(Bone[] bones, Vector3 targetPosition, float weight) { }

}

