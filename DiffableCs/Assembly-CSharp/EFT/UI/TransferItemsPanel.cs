namespace EFT.UI;

[UsedImplicitly]
public sealed class TransferItemsPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public InventoryController itemOwner; //Field offset: 0x10
		public TransferItemsPanel <>4__this; //Field offset: 0x18
		public IItemOwner rightController; //Field offset: 0x20

		public <>c__DisplayClass35_0() { }

		internal void <Show>b__0() { }

	}

	[CompilerGenerated]
	private struct <TryToRemoveAllFromCurrentItem>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TransferItemsPanel <>4__this; //Field offset: 0x20
		public bool force; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string BTR_CONTAINER_NAME_KEY = "TransferItemsScreen/BtrContainerName"; //Field offset: 0x0
	private const string TRANSFER_SCREEN_ERROR_MOVING_NOTIFICATION = "TransferScreen/ErrorMovingNotification"; //Field offset: 0x0
	private const string TRANSFER_SCREEN_PRICE_MESSAGE = "TransferScreen/PriceMessage"; //Field offset: 0x0
	private const string TRANSFER_SCREEN_NOT_ENOUGH_MONEY = "TransferScreen/NotEnoughMoney"; //Field offset: 0x0
	private const string TRANSFER_SCREEN_NOTHING_TO_TRANSFER = "TransferScreen/NothingToTransfer"; //Field offset: 0x0
	private const string TRANSFER_SCREEN_NOTHING_TO_REMOVE = "TransferScreen/NothingToRemove"; //Field offset: 0x0
	[SerializeField]
	private TextMeshProUGUI _containerName; //Field offset: 0x70
	[SerializeField]
	private TextMeshProUGUI _totalPrice; //Field offset: 0x78
	[SerializeField]
	private SearchableItemView _simplePanel; //Field offset: 0x80
	[SerializeField]
	private GridView _itemsToHandover; //Field offset: 0x88
	[SerializeField]
	private DefaultUIButton _transferButton; //Field offset: 0x90
	[SerializeField]
	private DefaultUIButton _cancelButton; //Field offset: 0x98
	private InventoryController _inventoryController; //Field offset: 0xA0
	private Stash _item; //Field offset: 0xA8
	private bool _needUpdateCounters; //Field offset: 0xB0
	private Task _transferTask; //Field offset: 0xB8
	private TransferItemsController _transferItemsController; //Field offset: 0xC0
	private readonly BindableEvent _onApplyTransfer; //Field offset: 0xC8
	[CompilerGenerated]
	private ItemContext <ItemContext>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private ItemUiContext <ItemUiContext>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private int <SumItemsPrice>k__BackingField; //Field offset: 0xE0

	private ItemContext ItemContext
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private ItemUiContext ItemUiContext
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public IBindableEvent OnApplyTransfer
	{
		 get { } //Length: 8
	}

	public private int SumItemsPrice
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public TransferItemsPanel() { }

	[CompilerGenerated]
	private void <Awake>b__32_0() { }

	private void Awake() { }

	public virtual void Close() { }

	[CompilerGenerated]
	private ItemContext get_ItemContext() { }

	[CompilerGenerated]
	private ItemUiContext get_ItemUiContext() { }

	public IBindableEvent get_OnApplyTransfer() { }

	[CompilerGenerated]
	public int get_SumItemsPrice() { }

	private void OwnerUpdateHandler(EventArgs _) { }

	[CompilerGenerated]
	private void set_ItemContext(ItemContext value) { }

	[CompilerGenerated]
	private void set_ItemUiContext(ItemUiContext value) { }

	[CompilerGenerated]
	private void set_SumItemsPrice(int value) { }

	public void Show(Stash item, ItemContext itemContext, InventoryController inventoryController, TransferItemsController transferItemsController) { }

	private void TransferItems() { }

	[AsyncStateMachine(typeof(<TryToRemoveAllFromCurrentItem>d__34))]
	public Task TryToRemoveAllFromCurrentItem(bool force = false) { }

	public void Update() { }

	private void UpdateCounters() { }

}

