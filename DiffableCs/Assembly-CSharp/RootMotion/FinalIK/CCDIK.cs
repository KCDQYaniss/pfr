namespace RootMotion.FinalIK;

[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/CCD IK")]
[HelpURL("http://www.root-motion.com/finalikdox/html/page3.html")]
public class CCDIK : IK
{
	public IKSolverCCD solver; //Field offset: 0x48

	public CCDIK() { }

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

