namespace EFT.UI;

[UsedImplicitly]
public sealed class TransferItemsScreen : EftScreen
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__25_0; //Field offset: 0x8
		public static Func <>9__25_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal IEnumerable <Show>b__25_0(DialogueChatMessage message) { }

		internal bool <Show>b__25_1(Item item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public TaskCompletionSource taskSource; //Field offset: 0x10

		public <>c__DisplayClass28_0() { }

		internal void <TryCloseScreen>b__0() { }

		internal void <TryCloseScreen>b__1() { }

	}

	[CompilerGenerated]
	private struct <ReceiveAll>d__29 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TransferItemsScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TransferAllItems>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TransferItemsScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28
		private YieldAwaiter <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryCloseScreen>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TransferItemsScreen <>4__this; //Field offset: 0x20
		private <>c__DisplayClass28_0 <>8__1; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class TransferItemsScreenController : EftScreenController
	{
		[CompilerGenerated]
		private struct <CloseScreenInterruption>d__11 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public TransferItemsScreenController <>4__this; //Field offset: 0x20
			public bool moveForward; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public readonly IEnumerable Messages; //Field offset: 0x58
		public readonly IHealthController HealthController; //Field offset: 0x60
		public readonly InventoryController InventoryController; //Field offset: 0x68
		public readonly Stash PlayerStash; //Field offset: 0x70
		public readonly IEftSession Session; //Field offset: 0x78
		public readonly Nullable ExpirationTime; //Field offset: 0x80

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		public TransferItemsScreenController(IEnumerable messages, IHealthController healthController, InventoryController inventoryController, Stash playerStash, IEftSession session, Nullable expirationTime = null) { }

		[CompilerGenerated]
		[DebuggerHidden]
		private Task <>n__0(bool moveForward) { }

		[AsyncStateMachine(typeof(<CloseScreenInterruption>d__11))]
		protected virtual Task CloseScreenInterruption(bool moveForward) { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		public virtual EEftScreenType get_ScreenType() { }

	}

	private const string PACKAGE_HAS_EXPIRED = "UI/TransferScreen/PackageHasExpired"; //Field offset: 0x0
	private const string TRANSFER_MESSAGE = "You still have untransfered items. Are you sure you want to end the transfer? You will be able to return to this process later."; //Field offset: 0x0
	[SerializeField]
	private SimpleStashPanel _stashPanel; //Field offset: 0xA0
	[SerializeField]
	private GridView _itemsToTransferGridView; //Field offset: 0xA8
	[SerializeField]
	private DefaultUIButton _closeButton; //Field offset: 0xB0
	[SerializeField]
	private DefaultUIButton _acceptButton; //Field offset: 0xB8
	[SerializeField]
	private DefaultUIButton _receiveAllButton; //Field offset: 0xC0
	[SerializeField]
	private GameObject _expirationTimePanel; //Field offset: 0xC8
	[SerializeField]
	private TextMeshProUGUI _expirationLabel; //Field offset: 0xD0
	private BindableState _isReceivingItems; //Field offset: 0xD8
	private ItemUiContext _itemUiContext; //Field offset: 0xE0
	private IEnumerable _messages; //Field offset: 0xE8
	private InventoryController _inventoryController; //Field offset: 0xF0
	private CompoundItem _lootItem; //Field offset: 0xF8
	private Nullable _expirationTime; //Field offset: 0x100
	private DateTime _lastTimerUpdate; //Field offset: 0x110
	private Grid _temporaryGrid; //Field offset: 0x118
	private Action _unbind; //Field offset: 0x120
	private ItemContext _transferContext; //Field offset: 0x128
	private ItemContext _stashContext; //Field offset: 0x130
	private Dictionary _itemExpirationTimeDict; //Field offset: 0x138

	public TransferItemsScreen() { }

	[CompilerGenerated]
	private void <Awake>b__22_0() { }

	[UsedImplicitly]
	private void Awake() { }

	private void ChangeReceivingItemsState(bool isReceiving) { }

	public virtual void Close() { }

	private void CollectExpiredItems() { }

	[AsyncStateMachine(typeof(<ReceiveAll>d__29))]
	private void ReceiveAll() { }

	public virtual void Show(TransferItemsScreenController controller) { }

	private void Show(IEnumerable messages, IHealthController healthController, InventoryController controller, Stash playerStash, IEftSession session, Nullable expirationTime) { }

	[AsyncStateMachine(typeof(<TransferAllItems>d__30))]
	private Task TransferAllItems() { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	[AsyncStateMachine(typeof(<TryCloseScreen>d__28))]
	private Task TryCloseScreen() { }

	[UsedImplicitly]
	private void Update() { }

}

