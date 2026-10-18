namespace EFT.UI;

public sealed class QuestObjectivesView : ConditionalObjectivesView
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public ConditionCollection conditions; //Field offset: 0x10
		public QuestObjectivesView <>4__this; //Field offset: 0x18

		public <>c__DisplayClass12_0() { }

		internal bool <StartCreateViewListOperation>b__0(Condition x) { }

		internal void <StartCreateViewListOperation>b__1(Condition condition, QuestObjectiveView view) { }

	}

	[CompilerGenerated]
	private struct <CreateViewList>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestObjectivesView <>4__this; //Field offset: 0x28
		public ConditionCollection conditions; //Field offset: 0x30
		private CancellationTokenSource <cancellationTokenSource>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private QuestObjectiveView _objectivePrefab; //Field offset: 0xA0
	[SerializeField]
	private GameObject _failtyBlock; //Field offset: 0xA8
	[SerializeField]
	private TextMeshProUGUI _timer; //Field offset: 0xB0
	[SerializeField]
	private Image _penaltyIcon; //Field offset: 0xB8
	private QuestController _questController; //Field offset: 0xC0
	private ItemController _inventoryController; //Field offset: 0xC8
	private Quest _quest; //Field offset: 0xD0
	private IEnumerator _timerWorker; //Field offset: 0xD8
	private CancellationTokenSource _cancellationTokenViewListCreation; //Field offset: 0xE0

	public QuestObjectivesView() { }

	[AsyncStateMachine(typeof(<CreateViewList>d__10))]
	protected virtual void CreateViewList(ConditionCollection conditions) { }

	public virtual void Show(ConditionalController controller, ItemController itemController, ConditionCollection conditions, IConditional conditional) { }

	private Task StartCreateViewListOperation(ConditionCollection conditions) { }

	private void UpdateTimer() { }

}

