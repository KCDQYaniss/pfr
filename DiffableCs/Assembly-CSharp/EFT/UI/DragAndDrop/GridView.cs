namespace EFT.UI.DragAndDrop;

public class GridView : UIElement, IContainerView, IAddHandler, IItemRelatedView, IRemoveHandler, IRefreshHandler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate <>9__35_0; //Field offset: 0x8
		public static Func <>9__42_0; //Field offset: 0x10
		public static Func <>9__42_1; //Field offset: 0x18
		public static Predicate <>9__45_0; //Field offset: 0x20
		public static Predicate <>9__45_1; //Field offset: 0x28
		public static Predicate <>9__46_0; //Field offset: 0x30
		public static Predicate <>9__46_1; //Field offset: 0x38

		private static <>c() { }

		public <>c() { }

		internal bool <EFT.IAddHandler.OnItemAdded>b__45_0(ItemView view) { }

		internal bool <EFT.IAddHandler.OnItemAdded>b__45_1(ItemView view) { }

		internal bool <EFT.IRemoveHandler.OnItemRemoved>b__46_0(ItemView view) { }

		internal bool <EFT.IRemoveHandler.OnItemRemoved>b__46_1(ItemView view) { }

		internal bool <ItemFoundHandler>b__35_0(ItemView iv) { }

		internal Item <MagnifyIfPossible>b__42_0(KeyValuePair elem) { }

		internal LocationInGrid <MagnifyIfPossible>b__42_1(KeyValuePair elem) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public IItemOwner itemOwner; //Field offset: 0x10
		public GridView <>4__this; //Field offset: 0x18
		public IPlayerSearchController playerSearchController; //Field offset: 0x20

		public <>c__DisplayClass34_0() { }

		internal void <Show>b__0() { }

		internal void <Show>b__1() { }

		internal void <Show>b__2() { }

		internal void <Show>b__3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass40_0
	{
		public GridItemAddress gridItemAddress; //Field offset: 0x10
		public GridView <>4__this; //Field offset: 0x18

		public <>c__DisplayClass40_0() { }

		internal bool <ManageActiveEvents>b__0(ItemView x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass40_1
	{
		public GridItemAddress gridItemAddress; //Field offset: 0x10
		public GridView <>4__this; //Field offset: 0x18

		public <>c__DisplayClass40_1() { }

		internal bool <ManageActiveEvents>b__1(ItemView x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass62_0
	{
		public DragItemContext itemContext; //Field offset: 0x10

		public <>c__DisplayClass62_0() { }

		internal DragItemContext <AcceptItem>b__0(Item item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass63_0
	{
		public SplitResult <splitResult>5__2; //Field offset: 0x10
		public TransferResult <transferResult>5__3; //Field offset: 0x18
		public GridView <>4__this; //Field offset: 0x20

		public <>c__DisplayClass63_0() { }

		internal void <AcceptOnce>b__1(int count) { }

		internal void <AcceptOnce>b__3(int count) { }

	}

	[CompilerGenerated]
	private struct <AcceptItem>d__62 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DragItemContext itemContext; //Field offset: 0x20
		public GridView <>4__this; //Field offset: 0x28
		public ItemContext targetItemContext; //Field offset: 0x30
		private <>c__DisplayClass62_0 <>8__1; //Field offset: 0x38
		private bool <ctrlPressed>5__2; //Field offset: 0x40
		private IEnumerator <>7__wrap2; //Field offset: 0x48
		private DragItemContext <tempContext>5__4; //Field offset: 0x50
		private bool <continueOperation>5__5; //Field offset: 0x58
		private bool <exit>5__6; //Field offset: 0x59
		private TaskAwaiter <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AcceptOnce>d__63 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GridView <>4__this; //Field offset: 0x20
		public DragItemContext itemContext; //Field offset: 0x28
		public ItemContext targetItemContext; //Field offset: 0x30
		public bool ctrlPressed; //Field offset: 0x38
		private OperationResult <possibleOperation>5__2; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <MagnifyIfPossible>d__42 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GridView <>4__this; //Field offset: 0x20
		public Rect rect; //Field offset: 0x28
		public bool force; //Field offset: 0x38
		private CancellationToken <currentCancellation>5__2; //Field offset: 0x40
		private bool <isAsync>5__3; //Field offset: 0x48
		private int <createdItems>5__4; //Field offset: 0x4C
		private Enumerator <>7__wrap4; //Field offset: 0x50
		private YieldAwaiter <>u__1; //Field offset: 0x78

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int CELL_SIZE = 63; //Field offset: 0x0
	private const int ASYNC_ITEM_BATCH_SIZE = 8; //Field offset: 0x0
	protected static readonly Color InvalidOperationColor; //Field offset: 0x0
	protected static readonly Color ValidMoveColor; //Field offset: 0x10
	private static readonly Color _swapColor; //Field offset: 0x20
	private static readonly Color _splitMergeColor; //Field offset: 0x30
	[SerializeField]
	private Image _highlightPanel; //Field offset: 0x70
	[SerializeField]
	private bool _nonInteractable; //Field offset: 0x78
	[SerializeField]
	private bool _isAsyncAllowed; //Field offset: 0x79
	[SerializeField]
	private FilterPanel _filterPanel; //Field offset: 0x80
	[SerializeField]
	private bool _drawDebugGizmos; //Field offset: 0x88
	private bool _asyncCreationAllowed; //Field offset: 0x89
	[CompilerGenerated]
	private ItemContext <SourceContext>k__BackingField; //Field offset: 0x90
	private bool _isMagnified; //Field offset: 0x98
	public Grid Grid; //Field offset: 0xA0
	protected readonly Dictionary ItemViews; //Field offset: 0xA8
	private IItemOwner _itemOwner; //Field offset: 0xB0
	protected ItemController _itemController; //Field offset: 0xB8
	private ItemUiContext _itemUiContext; //Field offset: 0xC0
	private Nullable _visibleLocalRect; //Field offset: 0xC8
	private RectTransform _rectTransform; //Field offset: 0xE0
	private CancellationTokenSource _cancellationTokenSource; //Field offset: 0xE8
	private Rect _cachedRect; //Field offset: 0xF0
	private IntVec2 _gridSize; //Field offset: 0x100

	protected FilterPanel FilterPanel
	{
		 get { } //Length: 8
	}

	public IEnumerable GridItemViews
	{
		 get { } //Length: 76
	}

	public private bool IsMagnified
	{
		private get { } //Length: 96
		 set { } //Length: 7
	}

	public private ItemContext SourceContext
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private static GridView() { }

	public GridView() { }

	[CompilerGenerated]
	internal static int <AcceptItem>g__GetAmmoCapacity|62_1(Magazine mag, Ammo ammo) { }

	[CompilerGenerated]
	internal static int <AcceptItem>g__GetAmmoCapacityForMultiBarrel|62_2(Weapon weapon, Ammo ammo) { }

	[CompilerGenerated]
	private void <AcceptOnce>b__63_2() { }

	[CompilerGenerated]
	private void <AcceptOnce>b__63_4() { }

	[CompilerGenerated]
	private Task <AcceptOnce>g__RunNetworkTransaction|63_0(IOperationResult operationResult) { }

	[AsyncStateMachine(typeof(<AcceptItem>d__62))]
	public override Task AcceptItem(DragItemContext itemContext, ItemContext targetItemContext) { }

	[AsyncStateMachine(typeof(<AcceptOnce>d__63))]
	private Task AcceptOnce(DragItemContext itemContext, ItemContext targetItemContext, bool ctrlPressed) { }

	private void AddItemView(ItemView itemView, LocationInGrid location) { }

	public LocationInGrid CalculateItemLocation(DragItemContext itemContext) { }

	public override bool CanAccept(DragItemContext itemContext, ItemContext targetItemContext, out OperationResult operation) { }

	public override bool CanDrag(ItemContext itemContext) { }

	public virtual void Close() { }

	private ItemView CreateItemView(Item item, LocationInGrid location, ItemUiContext itemUiContext, IItemOwner itemOwner = null) { }

	public override void DisableHighlight() { }

	public override void DragCancelled() { }

	public override void DragStarted() { }

	private override void EFT.IAddHandler.OnItemAdded(AddItemEventArgs eventArgs) { }

	private override void EFT.IRefreshHandler.OnRefreshItem(RefreshItemEventArgs eventArgs) { }

	private override void EFT.IRemoveHandler.OnItemRemoved(RemoveItemEventArgs eventArgs) { }

	[CanBeNull]
	private ItemView FindItemView(Item item, Predicate predicate = null) { }

	protected FilterPanel get_FilterPanel() { }

	public IEnumerable get_GridItemViews() { }

	private bool get_IsMagnified() { }

	[CompilerGenerated]
	public ItemContext get_SourceContext() { }

	protected override Color GetHighlightColor(DragItemContext itemContext, OperationResult possibleOperation, ItemContext targetItemContext) { }

	private Item GetTargetItem(ItemContext targetItemContext) { }

	private void HideHighlightPanel() { }

	public override void HighlightItemViewPosition(DragItemContext itemContext, ItemContext targetItemContext, bool preview) { }

	private void ItemFoundHandler(Item item) { }

	protected void MagnifyIfPossible() { }

	[AsyncStateMachine(typeof(<MagnifyIfPossible>d__42))]
	public Task MagnifyIfPossible(Rect rect, bool force) { }

	private void ManageActiveEvents() { }

	[UsedImplicitly]
	private void OnDrawGizmos() { }

	private void OnGridResized(int gridWidth, int gridHeight) { }

	protected override void PrepareItems() { }

	private void PrepareView() { }

	public void set_IsMagnified(bool value) { }

	[CompilerGenerated]
	private void set_SourceContext(ItemContext value) { }

	public void SetAsyncCreationAllowed(bool allowed) { }

	protected void SetItemViewPosition(ItemView itemView, LocationInGrid location) { }

	public void Show(Grid grid, ItemContext parentContext, ItemController itemController, ItemUiContext itemUiContext, FilterPanel filterPanel = null, bool magnify = false) { }

	private void ShowHighlightPanel() { }

	protected bool TrySetGridSize(int gridWidth, int gridHeight) { }

}

