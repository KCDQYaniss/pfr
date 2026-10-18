namespace EFT.Animations;

public class BreathEffector : IEffector
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__46_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal AnimValProcessor <Initialize>b__46_0(AnimVal val) { }

	}

	public PhysicalBase Physical; //Field offset: 0x10
	public bool IsAiming; //Field offset: 0x18
	private Spring _handsRotationSpring; //Field offset: 0x20
	private ShotEffector _shotEffector; //Field offset: 0x28
	public float Intensity; //Field offset: 0x30
	[Header("Smooth Random")]
	private float _shakeIntensity; //Field offset: 0x34
	public SmoothRandom XRandom; //Field offset: 0x38
	public SmoothRandom YRandom; //Field offset: 0x40
	private float _breathIntensity; //Field offset: 0x48
	private float _breathFrequency; //Field offset: 0x4C
	[Header("Tremor")]
	public SmoothRandom TremorXRandom; //Field offset: 0x50
	public SmoothRandom TremorYRandom; //Field offset: 0x58
	public SmoothRandom TremorZRandom; //Field offset: 0x60
	[Header("Hip Wiggle")]
	public SmoothRandom HipXRandom; //Field offset: 0x68
	public SmoothRandom HipZRandom; //Field offset: 0x70
	public float HipPenalty; //Field offset: 0x78
	public AnimVal[] Curves; //Field offset: 0x80
	private AnimValProcessor[] _processors; //Field offset: 0x88
	public BreathParameters BreathParams; //Field offset: 0x90
	public bool TremorOn; //Field offset: 0x98
	public bool Fracture; //Field offset: 0x99
	private float _cameraSensetivity; //Field offset: 0x9C
	public float StiffUntill; //Field offset: 0xA0
	public float EnergyLowerLimit; //Field offset: 0xA4
	public float EnergyFractureLimit; //Field offset: 0xA8
	public float AmplitudeGainPerShot; //Field offset: 0xAC
	public float Delay; //Field offset: 0xB0
	[Header("Mounting")]
	public float MountingVerticalOutOfBreathMultiplier; //Field offset: 0xB4
	public float MountingHorizontalOutOfBreathMultiplier; //Field offset: 0xB8
	public float BipodOutOfBreathMultiplier; //Field offset: 0xBC
	public bool IsInMounting; //Field offset: 0xC0
	public bool IsVerticalMounting; //Field offset: 0xC1
	public bool IsBipodUsed; //Field offset: 0xC2
	public BetterValueBlender AmplitudeGain; //Field offset: 0xC8
	public BetterValueBlender Hardness; //Field offset: 0xD0
	[SerializeField]
	private Vector2 _baseHipRandomAmplitudes; //Field offset: 0xD8
	[SerializeField]
	private Vector2 _randomBetween; //Field offset: 0xE0
	[SerializeField]
	private float _shotHardness; //Field offset: 0xE8
	[SerializeField]
	private AnimationCurve _lackOfOxygenStrength; //Field offset: 0xF0
	[CompilerGenerated]
	private float <Overweight>k__BackingField; //Field offset: 0xF8
	public Compute OxygenLevel; //Field offset: 0x100
	public Compute StaminaLevel; //Field offset: 0x108
	public bool TestBreath; //Field offset: 0x110

	public float Overweight
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public BreathEffector() { }

	[CompilerGenerated]
	private float <Initialize>b__46_1() { }

	[CompilerGenerated]
	private float <Initialize>b__46_2() { }

	[CompilerGenerated]
	private float <Initialize>b__46_3() { }

	[CompilerGenerated]
	private float <Initialize>b__46_4() { }

	public override string DebugOutput() { }

	[CompilerGenerated]
	public float get_Overweight() { }

	public override void Initialize(PlayerSpring playerSpring) { }

	public void OnShot() { }

	public override void Process(float deltaTime) { }

	[CompilerGenerated]
	public void set_Overweight(float value) { }

	public void SetBipod(bool bipodUsed) { }

	public void SetMounting(bool isMounted, bool isVertical) { }

	public void SetShotEffector(ShotEffector effector) { }

}

