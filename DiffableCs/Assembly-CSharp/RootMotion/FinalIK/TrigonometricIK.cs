namespace RootMotion.FinalIK;

[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Trigonometric IK")]
[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
public class TrigonometricIK : IK
{
	public IKSolverTrigonometric solver; //Field offset: 0x48

	public TrigonometricIK() { }

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

