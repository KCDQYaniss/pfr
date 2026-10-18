namespace EFT.UI;

public sealed class TraderAvatar : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public TraderAvatar <>4__this; //Field offset: 0x10
		public InventoryController inventoryController; //Field offset: 0x18

		public <>c__DisplayClass10_0() { }

		internal void <Show>b__0() { }

		internal void <Show>b__1() { }

		internal void <Show>b__2() { }

	}

	[CompilerGenerated]
	private struct <SetAvatar>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TraderAvatar <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private GameObject _availableToStartQuestsIcon; //Field offset: 0x70
	[SerializeField]
	private GameObject _availableToFinishQuestsIcon; //Field offset: 0x78
	[SerializeField]
	private GameObject _availableToHandoverQuestsIcon; //Field offset: 0x80
	[SerializeField]
	private GameObject _availableDialogueIcon; //Field offset: 0x88
	[SerializeField]
	private Image _avatar; //Field offset: 0x90
	[SerializeField]
	private GameObject _loader; //Field offset: 0x98
	private TraderInfo _traderInfo; //Field offset: 0xA0
	private QuestController _questController; //Field offset: 0xA8
	private bool _traderHasDialogue; //Field offset: 0xB0
	private bool _questStatusRefreshPending; //Field offset: 0xB1

	public TraderAvatar() { }

	public virtual void Close() { }

	private void OnConditionStatusChanged(Conditional _) { }

	private void OnInventoryItemAdded(AddItemEventArgs eventArgs) { }

	private void OnInventoryItemRefreshed(RefreshItemEventArgs _) { }

	private void OnInventoryItemRemoved(RemoveItemEventArgs eventArgs) { }

	private void OnTraderAvailabilityChanged() { }

	[AsyncStateMachine(typeof(<SetAvatar>d__19))]
	private Task SetAvatar() { }

	public void Show(TraderInfo trader, QuestController questController, bool traderHasDialogue) { }

	private void Update() { }

	private void UpdateConditionalStatus() { }

	private void UpdateDialogueStatus() { }

}

