namespace Audio.AmbientSubsystem.GameEvents;

public class HalloweenInfectedEventAudioPlayer : IGameEventAudioPlayer
{
	[CompilerGenerated]
	private struct <Init>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HalloweenInfectedEventAudioPlayer <>4__this; //Field offset: 0x20
		private CancellationToken <cancellationToken>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadBank>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string path; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private ResourceRequest <loadOperation>5__2; //Field offset: 0x30
		private YieldAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string ZOMBIE_CROWD_SOUND_BANK_PATH = "Audio/Events/InfectedEvent/ZombieAttackEventScreams"; //Field offset: 0x0
	private const int MAX_ZOMBIE_SCREAMS_COUNT = 10; //Field offset: 0x0
	private const float MAX_ZOMBIE_SCREAM_RADIUS = 100; //Field offset: 0x0
	private readonly HashSet _randomPoints; //Field offset: 0x10
	private readonly Vector2 _screamsRandomDelayRange; //Field offset: 0x18
	private CancellationTokenSource _tokenSource; //Field offset: 0x20
	private SoundBank _zombieCrowdSoundBank; //Field offset: 0x28
	private Action _unsubscribeOnStop; //Field offset: 0x30
	[CompilerGenerated]
	private bool <IsRunning>k__BackingField; //Field offset: 0x38

	public private override bool IsRunning
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public HalloweenInfectedEventAudioPlayer() { }

	[CompilerGenerated]
	public override bool get_IsRunning() { }

	private HashSet GetRandomPointsInCircle(Vector3 center, float radius, int pointsCount) { }

	[AsyncStateMachine(typeof(<Init>d__13))]
	private Task Init() { }

	[AsyncStateMachine(typeof(<LoadBank>d__14))]
	private Task LoadBank(string path, CancellationToken cancellationToken) { }

	private void PlayZombieAttackEventSound(Vector3 position, EnvironmentType environment) { }

	public override void Run() { }

	[CompilerGenerated]
	private void set_IsRunning(bool value) { }

	public override void Stop() { }

	private void ZombieAttackEventHandler(BotsCrowdSpawnEvent spawnEvent) { }

}

