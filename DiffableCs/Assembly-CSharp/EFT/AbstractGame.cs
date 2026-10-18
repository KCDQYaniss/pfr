namespace EFT;

[ScriptOrder(-500)]
public abstract class AbstractGame : MonoBehaviour, IGame, IDisposable
{
	[CompilerGenerated]
	private sealed class <LateFixedUpdateWorker>d__5 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AbstractGame <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <LateFixedUpdateWorker>d__5(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	protected const string HALLOWEEN_PREFAB_PATH = "Prefabs/HALLOWEEN_CONTROLLER"; //Field offset: 0x0
	[CompilerGenerated]
	private static Action OnGameTypeSetted; //Field offset: 0x0
	public const float MAX_FIXED_DELTA_TIME = 0.05; //Field offset: 0x0
	private bool _lateUpdateIsOkPrevFrame; //Field offset: 0x20
	private readonly WaitForFixedUpdate _waitForFixedUpdate; //Field offset: 0x28
	protected readonly CompositeDisposable CompositeDisposable; //Field offset: 0x30
	[CompilerGenerated]
	private GameStatus <Status>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private GameTimer <GameTimer>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private EGameType <GameType>k__BackingField; //Field offset: 0x48
	private float _cachedPastTime; //Field offset: 0x4C
	private bool _pastTimeCached; //Field offset: 0x50
	[CompilerGenerated]
	private EUpdateQueue <UpdateQueue>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	private Action OnMatchingStatusChanged; //Field offset: 0x58

	public static event Action OnGameTypeSetted
	{
		[CompilerGenerated]
		 add { } //Length: 293
		[CompilerGenerated]
		 remove { } //Length: 293
	}

	public event Action OnMatchingStatusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public float FixedDeltaTime
	{
		 get { } //Length: 69
		 set { } //Length: 616
	}

	public private override GameTimer GameTimer
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public EGameType GameType
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	protected abstract GameUI GameUi
	{
		 get { } //Length: 0
	}

	public bool InRaid
	{
		 get { } //Length: 120
	}

	public override int LastServerFrameId
	{
		 get { } //Length: 3
	}

	public override float LastServerTimeStamp
	{
		 get { } //Length: 4
	}

	public override int LocalRaidId
	{
		 get { } //Length: 3
	}

	public abstract string LocationId
	{
		 get { } //Length: 0
	}

	public abstract string LocationObjectId
	{
		 get { } //Length: 0
	}

	public override float PastTime
	{
		 get { } //Length: 145
	}

	protected abstract string ProfileId
	{
		 get { } //Length: 0
	}

	protected abstract int RaidID
	{
		 get { } //Length: 0
	}

	public override GameStatus Status
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public private EUpdateQueue UpdateQueue
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	protected AbstractGame() { }

	[CompilerGenerated]
	private bool <OnEpInteraction>b__60_0(Player x) { }

	[CompilerGenerated]
	private bool <OnEpInteraction>b__60_1(Player x) { }

	[CompilerGenerated]
	public static void add_OnGameTypeSetted(Action value) { }

	[CompilerGenerated]
	public void add_OnMatchingStatusChanged(Action value) { }

	protected static TGame Create(EUpdateQueue updateQueue, Nullable sessionTime = null, string goName = "GAME") { }

	public override void Dispose() { }

	private override GameObject EFT.IGame.get_gameObject() { }

	protected override void FixedUpdate() { }

	public float get_FixedDeltaTime() { }

	[CompilerGenerated]
	public override GameTimer get_GameTimer() { }

	[CompilerGenerated]
	public EGameType get_GameType() { }

	protected abstract GameUI get_GameUi() { }

	public bool get_InRaid() { }

	public override int get_LastServerFrameId() { }

	public override float get_LastServerTimeStamp() { }

	public override int get_LocalRaidId() { }

	public abstract string get_LocationId() { }

	public abstract string get_LocationObjectId() { }

	public override float get_PastTime() { }

	protected abstract string get_ProfileId() { }

	protected abstract int get_RaidID() { }

	[CompilerGenerated]
	public override GameStatus get_Status() { }

	[CompilerGenerated]
	public EUpdateQueue get_UpdateQueue() { }

	protected void InvokeMatchingStatusChanged(EMatchingStage stage, Nullable progress = null) { }

	protected override void LateFixedUpdate() { }

	[IteratorStateMachine(typeof(<LateFixedUpdateWorker>d__5))]
	private IEnumerator LateFixedUpdateWorker() { }

	protected override void LateUpdate() { }

	protected void OnEpInteraction(ExfiltrationPoint point, bool entered) { }

	[CompilerGenerated]
	public static void remove_OnGameTypeSetted(Action value) { }

	[CompilerGenerated]
	public void remove_OnMatchingStatusChanged(Action value) { }

	public void set_FixedDeltaTime(float value) { }

	[CompilerGenerated]
	private void set_GameTimer(GameTimer value) { }

	[CompilerGenerated]
	protected void set_GameType(EGameType value) { }

	[CompilerGenerated]
	protected void set_Status(GameStatus value) { }

	[CompilerGenerated]
	private void set_UpdateQueue(EUpdateQueue value) { }

	protected void SetFixedWeather(FixedWeatherLocationConfig cfg) { }

	protected override void SetMatchmakerStatus(EMatchingStage stage, Nullable progress = null) { }

	protected void ShowNewSecretExit(ExfiltrationPoint point, EExfiltrationStatus prevStatus) { }

	protected void UpdateExfiltrationUi(ExfiltrationPoint point, bool contains, bool initial = false) { }

}

