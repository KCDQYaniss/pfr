namespace EFT.UI;

public sealed class FlatQuestListDisplayView : BaseQuestListDisplayView
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public QuestListDisplayContext context; //Field offset: 0x10
		public FlatQuestListDisplayView <>4__this; //Field offset: 0x18
		public string traderId; //Field offset: 0x20

		public <>c__DisplayClass4_0() { }

		internal void <Show>b__0(Quest item, QuestListItemView view) { }

		internal bool <Show>g__IsVisible|1(Quest quest) { }

	}

	[CompilerGenerated]
	private sealed class <GetSelectableQuestViews>d__6 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private QuestListItemView <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public FlatQuestListDisplayView <>4__this; //Field offset: 0x28
		private IEnumerator <>7__wrap1; //Field offset: 0x30

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
		public <GetSelectableQuestViews>d__6(int <>1__state) { }

		private void <>m__Finally1() { }

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
	private RectTransform _questListContainer; //Field offset: 0x78
	[SerializeField]
	private QuestListItemView _questListItemViewPrefab; //Field offset: 0x80
	private BindableViewList _questBindableViewList; //Field offset: 0x88
	private IReadOnlyList _excludeFilter; //Field offset: 0x90

	public FlatQuestListDisplayView() { }

	public virtual void ApplyFilters(IReadOnlyList excludeFilter, bool showCompleted) { }

	public virtual void Close() { }

	[IteratorStateMachine(typeof(<GetSelectableQuestViews>d__6))]
	public virtual IEnumerable GetSelectableQuestViews() { }

	private void OnConditionStatusChanged(Conditional _) { }

	private void OnRemoveQuestFromList(Quest removedQuest) { }

	private void QuestAddedHandler(Quest addedQuest, QuestListItemView view) { }

	public virtual void Show(QuestListDisplayContext context) { }

	public virtual bool TryRevealFirstQuestView(ETierAccessoryType category, out QuestListItemView view) { }

	public virtual bool TryRevealQuestView(string questId, out QuestListItemView view) { }

	private void UpdateCounter() { }

	private void UpdateCounter(int successCount, int totalCount) { }

	private void UpdateSingleQuestVisibility(QuestListItemView questView) { }

	private void UpdateVisibility() { }

}

