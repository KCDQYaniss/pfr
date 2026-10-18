namespace RootMotion.FinalIK;

[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Full Body Biped")]
[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
public class GrounderFBBIK : Grounder
{
	internal class SpineEffector
	{
		[Tooltip("The type of the effector.")]
		public FullBodyBipedEffector effectorType; //Field offset: 0x10
		[Tooltip("The weight of horizontal bend offset towards the slope.")]
		public float horizontalWeight; //Field offset: 0x14
		[Tooltip("The vertical bend offset weight.")]
		public float verticalWeight; //Field offset: 0x18

		public SpineEffector() { }

	}

	[Tooltip("Reference to the FBBIK componet.")]
	public FullBodyBipedIK ik; //Field offset: 0x48
	[Tooltip("The amount of spine bending towards upward slopes.")]
	public float spineBend; //Field offset: 0x50
	[Tooltip("The interpolation speed of spine bending.")]
	public float spineSpeed; //Field offset: 0x54
	public SpineEffector[] spine; //Field offset: 0x58
	private Transform[] feet; //Field offset: 0x60
	private Vector3 spineOffset; //Field offset: 0x68
	private bool firstSolve; //Field offset: 0x74

	public GrounderFBBIK() { }

	private void FixedUpdate() { }

	public void Initiate() { }

	private bool IsReadyToInitiate() { }

	private void LateUpdate() { }

	private void OnDestroy() { }

	private void OnDrawGizmosSelected() { }

	private void OnSolverUpdate() { }

	[ContextMenu("Scrpt Reference")]
	protected virtual void OpenScriptReference() { }

	[ContextMenu("TUTORIAL VIDEO")]
	private void OpenTutorial() { }

	[ContextMenu("User Manual")]
	protected virtual void OpenUserManual() { }

	public virtual void ResetPosition() { }

	private void SetLegIK(IKEffector effector, Leg leg) { }

	private void Update() { }

}

