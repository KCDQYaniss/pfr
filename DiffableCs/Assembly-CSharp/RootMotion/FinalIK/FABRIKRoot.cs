namespace RootMotion.FinalIK;

[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK Root")]
[HelpURL("http://www.root-motion.com/finalikdox/html/page5.html")]
public class FABRIKRoot : IK
{
	public IKSolverFABRIKRoot solver; //Field offset: 0x48

	public FABRIKRoot() { }

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

