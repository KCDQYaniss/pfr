namespace RootMotion.FinalIK;

[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Target")]
[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
public class InteractionTarget : MonoBehaviour
{
	internal class Multiplier
	{
		[Tooltip("The curve type (InteractionObject.WeightCurve.Type).")]
		public Type curve; //Field offset: 0x10
		[Tooltip("Multiplier of the curve's value.")]
		public float multiplier; //Field offset: 0x14

		public Multiplier() { }

	}

	[Tooltip("The type of the FBBIK effector.")]
	public FullBodyBipedEffector effectorType; //Field offset: 0x20
	[Tooltip("InteractionObject weight curve multipliers for this effector target.")]
	public Multiplier[] multipliers; //Field offset: 0x28
	[Tooltip("The interaction speed multiplier for this effector. This can be used to make interactions faster/slower for specific effectors.")]
	public float interactionSpeedMlp; //Field offset: 0x30
	[Tooltip("The pivot to twist/swing this interaction target about. For symmetric objects that can be interacted with from a certain angular range.")]
	public Transform pivot; //Field offset: 0x38
	[Tooltip("The axis of twisting the interaction target (blue line).")]
	public Vector3 twistAxis; //Field offset: 0x40
	[Tooltip("The weight of twisting the interaction target towards the effector bone in the start of the interaction.")]
	public float twistWeight; //Field offset: 0x4C
	[Tooltip("The weight of swinging the interaction target towards the effector bone in the start of the interaction. Swing is defined as a 3-DOF rotation around any axis, while twist is only around the twist axis.")]
	public float swingWeight; //Field offset: 0x50
	[Tooltip("If true, will twist/swing around the pivot only once at the start of the interaction. If false, will continue rotating throuout the whole interaction.")]
	public bool rotateOnce; //Field offset: 0x54
	private Quaternion defaultLocalRotation; //Field offset: 0x58
	private Transform lastPivot; //Field offset: 0x68

	public InteractionTarget() { }

	[ContextMenu("Asset Store Thread")]
	private void ASThread() { }

	public float GetValue(Type curveType) { }

	[ContextMenu("Scrpt Reference")]
	private void OpenScriptReference() { }

	[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
	private void OpenTutorial1() { }

	[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
	private void OpenTutorial2() { }

	[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
	private void OpenTutorial3() { }

	[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
	private void OpenTutorial4() { }

	[ContextMenu("User Manual")]
	private void OpenUserManual() { }

	public void ResetRotation() { }

	public void RotateTo(Vector3 position) { }

	[ContextMenu("Support Group")]
	private void SupportGroup() { }

}

