namespace EFT;

internal class ClientWorld : World
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__45_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <DeserializeWindows>b__45_0(WindowBreaker x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public BorderZonePacket packet; //Field offset: 0x10

		public <>c__DisplayClass26_0() { }

		internal bool <ApplySniperFiringZonePackets>b__0(IPlayer x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass47_0
	{
		public ItemDescriptor itemDescriptor; //Field offset: 0x10
		public NetworkReader reader; //Field offset: 0x18

		public <>c__DisplayClass47_0() { }

		internal void <DeserializeTransferItems>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass51_0
	{
		public ClientWorld <>4__this; //Field offset: 0x10
		public NetworkReader reader; //Field offset: 0x18

		public <>c__DisplayClass51_0() { }

		internal LootData <DeserializeLoot>b__0() { }

	}

	[CompilerGenerated]
	private struct <DeserializeTransferItems>d__47 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public NetworkReader reader; //Field offset: 0x20
		public TransferItemsController transferItemsController; //Field offset: 0x28
		private <>c__DisplayClass47_0 <>8__1; //Field offset: 0x30
		public string name; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpawnWorldLootOnClient>d__49 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientWorld <>4__this; //Field offset: 0x20
		public NetworkReader reader; //Field offset: 0x28
		private Stopwatch <stopwatch>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private Dictionary _interactiveObjectsStatusInfosDictionary; //Field offset: 0x118
	[CompilerGenerated]
	private Action OnRpcLampStateChanged; //Field offset: 0x120
	[CompilerGenerated]
	private Action OnRpcWindowHit; //Field offset: 0x128
	private readonly List _lootSyncPackets; //Field offset: 0x130
	private readonly List _synchronizableObjectPackets; //Field offset: 0x138
	private readonly TaskCompletionSource _spawnCompletionSource; //Field offset: 0x140
	private readonly DeferredNetworkMessage _deferredNetworkWorldMessage; //Field offset: 0x148
	private readonly IBitReaderStream _reader; //Field offset: 0x150
	private ClientGameWorld _clientGameWorld; //Field offset: 0x158
	[CompilerGenerated]
	private bool <WorldSpawned>k__BackingField; //Field offset: 0x160
	private TimeSpan _totalDeserializationTime; //Field offset: 0x168
	private byte[] _lootBuffer; //Field offset: 0x170

	public event Action OnRpcLampStateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnRpcWindowHit
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	protected ClientGameWorld ClientGameWorld
	{
		 get { } //Length: 8
	}

	public private bool WorldSpawned
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public ClientWorld() { }

	[CompilerGenerated]
	public void add_OnRpcLampStateChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnRpcWindowHit(Action value) { }

	private void ApplySniperFiringZonePackets(List packets) { }

	private void ApplyVolumePackets(ref GameWorldPacket gameWorldPacket) { }

	public static ClientWorld Create(ClientGameWorld gameWorld, IDictionary interactables) { }

	public Task Deserialize(NetworkReader reader) { }

	private void DeserializeBotCullingData(NetworkReader reader) { }

	private void DeserializeGrenades(NetworkReader reader) { }

	private void DeserializeInteractiveObjects(NetworkReader reader) { }

	private void DeserializeInteractiveObjectsStatus(IBitReaderStream reader) { }

	private void DeserializeLamps(NetworkReader reader) { }

	private Task DeserializeLoot(NetworkReader reader) { }

	internal void DeserializeSyncAblesSnapshot(NetworkReader reader) { }

	private void DeserializeSyncAbse(NetworkReader reader) { }

	private void DeserializeSynchronizableObjects(NetworkReader reader) { }

	private void DeserializeTearGasGrenades(NetworkReader reader) { }

	[AsyncStateMachine(typeof(<DeserializeTransferItems>d__47))]
	private static Task DeserializeTransferItems(NetworkReader reader, TransferItemsController transferItemsController, string name) { }

	private void DeserializeWindows(NetworkReader reader) { }

	protected ClientGameWorld get_ClientGameWorld() { }

	[CompilerGenerated]
	public bool get_WorldSpawned() { }

	internal void Go() { }

	private void PrepareInteractiveObjectsDictionary() { }

	private void ProcessLootSyncPackets(DictionaryListHydra lootItems) { }

	private void ProcessWorldPacket(ArraySegment message) { }

	internal void Receive(ArraySegment message) { }

	private void Receive(ref GameWorldPacket gameWorldPacket) { }

	[CompilerGenerated]
	public void remove_OnRpcLampStateChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnRpcWindowHit(Action value) { }

	[CompilerGenerated]
	private void set_WorldSpawned(bool value) { }

	private void SetInteractiveObjectStatus(Dictionary infos, bool init) { }

	[AsyncStateMachine(typeof(<SpawnWorldLootOnClient>d__49))]
	internal Task SpawnWorldLootOnClient(NetworkReader reader) { }

	private void StoreLootSyncPacket(LootSyncPacket packet) { }

	private void StoreLootSyncPackets(List packets) { }

	private void StorePlatformSyncPackets(List packets, NetworkAdapter[] adapters) { }

	public virtual void SubscribeToBorderZones(BorderZone[] zones) { }

	private void SyncArtilleryProjectiles(List packets, ArtilleryShellingControllerClient clientShellingController) { }

	private void SyncCorpses(List packets, Dictionary observedCorpses) { }

	private void SyncGrenades(List packets, DictionaryListHydra grenades, float remoteTime) { }

	private void Update() { }

	private void UpdateSyncObjectPacket(SynchronizableObjectPacket packet) { }

	private void UpdateSyncObjectsPackets(List packets) { }

}

