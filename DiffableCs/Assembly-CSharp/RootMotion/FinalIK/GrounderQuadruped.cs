namespace RootMotion.FinalIK;

[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Quadruped")]
[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
public class GrounderQuadruped : Grounder
{
	internal struct Foot
	{
		public IKSolver solver; //Field offset: 0x0
		public Transform transform; //Field offset: 0x8
		public Quaternion rotation; //Field offset: 0x10
		public Leg leg; //Field offset: 0x20

		public Foot(IKSolver solver, Transform transform) { }

	}

	[Tooltip("The Grounding solver for the forelegs.")]
	public Grounding forelegSolver; //Field offset: 0x48
	[Range(0, 1)]
	[Tooltip("The weight of rotating the character root to the ground angle (range: 0 - 1).")]
	public float rootRotationWeight; //Field offset: 0x50
	[Range(-90, 0)]
	[Tooltip("The maximum angle of rotating the quadruped downwards (going downhill, range: -90 - 0).")]
	public float minRootRotation; //Field offset: 0x54
	[Range(0, 90)]
	[Tooltip("The maximum angle of rotating the quadruped upwards (going uphill, range: 0 - 90).")]
	public float maxRootRotation; //Field offset: 0x58
	[Tooltip("The speed of interpolating the character root rotation (range: 0 - inf).")]
	public float rootRotationSpeed; //Field offset: 0x5C
	[Tooltip("The maximum IK offset for the legs (range: 0 - inf).")]
	public float maxLegOffset; //Field offset: 0x60
	[Tooltip("The maximum IK offset for the forelegs (range: 0 - inf).")]
	public float maxForeLegOffset; //Field offset: 0x64
	[Range(0, 1)]
	[Tooltip("The weight of maintaining the head's rotation as it was before solving the Grounding (range: 0 - 1).")]
	public float maintainHeadRotationWeight; //Field offset: 0x68
	[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
	public Transform characterRoot; //Field offset: 0x70
	[Tooltip("The pelvis transform. Common ancestor of both legs and the spine.")]
	public Transform pelvis; //Field offset: 0x78
	[Tooltip("The last bone in the spine that is the common parent for both forelegs.")]
	public Transform lastSpineBone; //Field offset: 0x80
	[Tooltip("The head (optional, if you intend to maintain it's rotation).")]
	public Transform head; //Field offset: 0x88
	public IK[] legs; //Field offset: 0x90
	public IK[] forelegs; //Field offset: 0x98
	[HideInInspector]
	public Vector3 gravity; //Field offset: 0xA0
	private Foot[] feet; //Field offset: 0xB0
	private Vector3 animatedPelvisLocalPosition; //Field offset: 0xB8
	private Quaternion animatedPelvisLocalRotation; //Field offset: 0xC4
	private Quaternion animatedHeadLocalRotation; //Field offset: 0xD4
	private Vector3 solvedPelvisLocalPosition; //Field offset: 0xE4
	private Quaternion solvedPelvisLocalRotation; //Field offset: 0xF0
	private Quaternion solvedHeadLocalRotation; //Field offset: 0x100
	private int solvedFeet; //Field offset: 0x110
	private bool solved; //Field offset: 0x114
	private float angle; //Field offset: 0x118
	private Transform forefeetRoot; //Field offset: 0x120
	private Quaternion headRotation; //Field offset: 0x128
	private float lastWeight; //Field offset: 0x138

	public GrounderQuadruped() { }

	private void DestroyLegs(IK[] ikComponents) { }

	private void Initiate() { }

	private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset) { }

	private bool IsReadyToInitiate() { }

	private bool IsReadyToInitiateLegs(IK[] ikComponents) { }

	private void LateUpdate() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnPostSolverUpdate() { }

	private void OnSolverUpdate() { }

	[ContextMenu("Scrpt Reference")]
	protected virtual void OpenScriptReference() { }

	[ContextMenu("User Manual")]
	protected virtual void OpenUserManual() { }

	public virtual void ResetPosition() { }

	private void RootRotation() { }

	private void SetFootIK(Foot foot, float maxOffset) { }

	private void Update() { }

	private void UpdateForefeetRoot() { }

}

