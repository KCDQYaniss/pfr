namespace EFT.Quests;

public sealed class ConditionCounterManager
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public TaskConditionCounter counter; //Field offset: 0x10

		public <>c__DisplayClass5_0() { }

		internal bool <Load>b__0(TaskConditionCounter x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public MongoID id; //Field offset: 0x10

		public <>c__DisplayClass7_0() { }

		internal bool <GetCounter>b__0(TaskConditionCounter counter) { }

	}

	[CompilerGenerated]
	private sealed class <GetCounters>d__8 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private TaskConditionCounter <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public ConditionCounterManager <>4__this; //Field offset: 0x28
		private bool excludeNonGroupProgress; //Field offset: 0x30
		public bool <>3__excludeNonGroupProgress; //Field offset: 0x31
		private ConditionCheck[] checks; //Field offset: 0x38
		public ConditionCheck[] <>3__checks; //Field offset: 0x40
		private Enumerator <>7__wrap1; //Field offset: 0x48

		private override TaskConditionCounter System.Collections.Generic.IEnumerator<EFT.Quests.TaskConditionCounter>.Current
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
		public <GetCounters>d__8(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.Quests.TaskConditionCounter>.GetEnumerator() { }

		[DebuggerHidden]
		private override TaskConditionCounter System.Collections.Generic.IEnumerator<EFT.Quests.TaskConditionCounter>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private readonly IConditional _conditional; //Field offset: 0x10
	private readonly Dictionary _profileCounters; //Field offset: 0x18
	private readonly List _counters; //Field offset: 0x20

	public ConditionCounterManager(IConditional conditional, Dictionary profileCounters) { }

	public void Clear() { }

	[CanBeNull]
	public TaskConditionCounter GetCounter(MongoID id) { }

	[IteratorStateMachine(typeof(<GetCounters>d__8))]
	private IEnumerable GetCounters(ConditionCheck[] checks, bool excludeNonGroupProgress = false) { }

	private void Load(IEnumerable templates) { }

	public void LoadConditionCounters() { }

	public void ResetNullableConditions() { }

	public void Test(int valueToAdd, ConditionCheck[] checks) { }

	private static void Test(int valueToAdd, TaskConditionCounter counter, ConditionCheck[] checks) { }

	public void TestFromGroupPartyMember(int valueToAdd, ConditionCheck[] checks) { }

}

