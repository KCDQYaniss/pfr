//Type is in global namespace

public class WalkEffector : IEffector
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__23_2; //Field offset: 0x8
		public static Func <>9__23_0; //Field offset: 0x10
		public static Func <>9__23_3; //Field offset: 0x18
		public static Func <>9__23_1; //Field offset: 0x20
		public static Func <>9__23_4; //Field offset: 0x28
		public static Func <>9__23_5; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal AnimValProcessor[] <Initialize>b__23_0(WalkPreset p) { }

		internal AnimValProcessor[] <Initialize>b__23_1(WalkPreset p) { }

		internal AnimValProcessor <Initialize>b__23_2(AnimVal curve) { }

		internal AnimValProcessor <Initialize>b__23_3(AnimVal curve) { }

		internal IEnumerable <Initialize>b__23_4(AnimValProcessor[] presets) { }

		internal IEnumerable <Initialize>b__23_5(AnimValProcessor[] presets) { }

	}

	internal enum EWalkPreset
	{
		normal = 0,
		lame = 1,
		sprint = 2,
		duck = 3,
	}

	[CompilerGenerated]
	private Transform <Transform>k__BackingField; //Field offset: 0x10
	public float StepFrequency; //Field offset: 0x18
	public float Intensity; //Field offset: 0x1C
	public float SideSpeedMultyplyer; //Field offset: 0x20
	public float BackSpeedMultyplyer; //Field offset: 0x24
	public float Treshold; //Field offset: 0x28
	private Vector3 _lastPosition; //Field offset: 0x2C
	private bool _isWalking; //Field offset: 0x38
	public WalkPreset[] Presets; //Field offset: 0x40
	[FormerlySerializedAs("CameraPresets")]
	public WalkPreset[] OverweightPresets; //Field offset: 0x48
	public AnimValProcessor[][] PresetProcessors; //Field offset: 0x50
	public AnimValProcessor[][] OverweightPresetProcessors; //Field offset: 0x58
	public Vector2[] IntensityMinMax; //Field offset: 0x60
	public float Overweight; //Field offset: 0x68
	public EWalkPreset CurrentWalkPreset; //Field offset: 0x6C
	private float _speed; //Field offset: 0x70

	public float Speed
	{
		 get { } //Length: 6
		 set { } //Length: 125
	}

	public Transform Transform
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public WalkEffector() { }

	public void AdjustPose() { }

	public override string DebugOutput() { }

	public float get_Speed() { }

	[CompilerGenerated]
	public Transform get_Transform() { }

	public override void Initialize(PlayerSpring playerSpring) { }

	public void OnStop() { }

	public override void Process(float deltaTime) { }

	public void set_Speed(float value) { }

	[CompilerGenerated]
	public void set_Transform(Transform value) { }

}

