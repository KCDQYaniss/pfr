//Type is in global namespace

public class SimpleTIK : TrigonometricIK
{
	public IKSolverFastTrigonometric solver; //Field offset: 0x50

	public SimpleTIK() { }

	[ContextMenu("Asset Store Thread")]
	private void ASThread() { }

	public virtual IKSolver GetIKSolver() { }

	[ContextMenu("Scrpt Reference")]
	protected virtual void OpenScriptReference() { }

	[ContextMenu("User Manual")]
	protected virtual void OpenUserManual() { }

	[ContextMenu("Support Group")]
	private void SupportGroup() { }

}

