//Type is in global namespace

public class BotCreationData
{
	[CompilerGenerated]
	private struct <Create>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IGetProfileData profileData; //Field offset: 0x20
		public ITokenGetter token; //Field offset: 0x28
		public IBotCreator botCreator; //Field offset: 0x30
		public int count; //Field offset: 0x38
		private BotCreationData <data>5__2; //Field offset: 0x40
		private List <profiles>5__3; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50
		private int <countToSpawn>5__4; //Field offset: 0x58
		private int <i>5__5; //Field offset: 0x5C
		private TaskAwaiter <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static int _countClasses; //Field offset: 0x0
	public static int ProfilesLoadingProcess; //Field offset: 0x4
	private static HashSet _generatedHash; //Field offset: 0x8
	private static List _idsAtProcess; //Field offset: 0x10
	private List _positions; //Field offset: 0x10
	public IGetProfileData _profileData; //Field offset: 0x18
	private List _profiles; //Field offset: 0x20
	public int Id; //Field offset: 0x28
	private IBotCreator _botCreator; //Field offset: 0x30
	private ITokenGetter _tokenGetter; //Field offset: 0x38
	private HashSet _profilesIdsHash; //Field offset: 0x40
	private CancellationTokenSource _cancellationTokenSource; //Field offset: 0x48

	public int Count
	{
		 get { } //Length: 65
	}

	public int CountPositions
	{
		 get { } //Length: 65
	}

	public bool KeepZoneOnSpawn
	{
		 get { } //Length: 78
	}

	public List Profiles
	{
		 get { } //Length: 5
	}

	public Nullable Side
	{
		 get { } //Length: 66
	}

	public BotSpawnParams SpawnParams
	{
		 get { } //Length: 66
	}

	public bool SpawnStopped
	{
		 get { } //Length: 120
	}

	private static BotCreationData() { }

	protected BotCreationData(IGetProfileData profileData) { }

	public void AddPosition(Vector3 spawnPointPosition, int corePointId) { }

	public void AddProfile(Profile profile) { }

	public void AddProfiles(List profiles) { }

	public bool CanAtZoneByType(BotZone botZone, BotZonesLeaveController botsControllerZonesLeaveController) { }

	public Profile ChooseProfile(List simpleProfiles, bool withDelete) { }

	[AsyncStateMachine(typeof(<Create>d__17))]
	public static Task Create(IGetProfileData profileData, IBotCreator botCreator, int count, ITokenGetter token) { }

	public static BotCreationData CreateWithoutProfile(IGetProfileData profileData) { }

	public int get_Count() { }

	public int get_CountPositions() { }

	public bool get_KeepZoneOnSpawn() { }

	public List get_Profiles() { }

	public Nullable get_Side() { }

	public BotSpawnParams get_SpawnParams() { }

	public bool get_SpawnStopped() { }

	public string GetDebugData() { }

	public string GetDebugLocalName() { }

	public PositionNote GetPosition() { }

	public bool IsBossOrFollowerByTime() { }

	public bool IsSpawnOnStart() { }

	public bool IsValidSpawnType(WildSpawnType type) { }

	public CountTypeBotWave[] PrepareToLoadBackend(int count) { }

	public void RemoveProfile(Profile profile) { }

	public BotCreationData Separate(int spawnCount) { }

	public void SpawnProfile(Profile profile) { }

	public void SpawnProfiles(List profiles) { }

	public void StopSpawn() { }

}

