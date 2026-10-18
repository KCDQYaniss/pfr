namespace RootMotion.FinalIK;

[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Full Body Biped IK")]
[HelpURL("https://www.youtube.com/watch?v=7__IafZGwvI&index=1&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
public class FullBodyBipedIK : IK
{
	public BipedReferences references; //Field offset: 0x48
	public IKSolverFullBodyBiped solver; //Field offset: 0x50

	public FullBodyBipedIK() { }

	[ContextMenu("Asset Store Thread")]
	private void ASThread() { }

	[ContextMenu("Auto-detect References")]
	private void AutoDetectReferences() { }

	public virtual IKSolver GetIKSolver() { }

	[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
	private void OpenInspectorTutorial() { }

	[ContextMenu("Scrpt Reference")]
	protected virtual void OpenScriptReference() { }

	[ContextMenu("TUTORIAL VIDEO (SETUP)")]
	private void OpenSetupTutorial() { }

	[ContextMenu("User Manual")]
	protected virtual void OpenUserManual() { }

	public bool ReferencesError(ref string errorMessage) { }

	public bool ReferencesWarning(ref string warningMessage) { }

	[ContextMenu("Reinitiate")]
	private void Reinitiate() { }

	public void SetReferences(BipedReferences references, Transform rootNode) { }

	[ContextMenu("Support Group")]
	private void SupportGroup() { }

}

