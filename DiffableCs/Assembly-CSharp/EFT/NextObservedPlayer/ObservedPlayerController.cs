namespace EFT.NextObservedPlayer;

public class ObservedPlayerController : ICommandExecutable, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass77_0
	{
		public byte[] prefabsData; //Field offset: 0x10
		public byte[] customizationsData; //Field offset: 0x18

		public <>c__DisplayClass77_0() { }

		internal ResourceKey[] <LoadProfileResources>b__0() { }

	}

	[CompilerGenerated]
	private struct <CreateInstance>d__0`2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public ObservedPlayerSpawnMessage message; //Field offset: 0x0
		public int id; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadProfileResources>d__77 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public byte[] prefabsData; //Field offset: 0x20
		public byte[] customizationsData; //Field offset: 0x28
		private ResourceKey[] <keys>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private object <>u__2; //Field offset: 0x40
		private TaskAwaiter <>u__3; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static int _evenOrNotEvenUpdateLastValue; //Field offset: 0x0
	[CompilerGenerated]
	private ObservedPlayerInventoryController <InventoryController>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private ObservedPlayerView <PlayerView>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private ObservedPlayerModel <Model>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private ObserverPlayerCulling <Culling>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private ObservedPlayerInfoContainer <InfoContainer>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	private ObservedPlayerMovementController <MovementController>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private ObservedPlayerInterpolator <Interpolator>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private ObservedPlayerHealthController <HealthController>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	private Action OnSpectatorWhiteNoiseStatusChangedEvent; //Field offset: 0x108
	[CompilerGenerated]
	private ObservedPlayerAudioController <AudioController>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	private ObservedPlayerVoIP <VoIPController>k__BackingField; //Field offset: 0x118
	[CompilerGenerated]
	private int <Id>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private ObservedPlayerEquipmentViewController <EquipmentViewController>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	private ObservedPlayerArmorInfoController <ArmorInfoController>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	private TriggerColliderSearcher <TriggerColliderSearcher>k__BackingField; //Field offset: 0x138
	[CompilerGenerated]
	private ObservedPlayerHandsController <HandsController>k__BackingField; //Field offset: 0x140
	[CompilerGenerated]
	private bool <CachedSpectatorWhiteNoiseStatus>k__BackingField; //Field offset: 0x148
	private ObservedPlayerGestureController _gestureController; //Field offset: 0x150
	private ObservedPlayerDeadBodyCulling _playerDeadBodyCulling; //Field offset: 0x158
	private ObservedPlayerBodyAnimatorController _bodyAnimatorController; //Field offset: 0x160
	private bool _disposed; //Field offset: 0x168
	private int _evenOrNotEvenUpdate; //Field offset: 0x16C

	public event Action OnSpectatorWhiteNoiseStatusChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public private ObservedPlayerArmorInfoController ArmorInfoController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private ObservedPlayerAudioController AudioController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private bool CachedSpectatorWhiteNoiseStatus
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private ObserverPlayerCulling Culling
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private ObservedPlayerEquipmentViewController EquipmentViewController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private ObservedPlayerHandsController HandsController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private ObservedPlayerHealthController HealthController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private int Id
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private ObservedPlayerInfoContainer InfoContainer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private ObservedPlayerInterpolator Interpolator
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private ObservedPlayerInventoryController InventoryController
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private ObservedPlayerModel Model
	{
		[CompilerGenerated]
		 get { } //Length: 129
		[CompilerGenerated]
		private set { } //Length: 196
	}

	public private ObservedPlayerMovementController MovementController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private ObservedPlayerView PlayerView
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public ObservedPlayerStateContext StateContext
	{
		 get { } //Length: 33
	}

	public private TriggerColliderSearcher TriggerColliderSearcher
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private ObservedPlayerVoIP VoIPController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public ObservedPlayerController() { }

	[CompilerGenerated]
	public void add_OnSpectatorWhiteNoiseStatusChangedEvent(Action value) { }

	public void Apply(ObservedPlayerModel nextModel) { }

	public void ApplyDeath(CreateCorpsePacket packet) { }

	private static TObservedPlayerController Create(int id, ObservedPlayerView player, ObservedPlayerModel model, ObservedPlayerSpawnMessage spawnMessage) { }

	[AsyncStateMachine(typeof(<CreateInstance>d__0`2))]
	public static Task CreateInstance(int id, ObservedPlayerSpawnMessage message) { }

	public override void Dispose() { }

	public override void Execute(ICommandMessage command) { }

	private void ExecuteOnDeadPlayer(ICommandMessage command) { }

	public void ExecuteSpectator(ICommandMessage command) { }

	[CompilerGenerated]
	public ObservedPlayerArmorInfoController get_ArmorInfoController() { }

	[CompilerGenerated]
	public ObservedPlayerAudioController get_AudioController() { }

	[CompilerGenerated]
	public bool get_CachedSpectatorWhiteNoiseStatus() { }

	[CompilerGenerated]
	public ObserverPlayerCulling get_Culling() { }

	[CompilerGenerated]
	public ObservedPlayerEquipmentViewController get_EquipmentViewController() { }

	[CompilerGenerated]
	public ObservedPlayerHandsController get_HandsController() { }

	[CompilerGenerated]
	public ObservedPlayerHealthController get_HealthController() { }

	[CompilerGenerated]
	public int get_Id() { }

	[CompilerGenerated]
	public ObservedPlayerInfoContainer get_InfoContainer() { }

	[CompilerGenerated]
	public ObservedPlayerInterpolator get_Interpolator() { }

	[CompilerGenerated]
	public ObservedPlayerInventoryController get_InventoryController() { }

	[CompilerGenerated]
	public ObservedPlayerModel get_Model() { }

	[CompilerGenerated]
	public ObservedPlayerMovementController get_MovementController() { }

	[CompilerGenerated]
	public ObservedPlayerView get_PlayerView() { }

	public ObservedPlayerStateContext get_StateContext() { }

	[CompilerGenerated]
	public TriggerColliderSearcher get_TriggerColliderSearcher() { }

	[CompilerGenerated]
	public ObservedPlayerVoIP get_VoIPController() { }

	[AsyncStateMachine(typeof(<LoadProfileResources>d__77))]
	private static Task LoadProfileResources(byte[] prefabsData, byte[] customizationsData) { }

	public void ManualUpdate(float frameCountDividedByTwo) { }

	private void OnBeforeDeath() { }

	[CompilerGenerated]
	public void remove_OnSpectatorWhiteNoiseStatusChangedEvent(Action value) { }

	[CompilerGenerated]
	private void set_ArmorInfoController(ObservedPlayerArmorInfoController value) { }

	[CompilerGenerated]
	private void set_AudioController(ObservedPlayerAudioController value) { }

	[CompilerGenerated]
	private void set_CachedSpectatorWhiteNoiseStatus(bool value) { }

	[CompilerGenerated]
	private void set_Culling(ObserverPlayerCulling value) { }

	[CompilerGenerated]
	private void set_EquipmentViewController(ObservedPlayerEquipmentViewController value) { }

	[CompilerGenerated]
	private void set_HandsController(ObservedPlayerHandsController value) { }

	[CompilerGenerated]
	private void set_HealthController(ObservedPlayerHealthController value) { }

	[CompilerGenerated]
	private void set_Id(int value) { }

	[CompilerGenerated]
	private void set_InfoContainer(ObservedPlayerInfoContainer value) { }

	[CompilerGenerated]
	private void set_Interpolator(ObservedPlayerInterpolator value) { }

	[CompilerGenerated]
	private void set_InventoryController(ObservedPlayerInventoryController value) { }

	[CompilerGenerated]
	private void set_Model(ObservedPlayerModel value) { }

	[CompilerGenerated]
	private void set_MovementController(ObservedPlayerMovementController value) { }

	[CompilerGenerated]
	private void set_PlayerView(ObservedPlayerView value) { }

	[CompilerGenerated]
	private void set_TriggerColliderSearcher(TriggerColliderSearcher value) { }

	[CompilerGenerated]
	private void set_VoIPController(ObservedPlayerVoIP value) { }

	public void SetupPlayerDeadBodyCulling() { }

}

