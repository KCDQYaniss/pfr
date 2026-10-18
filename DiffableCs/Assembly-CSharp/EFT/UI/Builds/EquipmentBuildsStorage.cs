namespace EFT.UI.Builds;

public sealed class EquipmentBuildsStorage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__10_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <get_HasCustomBuilds>b__10_0(EquipmentBuild build) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public string name; //Field offset: 0x10

		public <>c__DisplayClass12_0() { }

		internal bool <FindCustomBuildByName>b__0(KeyValuePair x) { }

	}

	[CompilerGenerated]
	private struct <RemoveBuild>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EquipmentBuildsStorage <>4__this; //Field offset: 0x20
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
		public EquipmentBuild build; //Field offset: 0x20
		public EquipmentBuildsStorage <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string DEFAULT_BUILD_NAME_TEMPLATE = "NEW PRESET {0}"; //Field offset: 0x0
	private Dictionary _equipmentBuilds; //Field offset: 0x10
	private readonly IEftSession _session; //Field offset: 0x18
	private string _lastEquippedPresetName; //Field offset: 0x20

	public IReadOnlyDictionary EquipmentBuilds
	{
		 get { } //Length: 5
	}

	public bool HasCustomBuilds
	{
		 get { } //Length: 413
	}

	public string LastEquippedPresetName
	{
		 get { } //Length: 426
		 set { } //Length: 82
	}

	public EquipmentBuildsStorage(IEftSession session, Dictionary builds) { }

	[CanBeNull]
	public EquipmentBuild FindCustomBuildByName(string name) { }

	public IReadOnlyDictionary get_EquipmentBuilds() { }

	public bool get_HasCustomBuilds() { }

	public string get_LastEquippedPresetName() { }

	private string GetDefaultName() { }

	private void OverrideEquipmentBuild(EquipmentBuild equipmentBuild) { }

	[AsyncStateMachine(typeof(<RemoveBuild>d__17))]
	public Task RemoveBuild(MongoID buildId) { }

	[AsyncStateMachine(typeof(<SaveBuild>d__15))]
	public Task SaveBuild(EquipmentBuild build) { }

	public void SearchBuildOnRagfair(BuildItemSearchValue buildSearch) { }

	public void set_LastEquippedPresetName(string value) { }

}

