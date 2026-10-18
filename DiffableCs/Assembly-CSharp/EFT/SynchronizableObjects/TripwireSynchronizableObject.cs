namespace EFT.SynchronizableObjects;

public sealed class TripwireSynchronizableObject : SynchronizableObject
{
	[CompilerGenerated]
	private struct <GrenadeInWorldDestroyed>d__77 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TripwireSynchronizableObject <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public static readonly Vector3 VALIDATION_OFFSET; //Field offset: 0x0
	public const float COLLISION_CAPSULE_RADIUS_OFFSET = 0.06; //Field offset: 0x0
	public const float COLLISION_CAPSULE_RADIUS = 0.03; //Field offset: 0x0
	public const float MAX_HEIGHT_DIFFERENCE = 0.2; //Field offset: 0x0
	public const float LINE_WIDTH = 0.003; //Field offset: 0x0
	private static readonly Vector3 DROP_DIRECTION_VECTOR; //Field offset: 0xC
	private static RaycastHit _castHit; //Field offset: 0x18
	[SerializeField]
	[Space]
	private GameObject _firstStake; //Field offset: 0x88
	[SerializeField]
	private GameObject _firstStakeWireEnd; //Field offset: 0x90
	[SerializeField]
	private GameObject _secondStake; //Field offset: 0x98
	[SerializeField]
	private Transform _firstStakePivot; //Field offset: 0xA0
	[SerializeField]
	private TripwireProceduralMesh _line; //Field offset: 0xA8
	[SerializeField]
	private CapsuleCollider _collisionCollider; //Field offset: 0xB0
	[SerializeField]
	private CapsuleCollider _ballisticCapsule; //Field offset: 0xB8
	[SerializeField]
	private SphereCollider _interactionCollider; //Field offset: 0xC0
	[SerializeField]
	private BallisticCollider _ballisticCollider; //Field offset: 0xC8
	private Grenade _grenadeInWorld; //Field offset: 0xD0
	private Transform _secondStakePivot; //Field offset: 0xD8
	private bool _grenadeActivated; //Field offset: 0xE0
	private ETripwireState _tripwireState; //Field offset: 0xE4
	private ThrowWeap _originalGrenade; //Field offset: 0xE8
	private TripwireVisual _grenadeVisual; //Field offset: 0xF0
	private GrenadePrefab _grenadeComponent; //Field offset: 0xF8
	private IEnumerator _inertCoroutine; //Field offset: 0x100
	private ITripwireSoundController _soundController; //Field offset: 0x108
	private GrenadeEmission _grenadeEmission; //Field offset: 0x110
	[CompilerGenerated]
	private MongoID <GrenadeTemplateId>k__BackingField; //Field offset: 0x118
	[CompilerGenerated]
	private MongoID <GrenadeItemId>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	private int <PlacerRaidId>k__BackingField; //Field offset: 0x148
	[CompilerGenerated]
	private Vector3 <FromPosition>k__BackingField; //Field offset: 0x14C
	[CompilerGenerated]
	private Vector3 <ToPosition>k__BackingField; //Field offset: 0x158
	[CompilerGenerated]
	private Action OnDestroyed; //Field offset: 0x168
	[CompilerGenerated]
	private Action OnStateChanged; //Field offset: 0x170

	public event Action OnDestroyed
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnStateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public Vector3 FromPosition
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		 set { } //Length: 22
	}

	private ISyncEnvironment GameWorld
	{
		private get { } //Length: 46
	}

	public MongoID GrenadeItemId
	{
		[CompilerGenerated]
		 get { } //Length: 27
		[CompilerGenerated]
		 set { } //Length: 98
	}

	public MongoID GrenadeTemplateId
	{
		[CompilerGenerated]
		 get { } //Length: 27
		[CompilerGenerated]
		 set { } //Length: 98
	}

	public int NetId
	{
		 get { } //Length: 238
	}

	public int PlacerRaidId
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public Vector3 ToPosition
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		 set { } //Length: 22
	}

	private TripwiresGlobalSettings TripwiresSettings
	{
		private get { } //Length: 205
	}

	public ETripwireState TripwireState
	{
		 get { } //Length: 7
		 set { } //Length: 145
	}

	private static TripwireSynchronizableObject() { }

	public TripwireSynchronizableObject() { }

	private void ActivateGrenade() { }

	[CompilerGenerated]
	public void add_OnDestroyed(Action value) { }

	[CompilerGenerated]
	public void add_OnStateChanged(Action value) { }

	public virtual void Deserialize(NetworkReader reader) { }

	private void Destroyed() { }

	public void DisableTripwire() { }

	private void DisableTripwireByTimer() { }

	[CompilerGenerated]
	public Vector3 get_FromPosition() { }

	private ISyncEnvironment get_GameWorld() { }

	[CompilerGenerated]
	public MongoID get_GrenadeItemId() { }

	[CompilerGenerated]
	public MongoID get_GrenadeTemplateId() { }

	public int get_NetId() { }

	[CompilerGenerated]
	public int get_PlacerRaidId() { }

	[CompilerGenerated]
	public Vector3 get_ToPosition() { }

	private TripwiresGlobalSettings get_TripwiresSettings() { }

	public ETripwireState get_TripwireState() { }

	[AsyncStateMachine(typeof(<GrenadeInWorldDestroyed>d__77))]
	private void GrenadeInWorldDestroyed(Throwable _) { }

	private void HandleCook(ThrowWeap item, Transform grenadeTransform) { }

	private void HideContent() { }

	private void OnBallisticHit(DamageInfo _) { }

	private void OnLootGrenadeDestroyed(IKillable killable) { }

	[CompilerGenerated]
	public void remove_OnDestroyed(Action value) { }

	[CompilerGenerated]
	public void remove_OnStateChanged(Action value) { }

	public void Reset() { }

	[CompilerGenerated]
	public void set_FromPosition(Vector3 value) { }

	[CompilerGenerated]
	public void set_GrenadeItemId(MongoID value) { }

	[CompilerGenerated]
	public void set_GrenadeTemplateId(MongoID value) { }

	[CompilerGenerated]
	public void set_PlacerRaidId(int value) { }

	[CompilerGenerated]
	public void set_ToPosition(Vector3 value) { }

	public void set_TripwireState(ETripwireState value) { }

	public void SetGrenadeState(bool activate) { }

	public void SetupGrenade(ThrowWeap throwWeap, int playerRaidId, Vector3 fromPosition, Vector3 toPosition) { }

	private void SetupSoundController(int playerRaidId) { }

	private void SetupStakes(Vector3 fromPosition, Vector3 toPosition) { }

	private void SpawnLootGrenade() { }

	public void StartExplosion() { }

	private void StopInertTimer() { }

	public void TriggerTripwire() { }

	public static bool ValidateTripwirePosition(Vector3 playerPosition, Vector3 firstPosition, Vector3 secondPosition, bool isAI, bool withLogs, bool useLayerWithoutPlayer = false) { }

	public static bool ValidateTripwirePositionAI(Vector3 playerPosition, Vector3 firstPosition, Vector3 secondPosition, bool withLogs, bool useLayerWithoutPlayer = false) { }

	public static bool ValidateTripwirePositionPlayer(Vector3 playerPosition, Vector3 firstPosition, Vector3 secondPosition) { }

}

