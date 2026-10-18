//Type is in global namespace

public class CustomEffector : IEffector
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__12_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal AnimValProcessor <Initialize>b__12_0(AnimVal c) { }

	}

	private bool _inited; //Field offset: 0x10
	public WalkPreset AimPose; //Field offset: 0x18
	public float RestTransitionSpeed; //Field offset: 0x20
	public float RestDelay; //Field offset: 0x24
	public AnimVal RestValues; //Field offset: 0x28
	public AnimValProcessor[] _aimPose; //Field offset: 0x30
	private AnimValProcessor _restProcessor; //Field offset: 0x38
	private float _lastActivityTime; //Field offset: 0x40
	private float _initAimRotation; //Field offset: 0x44
	public ValueBlender PoseBlender; //Field offset: 0x48
	private float _poseNormalTime; //Field offset: 0x50
	private float _aimTarget; //Field offset: 0x54

	public bool Aim
	{
		 set { } //Length: 192
	}

	public Vector3 Offset
	{
		 get { } //Length: 104
	}

	public CustomEffector() { }

	public void Clear() { }

	public override string DebugOutput() { }

	public Vector3 get_Offset() { }

	public override void Initialize(PlayerSpring playerSpring) { }

	public override void Process(float intensity) { }

	public void ProcessRestPose() { }

	public void set_Aim(bool value) { }

	public void UpdateActivityTime() { }

}

