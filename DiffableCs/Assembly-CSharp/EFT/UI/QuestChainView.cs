namespace EFT.UI;

public sealed class QuestChainView : UIElement
{
	[CompilerGenerated]
	private sealed class <GetChainListQuests>d__36 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Quest <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public QuestChainView <>4__this; //Field offset: 0x28
		private Quest <currentQuest>5__2; //Field offset: 0x30
		private IEnumerator <>7__wrap2; //Field offset: 0x38

		private override Quest System.Collections.Generic.IEnumerator<EFT.Quests.Quest>.Current
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
		public <GetChainListQuests>d__36(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.Quests.Quest>.GetEnumerator() { }

		[DebuggerHidden]
		private override Quest System.Collections.Generic.IEnumerator<EFT.Quests.Quest>.get_Current() { }

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
	private sealed class <GetQuestViews>d__29 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private QuestListItemView <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public QuestChainView <>4__this; //Field offset: 0x28
		private int <i>5__2; //Field offset: 0x30

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
		public <GetQuestViews>d__29(int <>1__state) { }

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

	private const float HISTORY_TOGGLE_DISABLED_ALPHA = 0.3; //Field offset: 0x0
	private const float HISTORY_TOGGLE_ENABLED_ALPHA = 1; //Field offset: 0x0
	[SerializeField]
	private QuestListItemView _mainQuestView; //Field offset: 0x70
	[SerializeField]
	private Button _historyToggle; //Field offset: 0x78
	[SerializeField]
	private CanvasGroup _historyToggleCanvasGroup; //Field offset: 0x80
	[SerializeField]
	private RectTransform _historyContainer; //Field offset: 0x88
	[SerializeField]
	private Image _arrowBackground; //Field offset: 0x90
	[SerializeField]
	private Image _arrowIcon; //Field offset: 0x98
	[SerializeField]
	private Color _arrowIconQuestSelectedColor; //Field offset: 0xA0
	[SerializeField]
	private Color _arrowIconQuestDeselectedColor; //Field offset: 0xB0
	[SerializeField]
	private float _arrowIconExpandedRotation; //Field offset: 0xC0
	[SerializeField]
	private QuestListItemView _questListItemViewPrefab; //Field offset: 0xC8
	private IReadOnlyList _chain; //Field offset: 0xD0
	private IReadOnlyList _excludeFilter; //Field offset: 0xD8
	private Action _onQuestSelected; //Field offset: 0xE0
	private QuestController _questController; //Field offset: 0xE8
	private bool _historyExpanded; //Field offset: 0xF0
	private bool _mainQuestViewIsSelected; //Field offset: 0xF1
	private readonly List _historyViews; //Field offset: 0xF8
	[CompilerGenerated]
	private string <ChainId>k__BackingField; //Field offset: 0x100

	public private string ChainId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public QuestChainView() { }

	[CompilerGenerated]
	private void <Show>b__23_0() { }

	[CompilerGenerated]
	private void <Show>b__23_1() { }

	public void ApplyFilters(IReadOnlyList excludeFilter) { }

	private void ClearHistoryViews() { }

	public virtual void Close() { }

	[CompilerGenerated]
	public string get_ChainId() { }

	[IteratorStateMachine(typeof(<GetChainListQuests>d__36))]
	private IEnumerable GetChainListQuests() { }

	private Quest GetCurrentQuest() { }

	[IteratorStateMachine(typeof(<GetQuestViews>d__29))]
	public IEnumerable GetQuestViews() { }

	private void OnMainQuestViewChanged() { }

	private void RefreshMainQuest() { }

	[CompilerGenerated]
	private void set_ChainId(string value) { }

	public void SetHistoryExpanded(bool expanded) { }

	public void Show(string chainId, IReadOnlyList chain, QuestListItemView questListItemViewPrefab, Action onQuestSelected, QuestController questController) { }

	private void SyncHistoryContainer() { }

	private void SyncMainQuestSelectionArrowColor() { }

	private void ToggleHistory() { }

	public bool TryGetQuestView(string questId, out QuestListItemView view) { }

	public bool TryRevealQuestView(string questId, out QuestListItemView view) { }

	private void UpdateArrowIconColor() { }

	private void UpdateArrowIconRotation() { }

	public void UpdateChain(IReadOnlyList chain, IReadOnlyList excludeFilter) { }

	private void UpdateHistoryList() { }

}

