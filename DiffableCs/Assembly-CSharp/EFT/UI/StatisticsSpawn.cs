namespace EFT.UI;

public sealed class StatisticsSpawn : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		private struct <<SpawnStats>g__AwaitShowComplete|1>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass5_0 <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public StatisticsSpawn <>4__this; //Field offset: 0x10
		public StatGroupView prevGroupView; //Field offset: 0x18
		public List updateParents; //Field offset: 0x20
		public int currentViewCount; //Field offset: 0x28
		public GameObject currentGroup; //Field offset: 0x30
		public AsyncViewList viewList; //Field offset: 0x38
		public CancellationToken cancellationToken; //Field offset: 0x40

		public <>c__DisplayClass5_0() { }

		internal void <SpawnStats>b__0(StatGroup group, StatGroupView groupView) { }

		[AsyncStateMachine(typeof(<<SpawnStats>g__AwaitShowComplete|1>d))]
		internal Task <SpawnStats>g__AwaitShowComplete|1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public HorizontalLayoutGroup group; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal void <CreateVerticalGroup>b__0() { }

	}

	internal enum EStatGroupLayoutType
	{
		Default = 0,
		SameColumn = 1,
	}

	internal enum EStatisticsType
	{
		Overall = 0,
		Session = 1,
	}

	[SerializeField]
	private StatGroupView _statGroupViewTemplate; //Field offset: 0x70
	[SerializeField]
	private Transform _statsContainer; //Field offset: 0x78
	[SerializeField]
	private HorizontalLayoutGroup _horizontalGroup; //Field offset: 0x80

	public StatisticsSpawn() { }

	private GameObject CreateVerticalGroup() { }

	internal void SpawnStats(Profile profile, CountersCollection counters, EStatisticsType type) { }

}

