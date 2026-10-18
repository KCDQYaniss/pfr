namespace EFT.UI;

public sealed class QuestItemsUnloadWindow : BaseMessageWindow
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public QuestItemsUnloadWindow <>4__this; //Field offset: 0x10
		public Item item; //Field offset: 0x18
		public QuestItemRow view; //Field offset: 0x20

		public <>c__DisplayClass10_0() { }

		internal void <TryCreateQuestItemView>b__0() { }

	}

	[CompilerGenerated]
	private struct <MoveOut>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public KeyValuePair pair; //Field offset: 0x20
		public QuestItemsUnloadWindow <>4__this; //Field offset: 0x30
		private QuestItemRow <view>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40
		private TaskAwaiter <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <MoveOutAll>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestItemsUnloadWindow <>4__this; //Field offset: 0x20
		private KeyValuePair[] <>7__wrap1; //Field offset: 0x28
		private int <>7__wrap2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private QuestItemRow _questItemRowOriginal; //Field offset: 0xF0
	[SerializeField]
	private Transform _container; //Field offset: 0xF8
	[SerializeField]
	private DefaultUIButton _moveOutAll; //Field offset: 0x100
	private Dictionary _questItems; //Field offset: 0x108
	private InventoryController _inventoryController; //Field offset: 0x110
	private Dictionary _questsBuffer; //Field offset: 0x118

	public QuestItemsUnloadWindow() { }

	[CompilerGenerated]
	private void <Start>b__6_0() { }

	private void Clean() { }

	private Dictionary CreateQuestItemsMap(QuestController questController) { }

	[AsyncStateMachine(typeof(<MoveOut>d__12))]
	private Task MoveOut(KeyValuePair pair) { }

	[AsyncStateMachine(typeof(<MoveOutAll>d__11))]
	private Task MoveOutAll() { }

	public DialogWindowContext Show(InventoryController inventoryController, QuestController questController, Profile profile) { }

	private void Start() { }

	private bool TryCreateQuestItemView(Quest targetQuest, Item item, out QuestItemRow questItemRow) { }

	public bool TryShow(InventoryController inventoryController, QuestController questController, Profile profile, out DialogWindowContext context) { }

}

