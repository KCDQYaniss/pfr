namespace EFT.Vehicle;

public sealed class BTRView : MonoBehaviour
{
	[CompilerGenerated]
	private struct <CloseBtrScreen>d__106 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Player player; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GoIn>d__100 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BTRView <>4__this; //Field offset: 0x20
		public Player player; //Field offset: 0x28
		public bool fast; //Field offset: 0x30
		public BTRSide side; //Field offset: 0x38
		public byte placeId; //Field offset: 0x40
		private CancellationToken <token>5__2; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GoIn>d__101 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BTRView <>4__this; //Field offset: 0x20
		public ObservedPlayerView player; //Field offset: 0x28
		public bool fast; //Field offset: 0x30
		public BTRSide side; //Field offset: 0x38
		public byte placeId; //Field offset: 0x40
		private CancellationToken <token>5__2; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GoInAnimation>d__104 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerAnimator animator; //Field offset: 0x20
		public bool fast; //Field offset: 0x28
		public BTRView <>4__this; //Field offset: 0x30
		public CancellationToken token; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GoOut>d__102 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BTRView <>4__this; //Field offset: 0x20
		public Player player; //Field offset: 0x28
		public bool fast; //Field offset: 0x30
		public BTRSide side; //Field offset: 0x38
		private CancellationToken <token>5__2; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GoOut>d__103 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BTRView <>4__this; //Field offset: 0x20
		public ObservedPlayerView player; //Field offset: 0x28
		public bool fast; //Field offset: 0x30
		public BTRSide side; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GoOutAnimation>d__105 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerAnimator animator; //Field offset: 0x20
		public bool fast; //Field offset: 0x28
		public bool observed; //Field offset: 0x29
		public BTRView <>4__this; //Field offset: 0x30
		public CancellationToken token; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Interaction>d__96 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BTRView <>4__this; //Field offset: 0x20
		public InteractWithBtrPacket packet; //Field offset: 0x28
		public Player player; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartTask>d__75 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BTRView <>4__this; //Field offset: 0x20
		private BtrViewReadyEvent <syncEvent>5__2; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int MAX_SIDES = 2; //Field offset: 0x0
	private const int APPROACH_DURATION_MS = 300; //Field offset: 0x0
	private const float PLAYER_IN_RANGE_DISTANCE_SQR = 64; //Field offset: 0x0
	private const int TIME_TO_SHOW_TIMER_ON_STOP = 10; //Field offset: 0x0
	private const int OBSERVED_SYNC_PERIOD_MS = 300; //Field offset: 0x0
	[SerializeField]
	private BTRSide[] _btrSides; //Field offset: 0x20
	[Range(1, 2)]
	[SerializeField]
	private float _goInLookElevation; //Field offset: 0x28
	[Range(1, 2)]
	[SerializeField]
	private float _goOutLookElevation; //Field offset: 0x2C
	[SerializeField]
	private int _goInDurationMs; //Field offset: 0x30
	[SerializeField]
	private int _goOutDurationMs; //Field offset: 0x34
	[SerializeField]
	private BtrSoundController _soundController; //Field offset: 0x38
	[SerializeField]
	private List _disabledInput; //Field offset: 0x40
	[SerializeField]
	private BallisticColliderComposer _ballisticCollider; //Field offset: 0x48
	private BallisticHitReactor _hitReactor; //Field offset: 0x50
	private readonly Dictionary _playerTokenSources; //Field offset: 0x58
	public BTRTurretView turret; //Field offset: 0x60
	public VehicleSuspension suspension; //Field offset: 0x68
	public Transform PhysicsRoot; //Field offset: 0x70
	private TransformInterpolator _interpolator; //Field offset: 0x78
	[CompilerGenerated]
	private float <CurrentSpeed>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private float <MoveSpeed>k__BackingField; //Field offset: 0x84
	[CompilerGenerated]
	private bool <PlaceUpdated>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private Action OnStateChanged; //Field offset: 0x90
	public float inertiaSuspension; //Field offset: 0x98
	private EBtrState _btrState; //Field offset: 0x9C
	private bool _isPlayerInRange; //Field offset: 0x9D
	private EBtrState _lastBtrStateInRange; //Field offset: 0x9E
	private EPlayerBtrState _lastPlayerStateInRange; //Field offset: 0xA0
	private BTRSide _lastRangedSide; //Field offset: 0xA8
	public EVehicleRouteState RouteState; //Field offset: 0xB0
	public bool enableSyncPosition; //Field offset: 0xB1
	public EVehicleMoveDirection VehicleMoveDirection; //Field offset: 0xB2
	private Vector3 _previousPosition; //Field offset: 0xB4
	public float ActivateSuspensionTime; //Field offset: 0xC0
	private float _fallFactor; //Field offset: 0xC4
	private Vector3 _angleReset; //Field offset: 0xC8
	private Transform _cachedTransform; //Field offset: 0xD8
	private int _timeToEndPause; //Field offset: 0xE0
	private bool _needToNotify; //Field offset: 0xE4
	private Nullable _btrBotId; //Field offset: 0xE8
	private bool _offlineGame; //Field offset: 0xF0
	private bool _viewVisible; //Field offset: 0xF1
	public VehicleWheelsBase leftWheel1; //Field offset: 0xF8
	public VehicleWheelsBase leftWheel2; //Field offset: 0x100
	public VehicleWheelsBase leftWheel3; //Field offset: 0x108
	public VehicleWheelsBase leftWheel4; //Field offset: 0x110
	public VehicleWheelsBase rightWheel1; //Field offset: 0x118
	public VehicleWheelsBase rightWheel2; //Field offset: 0x120
	public VehicleWheelsBase rightWheel3; //Field offset: 0x128
	public VehicleWheelsBase rightWheel4; //Field offset: 0x130
	[CompilerGenerated]
	private Quaternion <TargetRotation>k__BackingField; //Field offset: 0x138
	private Action _unsubscribeOnDispose; //Field offset: 0x148

	public event Action OnStateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public private EBtrState BtrState
	{
		 get { } //Length: 8
		private set { } //Length: 53
	}

	public private float CurrentSpeed
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public bool IsMyPlayerInRange
	{
		 get { } //Length: 8
	}

	public private float MoveSpeed
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public bool PlaceUpdated
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public private Quaternion TargetRotation
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 11
	}

	public private int TimeToEndPause
	{
		 get { } //Length: 7
		private set { } //Length: 133
	}

	public BTRView() { }

	[CompilerGenerated]
	public void add_OnStateChanged(Action value) { }

	[AsyncStateMachine(typeof(<CloseBtrScreen>d__106))]
	private Task CloseBtrScreen(Player player) { }

	private void FixedUpdate() { }

	public EBtrState get_BtrState() { }

	[CompilerGenerated]
	public float get_CurrentSpeed() { }

	public bool get_IsMyPlayerInRange() { }

	[CompilerGenerated]
	public float get_MoveSpeed() { }

	[CompilerGenerated]
	public bool get_PlaceUpdated() { }

	[CompilerGenerated]
	public Quaternion get_TargetRotation() { }

	public int get_TimeToEndPause() { }

	public BTRSide GetBtrSide(byte sideId) { }

	private int GetBusyPlacesCount() { }

	public byte GetSideId(BTRSide side) { }

	[AsyncStateMachine(typeof(<GoIn>d__101))]
	private Task GoIn(ObservedPlayerView player, BTRSide side, byte placeId, bool fast) { }

	[AsyncStateMachine(typeof(<GoIn>d__100))]
	public Task GoIn(Player player, BTRSide side, byte placeId, bool fast) { }

	[AsyncStateMachine(typeof(<GoInAnimation>d__104))]
	private Task GoInAnimation(PlayerAnimator animator, bool fast, bool observed, CancellationToken token) { }

	[AsyncStateMachine(typeof(<GoOut>d__103))]
	private Task GoOut(ObservedPlayerView player, BTRSide side, byte placeId, bool fast) { }

	[AsyncStateMachine(typeof(<GoOut>d__102))]
	public Task GoOut(Player player, BTRSide side, byte placeId, bool fast) { }

	[AsyncStateMachine(typeof(<GoOutAnimation>d__105))]
	private Task GoOutAnimation(PlayerAnimator animator, bool fast, bool observed, CancellationToken token) { }

	private void HideView() { }

	private void InitializeSoundController() { }

	public void InitWheelsData(BTRGlobalSettings btrGlobalSettings) { }

	[AsyncStateMachine(typeof(<Interaction>d__96))]
	public Task Interaction(Player player, InteractWithBtrPacket packet) { }

	public void Interaction(ObservedPlayerView player, BtrGoOutInteractionMessage interaction) { }

	public void Interaction(ObservedPlayerView player, BtrGoInInteractionMessage interaction) { }

	private void LerpMove() { }

	private void OnBeforeRender() { }

	private void OnBtrHitLocal(DamageInfo damageInfo) { }

	private void OnDestroy() { }

	private void OnPlayerInRange(bool inRange) { }

	private void OnSpawnOnThePathEvent(BtrSpawnOnThePathEvent spawnEvent) { }

	public void OpenTransferItemsScreen() { }

	private void PlayerInRange(IPlayer player) { }

	private void PlayerInSideRange(Player player) { }

	private CancellationToken PlayerToken(IPlayer player) { }

	[CompilerGenerated]
	public void remove_OnStateChanged(Action value) { }

	private void RotateWheels() { }

	private void set_BtrState(EBtrState value) { }

	[CompilerGenerated]
	private void set_CurrentSpeed(float value) { }

	[CompilerGenerated]
	private void set_MoveSpeed(float value) { }

	[CompilerGenerated]
	public void set_PlaceUpdated(bool value) { }

	[CompilerGenerated]
	private void set_TargetRotation(Quaternion value) { }

	private void set_TimeToEndPause(int value) { }

	private void SetVehicleTag() { }

	private void ShowView() { }

	private bool[][] SidesInfo() { }

	private bool[][] SidesInfo(BTRSide relativeSide) { }

	private void Start() { }

	[AsyncStateMachine(typeof(<StartTask>d__75))]
	private Task StartTask() { }

	public void SyncViewFromServer(ref ShapshotBTRMessage packet) { }

	private void Update() { }

}

