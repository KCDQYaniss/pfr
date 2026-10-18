namespace RootMotion.FinalIK;

[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK")]
[HelpURL("http://www.root-motion.com/finalikdox/html/page4.html")]
public class FABRIK : IK
{
	public IKSolverFABRIK solver; //Field offset: 0x48

	public FABRIK() { }

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

