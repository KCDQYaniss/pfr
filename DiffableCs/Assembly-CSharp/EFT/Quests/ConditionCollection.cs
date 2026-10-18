namespace EFT.Quests;

public sealed class ConditionCollection : UpdatableBindableList
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__3_0; //Field offset: 0x8
		public static Func <>9__5_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <get_EarlyFinisherConditions>b__3_0(Condition condition) { }

		internal bool <get_NecessaryConditions>b__5_0(Condition x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public int identity; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal bool <GetCondition>b__0(Condition condition) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public IConditional conditional; //Field offset: 0x10

		public <>c__DisplayClass8_0() { }

		internal bool <TestAll>b__0(Condition condition) { }

		internal bool <TestAll>b__1(Condition condition) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public IConditional conditional; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal bool <TestAny>b__0(Condition condition) { }

	}

	private IEnumerable _necessaryConditions; //Field offset: 0x70
	private IEnumerable _earlyFinisherConditions; //Field offset: 0x78

	private IEnumerable EarlyFinisherConditions
	{
		private get { } //Length: 596
	}

	private IEnumerable NecessaryConditions
	{
		private get { } //Length: 596
	}

	public ConditionCollection() { }

	private IEnumerable get_EarlyFinisherConditions() { }

	private IEnumerable get_NecessaryConditions() { }

	public IEnumerable GetCompletedConditionTemplates(IConditional conditional) { }

	[CanBeNull]
	private Condition GetCondition(int identity) { }

	[CanBeNull]
	public Condition GetCondition(ConditionCheck check) { }

	public bool MatchIdentities(ConditionCheck[] checks) { }

	public bool TestAll(IConditional conditional, out bool canResetProgress, ConditionCheck[] checks) { }

	public bool TestAll(IConditional conditional) { }

	public bool TestAny(IConditional conditional) { }

}

