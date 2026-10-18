namespace RootMotion.FinalIK;

[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Biped IK")]
[HelpURL("http://www.root-motion.com/finalikdox/html/page2.html")]
public class BipedIK : SolverManager
{
	public BipedReferences references; //Field offset: 0x48
	public BipedIKSolvers solvers; //Field offset: 0x50

	public BipedIK() { }

	[ContextMenu("Asset Store Thread")]
	private void ASThread() { }

	protected virtual void FixTransforms() { }

	public IKSolverLimb GetGoalIK(AvatarIKGoal goal) { }

	public Vector3 GetIKPosition(AvatarIKGoal goal) { }

	public float GetIKPositionWeight(AvatarIKGoal goal) { }

	public Quaternion GetIKRotation(AvatarIKGoal goal) { }

	public float GetIKRotationWeight(AvatarIKGoal goal) { }

	public void InitiateBipedIK() { }

	protected virtual void InitiateSolver() { }

	public void LogWarning(string message) { }

	[ContextMenu("Scrpt Reference")]
	private void OpenScriptReference() { }

	[ContextMenu("User Manual")]
	private void OpenUserManual() { }

	public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition) { }

	public void SetIKPositionWeight(AvatarIKGoal goal, float weight) { }

	public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation) { }

	public void SetIKRotationWeight(AvatarIKGoal goal, float weight) { }

	public void SetLookAtPosition(Vector3 lookAtPosition) { }

	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes) { }

	public void SetSpinePosition(Vector3 spinePosition) { }

	public void SetSpineWeight(float weight) { }

	public void SetToDefaults() { }

	[ContextMenu("Support Group")]
	private void SupportGroup() { }

	public void UpdateBipedIK() { }

	protected virtual void UpdateSolver() { }

}

