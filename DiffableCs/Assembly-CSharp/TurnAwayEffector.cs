//Type is in global namespace

public class TurnAwayEffector : IEffector
{
	internal class AnimVal
	{
		internal enum ComponentType
		{
			X = 0,
			Y = 1,
			Z = 2,
		}

		public float Intensity; //Field offset: 0x10
		public float AltIntensity; //Field offset: 0x14
		public float Intensity1; //Field offset: 0x18
		public float AltIntensity1; //Field offset: 0x1C
		public AnimationCurve Curve; //Field offset: 0x20
		public ComponentType Component; //Field offset: 0x28
		private int _component; //Field offset: 0x2C

		public AnimVal() { }

		public void Initialize() { }

		public override void Process(ref Vector3 vec, float value, EPointOfView pov, float weight) { }

	}

	public float OverlapValue; //Field offset: 0x10
	[SerializeField]
	private TurnAwayPose _rifleShift; //Field offset: 0x18
	[SerializeField]
	private TurnAwayPose _pistolShift; //Field offset: 0x20
	[SerializeField]
	private TurnAwayPose _proneShift; //Field offset: 0x28
	[SerializeField]
	private TurnAwayPose[] _elbows; //Field offset: 0x30
	private TurnAwayPose _currentShift; //Field offset: 0x38
	[SerializeField]
	private float _blendSpeed; //Field offset: 0x40
	[SerializeField]
	private float _turnAwayThreshold; //Field offset: 0x44
	[SerializeField]
	private float _turnAwayLeftStanceThreshold; //Field offset: 0x48
	[SerializeField]
	private float _playerOverlapThreshold; //Field offset: 0x4C
	[SerializeField]
	private float _playerLeftStanceOverlapThreshold; //Field offset: 0x50
	[SerializeField]
	private float _inSmoothTime; //Field offset: 0x54
	[SerializeField]
	private float _outSmoothTime; //Field offset: 0x58
	private EPointOfView _pov; //Field offset: 0x5C
	private bool _isPistol; //Field offset: 0x60
	private bool _isInProne; //Field offset: 0x61
	private bool _isLeftStance; //Field offset: 0x62
	private bool _isInMountState; //Field offset: 0x63
	public bool IsDirty; //Field offset: 0x64
	private float _fovInput; //Field offset: 0x68
	public bool OverlapsWithPlayer; //Field offset: 0x6C
	public float OverlapDepth; //Field offset: 0x70
	public float OriginZShift; //Field offset: 0x74
	private float _fovScale; //Field offset: 0x78
	private float _normalFovScale; //Field offset: 0x7C
	public float Overlap; //Field offset: 0x80
	private float _blend; //Field offset: 0x84
	public AnimationCurve CameraShiftCurve; //Field offset: 0x88
	private Vector3 _position; //Field offset: 0x90
	private Vector3 _rotation; //Field offset: 0x9C
	private Vector3 _cameraShift; //Field offset: 0xA8
	private Vector3 _lElbowShift; //Field offset: 0xB4
	private Vector3 _rElbowShift; //Field offset: 0xC0
	private float _cameraZShift; //Field offset: 0xCC
	private float _maxZShift; //Field offset: 0xD0
	[SerializeField]
	private float _cameraShiftAtMaxOverlap; //Field offset: 0xD4

	public Vector3 CameraShift
	{
		 get { } //Length: 25
	}

	public float FovScale
	{
		 set { } //Length: 74
	}

	public bool InMountState
	{
		 set { } //Length: 4
	}

	public bool IsInPronePose
	{
		 set { } //Length: 10
	}

	public bool IsPistol
	{
		 set { } //Length: 10
	}

	public bool LeftStance
	{
		 set { } //Length: 4
	}

	public Vector3 LElbowShift
	{
		 get { } //Length: 25
	}

	public EPointOfView PointOfView
	{
		 set { } //Length: 88
	}

	public Vector3 Position
	{
		 get { } //Length: 25
	}

	public Vector3 RElbowShift
	{
		 get { } //Length: 25
	}

	public Vector3 Rotation
	{
		 get { } //Length: 25
	}

	public TurnAwayEffector() { }

	public override string DebugOutput() { }

	public Vector3 get_CameraShift() { }

	public Vector3 get_LElbowShift() { }

	public Vector3 get_Position() { }

	public Vector3 get_RElbowShift() { }

	public Vector3 get_Rotation() { }

	public override void Initialize(PlayerSpring playerSpring) { }

	public override void Process(float deltaTime) { }

	public void set_FovScale(float value) { }

	public void set_InMountState(bool value) { }

	public void set_IsInPronePose(bool value) { }

	public void set_IsPistol(bool value) { }

	public void set_LeftStance(bool value) { }

	public void set_PointOfView(EPointOfView value) { }

	public void UpdatePreset() { }

}

