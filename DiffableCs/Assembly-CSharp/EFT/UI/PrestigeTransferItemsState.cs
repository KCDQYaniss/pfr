namespace EFT.UI;

public sealed class PrestigeTransferItemsState : EftScreenState, ISelectionContext
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__26_0; //Field offset: 0x8
		public static Func <>9__27_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <NextClickHandler>b__26_0() { }

		internal PrestigeObtainData <SendItemsAccept>b__27_0(KeyValuePair itemInCollection) { }

	}

	[CompilerGenerated]
	private struct <HideState>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PrestigeTransferItemsState <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <NextClickHandler>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PrestigeTransferItemsState <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendItemsAccept>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PrestigeTransferItemsState <>4__this; //Field offset: 0x20
		private IEnumerable <data>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowState>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PrestigeTransferItemsState <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ValidateTransform>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public PrestigeTransferItemsState <>4__this; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const string MESSAGE_DESCRIPTION = "TransferItemsMessage/Description"; //Field offset: 0x0
	[SerializeField]
	private GridView _stashView; //Field offset: 0x90
	[SerializeField]
	private SimpleStashPanel _stashPanel; //Field offset: 0x98
	[SerializeField]
	private ArenaEftItemTransferGridView _transferView; //Field offset: 0xA0
	[SerializeField]
	private Image _prestigeLevel; //Field offset: 0xA8
	[SerializeField]
	private TMP_Text _sizeLabel; //Field offset: 0xB0
	[SerializeField]
	private RectTransform _transferRoot; //Field offset: 0xB8
	[SerializeField]
	private ToggleButton _fitItemsButton; //Field offset: 0xC0
	[SerializeField]
	private PrestigeTransferTableWindow _fitItemsWindow; //Field offset: 0xC8
	private HashSet _selectedItems; //Field offset: 0xD0
	private ItemUiContext _itemUiContext; //Field offset: 0xD8
	private ReferenceGrid _transferGrid; //Field offset: 0xE0
	private ItemController _fakeController; //Field offset: 0xE8
	private InventoryController _inventoryController; //Field offset: 0xF0
	private IEftSession _session; //Field offset: 0xF8
	private TransferStashConfig _stashConfig; //Field offset: 0x100
	private PrestigeSettings _prestigeSettings; //Field offset: 0x108
	[CompilerGenerated]
	private Action OnItemSelected; //Field offset: 0x110

	public override event Action OnItemSelected
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public PrestigeTransferItemsState() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__1() { }

	[CompilerGenerated]
	private void <ToggleFitWindowHandler>b__25_0() { }

	[CompilerGenerated]
	public override void add_OnItemSelected(Action value) { }

	public virtual void Close() { }

	private Stash CreateTransferStash() { }

	private override bool EFT.InventoryLogic.SelectableItemContext.ISelectionContext.IsActive(ItemContext context, out string tooltip) { }

	private override bool EFT.InventoryLogic.SelectableItemContext.ISelectionContext.IsSelected(Item item) { }

	private override void EFT.InventoryLogic.SelectableItemContext.ISelectionContext.ToggleSelection(SelectableItemContext context) { }

	private void HideInventoryViews() { }

	[AsyncStateMachine(typeof(<HideState>d__22))]
	public virtual Task HideState() { }

	public void Init(InventoryController inventoryController, IEftSession session, int prestigeLevelToOpen) { }

	private bool IsSelected(Item item) { }

	[AsyncStateMachine(typeof(<NextClickHandler>d__26))]
	public Task NextClickHandler() { }

	[CompilerGenerated]
	public override void remove_OnItemSelected(Action value) { }

	private void SelectItem(Item item, GridItemAddress to = null) { }

	[AsyncStateMachine(typeof(<SendItemsAccept>d__27))]
	private Task SendItemsAccept() { }

	private void ShowInventoryViews() { }

	[AsyncStateMachine(typeof(<ShowState>d__21))]
	public virtual Task ShowState() { }

	private void ToggleFitWindowHandler(bool active) { }

	[AsyncStateMachine(typeof(<ValidateTransform>d__34))]
	private void ValidateTransform() { }

}

