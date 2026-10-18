namespace EFT.UI.DragAndDrop;

public class SlotView : UIElement, IContainerView, IAddHandler, IItemRelatedView, IRemoveHandler, ISetInHandsHandler, IRemoveFromHandsHandler
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass73_0
	{
		public SplitResult <splitResult>5__2; //Field offset: 0x10
		public TransferResult <transferResult>5__3; //Field offset: 0x18
		public SlotView <>4__this; //Field offset: 0x20

		public <>c__DisplayClass73_0() { }

		internal void <AcceptItem>b__0(int count) { }

		internal void <AcceptItem>b__2(int count) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Callback <0>__InventoryOperationHandler; //Field offset: 0x0

	}

	[CompilerGenerated]
	private struct <AcceptItem>d__73 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SlotView <>4__this; //Field offset: 0x20
		public DragItemContext itemContext; //Field offset: 0x28
		public ItemContext targetItemContext; //Field offset: 0x30
		private OperationResult <possibleOperation>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <SetItemScale>d__57 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public SlotView <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <SetItemScale>d__57(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private static readonly WaitForEndOfFrame _waitForEndOfFrame; //Field offset: 0x0
	private static readonly Color _invalidOperationColor; //Field offset: 0x8
	private static readonly Color _validMoveColor; //Field offset: 0x18
	private static readonly Color _swapColor; //Field offset: 0x28
	private static readonly Color _splitMergeColor; //Field offset: 0x38
	[SerializeField]
	protected Image FullBorder; //Field offset: 0x70
	[SerializeField]
	protected GameObject SearchIcon; //Field offset: 0x78
	[SerializeField]
	protected Image SlotBackImage; //Field offset: 0x80
	[SerializeField]
	protected Image ActiveCamoraImage; //Field offset: 0x88
	[SerializeField]
	private RectTransform _slotPlace; //Field offset: 0x90
	[SerializeField]
	private Image _slotBackground; //Field offset: 0x98
	[SerializeField]
	private Image _emptyBorder; //Field offset: 0xA0
	[SerializeField]
	private Image _selectedBorder; //Field offset: 0xA8
	[SerializeField]
	private Image _selectedCorner; //Field offset: 0xB0
	[SerializeField]
	private TextMeshProUGUI _headerText; //Field offset: 0xB8
	[SerializeField]
	private SlotViewHeader _slotHeader; //Field offset: 0xC0
	[CompilerGenerated]
	private Action OnItemHover; //Field offset: 0xC8
	[CompilerGenerated]
	private Action OnDragStarted; //Field offset: 0xD0
	[CompilerGenerated]
	private Action OnDragCancelled; //Field offset: 0xD8
	internal ItemView ItemView; //Field offset: 0xE0
	[CompilerGenerated]
	private ItemContext <ParentItemContext>k__BackingField; //Field offset: 0xE8
	protected IItemOwner ItemOwner; //Field offset: 0xF0
	protected ItemController ItemController; //Field offset: 0xF8
	protected SkillManager Skills; //Field offset: 0x100
	protected InsuranceCompany InsuranceCompany; //Field offset: 0x108
	protected Sprite CachedSprite; //Field offset: 0x110
	protected ItemUiContext ItemUiContext; //Field offset: 0x118
	protected bool HighlightedGlobally; //Field offset: 0x120
	private Color _emptyBorderColor; //Field offset: 0x124
	private Color _fullBorderColor; //Field offset: 0x134
	private Color _selectedBorderColor; //Field offset: 0x144
	private bool _isOpen; //Field offset: 0x154
	private Action _itemContextUnbind; //Field offset: 0x158
	private WindowContext _equipWindowContext; //Field offset: 0x160
	[CompilerGenerated]
	private Slot <Slot>k__BackingField; //Field offset: 0x168

	public event Action OnDragCancelled
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event Action OnDragStarted
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event Action OnItemHover
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	protected private ItemContext ParentItemContext
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private Slot Slot
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private static SlotView() { }

	public SlotView() { }

	[CompilerGenerated]
	private void <AcceptItem>b__73_1() { }

	[CompilerGenerated]
	private void <AcceptItem>b__73_3() { }

	[CompilerGenerated]
	private void <HeaderClickHandler>g__OnWindowClose|49_0() { }

	[CompilerGenerated]
	private void <Show>b__48_0() { }

	[CompilerGenerated]
	private void <Show>b__48_1() { }

	[AsyncStateMachine(typeof(<AcceptItem>d__73))]
	public override Task AcceptItem(DragItemContext itemContext, ItemContext targetItemContext) { }

	[CompilerGenerated]
	public void add_OnDragCancelled(Action value) { }

	[CompilerGenerated]
	public void add_OnDragStarted(Action value) { }

	[CompilerGenerated]
	public void add_OnItemHover(Action value) { }

	public override bool CanAccept(DragItemContext itemContext, ItemContext targetItemContext, out OperationResult operation) { }

	public override bool CanDrag(ItemContext itemContext) { }

	private void CheckAcceptHandler(DragItemContext dragItemContext) { }

	public virtual void Close() { }

	private void CreateItemView(Item item, IItemOwner itemOwner = null) { }

	protected override ItemView CreateItemViewKernel(Item item, IItemOwner itemOwner) { }

	public override void DisableHighlight() { }

	private void DisableHighlightSilent() { }

	public override void DragCancelled() { }

	public override void DragStarted() { }

	private override void EFT.IAddHandler.OnItemAdded(AddItemEventArgs eventArgs) { }

	private override void EFT.IRemoveFromHandsHandler.OnRemoveFromHands(RemoveFromHandsEventArgs eventArgs) { }

	private override void EFT.IRemoveHandler.OnItemRemoved(RemoveItemEventArgs eventArgs) { }

	private override void EFT.ISetInHandsHandler.OnSetInHands(SetInHandsEventArgs eventArgs) { }

	[CompilerGenerated]
	protected ItemContext get_ParentItemContext() { }

	[CompilerGenerated]
	public Slot get_Slot() { }

	private static Color GetHighlightColor(OperationResult possibleAction) { }

	private void HeaderClickHandler(bool selected) { }

	public override void HighlightItemViewPosition(DragItemContext itemContext, ItemContext targetItemContext, bool preview) { }

	private void InventoryErrorHandler(InventoryError error) { }

	private static void InventoryOperationHandler(IResult result) { }

	protected override void OnAddToSlot(Item item, AddItemEventArgs args) { }

	protected override void OnRemoveFromSlot(Item item, RemoveItemEventArgs args) { }

	[CompilerGenerated]
	public void remove_OnDragCancelled(Action value) { }

	[CompilerGenerated]
	public void remove_OnDragStarted(Action value) { }

	[CompilerGenerated]
	public void remove_OnItemHover(Action value) { }

	private void RemoveItemView() { }

	protected void ScaleItem(Vector2 size) { }

	[CompilerGenerated]
	private void set_ParentItemContext(ItemContext value) { }

	[CompilerGenerated]
	private void set_Slot(Slot value) { }

	[IteratorStateMachine(typeof(<SetItemScale>d__57))]
	private IEnumerator SetItemScale() { }

	protected void SetSlotBackImage(Sprite sprite) { }

	protected void SetSlotGraphics(bool fullSlot, bool selected) { }

	protected override void SetupItemView(Item item) { }

	public override void Show(Slot slot, ItemContext parentItemContext, ItemController itemController, ItemUiContext itemUiContext, SkillManager skills, InsuranceCompany insurance, bool canClickOnHeader = false) { }

	protected void Start() { }

}

