namespace EFT.UI;

public sealed class TieredQuestListDisplayView : BaseQuestListDisplayView
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__24_0; //Field offset: 0x8
		public static Func <>9__26_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <SetDailyQuests>b__26_0(Quest q) { }

		internal bool <UpdateChainsGroup>b__24_0(Quest q) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public ETierAccessoryType tier; //Field offset: 0x10

		public <>c__DisplayClass25_0() { }

		internal bool <SetTierQuests>b__0(Quest q) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public string traderId; //Field offset: 0x10

		public <>c__DisplayClass28_0() { }

		internal bool <GetTraderQuests>b__0(Quest q) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public string id; //Field offset: 0x10

		public <>c__DisplayClass29_0() { }

		internal bool <GroupIntoChains>b__0(Quest q) { }

	}

	[CompilerGenerated]
	private sealed class <EnumerateGroups>d__17 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private BaseQuestAccessoryGroupView <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public TieredQuestListDisplayView <>4__this; //Field offset: 0x28
		private QuestAccessoryTierGroupView[] <>7__wrap1; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38

		private override BaseQuestAccessoryGroupView System.Collections.Generic.IEnumerator<EFT.UI.BaseQuestAccessoryGroupView>.Current
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
		public <EnumerateGroups>d__17(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.UI.BaseQuestAccessoryGroupView>.GetEnumerator() { }

		[DebuggerHidden]
		private override BaseQuestAccessoryGroupView System.Collections.Generic.IEnumerator<EFT.UI.BaseQuestAccessoryGroupView>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <GetSelectableQuestViews>d__11 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private QuestListItemView <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public TieredQuestListDisplayView <>4__this; //Field offset: 0x28
		private IEnumerator <>7__wrap1; //Field offset: 0x30
		private IEnumerator <>7__wrap2; //Field offset: 0x38

		private override QuestListItemView System.Collections.Generic.IEnumerator<EFT.UI.QuestListItemView>.Current
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
		public <GetSelectableQuestViews>d__11(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.UI.QuestListItemView>.GetEnumerator() { }

		[DebuggerHidden]
		private override QuestListItemView System.Collections.Generic.IEnumerator<EFT.UI.QuestListItemView>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[SerializeField]
	private QuestAccessoryTierGroupView _tier1Group; //Field offset: 0x78
	[SerializeField]
	private QuestAccessoryTierGroupView _tier2Group; //Field offset: 0x80
	[SerializeField]
	private QuestAccessoryTierGroupView _tier3Group; //Field offset: 0x88
	[SerializeField]
	private QuestAccessoryTierGroupView _tier4Group; //Field offset: 0x90
	[SerializeField]
	private QuestAccessoryTierGroupView _dailyGroup; //Field offset: 0x98
	[SerializeField]
	private QuestAccessoryChainGroupView _chainsGroup; //Field offset: 0xA0
	private QuestAccessoryTierGroupView[] _tierGroups; //Field offset: 0xA8
	private IReadOnlyList _excludeFilter; //Field offset: 0xB0

	public TieredQuestListDisplayView() { }

	public virtual void ApplyFilters(IReadOnlyList excludeFilter, bool showCompleted) { }

	private void ApplyFiltersToTierGroups() { }

	private void Awake() { }

	public virtual void Close() { }

	private void CloseGroups() { }

	private void ConfigureGroups(Action onQuestSelected) { }

	[IteratorStateMachine(typeof(<EnumerateGroups>d__17))]
	private IEnumerable EnumerateGroups() { }

	private BaseQuestAccessoryGroupView FindGroup(ETierAccessoryType category) { }

	private static string GetCollapsedKey(string traderId, ETierAccessoryType tier) { }

	[IteratorStateMachine(typeof(<GetSelectableQuestViews>d__11))]
	public virtual IEnumerable GetSelectableQuestViews() { }

	private List GetTraderQuests() { }

	private List GroupIntoChains(List quests) { }

	private void OnConditionStatusChanged(Conditional _) { }

	private void OnGroupExpandedChanged(ETierAccessoryType tier, bool expanded) { }

	private void OnQuestCollectionChanged(Quest _) { }

	private void RebuildList() { }

	private void RefreshAfterStatusChanged() { }

	public virtual void RefreshStatuses() { }

	private void SetDailyQuests(IReadOnlyList allQuests) { }

	private void SetTierQuests(QuestAccessoryTierGroupView group, IReadOnlyList allQuests, ETierAccessoryType tier) { }

	public virtual void Show(QuestListDisplayContext context) { }

	public virtual bool TryRevealFirstQuestView(ETierAccessoryType category, out QuestListItemView view) { }

	public virtual bool TryRevealQuestView(string questId, out QuestListItemView view) { }

	private void UpdateChainsGroup(IReadOnlyList allQuests = null) { }

	private void UpdateCounter() { }

}

