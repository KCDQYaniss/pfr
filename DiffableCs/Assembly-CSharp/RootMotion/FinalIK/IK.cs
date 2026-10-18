namespace RootMotion.FinalIK;

public abstract class IK : SolverManager
{

	protected IK() { }

	protected virtual void FixTransforms() { }

	public abstract IKSolver GetIKSolver() { }

	protected virtual void InitiateSolver() { }

	protected abstract void OpenScriptReference() { }

	protected abstract void OpenUserManual() { }

	protected virtual void UpdateSolver() { }

}

