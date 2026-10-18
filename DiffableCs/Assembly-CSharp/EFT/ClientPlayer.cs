namespace EFT;

[UsedImplicitly]
public class ClientPlayer : NetworkPlayer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__212_0; //Field offset: 0x8
		public static Func <>9__213_0; //Field offset: 0x10
		public static Func <>9__213_1; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal LightsState <SendHeadlightsPacket>b__212_0(TacticalComboVisualController x) { }

		internal Item <SendWeaponLightPacket>b__213_0(Slot x) { }

		internal LightsState <SendWeaponLightPacket>b__213_1(LightComponent x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__3`1
	{
		public static readonly <>c__3 <>9; //Field offset: 0x0
		public static Func <>9__3_0; //Field offset: 0x0
		public static Func <>9__3_1; //Field offset: 0x0

		private static <>c__3`1() { }

		public <>c__3`1() { }

		internal float <Create>b__3_0() { }

		internal float <Create>b__3_1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass124_0
	{
		public byte[] profileZip; //Field offset: 0x10
		public Profile profile; //Field offset: 0x18

		public <>c__DisplayClass124_0() { }

		internal void <CompleteDeserializeInitialData>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass124_1
	{
		public string pointName; //Field offset: 0x10

		public <>c__DisplayClass124_1() { }

		internal bool <CompleteDeserializeInitialData>b__1(SecretExfiltrationPoint x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass137_0
	{
		public ClientPlayer <>4__this; //Field offset: 0x10
		public LootableContainer container; //Field offset: 0x18

		public <>c__DisplayClass137_0() { }

		internal void <TryInteractionCallback>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass234_0
	{
		public Callback callback; //Field offset: 0x10

		public <>c__DisplayClass234_0() { }

		internal void <Interact>b__0(bool succeed) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass236_0
	{
		public ClientPlayer <>4__this; //Field offset: 0x10
		public bool withNetwork; //Field offset: 0x18
		public Process process; //Field offset: 0x20
		public Action confirmCallback; //Field offset: 0x28

		public <>c__DisplayClass236_0() { }

		internal EmptyHandsController <Proceed>b__0() { }

		internal void <Proceed>b__1() { }

		internal void <Proceed>b__2(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass237_0
	{
		public ClientPlayer <>4__this; //Field offset: 0x10
		public Weapon weapon; //Field offset: 0x18
		public Process process; //Field offset: 0x20
		public Action confirmCallback; //Field offset: 0x28

		public <>c__DisplayClass237_0() { }

		internal FirearmController <Proceed>b__0() { }

		internal void <Proceed>b__1() { }

		internal void <Proceed>b__2(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass238_0
	{
		public ClientPlayer <>4__this; //Field offset: 0x10
		public ThrowWeap throwWeap; //Field offset: 0x18
		public Process process; //Field offset: 0x20
		public Action confirmCallback; //Field offset: 0x28

		public <>c__DisplayClass238_0() { }

		internal GrenadeHandsController <Proceed>b__0() { }

		internal void <Proceed>b__1() { }

		internal void <Proceed>b__2(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass239_0
	{
		public ClientPlayer <>4__this; //Field offset: 0x10
		public Meds meds; //Field offset: 0x18
		public OneAndList bodyParts; //Field offset: 0x20
		public int animationVariant; //Field offset: 0x30
		public Process process; //Field offset: 0x38
		public Action confirmCallback; //Field offset: 0x40

		public <>c__DisplayClass239_0() { }

		internal MedsController <Proceed>b__0() { }

		internal void <Proceed>b__1() { }

		internal void <Proceed>b__2(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass240_0
	{
		public ClientPlayer <>4__this; //Field offset: 0x10
		public RecorderItem recorder; //Field offset: 0x18
		public RecorderHandler recorderHandler; //Field offset: 0x20
		public Process process; //Field offset: 0x28
		public Action confirmCallback; //Field offset: 0x30

		public <>c__DisplayClass240_0() { }

		internal RecorderHandsController <Proceed>b__0() { }

		internal void <Proceed>b__1() { }

		internal void <Proceed>b__2(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass241_0
	{
		public ClientPlayer <>4__this; //Field offset: 0x10
		public FoodDrink foodDrink; //Field offset: 0x18
		public OneAndList bodyParts; //Field offset: 0x20
		public float amount; //Field offset: 0x30
		public int animationVariant; //Field offset: 0x34
		public Process process; //Field offset: 0x38
		public Action confirmCallback; //Field offset: 0x40

		public <>c__DisplayClass241_0() { }

		internal MedsController <Proceed>b__0() { }

		internal void <Proceed>b__1() { }

		internal void <Proceed>b__2(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass242_0
	{
		public ClientPlayer <>4__this; //Field offset: 0x10
		public KnifeComponent knife; //Field offset: 0x18
		public Process process; //Field offset: 0x20
		public Action confirmCallback; //Field offset: 0x28

		public <>c__DisplayClass242_0() { }

		internal KnifeController <Proceed>b__0() { }

		internal void <Proceed>b__1() { }

		internal void <Proceed>b__2(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass243_0`1
	{
		public ClientPlayer <>4__this; //Field offset: 0x0
		public Item item; //Field offset: 0x0
		public Process process; //Field offset: 0x0
		public Action confirmCallback; //Field offset: 0x0

		public <>c__DisplayClass243_0`1() { }

		internal T <Proceed>b__0() { }

		internal void <Proceed>b__1() { }

		internal void <Proceed>b__2(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass244_0
	{
		public ClientPlayer <>4__this; //Field offset: 0x10
		public ThrowWeap throwWeap; //Field offset: 0x18
		public Process process; //Field offset: 0x20
		public Action confirmCallback; //Field offset: 0x28

		public <>c__DisplayClass244_0() { }

		internal QuickGrenadeThrowHandsController <Proceed>b__0() { }

		internal void <Proceed>b__1() { }

		internal void <Proceed>b__2(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass245_0
	{
		public ClientPlayer <>4__this; //Field offset: 0x10
		public KnifeComponent knife; //Field offset: 0x18
		public Process process; //Field offset: 0x20
		public Action confirmCallback; //Field offset: 0x28

		public <>c__DisplayClass245_0() { }

		internal QuickKnifeKickController <Proceed>b__0() { }

		internal void <Proceed>b__1() { }

		internal void <Proceed>b__2(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass246_0
	{
		public ClientPlayer <>4__this; //Field offset: 0x10
		public Item item; //Field offset: 0x18
		public Process process; //Field offset: 0x20
		public Action confirmCallback; //Field offset: 0x28

		public <>c__DisplayClass246_0() { }

		internal QuickUseItemController <Proceed>b__0() { }

		internal void <Proceed>b__1() { }

		internal void <Proceed>b__2(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass248_0
	{
		public uint id; //Field offset: 0x10
		public Action confirmAction; //Field offset: 0x18

		public <>c__DisplayClass248_0() { }

		internal void <SetConfirmCallback>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0`1
	{
		public TClientPlayer player; //Field offset: 0x0

		public <>c__DisplayClass3_0`1() { }

		internal void <Create>b__2(BaseReconnectEvent reconnectEvent) { }

		internal void <Create>b__3(SendEndCutsceneOnServerEvent tpEvent) { }

		internal void <Create>b__4(SyncClientEventState createPlayerEvent) { }

		internal void <Create>b__5(SeasonsReconnectEvent event) { }

		internal void <Create>b__6(CutsceneForMyPlayerStartedEvent tpEvent) { }

	}

	[CompilerGenerated]
	private struct <CompleteDeserializeInitialData>d__124 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public byte[] profileZip; //Field offset: 0x20
		public NetworkReader reader; //Field offset: 0x28
		public bool isAlive; //Field offset: 0x30
		public ClientPlayer <>4__this; //Field offset: 0x38
		public Callback callback; //Field offset: 0x40
		private <>c__DisplayClass124_0 <>8__1; //Field offset: 0x48
		public Quaternion rotation; //Field offset: 0x50
		public bool isInPronePose; //Field offset: 0x60
		public float poseLevel; //Field offset: 0x64
		public EVoipState voipState; //Field offset: 0x68
		public bool isInBufferZone; //Field offset: 0x69
		public int bufferZoneUsageTimeLeft; //Field offset: 0x6C
		public bool leftStance; //Field offset: 0x70
		private byte[] <healthState>5__2; //Field offset: 0x78
		private string <itemId>5__3; //Field offset: 0x80
		private EHandsControllerType <type>5__4; //Field offset: 0x88
		private bool <isInSpawnOperation>5__5; //Field offset: 0x8C
		private bool <isStationaryWeapon>5__6; //Field offset: 0x8D
		private Vector2 <stationaryRotation>5__7; //Field offset: 0x90
		private Quaternion <playerStationaryRot>5__8; //Field offset: 0x98
		private int <animationVariant>5__9; //Field offset: 0xA8
		private MongoID <firstId>5__10; //Field offset: 0xB0
		private ushort <firstOperationId>5__11; //Field offset: 0xC8
		private bool <isInBtr>5__12; //Field offset: 0xCA
		private InteractWithBtrPacket <btrPacket>5__13; //Field offset: 0xCC
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"pointId", "occupant"})]
		private List <raidDialogEntryReconnectState>5__14; //Field offset: 0xD8
		private Dictionary <globalSaveStates>5__15; //Field offset: 0xE0
		private TaskAwaiter <>u__1; //Field offset: 0xE8

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ContinueChunkedProfileSpawn>d__123 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientPlayer <>4__this; //Field offset: 0x20
		public ChunkedProfileSpawnParameters parameters; //Field offset: 0x28
		public byte[] compressedProfile; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DeserializeInitialData>d__122 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public NetworkReader reader; //Field offset: 0x20
		public ClientPlayer <>4__this; //Field offset: 0x28
		public Callback callback; //Field offset: 0x30
		public bool isAlive; //Field offset: 0x38
		public Quaternion rotation; //Field offset: 0x3C
		public bool isInPronePose; //Field offset: 0x4C
		public float poseLevel; //Field offset: 0x50
		public EVoipState voipState; //Field offset: 0x54
		public bool isInBufferZone; //Field offset: 0x55
		public int bufferZoneUsageTimeLeft; //Field offset: 0x58
		public bool leftStance; //Field offset: 0x5C
		private TaskAwaiter <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnDeserializeInitialState>d__125 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientPlayer <>4__this; //Field offset: 0x20
		public Profile profile; //Field offset: 0x28
		public MongoID firstId; //Field offset: 0x30
		public ushort firstOperationId; //Field offset: 0x48
		public Dictionary globalSaveStates; //Field offset: 0x50
		public byte[] healthState; //Field offset: 0x58
		public Quaternion rotation; //Field offset: 0x60
		public EVoipState voipState; //Field offset: 0x70
		public bool leftStance; //Field offset: 0x71
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"pointId", "occupant"})]
		public List raidDialogReconnectState; //Field offset: 0x78
		public bool isAlive; //Field offset: 0x80
		public EHandsControllerType type; //Field offset: 0x84
		public string itemId; //Field offset: 0x88
		public bool isStationaryWeapon; //Field offset: 0x90
		public int animationVariant; //Field offset: 0x94
		public Callback callback; //Field offset: 0x98
		public Vector2 stationaryRotation; //Field offset: 0xA0
		public Quaternion playerStationaryRotation; //Field offset: 0xA8
		public bool isInSpawnOperation; //Field offset: 0xB8
		public float poseLevel; //Field offset: 0xBC
		public bool isInPronePose; //Field offset: 0xC0
		public bool isInBufferZone; //Field offset: 0xC1
		public int bufferZoneUsageTimeLeft; //Field offset: 0xC4
		public bool isInBtr; //Field offset: 0xC8
		public InteractWithBtrPacket btrPacket; //Field offset: 0xCC
		private ClientPlayerInventoryController <inventoryController>5__2; //Field offset: 0xD8
		private ClientNetworkQuestLocationObjectsController <questLocationObjectsController>5__3; //Field offset: 0xE0
		private TaskAwaiter <>u__1; //Field offset: 0xE8
		private TaskAwaiter <>u__2; //Field offset: 0xF0
		private TaskAwaiter <>u__3; //Field offset: 0xF8
		private TaskAwaiter <>u__4; //Field offset: 0x100
		private TaskAwaiter <>u__5; //Field offset: 0x108
		private TaskAwaiter <>u__6; //Field offset: 0x110
		private Item <item>5__4; //Field offset: 0x118
		private TaskAwaiter <>u__7; //Field offset: 0x120
		private TaskAwaiter <>u__8; //Field offset: 0x128
		private TaskAwaiter <>u__9; //Field offset: 0x130
		private TaskAwaiter <>u__10; //Field offset: 0x138
		private TaskAwaiter <>u__11; //Field offset: 0x140

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnGameSessionEnd>d__194 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientPlayer <>4__this; //Field offset: 0x20
		public ExitStatus exitStatus; //Field offset: 0x28
		public float pastTime; //Field offset: 0x2C
		public string locationId; //Field offset: 0x30
		public string exitName; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ProcessReconnectInBtr>d__200 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Task onCurrentHandsControllerSpawned; //Field offset: 0x20
		public InteractWithBtrPacket interactionBtrPacket; //Field offset: 0x28
		public ClientPlayer <>4__this; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40
		private YieldAwaiter <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public sealed class ChunkedProfileSpawnParameters
	{
		public ClientPlayer Player; //Field offset: 0x10
		public byte[] MessageTail; //Field offset: 0x18
		public Callback Callback; //Field offset: 0x20
		public bool IsAlive; //Field offset: 0x28
		public Quaternion Rotation; //Field offset: 0x2C
		public bool IsInPronePose; //Field offset: 0x3C
		public float PoseLevel; //Field offset: 0x40
		public EVoipState VoipState; //Field offset: 0x44
		public bool IsInBufferZone; //Field offset: 0x45
		public int BufferZoneUsageTimeLeft; //Field offset: 0x48
		public bool LeftStance; //Field offset: 0x4C

		public ChunkedProfileSpawnParameters() { }

	}

	public sealed class ClientPlayerInventoryController : PlayerOwnerInventoryController, IOperationHandler
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_0
		{
			public IResult operationResult; //Field offset: 0x10
			public OperationState lastServerResult; //Field offset: 0x18
			public AbstractOperation operation; //Field offset: 0x30
			public ClientPlayerInventoryController <>4__this; //Field offset: 0x38
			public Callback callback; //Field offset: 0x40

			public <>c__DisplayClass12_0() { }

			internal void <Execute>b__2(IResult executeResult) { }

			internal void <Execute>g__ProcessServerCallback|1(OperationState serverState) { }

			internal void <Execute>g__TryFinalizeOperation|0(IResult result) { }

		}

		private readonly ClientPlayer _clientPlayer; //Field offset: 0x1B0
		[CompilerGenerated]
		private readonly IPlayerSearchController <PlayerSearchController>k__BackingField; //Field offset: 0x1B8

		public virtual IPlayerSearchController PlayerSearchController
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		internal ClientPlayerInventoryController(ClientPlayer player, Profile profile, MongoID firstId, ushort firstOperationId) { }

		private void CheckDesync(int inventoryHashSum, bool badBeforeExecuting, AbstractOperation operation) { }

		internal virtual SearchContentOperation CreateSearchOperation(SearchableItem item) { }

		private override OperationCreationResult EFT.InventoryLogic.IOperationHandler.CreateOperationFromDescriptor(InventoryOperationDescriptor descriptor) { }

		internal virtual void Execute(AbstractOperation operation, Callback callback) { }

		public virtual void ExecuteStationaryOperation(StationaryWeapon stationaryWeapon, Callback callback = null) { }

		[CompilerGenerated]
		public virtual IPlayerSearchController get_PlayerSearchController() { }

		public virtual void GetTraderServicesDataFromServer(string traderId) { }

		protected virtual void NotifyMagazineChecked(string name) { }

		private uint SetConfirmCallback(T operation, Action callback) { }

		public virtual void StopRecorderOperation(bool immediate, out Task completionTask) { }

		internal void StopSearchOperation(SearchContentOperation operation) { }

	}

	internal sealed class DataSender : IClientPlayerDataSender
	{
		internal sealed class DataSentDelegate : MulticastDelegate
		{

			public DataSentDelegate(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(ClientPlayer player, int bytes, ulong totalBytes, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(ClientPlayer player, int bytes, ulong totalBytes) { }

		}

		private readonly ClientPlayer _player; //Field offset: 0x10
		private readonly SendDelegate _sendDelegate; //Field offset: 0x18
		private readonly IBitWriterStream _writerStream; //Field offset: 0x20
		private Client2ServerPacket _previousCriticalPacket; //Field offset: 0x28
		private readonly LoopedQueue _packetsQueue; //Field offset: 0x648
		private ulong _bytesWritten; //Field offset: 0x650
		private readonly float _sendRateLimitSeconds; //Field offset: 0x658
		private float _timeTillNextPacketsDispatch; //Field offset: 0x65C
		private float _deltaTimeFromLastCriticalPacket; //Field offset: 0x660
		private int _nonCriticalPacketsCount; //Field offset: 0x664
		[CompilerGenerated]
		private DataSentDelegate _dataSentEvent; //Field offset: 0x668
		public bool PreventDispatch; //Field offset: 0x670
		private bool _hasCriticalDataToSend; //Field offset: 0x671

		private event DataSentDelegate _dataSentEvent
		{
			[CompilerGenerated]
			private add { } //Length: 251
			[CompilerGenerated]
			private remove { } //Length: 251
		}

		private override event DataSentDelegate EFT.ClientPlayer.IClientPlayerDataSender.DataSentEvent
		{
			private add { } //Length: 251
			private remove { } //Length: 251
		}

		private override ulong EFT.ClientPlayer.IClientPlayerDataSender.BytesWritten
		{
			private get { } //Length: 8
		}

		internal DataSender(ClientPlayer player, SendDelegate sendDelegate, int sendRateFramesLimit) { }

		[CompilerGenerated]
		private void add__dataSentEvent(DataSentDelegate value) { }

		private override void EFT.ClientPlayer.IClientPlayerDataSender.add_DataSentEvent(DataSentDelegate value) { }

		private override void EFT.ClientPlayer.IClientPlayerDataSender.Dispatch() { }

		private override ulong EFT.ClientPlayer.IClientPlayerDataSender.get_BytesWritten() { }

		private override void EFT.ClientPlayer.IClientPlayerDataSender.remove_DataSentEvent(DataSentDelegate value) { }

		private override void EFT.ClientPlayer.IClientPlayerDataSender.Send(ref Client2ServerPacket client2ServerPacket, float deltaTime, float time, float lastServerTime) { }

		[CompilerGenerated]
		private void remove__dataSentEvent(DataSentDelegate value) { }

		private void SendMovementShort(float lastServerTime) { }

	}

	private struct EndedCutsceneInfoForServer
	{
		public string calledOnSceneName; //Field offset: 0x0
		public int cutseneID; //Field offset: 0x8

	}

	internal interface IClientPlayerDataSender
	{

		public event DataSentDelegate DataSentEvent
		{
			[CompilerGenerated]
			 add { } //Length: 0
			[CompilerGenerated]
			 remove { } //Length: 0
		}

		public ulong BytesWritten
		{
			 get { } //Length: 0
		}

		[CompilerGenerated]
		public void add_DataSentEvent(DataSentDelegate value) { }

		public void Dispatch() { }

		public ulong get_BytesWritten() { }

		[CompilerGenerated]
		public void remove_DataSentEvent(DataSentDelegate value) { }

		public void Send(ref Client2ServerPacket client2ServerPacket, float deltaTime, float time, float lastServerTime) { }

	}

	[IsReadOnly]
	private struct OperationState
	{
		public readonly int InventoryHash; //Field offset: 0x0
		public readonly bool BadBeforeExecution; //Field offset: 0x4
		public readonly EOperationStatus Status; //Field offset: 0x8
		public readonly string Error; //Field offset: 0x10

		public OperationState(int inventoryHash, bool badBeforeExecution, EOperationStatus status, string error) { }

	}

	private sealed class PlayerVoipController : IPlayerVoipController, IDisposable
	{
		private abstract class AbstractState
		{
			[CompilerGenerated]
			private PlayerVoipController <Controller>k__BackingField; //Field offset: 0x10

			internal PlayerVoipController Controller
			{
				[CompilerGenerated]
				internal get { } //Length: 5
				[CompilerGenerated]
				internal set { } //Length: 82
			}

			protected DissonanceComms DissonanceComms
			{
				 get { } //Length: 39
			}

			internal bool IsCurrent
			{
				internal get { } //Length: 27
			}

			internal abstract EVoipControllerStatus Status
			{
				internal get { } //Length: 0
			}

			internal TalksRegistry TalksRegistry
			{
				internal get { } //Length: 27
			}

			internal abstract TimeSpan TimeToNextStatus
			{
				internal get { } //Length: 0
			}

			protected AbstractState() { }

			internal override void DeviceChangedHandler() { }

			[CompilerGenerated]
			internal PlayerVoipController get_Controller() { }

			protected DissonanceComms get_DissonanceComms() { }

			internal bool get_IsCurrent() { }

			internal abstract EVoipControllerStatus get_Status() { }

			internal TalksRegistry get_TalksRegistry() { }

			internal abstract TimeSpan get_TimeToNextStatus() { }

			internal override EVoipControllerStatus Run() { }

			[CompilerGenerated]
			internal void set_Controller(PlayerVoipController value) { }

			internal override EVoipControllerStatus StopTalk() { }

			internal override EVoipControllerStatus ToggleTalk() { }

			internal override void Update() { }

			internal override void VoipDisabled() { }

			internal override void VoipEnabled() { }

		}

		private abstract class AbstractStateMuted : AbstractState
		{

			protected AbstractStateMuted() { }

			internal virtual EVoipControllerStatus Run() { }

			internal virtual void Update() { }

			internal virtual void VoipEnabled() { }

		}

		private abstract class AbstractStateRestricted : AbstractStateMuted
		{
			protected Restriction Restriction; //Field offset: 0x18

			internal virtual TimeSpan TimeToNextStatus
			{
				internal get { } //Length: 11
			}

			protected AbstractStateRestricted() { }

			internal virtual TimeSpan get_TimeToNextStatus() { }

			internal virtual void Update() { }

		}

		[IsReadOnly]
		public struct Restriction
		{
			[CompilerGenerated]
			private readonly DateTime <DateTime>k__BackingField; //Field offset: 0x0
			[CompilerGenerated]
			private readonly DateTime <Created>k__BackingField; //Field offset: 0x8

			internal bool Completed
			{
				internal get { } //Length: 105
			}

			internal DateTime Created
			{
				[CompilerGenerated]
				internal get { } //Length: 5
			}

			internal DateTime DateTime
			{
				[CompilerGenerated]
				internal get { } //Length: 4
			}

			internal TimeSpan TimeToNextStatus
			{
				internal get { } //Length: 248
			}

			internal Restriction(in DateTime dateTime, in DateTime created) { }

			internal Restriction(in DateTime dateTime) { }

			internal Restriction(in TimeSpan timeSpan) { }

			internal bool get_Completed() { }

			[CompilerGenerated]
			internal DateTime get_Created() { }

			[CompilerGenerated]
			internal DateTime get_DateTime() { }

			internal TimeSpan get_TimeToNextStatus() { }

			internal void LogIsCompleted() { }

		}

		private sealed class StateBanned : AbstractStateRestricted
		{

			internal bool BanCompleted
			{
				internal get { } //Length: 11
			}

			internal virtual EVoipControllerStatus Status
			{
				internal get { } //Length: 6
			}

			internal virtual TimeSpan TimeToNextStatus
			{
				internal get { } //Length: 11
			}

			public StateBanned() { }

			internal static StateBanned Create(PlayerVoipController controller) { }

			internal bool get_BanCompleted() { }

			internal virtual EVoipControllerStatus get_Status() { }

			internal virtual TimeSpan get_TimeToNextStatus() { }

			internal virtual EVoipControllerStatus Run() { }

		}

		private sealed class StateBlocked : AbstractStateRestricted
		{

			internal virtual EVoipControllerStatus Status
			{
				internal get { } //Length: 6
			}

			public StateBlocked() { }

			internal virtual EVoipControllerStatus get_Status() { }

			internal virtual EVoipControllerStatus Run() { }

		}

		private sealed class StateLimited : AbstractStateRestricted
		{

			internal virtual EVoipControllerStatus Status
			{
				internal get { } //Length: 6
			}

			public StateLimited() { }

			internal virtual EVoipControllerStatus get_Status() { }

			internal virtual EVoipControllerStatus Run() { }

		}

		private sealed class StateMicrophoneFail : AbstractStateRestricted
		{

			internal virtual EVoipControllerStatus Status
			{
				internal get { } //Length: 6
			}

			public StateMicrophoneFail() { }

			internal virtual EVoipControllerStatus get_Status() { }

			internal virtual EVoipControllerStatus Run() { }

			internal virtual void Update() { }

		}

		private sealed class StateOff : AbstractStateRestricted
		{

			internal virtual EVoipControllerStatus Status
			{
				internal get { } //Length: 3
			}

			internal virtual TimeSpan TimeToNextStatus
			{
				internal get { } //Length: 11
			}

			public StateOff() { }

			internal virtual EVoipControllerStatus get_Status() { }

			internal virtual TimeSpan get_TimeToNextStatus() { }

			internal virtual EVoipControllerStatus Run() { }

			internal virtual void Update() { }

		}

		private sealed class StateReady : AbstractStateMuted
		{

			internal virtual EVoipControllerStatus Status
			{
				internal get { } //Length: 6
			}

			internal virtual TimeSpan TimeToNextStatus
			{
				internal get { } //Length: 83
			}

			public StateReady() { }

			private EVoipControllerStatus BlockTalk() { }

			internal virtual EVoipControllerStatus get_Status() { }

			internal virtual TimeSpan get_TimeToNextStatus() { }

			internal virtual EVoipControllerStatus Run() { }

			internal virtual EVoipControllerStatus ToggleTalk() { }

		}

		private sealed class StateTalking : AbstractState
		{
			private Restriction _restriction; //Field offset: 0x18

			internal virtual EVoipControllerStatus Status
			{
				internal get { } //Length: 6
			}

			internal virtual TimeSpan TimeToNextStatus
			{
				internal get { } //Length: 11
			}

			public StateTalking() { }

			internal virtual EVoipControllerStatus get_Status() { }

			internal virtual TimeSpan get_TimeToNextStatus() { }

			private void LimitTalk() { }

			internal virtual EVoipControllerStatus Run() { }

			internal virtual EVoipControllerStatus StopTalk() { }

			internal virtual EVoipControllerStatus ToggleTalk() { }

			internal virtual void Update() { }

		}

		public sealed class TalksRegistry
		{
			private struct Talk
			{
				public DateTime From; //Field offset: 0x0
				public DateTime To; //Field offset: 0x8

				public TimeSpan Duration
				{
					 get { } //Length: 98
				}

				public TimeSpan get_Duration() { }

			}

			private TimeSpan _activationsInterval; //Field offset: 0x10
			private List _talks; //Field offset: 0x18
			private byte _activationsLimit; //Field offset: 0x20
			private TimeSpan _size; //Field offset: 0x28

			public TalksRegistry() { }

			internal bool CanTalk() { }

			internal static TalksRegistry Create(byte activationsLimit, float activationsInterval, float speakingInterval) { }

			internal void RegisterTalking(DateTime from, DateTime to) { }

			internal TimeSpan TalksDuration(DateTime dateTime) { }

		}

		private ClientPlayer _clientPlayer; //Field offset: 0x10
		private readonly CompositeDisposable _compositeDisposable; //Field offset: 0x18
		private readonly TalksRegistry _talksRegistry; //Field offset: 0x20
		private readonly StateReady _stateReady; //Field offset: 0x28
		private readonly StateTalking _stateTalking; //Field offset: 0x30
		private readonly StateLimited _stateLimited; //Field offset: 0x38
		private readonly StateBlocked _stateBlocked; //Field offset: 0x40
		private readonly StateBanned _stateBanned; //Field offset: 0x48
		private readonly StateOff _stateOff; //Field offset: 0x50
		private readonly StateMicrophoneFail _stateMicrophoneFail; //Field offset: 0x58
		private AbstractState _currentState; //Field offset: 0x60
		[CompilerGenerated]
		private readonly TimeSpan <BlockingTime>k__BackingField; //Field offset: 0x68
		[CompilerGenerated]
		private readonly TimeSpan <SpeakingSecondsInterval>k__BackingField; //Field offset: 0x70
		[CompilerGenerated]
		private readonly TimeSpan <SpeakingSecondsLimit>k__BackingField; //Field offset: 0x78
		[CompilerGenerated]
		private readonly TimeSpan <SpeakingPause>k__BackingField; //Field offset: 0x80
		private Nullable _interactionDateTime; //Field offset: 0x88
		private bool _voIPEnabled; //Field offset: 0x98
		private bool _forceMuteVoIP; //Field offset: 0x99
		[CompilerGenerated]
		private readonly BindableState <Status>k__BackingField; //Field offset: 0xA0
		[CompilerGenerated]
		private readonly BindableState <HasInteraction>k__BackingField; //Field offset: 0xA8
		[CompilerGenerated]
		private readonly BindableState <TalkDetected>k__BackingField; //Field offset: 0xB0
		[CompilerGenerated]
		private Action AbuseNotification; //Field offset: 0xB8

		public override event Action AbuseNotification
		{
			[CompilerGenerated]
			 add { } //Length: 251
			[CompilerGenerated]
			 remove { } //Length: 251
		}

		private TimeSpan BlockingTime
		{
			[CompilerGenerated]
			private get { } //Length: 5
		}

		private DissonanceComms DissonanceComms
		{
			private get { } //Length: 30
		}

		private override TimeSpan EFT.IPlayerVoipController.TimeToNextStatus
		{
			private get { } //Length: 42
		}

		public override BindableState HasInteraction
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		private TimeSpan SpeakingPause
		{
			[CompilerGenerated]
			private get { } //Length: 8
		}

		private TimeSpan SpeakingSecondsInterval
		{
			[CompilerGenerated]
			private get { } //Length: 5
		}

		private TimeSpan SpeakingSecondsLimit
		{
			[CompilerGenerated]
			private get { } //Length: 5
		}

		public override BindableState Status
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public override BindableState TalkDetected
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		internal PlayerVoipController(ClientPlayer clientPlayer, SoundSettingsGroup soundSettings) { }

		[CompilerGenerated]
		private void <.ctor>b__28_0() { }

		[CompilerGenerated]
		public override void add_AbuseNotification(Action value) { }

		private void AudioConfigurationChangedHandler(bool hasChanged) { }

		private Restriction CreateBanRestriction() { }

		private Restriction CreateBlockRestriction() { }

		private Restriction CreateLimitRestriction() { }

		private Restriction CreateTalkRestriction() { }

		public override void Dispose() { }

		private override TimeSpan EFT.IPlayerVoipController.get_TimeToNextStatus() { }

		private override void EFT.IPlayerVoipController.ReportAbuse() { }

		private override EVoipControllerStatus EFT.IPlayerVoipController.StopTalk() { }

		private override EVoipControllerStatus EFT.IPlayerVoipController.ToggleTalk() { }

		public override void ForceMuteVoIP(bool enable) { }

		[CompilerGenerated]
		private TimeSpan get_BlockingTime() { }

		private DissonanceComms get_DissonanceComms() { }

		[CompilerGenerated]
		public override BindableState get_HasInteraction() { }

		[CompilerGenerated]
		private TimeSpan get_SpeakingPause() { }

		[CompilerGenerated]
		private TimeSpan get_SpeakingSecondsInterval() { }

		[CompilerGenerated]
		private TimeSpan get_SpeakingSecondsLimit() { }

		[CompilerGenerated]
		public override BindableState get_Status() { }

		[CompilerGenerated]
		public override BindableState get_TalkDetected() { }

		private void OnVoipDeviceChanged(string device) { }

		private void OnVoipEnabledChanged(bool enabled) { }

		[CompilerGenerated]
		public override void remove_AbuseNotification(Action value) { }

		private EVoipControllerStatus RunState(AbstractState state) { }

		private void SetDefaultInteractionDateTime() { }

		private void TryDetectTalk() { }

		internal void Update() { }

		private void UpdateInteraction() { }

		private void UpdatePlayerVoipState(EVoipControllerStatus status) { }

		internal void VoipAbuseNotification() { }

	}

	internal sealed class SendDelegate : MulticastDelegate
	{

		public SendDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(NetworkChannel channel, NetworkMessageType messageType, in ArraySegment segment, AsyncCallback callback, object object) { }

		public override void EndInvoke(in ArraySegment segment, IAsyncResult result) { }

		public override void Invoke(NetworkChannel channel, NetworkMessageType messageType, in ArraySegment segment) { }

	}

	private const float FULL_POSITION_SYNC_INTERVAL = 2.17; //Field offset: 0x0
	private const float RTT_DELAY = 0.3; //Field offset: 0x0
	private static Queue _rttQueue; //Field offset: 0x0
	private const int TalkRestrictionDepth = 20; //Field offset: 0x0
	private static readonly TimeSpan TalkDetectionTime; //Field offset: 0x8
	private readonly Dictionary _operationCallbacks; //Field offset: 0xC98
	private readonly HashSet _blockHandsOperations; //Field offset: 0xCA0
	private Nullable _lastStationaryWeaponOperationId; //Field offset: 0xCA8
	private long _criticalPacketsSent; //Field offset: 0xCB0
	private long _criticalPacketsProcessedByServer; //Field offset: 0xCB8
	private QueueSum _unprocessedCriticalPacketsTimeQueue; //Field offset: 0xCC0
	private float _lastRTT; //Field offset: 0xCC8
	[CompilerGenerated]
	private bool <IsInitialized>k__BackingField; //Field offset: 0xCCC
	private ClientPlayerInventoryController _clientInventoryController; //Field offset: 0xCD0
	private ClientPlayerHealthController _clientHealthController; //Field offset: 0xCD8
	private float _clientTime; //Field offset: 0xCE0
	private IClientPlayerDataSender _dataSender; //Field offset: 0xCE8
	private readonly Dictionary _networkCallbacks; //Field offset: 0xCF0
	private uint _nextNetCallbackId; //Field offset: 0xCF8
	public int ScavExfilMask; //Field offset: 0xCFC
	[CompilerGenerated]
	private int <SyncedSessionExp>k__BackingField; //Field offset: 0xD00
	private VoipSettings _voipSettings; //Field offset: 0xD08
	private PlayerVoipController _voipController; //Field offset: 0xD10
	private INetworkGame _game; //Field offset: 0xD18
	private ClientGameWorld _clientGameWorld; //Field offset: 0xD20
	private Action _unsubscribeFromGlobalEvents; //Field offset: 0xD28
	private Action _unsubscribeFromClientSpawn; //Field offset: 0xD30
	private Action _unsubscribeSeasonsReconnectEvent; //Field offset: 0xD38
	private Action _unsubscribeFromReconnectEvent; //Field offset: 0xD40
	private bool _isInCutscene; //Field offset: 0xD48
	private bool _sendEndCutsceneOnServer; //Field offset: 0xD49
	private EndedCutsceneInfoForServer _cutsceneEndInfo; //Field offset: 0xD50
	private ERaidMode _raidMode; //Field offset: 0xD60
	private VaultingPacket _vaultingPacket; //Field offset: 0xD64
	private InteractionPacket _interactionPacket; //Field offset: 0xD8C
	private InventoryInteractionPacket _inventoryInteractionPacket; //Field offset: 0xD8F
	private MountingPacket _mountingPacket; //Field offset: 0xD94
	private LeftHandPacket _leftHandPacket; //Field offset: 0xDB0
	private ClientPlayerMovementContext _clientPlayerMovementContext; //Field offset: 0xDC8
	public bool TranslateNetCommands; //Field offset: 0xDD0
	private TaskCompletionSource _raidDialogEntryClaimTcs; //Field offset: 0xDD8
	private Vector3 _debugLastPositionSent; //Field offset: 0xDE0
	private MovementInfoPacket infoPacketOnStartCutscene; //Field offset: 0xDF0
	[CompilerGenerated]
	private bool <IsBot>k__BackingField; //Field offset: 0xF68
	public DeferredNetworkMessage DeferredNetworkMessage; //Field offset: 0xF70
	private IBitReaderStream _reader; //Field offset: 0xF78
	private readonly Queue _operationQueue; //Field offset: 0xF80
	[CompilerGenerated]
	private Action SetActiveLighthouseTraderZoneDebug; //Field offset: 0xF88
	[CompilerGenerated]
	private Action OnSyncLighthouseTraderZoneData; //Field offset: 0xF90
	private readonly LoopedQueue ClientShots; //Field offset: 0xF98
	private IClientSession _session; //Field offset: 0xFA0
	private bool _syncPositionPacketApplied; //Field offset: 0xFA8
	private bool _needFullSyncPosition; //Field offset: 0xFA9
	private float _lastTimeFullSyncPosition; //Field offset: 0xFAC
	protected HandsChangePacket _handsChangePacket; //Field offset: 0xFB0
	private InteractWithDoorPacket _interactWithDoorPacket; //Field offset: 0xFD8
	private InteractWithBtrPacket _interactWithBtrPacket; //Field offset: 0xFF8
	private InteractWithTripwirePacket _interactWithTripwirePacket; //Field offset: 0x1004
	private InteractWithTransitPacket _interactWithTransitPacket; //Field offset: 0x1010
	private InteractWithEventObjectPacket _interactWithEventObjectPacket; //Field offset: 0x1028
	protected LootInteractionPacket _lootInteractionPacket; //Field offset: 0x1038
	private StationaryWeaponPacket _stationaryWeaponPacket; //Field offset: 0x1050
	private PlantItemPacket _plantItemPacket; //Field offset: 0x1068
	private Client2ServerPacket _client2ServerPacket; //Field offset: 0x1080
	private Client2ServerPacket _previousClient2ServerPacket; //Field offset: 0x16A0
	private bool _hasPreviousClient2ServerPacket; //Field offset: 0x1CC0
	private bool _requireExtraPrecisionMovement; //Field offset: 0x1CC1
	[CompilerGenerated]
	private DateTime <TalkDateTime>k__BackingField; //Field offset: 0x1CC8

	public event DataSentDelegate OnPacketSent
	{
		 add { } //Length: 89
		 remove { } //Length: 89
	}

	public event Action OnSyncLighthouseTraderZoneData
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action SetActiveLighthouseTraderZoneDebug
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	protected virtual float Distance
	{
		 get { } //Length: 4
	}

	public virtual AbstractHandsController HandsController
	{
		 get { } //Length: 8
		 set { } //Length: 73
	}

	internal virtual PlayerInventoryController InventoryController
	{
		internal get { } //Length: 8
	}

	public bool IsBot
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public private bool IsInitialized
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private bool IsTalked
	{
		private get { } //Length: 253
	}

	public virtual bool IsVisible
	{
		 get { } //Length: 3
		 set { } //Length: 3
	}

	public bool IsWaitingForNetworkCallback
	{
		 get { } //Length: 119
	}

	public virtual Vector3 LocalShotDirection
	{
		 get { } //Length: 50
	}

	public virtual bool OnHisWayToOperateStationaryWeapon
	{
		 get { } //Length: 158
	}

	public static bool RTTEnabled
	{
		 get { } //Length: 87
		 set { } //Length: 447
	}

	public private int SyncedSessionExp
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public DateTime TalkDateTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public long UnprocessedCriticalPackets
	{
		 get { } //Length: 15
	}

	private float UnprocessedCriticalPacketsTime
	{
		private get { } //Length: 31
	}

	public int UnprocessedCriticalPacketsTimeMs
	{
		 get { } //Length: 43
	}

	private static ClientPlayer() { }

	public ClientPlayer() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0(ExitStatus exitStatus, float pastTime, string locationId, string exitName) { }

	[CompilerGenerated]
	private void <ExecuteOperationQueue>b__129_0(IResult result) { }

	[CompilerGenerated]
	private void <OperateStationaryWeapon>b__149_0(IResult result) { }

	public void add_OnPacketSent(DataSentDelegate value) { }

	[CompilerGenerated]
	public void add_OnSyncLighthouseTraderZoneData(Action value) { }

	[CompilerGenerated]
	public void add_SetActiveLighthouseTraderZoneDebug(Action value) { }

	public virtual void ApplyDamageInfo(DamageInfo damageInfo, EBodyPart bodyPartType, EBodyPartColliderType colliderType, float absorbed) { }

	private void ApplyKeyUsage(KeyUsagePacket packet) { }

	public virtual PlayerHitInfo ApplyShot(DamageInfo damageInfo, EBodyPart bodyPartType, EBodyPartColliderType colliderType, EArmorPlateCollider armorPlateCollider, ShotId shotId) { }

	private void ApplyTeleportPacket(SyncPositionPacket packet) { }

	internal virtual void BtrInteraction(BTRSide btr, byte placeId, EInteractionType interaction) { }

	internal virtual void CancelDoorInteraction(WorldInteractiveObject door, InteractionResult interactionResult) { }

	[AsyncStateMachine(typeof(<CompleteDeserializeInitialData>d__124))]
	private Task CompleteDeserializeInitialData(Callback callback, NetworkReader reader, bool isAlive, Quaternion rotation, bool isInPronePose, float poseLevel, EVoipState voipState, bool isInBufferZone, int bufferZoneUsageTimeLeft, bool leftStance, byte[] profileZip) { }

	protected virtual void ComplexLateUpdate(EUpdateQueue queue, float deltaTime) { }

	[AsyncStateMachine(typeof(<ContinueChunkedProfileSpawn>d__123))]
	internal Task ContinueChunkedProfileSpawn(byte[] compressedProfile, ChunkedProfileSpawnParameters parameters) { }

	internal static TClientPlayer Create(ClientGameWorld gameWorld, INetworkGame game, int playerId, Vector3 position, IFrameIndexer frameIndexer, SendDelegate sendDelegate, int sendRateFramesLimit, EUpdateQueue updateQueue, EUpdateMode armsUpdateMode, EUpdateMode bodyUpdateMode, Mode characterControllerMode, IClientSession session, VoipSettings voipSettings, ERaidMode raidMode) { }

	protected virtual Corpse CreateCorpse() { }

	protected virtual void CreateMovementContext() { }

	protected virtual void CreateNestedSource() { }

	internal void CutsceneForMyPlayerStarted(CutsceneForMyPlayerStartedEvent cutsceneEvent) { }

	[Conditional("DEBUG")]
	[Conditional("CONSOLE")]
	private void DebugCheckSpeedLimit() { }

	[AsyncStateMachine(typeof(<DeserializeInitialData>d__122))]
	private Task DeserializeInitialData(Callback callback, NetworkReader reader, bool isAlive, Quaternion rotation, bool isInPronePose, float poseLevel, EVoipState voipState, bool isInBufferZone, int bufferZoneUsageTimeLeft, bool leftStance) { }

	public virtual void DevelopLockDoors() { }

	public virtual void DevelopResetDiscardLimits() { }

	public virtual void DevelopSetActiveLighthouseTraderZoneDebug(bool value) { }

	internal void DevelopSetDamageCoeff(float coeff) { }

	public virtual void DevelopSetEncodedRadioTransmitter(bool value) { }

	public virtual void DevelopUnlockDoors(bool open) { }

	public virtual void Dispose() { }

	protected virtual void DropCurrentController(Action callback, bool fastDrop, Item nextControllerItem = null) { }

	internal virtual void EventObjectInteraction(EventObjectController controller, int objectId, EInteraction interaction) { }

	internal virtual void ExecuteInteraction(WorldInteractiveObject door, InteractionResult interactionResult) { }

	private void ExecuteOperationQueue() { }

	private void FinalizeAndSendClient2ServerPacket(float deltaTime) { }

	public virtual void FixedUpdateTick() { }

	protected virtual float get_Distance() { }

	public virtual AbstractHandsController get_HandsController() { }

	internal virtual PlayerInventoryController get_InventoryController() { }

	[CompilerGenerated]
	public bool get_IsBot() { }

	[CompilerGenerated]
	public bool get_IsInitialized() { }

	private bool get_IsTalked() { }

	public virtual bool get_IsVisible() { }

	public bool get_IsWaitingForNetworkCallback() { }

	public virtual Vector3 get_LocalShotDirection() { }

	public virtual bool get_OnHisWayToOperateStationaryWeapon() { }

	public static bool get_RTTEnabled() { }

	[CompilerGenerated]
	public int get_SyncedSessionExp() { }

	[CompilerGenerated]
	public DateTime get_TalkDateTime() { }

	public long get_UnprocessedCriticalPackets() { }

	private float get_UnprocessedCriticalPacketsTime() { }

	public int get_UnprocessedCriticalPacketsTimeMs() { }

	public IClientPlayerDataSender GetDataSender() { }

	public virtual void GetRadioTransmitterStatusFromServer() { }

	public virtual int GetSessionExperienceForExitPrediction() { }

	public void GetTraderServicesDataFromServer(string traderId) { }

	private void HandleReconnect(BaseReconnectEvent baseReconnectEvent) { }

	protected virtual void InitVoip(EVoipState voipState) { }

	public virtual void Interact(IItemOwner loot, Callback callback) { }

	public virtual void KillAIs() { }

	public virtual void KillMe(EBodyPartColliderType colliderType, float damage) { }

	protected virtual void LateUpdate() { }

	protected virtual void ManageAggressor(DamageInfo damageInfo, EBodyPart bodyPart, EBodyPartColliderType colliderType) { }

	public virtual void MouseLook(bool forceApplyToOriginalRibcage = false) { }

	private uint NextCallbackId() { }

	public virtual void OnAnimatedInteraction(EInteraction interaction) { }

	private void OnCharacterControllerSpeedLimitChanged() { }

	protected virtual void OnDead(EDamageType damageType) { }

	public void OnDeserializeFromServer(ArraySegment message) { }

	public void OnDeserializeInitialState(NetworkReader networkReader, Callback callback) { }

	[AsyncStateMachine(typeof(<OnDeserializeInitialState>d__125))]
	private Task OnDeserializeInitialState(Profile profile, MongoID firstId, ushort firstOperationId, Quaternion rotation, bool isAlive, EHandsControllerType type, bool isInSpawnOperation, string itemId, byte[] healthState, bool isInPronePose, float poseLevel, bool isStationaryWeapon, Vector2 stationaryRotation, Quaternion playerStationaryRotation, int animationVariant, EVoipState voipState, bool isInBufferZone, int bufferZoneUsageTimeLeft, bool leftStance, Dictionary globalSaveStates, bool isInBtr, InteractWithBtrPacket btrPacket, List raidDialogReconnectState, Callback callback) { }

	protected virtual void OnDestroy() { }

	[AsyncStateMachine(typeof(<OnGameSessionEnd>d__194))]
	public virtual Task OnGameSessionEnd(ExitStatus exitStatus, float pastTime, string locationId, string exitName) { }

	public virtual void OnInventoryInteraction(bool inventory, bool isOperation = false) { }

	public virtual void OnMounting(EMountingCommand command) { }

	private void OnNeedEndCutsceneOnServer(SendEndCutsceneOnServerEvent endCutsceneEvent) { }

	protected virtual void OnPhraseTold(EPhraseTrigger event, TaggedClip clip, TagBank bank, BaseSpeaker speaker) { }

	protected virtual void OnSkillLevelChanged(BaseSkill skill) { }

	public virtual void OnVaulting() { }

	protected virtual void OnWeaponMastered(Mastering masterSkill) { }

	public virtual void OperateStationaryWeapon(StationaryWeapon stationaryWeapon, EStationaryCommand command) { }

	public ulong OutgoingPacketsBytes() { }

	public virtual void PauseAllEffectsOnPlayer() { }

	internal virtual void PlantItemNetwork(string itemId, string zoneId, bool successful) { }

	protected virtual void PlayToggleSound(ref bool previousState, bool isOn, AudioClip toggleOn, AudioClip toggleOff) { }

	private void PrepareDoorPacket(WorldInteractiveObject door, InteractionResult interactionResult, EInteractionStage stage) { }

	protected virtual void Proceed(FoodDrink foodDrink, float amount, Callback callback, int animationVariant, bool scheduled = true) { }

	protected virtual void Proceed(Item item, Callback callback, bool scheduled = true) { }

	protected virtual void Proceed(ThrowWeap throwWeap, Callback callback, bool scheduled = true) { }

	protected virtual void Proceed(Weapon weapon, Callback callback, bool scheduled = true) { }

	protected virtual void Proceed(bool withNetwork, Callback callback, bool scheduled = true) { }

	protected virtual void Proceed(RecorderItem recorder, Callback callback, bool scheduled = true) { }

	protected virtual void Proceed(KnifeComponent knife, Callback callback, bool scheduled = true) { }

	protected virtual void Proceed(Meds meds, OneAndList bodyParts, Callback callback, int animationVariant, bool scheduled = true) { }

	protected virtual void Proceed(KnifeComponent knife, Callback callback, bool scheduled = true) { }

	protected virtual void Proceed(ThrowWeap throwWeap, Callback callback, bool scheduled = true) { }

	internal virtual void Proceed(Item item, Callback callback, bool scheduled = true) { }

	private void ProcessClientConfirmCallback(uint callbackId, string error) { }

	private void ProcessCommonPacket(CommonPacket commonPacket) { }

	public void ProcessCompletedAchievementsData(CompletedAchievementConditionsData data) { }

	private void ProcessInteractWithBtr(InteractWithBtrPacket interactionBtrPacket) { }

	private void ProcessNetworkDeath(string aggressorName, string aggressorMainCharacterName, EPlayerSide aggressorSide, EBodyPartColliderType colliderType, string weaponName, EMemberCategory memberCategory, WildSpawnType role) { }

	private void ProcessRadioTransmitter(bool isEncoded, RadioTransmitterStatus status, bool isAgressor) { }

	[AsyncStateMachine(typeof(<ProcessReconnectInBtr>d__200))]
	private Task ProcessReconnectInBtr(InteractWithBtrPacket interactionBtrPacket, Task onCurrentHandsControllerSpawned) { }

	private void ProcessRpcAcceptHitDebugData(ClientShot[] clientShots) { }

	private void ProcessRpcAchievementConditionValueChanged(int questId, EQuestStatus status, MongoID conditionId, double value, bool notify) { }

	private void ProcessRpcClientOperationStatus(uint operationId, EOperationStatus status, string error, int inventoryHashSum, bool badBeforeExecuting) { }

	private void ProcessRpcPrestigeConditionValueChanged(int questId, EQuestStatus status, MongoID conditionId, double value, bool notify) { }

	private void ProcessRpcQuestConditionValueChanged(int questId, EQuestStatus status, MongoID conditionId, double value, bool notify) { }

	private void ProcessTraderInfo(string traderId, double standing) { }

	private void ProcessWeaponOverheat(string weaponId, float lastOverheat, float lastShotTime, bool slideReached) { }

	public void RaidDialogEntryPointRelease(string pointId) { }

	public Task RaidDialogEntryPointTryClaimAsync(string pointId) { }

	public void ReceiveRaidDialogEntryPointClaimResponse(bool success) { }

	public void ReceiveTraderServicesDataFromServer(byte[] packet) { }

	private void RefreshExitTriggerRunnerVisual() { }

	public void remove_OnPacketSent(DataSentDelegate value) { }

	[CompilerGenerated]
	public void remove_OnSyncLighthouseTraderZoneData(Action value) { }

	[CompilerGenerated]
	public void remove_SetActiveLighthouseTraderZoneDebug(Action value) { }

	public virtual void RemoveLeftHandItem(float speed = 1) { }

	private void ResendPreviousMovementWithCriticalPriority() { }

	public virtual void ResetGestureInHands() { }

	public void ResetHands() { }

	private Nullable RTTGenerate() { }

	private void RTTReceive(ushort rttKey, int singleFixedUpdate, int serverTime) { }

	private void SendClientInput() { }

	public void SendCommonEventData(ArraySegment segment) { }

	public void SendCutsceneViewComplete(int playerId, string cutsceneId, int cutsceneProcessId) { }

	protected virtual void SendHeadlightsPacket(bool isSilent) { }

	protected virtual void SendTripwireInteractionSoundState(EInteractionStatus interactionStatus, bool isSuccess, bool hasMultiTool) { }

	protected virtual void SendUnderRoofStatus(bool isUnderRoof) { }

	protected virtual void SendVoiceMuffledState(bool isMuffled) { }

	protected virtual void SendWeaponLightPacket() { }

	protected virtual void set_HandsController(AbstractHandsController value) { }

	[CompilerGenerated]
	public void set_IsBot(bool value) { }

	[CompilerGenerated]
	private void set_IsInitialized(bool value) { }

	public virtual void set_IsVisible(bool value) { }

	public static void set_RTTEnabled(bool value) { }

	[CompilerGenerated]
	private void set_SyncedSessionExp(int value) { }

	[CompilerGenerated]
	public void set_TalkDateTime(DateTime value) { }

	private void SetActiveLighthouseTraderZoneDebugTool(bool active) { }

	public virtual void SetAudioProtagonist() { }

	private uint SetConfirmCallback(Action confirmAction) { }

	public virtual void SetEventState(EEventState eventState) { }

	public virtual void SetInventoryOpened(bool opened) { }

	public void SetLeftHand(LeftHandData data) { }

	private void SetMovementInfoPacket() { }

	private void SetPortableRangeFinderPacket() { }

	private void SetRadioTransmitterPacket() { }

	private void SetRecorderPacket() { }

	private void SetUsableItemPacket() { }

	protected virtual bool ShouldVocalizeDeath(EBodyPart bodyPart) { }

	public virtual void ShowStringNotification(string message) { }

	public virtual void SpawnAI(int count) { }

	protected virtual void StartInflictSelfDamageCoroutine() { }

	internal virtual void StartInteraction(WorldInteractiveObject door, InteractionResult interactionResult, Action callback, bool enterDoorState = true) { }

	private void SyncEventOnSpawn(SyncClientEventState createPlayerEvent) { }

	public void SyncLighthouseTraderZoneData(LighthouseTraderZoneData data) { }

	private void SyncSeasonsOnReconnect(SeasonsReconnectEvent reconnectEvent) { }

	public virtual void Teleport(Vector3 position, bool onServerToo = false) { }

	public virtual void ToggleLeftHand(Item item) { }

	internal virtual void TransitInteraction(TransitController controller, int transitPointId, string keyId, EDateTime time) { }

	protected virtual void TriggerPhraseCommand(EPhraseTrigger phrase, int netPhraseId) { }

	internal virtual void TripwireInteraction(TripwireSynchronizableObject tripwire) { }

	private static void TryBegin(IResult result, Action confirmAction) { }

	public virtual void TryInteractionCallback(LootableContainer container) { }

	public virtual void UnpauseAllEffectsOnPlayer() { }

	public virtual void UpdateMuffledState() { }

	protected virtual void UpdatePhones() { }

	public virtual void UpdateTick() { }

	public void VoipAbuseNotification() { }

	public void WriteCancelApplyingItemPacket() { }

}

