namespace RootMotion.FinalIK;

public class Finger
{
	[Range(0, 1)]
	[Tooltip("Master Weight for the finger.")]
	public float weight; //Field offset: 0x10
	[Tooltip("The first bone of the finger.")]
	public Transform bone1; //Field offset: 0x18
	[Tooltip("The second bone of the finger.")]
	public Transform bone2; //Field offset: 0x20
	[Tooltip("The (optional) third bone of the finger. This can be ignored for thumbs.")]
	public Transform bone3; //Field offset: 0x28
	[Tooltip("The fingertip object. If your character doesn't have tip bones, you can create an empty GameObject and parent it to the last bone in the finger. Place it to the tip of the finger.")]
	public Transform tip; //Field offset: 0x30
	[Tooltip("The IK target (optional, can use IKPosition and IKRotation directly).")]
	public Transform target; //Field offset: 0x38
	[CompilerGenerated]
	private bool <initiated>k__BackingField; //Field offset: 0x40
	private IKSolverLimb solver; //Field offset: 0x48
	private Quaternion bone3RelativeToTarget; //Field offset: 0x50
	private Vector3 bone3DefaultLocalPosition; //Field offset: 0x60
	private Quaternion bone3DefaultLocalRotation; //Field offset: 0x6C

	public Vector3 IKPosition
	{
		 get { } //Length: 41
		 set { } //Length: 40
	}

	public Quaternion IKRotation
	{
		 get { } //Length: 33
		 set { } //Length: 30
	}

	public private bool initiated
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public Finger() { }

	public void FixTransforms() { }

	public Vector3 get_IKPosition() { }

	public Quaternion get_IKRotation() { }

	[CompilerGenerated]
	public bool get_initiated() { }

	public void Initiate(Transform hand, int index) { }

	public bool IsValid(ref string errorMessage) { }

	public void set_IKPosition(Vector3 value) { }

	public void set_IKRotation(Quaternion value) { }

	[CompilerGenerated]
	private void set_initiated(bool value) { }

	public void Update(float masterWeight) { }

}

