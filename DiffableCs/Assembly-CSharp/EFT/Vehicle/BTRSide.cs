namespace EFT.Vehicle;

[DefaultExecutionOrder(1)]
public class BTRSide : MonoBehaviour, IInteractive
{
	[CompilerGenerated]
	private struct <>c__DisplayClass51_0
	{
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"player", "place"})]
		public ValueTuple passenger; //Field offset: 0x0

	}

	[CompilerGenerated]
	private struct <ProcessApproach>d__31 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Vector3 start; //Field offset: 0x20
		public Vector3 target; //Field offset: 0x2C
		public Player player; //Field offset: 0x38
		public BTRSide <>4__this; //Field offset: 0x40
		private ApproachState <approachState>5__2; //Field offset: 0x48
		private YieldAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum EState
	{
		Free = 0,
		Busy = 1,
	}

	private const int MAX_PLACES = 2; //Field offset: 0x0
	private const float PLAYER_IN_RANGE_DISTANCE_SQR = 3; //Field offset: 0x0
	private const float MAX_CAMERA_SHAKE = 0.05; //Field offset: 0x0
	[SerializeField]
	private float _interactionDistanceSqr; //Field offset: 0x20
	[SerializeField]
	private Transform _startPoint; //Field offset: 0x28
	[SerializeField]
	private Transform _goInPoint; //Field offset: 0x30
	[SerializeField]
	private Transform _goOutPoint; //Field offset: 0x38
	[SerializeField]
	private BTRPlace[] _btrPlaces; //Field offset: 0x40
	[SerializeField]
	private BTRDoor[] _doors; //Field offset: 0x48
	private EState _state; //Field offset: 0x50
	[CompilerGenerated]
	private Action OnStateChanged; //Field offset: 0x58
	[CompilerGenerated]
	private BTRView <BtrView>k__BackingField; //Field offset: 0x60
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"player", "place"})]
	private ValueTuple _localPassenger; //Field offset: 0x68
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"player", "place"})]
	private readonly List _observedPassengers; //Field offset: 0x78

	public event Action OnStateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public private BTRView BtrView
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private EState State
	{
		 get { } //Length: 5
		private set { } //Length: 82
	}

	public BTRSide() { }

	[CompilerGenerated]
	private void <ApplyLocalPassenger>g__ApplyCameraShake|49_2() { }

	[CompilerGenerated]
	private void <ApplyLocalPassenger>g__ApplyLocalPositionHard|49_0(Vector3 targetPosition) { }

	[CompilerGenerated]
	private void <ApplyLocalPassenger>g__ApplyLocalRotation|49_1() { }

	[CompilerGenerated]
	private void <ApplyObservedPassengers>g__ApplyObservedPositionAndRotationHard|51_0(Vector3 targetPosition, ref <>c__DisplayClass51_0 unnamed_param_1) { }

	[CompilerGenerated]
	public void add_OnStateChanged(Action value) { }

	public void AddPassenger(ObservedPlayerView player, int placeId) { }

	public void AddPassenger(Player player, int placeId) { }

	private void ApplyLocalPassenger() { }

	private void ApplyObservedPassengers() { }

	public void ApplyPlayerRotation(MovementContext movementContext, Vector3 start, Vector3 target) { }

	private void DeinitDoors() { }

	public bool DistanceCheck(Vector3 position) { }

	[CompilerGenerated]
	public BTRView get_BtrView() { }

	public EState get_State() { }

	public InteractWithBtrPacket GetInteractWithBtrPacket(byte placeId, EInteractionType interaction) { }

	public ValueTuple GoInPoints() { }

	public ValueTuple GoOutPoints() { }

	public void Init(BTRView btrView) { }

	private void InitDoors() { }

	public bool IsPlayerInRange(IPlayer player) { }

	private void LateUpdate() { }

	private void OnDestroy() { }

	private Vector3 PlacePosition(int placeId) { }

	private void PlaceUpdated() { }

	[AsyncStateMachine(typeof(<ProcessApproach>d__31))]
	public Task ProcessApproach(Player player, Vector3 start, Vector3 target) { }

	[CompilerGenerated]
	public void remove_OnStateChanged(Action value) { }

	public void RemovePassenger(Player player) { }

	public void RemovePassenger(ObservedPlayerView player) { }

	private void ResetPlayerTransform(IPlayer player) { }

	[CompilerGenerated]
	private void set_BtrView(BTRView value) { }

	private void set_State(EState value) { }

	public bool[] SideInfo() { }

	private void Start() { }

	private void StateChanged(EState previousState, EState newState) { }

	private void SubscribeOnPlaces(bool subscribe) { }

	private void SubscribeOnSideState(bool subscribe) { }

	public void SyncStateFromServer(byte state, byte place0State, byte place1State) { }

	private bool TryGetApproachState(Player player, out ApproachState approachState) { }

	public bool TryGetCachedPlace(out byte placeId) { }

	public bool TryGetPlace(out byte placeId) { }

	private void Update() { }

	private void UseDoor(bool open) { }

}

