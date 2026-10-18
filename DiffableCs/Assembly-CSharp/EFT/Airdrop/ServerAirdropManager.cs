namespace EFT.Airdrop;

public sealed class ServerAirdropManager : AirdropManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__33_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal IEnumerable <InitContainerLoot>b__33_0(Item x) { }

	}

	[CompilerGenerated]
	private struct <InitContainerLoot>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string lootTemplateId; //Field offset: 0x20
		public AirdropSynchronizableObject container; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const float AIRDROP_EVENT_THRESHOLD = 120; //Field offset: 0x0
	private long _lastAirdropEventTime; //Field offset: 0x40
	private float _nextSpawnAirdropTime; //Field offset: 0x48
	private float _nextAirdropTimeByFlare; //Field offset: 0x4C
	private float _currentAirdropsCount; //Field offset: 0x50
	private List _projectileSuccessPositions; //Field offset: 0x58
	[CanBeNull]
	private string _overrideLootTemplateId; //Field offset: 0x60
	private float _planeAirdropStart; //Field offset: 0x68
	private float _planeAirdropMax; //Field offset: 0x6C
	private bool _airdropsEnabled; //Field offset: 0x70

	private bool CanSummonAirdrop
	{
		private get { } //Length: 86
	}

	private int MinPlayersCountToSpawnAirdrop
	{
		private get { } //Length: 26
	}

	private float PlaneAirdropChance
	{
		private get { } //Length: 28
	}

	private float PlaneAirdropCooldown
	{
		private get { } //Length: 121
	}

	private float PlaneAirdropEnd
	{
		private get { } //Length: 31
	}

	private int PlaneAirdropFlareWait
	{
		private get { } //Length: 72
	}

	private int UnsuccessfulTryPenalty
	{
		private get { } //Length: 26
	}

	public ServerAirdropManager() { }

	public virtual void AirdropEvent(long buttonClickLastTime) { }

	public virtual void Dispose() { }

	public void FlareSuccessEventHandler(string profileId, Vector3 position, string lootTemplateId) { }

	private bool get_CanSummonAirdrop() { }

	private int get_MinPlayersCountToSpawnAirdrop() { }

	private float get_PlaneAirdropChance() { }

	private float get_PlaneAirdropCooldown() { }

	private float get_PlaneAirdropEnd() { }

	private int get_PlaneAirdropFlareWait() { }

	private int get_UnsuccessfulTryPenalty() { }

	private Vector3 GetEquidistantPoint() { }

	private bool HasLeftPlayersCount(int count) { }

	public virtual void Init(bool enabledAirdrops) { }

	[AsyncStateMachine(typeof(<InitContainerLoot>d__33))]
	public virtual Task InitContainerLoot(AirdropSynchronizableObject container, string lootTemplateId) { }

	public virtual void ManualUpdate(float deltaTime) { }

	private void OnCachedParametersUpdate() { }

	private void UpdateAirdropTimers(float airdropDeltaTime) { }

	private void UpdateCachedAirdropParameters() { }

}

