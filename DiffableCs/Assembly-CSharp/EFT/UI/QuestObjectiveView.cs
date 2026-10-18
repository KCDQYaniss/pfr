namespace EFT.UI;

public sealed class QuestObjectiveView : ObjectiveView
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__11_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <QuestHandover>b__11_0(Item item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public TaskCompletionSource taskSource; //Field offset: 0x10
		public DialogWindowContext context; //Field offset: 0x18

		public <>c__DisplayClass11_0() { }

		internal void <QuestHandover>g__DeclineHandler|1() { }

	}

	[CompilerGenerated]
	private struct <QuestHandover>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestObjectiveView <>4__this; //Field offset: 0x20
		public Quest selectedQuest; //Field offset: 0x28
		private Item[] <itemsToHandover>5__2; //Field offset: 0x30
		private ConditionItem <itemCondition>5__3; //Field offset: 0x38
		private object <>7__wrap3; //Field offset: 0x40
		private int <>7__wrap4; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private DefaultUIButton _handoverButton; //Field offset: 0x118
	private HandoverQuestItemsWindow _handoverItemsWindow; //Field offset: 0x120
	private Quest _quest; //Field offset: 0x128
	private QuestController _questController; //Field offset: 0x130
	private bool _performingAction; //Field offset: 0x138
	private ItemController _itemController; //Field offset: 0x140

	public QuestObjectiveView() { }

	[CompilerGenerated]
	private void <CreateViewList>b__8_0() { }

	[CompilerGenerated]
	private void <CreateViewList>b__8_1(Condition item, QuestObjectiveView view) { }

	protected virtual void Awake() { }

	public virtual void Close() { }

	protected virtual void CreateViewList() { }

	protected virtual void OnConditionChanged(ConditionProgressChecker conditionProgressChecker) { }

	private void QuestHandover() { }

	[AsyncStateMachine(typeof(<QuestHandover>d__11))]
	private Task QuestHandover(Quest selectedQuest) { }

	public void Show(Quest quest, Condition condition, QuestController questController, ItemController itemController, Sprite icon, bool childCondition = false, string prefix = "") { }

}

