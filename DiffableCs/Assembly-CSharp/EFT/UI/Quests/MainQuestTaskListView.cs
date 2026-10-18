namespace EFT.UI.Quests;

public sealed class MainQuestTaskListView : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public IBindableList readQuestData; //Field offset: 0x10
		public MainQuestTaskListView <>4__this; //Field offset: 0x18

		public <>c__DisplayClass11_0() { }

		internal void <Show>b__0() { }

	}

	[SerializeField]
	private RectTransform _conditionsContainer; //Field offset: 0x70
	[SerializeField]
	private MainQuestTaskView _conditionsViewTemplate; //Field offset: 0x78
	[SerializeField]
	private GameObject _unreadWarning; //Field offset: 0x80
	[SerializeField]
	private HoverReadTrigger _hoverReadTrigger; //Field offset: 0x88
	private readonly BindableEvent _onReadAll; //Field offset: 0x90
	private IChaptersViewController _viewController; //Field offset: 0x98
	private readonly List _conditions; //Field offset: 0xA0
	private readonly HashSet _conditionIds; //Field offset: 0xA8
	private UiElementPool _pool; //Field offset: 0xB0

	public IBindableEvent OnReadAll
	{
		 get { } //Length: 8
	}

	public MainQuestTaskListView() { }

	public IBindableEvent get_OnReadAll() { }

	private static bool IsPrimary(IChaptersViewController viewController, MainQuest quest, Condition condition) { }

	private void ReadAll() { }

	private void ReadDataChangeHandler(MongoID dataId) { }

	public void Show(IEnumerable conditions, IChaptersViewController viewController, bool expanded, out bool hasHiddenConditions) { }

	private void UpdateReadStatus() { }

}

