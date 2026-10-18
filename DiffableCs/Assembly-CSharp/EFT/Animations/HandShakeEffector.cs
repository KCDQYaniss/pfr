namespace EFT.Animations;

public class HandShakeEffector : IEffector
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__37_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal AnimValProcessor <Initialize>b__37_0(AnimVal curve) { }

	}

	private const float DEFAULT_SHAKE_INTENSITY = 3; //Field offset: 0x0
	private const float DEFAULT_CURVE_INTENSITY = 1; //Field offset: 0x0
	private const float DEFAULT_CURVE_FREQUENCY = 1; //Field offset: 0x0
	[CompilerGenerated]
	private Transform <Transform>k__BackingField; //Field offset: 0x10
	public PhysicalBase Physical; //Field offset: 0x18
	public bool IsAiming; //Field offset: 0x20
	[SerializeField]
	private float _shakeIntensity; //Field offset: 0x24
	[Header("Smooth Random")]
	[SerializeField]
	[Space(10)]
	private float _energyMultiplier; //Field offset: 0x28
	[SerializeField]
	private float _energyLowerLimit; //Field offset: 0x2C
	[SerializeField]
	private float _energyFractureLimit; //Field offset: 0x30
	[SerializeField]
	private bool _useHandShakeParams; //Field offset: 0x34
	[SerializeField]
	private BreathParameters _handShakeParams; //Field offset: 0x38
	[SerializeField]
	[Tooltip("Affects on Hands Rotation Spring")]
	private SmoothRandom _handsRotationSpringXRandom; //Field offset: 0x40
	[SerializeField]
	[Tooltip("Affects on Hands Rotation Spring")]
	private SmoothRandom _handsRotationSpringYRandom; //Field offset: 0x48
	private Vector3 _handsRotationSpringAcceleration; //Field offset: 0x50
	[Header("Tremor")]
	[SerializeField]
	[Space(10)]
	[Tooltip("Affects on Recoil Rotation Spring Zero")]
	private SmoothRandom _recoilRotationSpringTremorXRandom; //Field offset: 0x60
	[SerializeField]
	[Tooltip("Affects on Recoil Rotation Spring Zero")]
	private SmoothRandom _recoilRotationSpringTremorYRandom; //Field offset: 0x68
	[SerializeField]
	[Tooltip("Affects on Recoil Rotation Spring Zero")]
	private SmoothRandom _recoilRotationSpringTremorZRandom; //Field offset: 0x70
	private Vector3 _recoilRotationSpringZero; //Field offset: 0x78
	[Header("Curves")]
	[SerializeField]
	[Space(10)]
	private float _curveFrequency; //Field offset: 0x84
	[SerializeField]
	private float _curveIntensity; //Field offset: 0x88
	[FormerlySerializedAs("Curves")]
	[SerializeField]
	[Tooltip("Curves are initializing on weapon switch, so if you delete vals of curves or curves themselves, need to initialize them again to apply changes by switching the gun")]
	private AnimVal[] _curves; //Field offset: 0x90
	[Header("Damping")]
	[SerializeField]
	[Space(10)]
	private bool _enableDamping; //Field offset: 0x98
	[SerializeField]
	private float _dampingStartTimePercent; //Field offset: 0x9C
	private float _passedTime; //Field offset: 0xA0
	private float _dampingCoef; //Field offset: 0xA4
	private float _dampingPassedTime; //Field offset: 0xA8
	private float _dampingDuration; //Field offset: 0xAC
	private float _dampingStartTime; //Field offset: 0xB0
	private AnimValProcessor[] _processors; //Field offset: 0xB8
	private Compute _staminaLevel; //Field offset: 0xC0
	private Spring _handsRotationSpring; //Field offset: 0xC8
	private RecoilProcessBase _recoilRotationSpring; //Field offset: 0xD0
	private ShotEffector _shotEffector; //Field offset: 0xD8

	public Transform Transform
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public HandShakeEffector() { }

	[CompilerGenerated]
	private float <Initialize>b__37_1() { }

	[CompilerGenerated]
	private float <Initialize>b__37_2() { }

	public void CalculateDamping(float duration) { }

	public override string DebugOutput() { }

	[CompilerGenerated]
	public Transform get_Transform() { }

	public override void Initialize(PlayerSpring playerSpring) { }

	public void OnStop() { }

	public override void Process(float deltaTime) { }

	[CompilerGenerated]
	public void set_Transform(Transform value) { }

	public void SetShotEffector(ShotEffector effector) { }

	public void Setup(float tremorIntensity, float curveFrequency, float curveIntensity) { }

}

