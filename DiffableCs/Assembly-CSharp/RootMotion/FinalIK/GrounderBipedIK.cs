namespace RootMotion.FinalIK;

[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Biped")]
[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
public class GrounderBipedIK : Grounder
{
	[Tooltip("The BipedIK componet.")]
	public BipedIK ik; //Field offset: 0x48
	[Tooltip("The amount of spine bending towards upward slopes.")]
	public float spineBend; //Field offset: 0x50
	[Tooltip("The interpolation speed of spine bending.")]
	public float spineSpeed; //Field offset: 0x54
	private Transform[] feet; //Field offset: 0x58
	private Quaternion[] footRotations; //Field offset: 0x60
	private Vector3 animatedPelvisLocalPosition; //Field offset: 0x68
	private Vector3 solvedPelvisLocalPosition; //Field offset: 0x74
	private Vector3 spineOffset; //Field offset: 0x80
	private float lastWeight; //Field offset: 0x8C

	public GrounderBipedIK() { }

	private void Initiate() { }

	private bool IsReadyToInitiate() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnPostSolverUpdate() { }

	private void OnSolverUpdate() { }

	[ContextMenu("Scrpt Reference")]
	protected virtual void OpenScriptReference() { }

	[ContextMenu("User Manual")]
	protected virtual void OpenUserManual() { }

	public virtual void ResetPosition() { }

	private void SetLegIK(IKSolverLimb limb, int index) { }

	private void Update() { }

}

