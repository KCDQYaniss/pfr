//Type is in global namespace

public class BotProfileBackuploader
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__26_0; //Field offset: 0x8
		public static Func <>9__26_1; //Field offset: 0x10
		public static Func <>9__27_0; //Field offset: 0x18
		public static Func <>9__29_0; //Field offset: 0x20
		public static Func <>9__30_0; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal int <AddProfileForBackup>b__27_0(CountTypeBotWave x) { }

		internal int <CacheSimpleProfilesChecker>b__26_0(CountTypeBotWave x) { }

		internal int <CacheSimpleProfilesChecker>b__26_1(CountTypeBotWave x) { }

		internal int <DoLoad>b__29_0(CountTypeBotWave x) { }

		internal int <LogsCache>b__30_0(CountTypeBotWave x) { }

	}

	[CompilerGenerated]
	private struct <DoLoad>d__29 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BotProfileBackuploader <>4__this; //Field offset: 0x20
		private float <startTime>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int OFFSET_SAFE = 3; //Field offset: 0x0
	private const int STANDART_BKACUP_COUNT = 8; //Field offset: 0x0
	private const int READY_TO_LOAD = 10; //Field offset: 0x0
	private const float CHECK_PERIOD = 2; //Field offset: 0x0
	private const float SEND_PERIOD = 50; //Field offset: 0x0
	private int _loadsProcess; //Field offset: 0x10
	private int _totalBackups; //Field offset: 0x14
	private List _periodsForBackups; //Field offset: 0x18
	private float _lastSendTime; //Field offset: 0x20
	private float _checkPeriodTime; //Field offset: 0x24
	private ProfileLoader _profileLoader; //Field offset: 0x28
	private ABotProfileCreator _profileCreator; //Field offset: 0x30
	private Action _callback; //Field offset: 0x38
	private List _cacheToLoad; //Field offset: 0x40
	private ITimer _timerToUpload; //Field offset: 0x48
	private ITimer _timerToCheckCache; //Field offset: 0x50
	private TwoDimensionalDictionary _targetCount; //Field offset: 0x58
	private float _nextCacheUpload; //Field offset: 0x60
	private bool _uploadCacheComplete; //Field offset: 0x64

	public int LoadsProcess
	{
		 get { } //Length: 164
	}

	public List PeriodsForBackups
	{
		 get { } //Length: 5
	}

	public int TotalBackups
	{
		 get { } //Length: 4
	}

	public BotProfileBackuploader(ABotProfileCreator profileCreator, ProfileLoader profileLoader, Action callback) { }

	public void AddProfileForBackup(BotCreationData data) { }

	public void AddToTargetBackup(BotDifficulty difficulty, WildSpawnType role, int count) { }

	private void CacheSimpleProfilesChecker() { }

	[AsyncStateMachine(typeof(<DoLoad>d__29))]
	private Task DoLoad() { }

	public int get_LoadsProcess() { }

	public List get_PeriodsForBackups() { }

	public int get_TotalBackups() { }

	private void LogsCache(bool isError) { }

	private void Update() { }

}

