namespace EFT.Utilities;

[RequireComponent(typeof(CinemachinePathBase))]
public class AutoCameraController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__57_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal float <Setup>b__57_1(PointAction o) { }

	}

	internal enum EAction
	{
		None = 0,
		AimObject = 1,
		AimPoint = 2,
		AimForward = 3,
		Wait = 4,
	}

	internal struct PointAction
	{
		public float Index; //Field offset: 0x0
		public EAction Action; //Field offset: 0x4
		public string StringValue; //Field offset: 0x8
		public float FloatValue; //Field offset: 0x10
		public Vector3 VectorValue; //Field offset: 0x14

	}

	private const string AUTO_CAMERA_PREFAB_PATH = "Debug/AutoCamera"; //Field offset: 0x0
	public CinemachineVirtualCamera CamVM; //Field offset: 0x20
	public float Speed; //Field offset: 0x28
	public PointAction[] Points; //Field offset: 0x30
	[CompilerGenerated]
	private Action OnComplete; //Field offset: 0x38
	[CompilerGenerated]
	private float <CurrentWaypointIndex>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private bool <IsFpsIndependent>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private bool <WaitStableFPS>k__BackingField; //Field offset: 0x45
	[CompilerGenerated]
	private int <WaitStableFPSSampleCount>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private float <WaitStableFPSDeltaThreshold>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	private int <IdleFrameCount>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private Action OnSampleFrameUpdate; //Field offset: 0x58
	[CompilerGenerated]
	private Action OnSampleFrameEnd; //Field offset: 0x60
	[CompilerGenerated]
	private Action OnPrematureEvacuation; //Field offset: 0x68
	private CinemachineTrackedDolly _camTrack; //Field offset: 0x70
	private Queue _processActions; //Field offset: 0x78
	private float _waitSeconds; //Field offset: 0x80
	private bool _isComplete; //Field offset: 0x84
	private bool _isProcess; //Field offset: 0x85
	private GameObject _tempObject; //Field offset: 0x88
	private PointAction _currentAction; //Field offset: 0x90
	private double[] _waitStableFPSSamples; //Field offset: 0xB0
	private int _waitStableFPSSamplesIndex; //Field offset: 0xB8
	private int _idleFrameAccumulator; //Field offset: 0xBC

	public event Action OnComplete
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnPrematureEvacuation
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnSampleFrameEnd
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnSampleFrameUpdate
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public private float CurrentWaypointIndex
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public int IdleFrameCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool IsComplete
	{
		 get { } //Length: 8
	}

	public bool IsFpsIndependent
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool IsProcess
	{
		 get { } //Length: 8
	}

	public bool WaitStableFPS
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public float WaitStableFPSDeltaThreshold
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public int WaitStableFPSSampleCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public AutoCameraController() { }

	[CompilerGenerated]
	private void <ManualUpdate>g__AtEndOfFrame|58_0() { }

	[CompilerGenerated]
	private void <Setup>g__OnRaidEnd|57_0() { }

	[CompilerGenerated]
	public void add_OnComplete(Action value) { }

	[CompilerGenerated]
	public void add_OnPrematureEvacuation(Action value) { }

	[CompilerGenerated]
	public void add_OnSampleFrameEnd(Action value) { }

	[CompilerGenerated]
	public void add_OnSampleFrameUpdate(Action value) { }

	private void Awake() { }

	public void Clear() { }

	private void DoComplete() { }

	[CompilerGenerated]
	public float get_CurrentWaypointIndex() { }

	[CompilerGenerated]
	public int get_IdleFrameCount() { }

	public bool get_IsComplete() { }

	[CompilerGenerated]
	public bool get_IsFpsIndependent() { }

	public bool get_IsProcess() { }

	[CompilerGenerated]
	public bool get_WaitStableFPS() { }

	[CompilerGenerated]
	public float get_WaitStableFPSDeltaThreshold() { }

	[CompilerGenerated]
	public int get_WaitStableFPSSampleCount() { }

	private bool IsFpsStabilized() { }

	public void ManualUpdate(float deltaTime) { }

	private void OnDestroy() { }

	[CompilerGenerated]
	public void remove_OnComplete(Action value) { }

	[CompilerGenerated]
	public void remove_OnPrematureEvacuation(Action value) { }

	[CompilerGenerated]
	public void remove_OnSampleFrameEnd(Action value) { }

	[CompilerGenerated]
	public void remove_OnSampleFrameUpdate(Action value) { }

	[CompilerGenerated]
	private void set_CurrentWaypointIndex(float value) { }

	[CompilerGenerated]
	public void set_IdleFrameCount(int value) { }

	[CompilerGenerated]
	public void set_IsFpsIndependent(bool value) { }

	[CompilerGenerated]
	public void set_WaitStableFPS(bool value) { }

	[CompilerGenerated]
	public void set_WaitStableFPSDeltaThreshold(float value) { }

	[CompilerGenerated]
	public void set_WaitStableFPSSampleCount(int value) { }

	public void Setup() { }

}

