namespace RootMotion.FinalIK;

public class Recoil : OffsetModifier
{
	internal enum Handedness
	{
		Right = 0,
		Left = 1,
	}

	internal class RecoilOffset
	{
		internal class EffectorLink
		{
			[Tooltip("Type of the FBBIK effector to use")]
			public FullBodyBipedEffector effector; //Field offset: 0x10
			[Tooltip("Weight of using this effector")]
			public float weight; //Field offset: 0x14

			public EffectorLink() { }

		}

		[Tooltip("Offset vector for the associated effector when doing recoil.")]
		public Vector3 offset; //Field offset: 0x10
		[Range(0, 1)]
		[Tooltip("When firing before the last recoil has faded, how much of the current recoil offset will be maintained?")]
		public float additivity; //Field offset: 0x1C
		[Tooltip("Max additive recoil for automatic fire.")]
		public float maxAdditiveOffsetMag; //Field offset: 0x20
		[Tooltip("Linking this recoil offset to FBBIK effectors.")]
		public EffectorLink[] effectorLinks; //Field offset: 0x28
		private Vector3 additiveOffset; //Field offset: 0x30
		private Vector3 lastOffset; //Field offset: 0x3C

		public RecoilOffset() { }

		public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft) { }

		public void Start() { }

	}

	[Tooltip("Reference to the AimIK component. Optional, only used to getting the aiming direction.")]
	public AimIK aimIK; //Field offset: 0x38
	[Tooltip("Which hand is holding the weapon?")]
	public Handedness handedness; //Field offset: 0x40
	[Tooltip("Check for 2-handed weapons.")]
	public bool twoHanded; //Field offset: 0x44
	[Tooltip("Weight curve for the recoil offsets. Recoil procedure is as long as this curve.")]
	public AnimationCurve recoilWeight; //Field offset: 0x48
	[Tooltip("How much is the magnitude randomized each time Recoil is called?")]
	public float magnitudeRandom; //Field offset: 0x50
	[Tooltip("How much is the rotation randomized each time Recoil is called?")]
	public Vector3 rotationRandom; //Field offset: 0x54
	[Tooltip("Rotating the primary hand bone for the recoil (in local space).")]
	public Vector3 handRotationOffset; //Field offset: 0x60
	[Tooltip("Time of blending in another recoil when doing automatic fire.")]
	public float blendTime; //Field offset: 0x6C
	[Space(10)]
	[Tooltip("FBBIK effector position offsets for the recoil (in aiming direction space).")]
	public RecoilOffset[] offsets; //Field offset: 0x70
	[HideInInspector]
	public Quaternion rotationOffset; //Field offset: 0x78
	private float magnitudeMlp; //Field offset: 0x88
	private float endTime; //Field offset: 0x8C
	private Quaternion handRotation; //Field offset: 0x90
	private Quaternion secondaryHandRelativeRotation; //Field offset: 0xA0
	private Quaternion randomRotation; //Field offset: 0xB0
	private float length; //Field offset: 0xC0
	private bool initiated; //Field offset: 0xC4
	private float blendWeight; //Field offset: 0xC8
	private float w; //Field offset: 0xCC
	private Quaternion primaryHandRotation; //Field offset: 0xD0
	private bool handRotationsSet; //Field offset: 0xE0

	private Transform primaryHand
	{
		private get { } //Length: 98
	}

	private IKEffector primaryHandEffector
	{
		private get { } //Length: 92
	}

	private Transform secondaryHand
	{
		private get { } //Length: 98
	}

	private IKEffector secondaryHandEffector
	{
		private get { } //Length: 92
	}

	public Recoil() { }

	private void AfterFBBIK() { }

	public void Fire(float magnitude) { }

	private Transform get_primaryHand() { }

	private IKEffector get_primaryHandEffector() { }

	private Transform get_secondaryHand() { }

	private IKEffector get_secondaryHandEffector() { }

	protected virtual void OnDestroy() { }

	protected virtual void OnModifyOffset() { }

	public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation) { }

}

