namespace EFT.UI;

public sealed class QuestAccessoryChainGroupView : BaseQuestAccessoryGroupView
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__18_0; //Field offset: 0x8
		public static Func <>9__18_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <SyncChainsList>b__18_0(QuestChainDisplayData chain) { }

		internal string <SyncChainsList>b__18_1(QuestChainView view) { }

	}

	[CompilerGenerated]
	private sealed class <GetQuestViews>d__17 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private QuestListItemView <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public QuestAccessoryChainGroupView <>4__this; //Field offset: 0x28
		private Enumerator <>7__wrap1; //Field offset: 0x30
		private IEnumerator <>7__wrap2; //Field offset: 0x48

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
		public <GetQuestViews>d__17(int <>1__state) { }

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
	private RectTransform _chainsContainer; //Field offset: 0xD8
	[SerializeField]
	private QuestChainView _questChainViewPrefab; //Field offset: 0xE0
	[SerializeField]
	private QuestListItemView _questListItemViewPrefab; //Field offset: 0xE8
	private IReadOnlyList _chains; //Field offset: 0xF0
	private readonly List _chainViews; //Field offset: 0xF8
	private readonly List _questsForStatusIcons; //Field offset: 0x100

	protected virtual RectTransform _contentContainer
	{
		 get { } //Length: 8
	}

	public QuestAccessoryChainGroupView() { }

	[CompilerGenerated]
	private bool <GetDisplayableChains>b__14_0(QuestChainDisplayData chain) { }

	protected virtual void ClearContentViews() { }

	public bool ContainsQuest(string questId) { }

	protected virtual RectTransform get__contentContainer() { }

	private IEnumerable GetDisplayableChains() { }

	[IteratorStateMachine(typeof(<GetQuestViews>d__17))]
	public IEnumerable GetQuestViews() { }

	protected virtual void Refresh() { }

	public virtual void RefreshStatusIcons() { }

	protected virtual void ResetContentState() { }

	public void Show(IReadOnlyList chains) { }

	private void SyncChainsList() { }

	protected virtual void SyncContentContainer() { }

	public bool TryGetQuestView(string questId, out QuestListItemView view) { }

}

