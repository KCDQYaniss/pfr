namespace EFT.UI.Quests;

public sealed class MainQuestChapterTasksView : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"Quest", "Condition"})]
		public static Func <>9__11_0; //Field offset: 0x8
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"Quest", "Condition"})]
		public static Func <>9__11_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <UpdateConditions>b__11_0(ValueTuple questAndCondition) { }

		internal bool <UpdateConditions>b__11_1(ValueTuple questAndCondition) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public QuestController questController; //Field offset: 0x10
		public IReadOnlyList subQuests; //Field offset: 0x18
		public QuestChapter chapter; //Field offset: 0x20
		public MainQuestChapterTasksView <>4__this; //Field offset: 0x28
		public IChaptersViewController viewController; //Field offset: 0x30

		public <>c__DisplayClass10_0() { }

		internal void <ShowConditions>b__0() { }

		internal void <ShowConditions>g__QuestChangeHandler|1(Conditional conditional) { }

	}

	[SerializeField]
	private MainQuestTaskListView _mainTasksList; //Field offset: 0x70
	[SerializeField]
	private MainQuestTaskListView _optionalTasksList; //Field offset: 0x78
	[SerializeField]
	private GameObject _expandTasksButton; //Field offset: 0x80
	private IChaptersViewController _viewController; //Field offset: 0x88
	private bool _alwaysExpanded; //Field offset: 0x90
	private bool _expanded; //Field offset: 0x91

	public MainQuestChapterTasksView() { }

	[CompilerGenerated]
	private void <Show>b__6_0() { }

	[CompilerGenerated]
	private void <Show>b__6_1() { }

	public void ReadAll() { }

	private void ReadConditions(EChapterConditionType type) { }

	public void SetExpanded(bool expanded) { }

	public void Show(IChaptersViewController viewController) { }

	private void ShowConditions(IChaptersViewController viewController) { }

	private void UpdateConditions(IChaptersViewController viewController) { }

}

