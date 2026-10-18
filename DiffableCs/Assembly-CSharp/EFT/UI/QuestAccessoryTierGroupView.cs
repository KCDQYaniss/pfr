namespace EFT.UI;

public sealed class QuestAccessoryTierGroupView : BaseQuestAccessoryGroupView
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__16_0; //Field offset: 0x8
		public static Func <>9__16_1; //Field offset: 0x10
		public static Func <>9__16_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal string <SyncQuestsList>b__16_0(Quest quest) { }

		internal bool <SyncQuestsList>b__16_1(QuestListItemView view) { }

		internal string <SyncQuestsList>b__16_2(QuestListItemView view) { }

	}

	[SerializeField]
	private RectTransform _questsContainer; //Field offset: 0xD8
	[SerializeField]
	private QuestListItemView _questListItemViewPrefab; //Field offset: 0xE0
	private IReadOnlyList _quests; //Field offset: 0xE8
	private readonly List _questViews; //Field offset: 0xF0

	protected virtual RectTransform _contentContainer
	{
		 get { } //Length: 8
	}

	public QuestAccessoryTierGroupView() { }

	[CompilerGenerated]
	private bool <GetVisibleQuests>b__12_0(Quest q) { }

	protected virtual void ClearContentViews() { }

	public bool ContainsQuest(string questId) { }

	protected virtual RectTransform get__contentContainer() { }

	public IEnumerable GetQuestViews() { }

	private List GetVisibleQuests() { }

	protected virtual void Refresh() { }

	public virtual void RefreshStatusIcons() { }

	protected virtual void ResetContentState() { }

	public void Show(IReadOnlyList quests) { }

	protected virtual void SyncContentContainer() { }

	private void SyncQuestsList() { }

	public bool TryGetQuestView(string questId, out QuestListItemView view) { }

}

