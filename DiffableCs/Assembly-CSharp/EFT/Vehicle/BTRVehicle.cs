namespace EFT.Vehicle;

public sealed class BTRVehicle : VehicleBase
{
	[CompilerGenerated]
	private struct <<InteractInternal>g__BusyState|70_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BTRVehicle <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<InteractInternal>g__BusyState|70_1>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BTRVehicle <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int BTR_DOOR_BUSY_DURATION_MS = 2000; //Field offset: 0x0
	private const float ENEMY_PLAYERS_NEAR_BTR_RANGE_SQR = 900; //Field offset: 0x0
	[SerializeField]
	private float _explosionDistance; //Field offset: 0x1B8
	public float ExplosionDistanceSqr; //Field offset: 0x1BC
	public Transform bodyViewRoot; //Field offset: 0x1C0
	public BTRTurretServer BTRTurret; //Field offset: 0x1C8
	public Vector3 botPosition; //Field offset: 0x1D0
	[Header("SLOTS INFO")]
	public byte LeftSideState; //Field offset: 0x1DC
	public byte LeftSlot0State; //Field offset: 0x1DD
	public byte LeftSlot1State; //Field offset: 0x1DE
	public byte RightSideState; //Field offset: 0x1DF
	public byte RightSlot0State; //Field offset: 0x1E0
	public byte RightSlot1State; //Field offset: 0x1E1
	[SerializeField]
	private List _passengers; //Field offset: 0x1E8
	private readonly List _blackListPlayers; //Field offset: 0x1F0
	private readonly List _blackListGroups; //Field offset: 0x1F8
	private readonly List _goOutList; //Field offset: 0x200
	[SerializeField]
	private Transform _leftSlot0Point; //Field offset: 0x208
	[SerializeField]
	private Transform _leftSlot1Point; //Field offset: 0x210
	[SerializeField]
	private Transform _rightSlot0Point; //Field offset: 0x218
	[SerializeField]
	private Transform _rightSlot1Point; //Field offset: 0x220
	[Header("BOX KILLER")]
	[SerializeField]
	private BoxCollider _killCollider; //Field offset: 0x228
	[SerializeField]
	private LayerMask _playerLayer; //Field offset: 0x230
	private OverlapBoxCollider _overlapBoxCollider; //Field offset: 0x238
	[CompilerGenerated]
	private Action OnPlayerAdded; //Field offset: 0x240
	[CompilerGenerated]
	private Action OnPlayerRemoved; //Field offset: 0x248
	[CompilerGenerated]
	private Action OnHitFromPlayer; //Field offset: 0x250
	[CompilerGenerated]
	private Action GoInEvent; //Field offset: 0x258
	[CompilerGenerated]
	private Action GoOutEvent; //Field offset: 0x260
	[SerializeField]
	private string _offlineLayerMaskName; //Field offset: 0x268
	[SerializeField]
	private List _ballisticColliders; //Field offset: 0x270

	public event Action GoInEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action GoOutEvent
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event Action OnHitFromPlayer
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnPlayerAdded
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnPlayerRemoved
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public IReadOnlyList Passengers
	{
		 get { } //Length: 8
	}

	public BTRVehicle() { }

	[AsyncStateMachine(typeof(<<InteractInternal>g__BusyState|70_0>d))]
	[CompilerGenerated]
	private Task <InteractInternal>g__BusyState|70_0() { }

	[AsyncStateMachine(typeof(<<InteractInternal>g__BusyState|70_1>d))]
	[CompilerGenerated]
	private Task <InteractInternal>g__BusyState|70_1() { }

	[CompilerGenerated]
	public void add_GoInEvent(Action value) { }

	[CompilerGenerated]
	public void add_GoOutEvent(Action value) { }

	[CompilerGenerated]
	public void add_OnHitFromPlayer(Action value) { }

	[CompilerGenerated]
	public void add_OnPlayerAdded(Action value) { }

	[CompilerGenerated]
	public void add_OnPlayerRemoved(Action value) { }

	private void AddPassenger(Player player, InteractWithBtrPacket packet) { }

	public void AddPlayerToBlackList(Player player) { }

	private void AddToGoOutList(BTRPassenger passenger) { }

	private void ApplyHitFromBtr(IPlayer player) { }

	private void ApplyPoint(BTRPassenger passenger) { }

	private bool CanInteract(IPlayer player) { }

	public void ClearBlacklist() { }

	private void DisableRender() { }

	public void EveryoneGoOut() { }

	protected virtual void ExtractPassengers() { }

	public IReadOnlyList get_Passengers() { }

	private DamageInfo GetBtrDamage(IPlayer player, BodyPartCollider partCollider) { }

	public Transform GetPoint(BTRPassenger passenger) { }

	public void GoOutFromServer(Player player) { }

	public virtual void HitFromPlayer(Player player) { }

	private void HitPedestrian(Collider targetCollider) { }

	public void Interact(Player player, InteractWithBtrPacket packet) { }

	private EBtrInteractionStatus InteractInternal(Player player, InteractWithBtrPacket packet) { }

	private bool IsAnyEnemyNearBtrInRange() { }

	private bool IsAnyPassengerInGroupWithAggressor() { }

	protected virtual bool IsDoorsClosed() { }

	public bool IsInBlackList(Player player) { }

	public bool IsPassenger(IPlayer player, out BTRPassenger passengerInfo) { }

	protected virtual void OnIncomingToDestination(string pathID) { }

	private void OnValidate() { }

	private void ProcessGoOutList() { }

	private EBtrInteractionStatus ProcessSlot(Player player, InteractWithBtrPacket packet, ref byte slot) { }

	private void ProcessSlot(byte slot, ref byte slot0, ref byte slot1, byte state) { }

	[CompilerGenerated]
	public void remove_GoInEvent(Action value) { }

	[CompilerGenerated]
	public void remove_GoOutEvent(Action value) { }

	[CompilerGenerated]
	public void remove_OnHitFromPlayer(Action value) { }

	[CompilerGenerated]
	public void remove_OnPlayerAdded(Action value) { }

	[CompilerGenerated]
	public void remove_OnPlayerRemoved(Action value) { }

	public void RemoveFromBlackList(Player player) { }

	private void RemoveFromGoOutList(BTRPassenger passenger) { }

	private void RemovePassenger(Player player) { }

	private void SendNotificationToClient(Player player, EBtrInteractionStatus status) { }

	private void SetOfflineLayerMask() { }

	private void SetPlayerFlags(Player player, bool flag) { }

	private void SetSlotWoInteraction(BTRPassenger passenger, byte state) { }

	private void SetVehicleTag() { }

	protected virtual void Start() { }

	private EBtrInteractionStatus TryPassengerGoOut(BTRPassenger passenger) { }

	protected virtual void Update() { }

}

