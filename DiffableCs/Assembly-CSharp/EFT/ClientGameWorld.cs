namespace EFT;

internal abstract class ClientGameWorld : GameWorld
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public ClientWorld clientWorld; //Field offset: 0x10
		public ClientGameWorld <>4__this; //Field offset: 0x18

		public <>c__DisplayClass16_0() { }

		internal void <ConnectWithNetworkWorld>b__0() { }

		internal void <ConnectWithNetworkWorld>b__1() { }

	}

	[CompilerGenerated]
	private struct <BetterAudioSetup>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PreloadAdditionalData>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientGameWorld <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private float <LastServerWorldTime>k__BackingField; //Field offset: 0x310
	[CompilerGenerated]
	private ClientSynchronizableObjectLogicProcessor <ClientSynchronizableObjectLogicProcessor>k__BackingField; //Field offset: 0x318
	[CompilerGenerated]
	private KarmaClientController <KarmaClientController>k__BackingField; //Field offset: 0x320
	private ulong _totalOutgoingBytes; //Field offset: 0x328

	public private ClientSynchronizableObjectLogicProcessor ClientSynchronizableObjectLogicProcessor
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public KarmaClientController KarmaClientController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public float LastServerWorldTime
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public virtual ulong TotalOutgoingBytes
	{
		 get { } //Length: 8
	}

	protected ClientGameWorld() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0() { }

	[AsyncStateMachine(typeof(<BetterAudioSetup>d__19))]
	private Task BetterAudioSetup() { }

	internal virtual void ConnectWithNetworkWorld(World world) { }

	public virtual void Dispose() { }

	private void DrawGrenadePath(Vector3 pos) { }

	private void FlareSuccessEventHandler(string profileId, Vector3 flarePosition, AmmoTemplate ammoTemplate) { }

	[CompilerGenerated]
	public ClientSynchronizableObjectLogicProcessor get_ClientSynchronizableObjectLogicProcessor() { }

	[CompilerGenerated]
	public KarmaClientController get_KarmaClientController() { }

	[CompilerGenerated]
	public float get_LastServerWorldTime() { }

	public virtual ulong get_TotalOutgoingBytes() { }

	public virtual PlayerHitInfo HackShot(DamageInfo damageInfo) { }

	public virtual void InitAirdrop(string lootTemplateId = null, bool takeNearbyPoint = false, Vector3 position = null) { }

	private void LateUpdate() { }

	private void NetworkWorldOnRpcLampStateChanged(int netId, EState state) { }

	private void NetworkWorldOnRpcWindowHit(int netId, Vector3 hitPosition) { }

	protected virtual void OnDestroy() { }

	private void OnFlare(IPlayer iPlayer, Vector3 flarePosition, AmmoTemplate ammoTemplate) { }

	private void OnPacketSent(ClientPlayer player, int bytes, ulong totalBytes) { }

	protected virtual void OtherElseWorldTick(float dt) { }

	[AsyncStateMachine(typeof(<PreloadAdditionalData>d__18))]
	protected virtual Task PreloadAdditionalData() { }

	public virtual void RegisterPlayer(IPlayer iPlayer) { }

	[CompilerGenerated]
	private void set_ClientSynchronizableObjectLogicProcessor(ClientSynchronizableObjectLogicProcessor value) { }

	[CompilerGenerated]
	public void set_KarmaClientController(KarmaClientController value) { }

	[CompilerGenerated]
	public void set_LastServerWorldTime(float value) { }

	public virtual void ShotDelegate(Shot shotResult) { }

	protected virtual void SpawnLootCorpse(JsonCorpse lootItem) { }

	protected virtual SynchronizableObjectLogicProcessor SyncObjectProcessorFactory() { }

	private GameObject TakeAirdropPoint(bool takeNearbyPoint = false, Vector3 position = null) { }

	public virtual void UnregisterPlayer(IPlayer player) { }

}

