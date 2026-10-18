//Type is in global namespace

public abstract class ABotProfileCreator : IBotProfileCreator
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__5_0; //Field offset: 0x8
		public static Func <>9__5_2; //Field offset: 0x10
		public static Func <>9__5_1; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal int <DelemiterCountBotTypes>b__5_0(CountTypeBotWave x) { }

		internal int <DelemiterCountBotTypes>b__5_1(CountTypeBotWave x) { }

		internal int <DelemiterCountBotTypes>b__5_2(CountTypeBotWave x) { }

	}

	internal sealed class ProfileLoader : MulticastDelegate
	{

		public ProfileLoader(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(List data, EProfilesAskingStat stat, AsyncCallback callback, object object) { }

		public override Task EndInvoke(IAsyncResult result) { }

		public override Task Invoke(List data, EProfilesAskingStat stat) { }

	}

	public const int BACKEND_MAX = 100; //Field offset: 0x0
	protected List _simpleProfiles; //Field offset: 0x10
	protected bool _startPfoilesLoaded; //Field offset: 0x18

	public abstract int BundlesLoading
	{
		 get { } //Length: 0
	}

	public override bool StartProfilesLoaded
	{
		 get { } //Length: 5
	}

	protected ABotProfileCreator() { }

	public abstract void AddToTargetBackup(BotDifficulty difficulty, WildSpawnType role, int count) { }

	public override void CreateProfile(EPlayerSide side, WildSpawnType type, BotDifficulty botDifficulty, Action callback, bool withDelete) { }

	public override Task CreateProfile(BotCreationData data, CancellationToken cancellationToken, bool withDelete) { }

	public TwoDimensionalDictionary CurCacheddProfilesCount() { }

	public static List DelemiterCountBotTypes(List listWaves) { }

	public override void FillBackupProfilesData(DebugBotProfilesStructContainer resultCache) { }

	public abstract int get_BundlesLoading() { }

	public override bool get_StartProfilesLoaded() { }

	public Profile GetNewProfile() { }

	protected override Profile GetNewProfile(BotCreationData data, bool withDelete) { }

}

