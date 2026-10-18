namespace RootMotion.FinalIK;

[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Limb IK")]
[HelpURL("http://www.root-motion.com/finalikdox/html/page7.html")]
public class LimbIK : IK
{
	public IKSolverLimb solver; //Field offset: 0x48

	public LimbIK() { }

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

