namespace EFT;

public abstract class KolotunController : IDisposable
{
	[CompilerGenerated]
	private struct <InitFrostbiteAudioEffect>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CancellationToken token; //Field offset: 0x20
		public int ticksPerPlay; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x2C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private bool <IsActive>k__BackingField; //Field offset: 0x10
	protected readonly CancellationTokenSource Cts; //Field offset: 0x18
	protected readonly KolotunGlobalSettings Settings; //Field offset: 0x20
	[CompilerGenerated]
	private int <EventStage>k__BackingField; //Field offset: 0x28
	private readonly FlameDamageTrigger[] _flames; //Field offset: 0x30
	private readonly HashSet _protectiveClothing; //Field offset: 0x38

	public int EventStage
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	protected bool IsActive
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	protected KolotunController(KolotunGlobalSettings settings, Location location, LocationSettings locationSettings) { }

	private static void DisableEventObjects() { }

	public override void Dispose() { }

	[CompilerGenerated]
	public int get_EventStage() { }

	[CompilerGenerated]
	protected bool get_IsActive() { }

	[AsyncStateMachine(typeof(<InitFrostbiteAudioEffect>d__25))]
	private Task InitFrostbiteAudioEffect(int ticksPerPlay, CancellationToken token) { }

	public static bool IsEventActive(out KolotunController eventController) { }

	private bool IsHeatWeather(Player player) { }

	protected override bool IsInDoor(Player player) { }

	protected override bool IsInsideBTR(Player player) { }

	private bool IsNearFire(Player player) { }

	protected bool IsProtectedFromCold(Player player) { }

	private bool IsUnderAlcohol(Player player) { }

	private static bool IsWorkOnLocation(Location location, LocationSettings locationSettings) { }

	[CompilerGenerated]
	public void set_EventStage(int value) { }

	[CompilerGenerated]
	protected void set_IsActive(bool value) { }

	public static void ToggleEventEnvironment(bool isOn) { }

	protected bool TryGetBuffName(out string buffName) { }

}

