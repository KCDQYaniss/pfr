namespace RootMotion.FinalIK;

[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder IK")]
[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
public class GrounderIK : Grounder
{
	public IK[] legs; //Field offset: 0x48
	[Tooltip("The pelvis transform. Common ancestor of all the legs.")]
	public Transform pelvis; //Field offset: 0x50
	[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
	public Transform characterRoot; //Field offset: 0x58
	[Range(0, 1)]
	[Tooltip("The weight of rotating the character root to the ground normal (range: 0 - 1).")]
	public float rootRotationWeight; //Field offset: 0x60
	[Tooltip("The speed of rotating the character root to the ground normal (range: 0 - inf).")]
	public float rootRotationSpeed; //Field offset: 0x64
	[Tooltip("The maximum angle of root rotation (range: 0 - 90).")]
	public float maxRootRotationAngle; //Field offset: 0x68
	private Transform[] feet; //Field offset: 0x70
	private Quaternion[] footRotations; //Field offset: 0x78
	private Vector3 animatedPelvisLocalPosition; //Field offset: 0x80
	private Vector3 solvedPelvisLocalPosition; //Field offset: 0x8C
	private int solvedFeet; //Field offset: 0x98
	private bool solved; //Field offset: 0x9C
	private float lastWeight; //Field offset: 0xA0

	public GrounderIK() { }

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

	private void SetLegIK(int index) { }

	private void Update() { }

}

