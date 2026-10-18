namespace EFT.UI.Builds;

[DefaultMember("Item")]
public sealed class WeaponBuildsStorage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__12_0; //Field offset: 0x8
		public static Func <>9__12_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <FindBuild>b__12_0(Item x) { }

		internal string <FindBuild>b__12_1(Item x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public string name; //Field offset: 0x10

		public <>c__DisplayClass8_0() { }

		internal bool <FindByName>b__0(KeyValuePair x) { }

	}

	[CompilerGenerated]
	private struct <RemoveBuild>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WeaponBuildsStorage <>4__this; //Field offset: 0x20
		public MongoID buildId; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SaveBuild>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WeaponBuild build; //Field offset: 0x20
		public WeaponBuildsStorage <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private readonly Dictionary <WeaponBuilds>k__BackingField; //Field offset: 0x10
	private readonly IEftSession _session; //Field offset: 0x18

	private Handbook Handbook
	{
		private get { } //Length: 46
	}

	[CanBeNull]
	public WeaponBuild Item
	{
		 get { } //Length: 110
	}

	private Dictionary WeaponBuilds
	{
		[CompilerGenerated]
		private get { } //Length: 5
	}

	public WeaponBuildsStorage(IEftSession session, Dictionary builds) { }

	public void AddItemPresets(ItemPreset[] itemPresets) { }

	private WeaponBuild BuildFromPreset(ItemPreset preset) { }

	[CanBeNull]
	public WeaponBuild FindBuild(Item item) { }

	[CanBeNull]
	public WeaponBuild FindByName(string name) { }

	private Handbook get_Handbook() { }

	public WeaponBuild get_Item(MongoID id) { }

	[CompilerGenerated]
	private Dictionary get_WeaponBuilds() { }

	private void InsertBuild(WeaponBuild build) { }

	[CanBeNull]
	private HandbookNode NodeFromBuild(WeaponBuild build) { }

	private void OverrideWeaponBuild(WeaponBuild weaponBuild) { }

	public void ReinsertAll() { }

	[AsyncStateMachine(typeof(<RemoveBuild>d__17))]
	public Task RemoveBuild(MongoID buildId) { }

	private void RemoveBuildFromHandbook(MongoID buildId) { }

	[AsyncStateMachine(typeof(<SaveBuild>d__15))]
	public Task SaveBuild(WeaponBuild build) { }

}

