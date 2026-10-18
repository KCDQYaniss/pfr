namespace EFT.Airdrop;

public abstract class AirdropManager : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate <>9__14_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <TakeAirdropPoint>b__14_0(AirdropPoint point) { }

	}

	[CompilerGenerated]
	private struct <InitContainerLoot>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private List _deactivatedAirdropPoints; //Field offset: 0x10
	protected List _airdropPoints; //Field offset: 0x18
	protected Timer _spawnAirdropTimer; //Field offset: 0x20
	protected AirdropParameters CachedAirdropParameters; //Field offset: 0x28
	public AirdropParameters[] AirdropParameters; //Field offset: 0x30
	protected bool _isInited; //Field offset: 0x38

	public bool IsInited
	{
		 get { } //Length: 5
	}

	protected AirdropManager() { }

	private void ActivateAirdropPoints() { }

	public override void AddProjectile(GameObject projectile, float expiredTime) { }

	public override void AirdropEvent(long buttonClickLastTime) { }

	public override void Dispose() { }

	public bool get_IsInited() { }

	public override void Init(bool enableAirdrops) { }

	[AsyncStateMachine(typeof(<InitContainerLoot>d__13))]
	public override Task InitContainerLoot(AirdropSynchronizableObject container, string containerId) { }

	public override void ManualUpdate(float deltaTime) { }

	public override void OnFlareSuccessEvent(bool canSendAirdrop) { }

	private void RemoveNearbyAirdropPoints(Vector3 pointPosition) { }

	public GameObject TakeAirdropPoint(bool takeNearbyPoint = false, Vector3 position = null) { }

}

