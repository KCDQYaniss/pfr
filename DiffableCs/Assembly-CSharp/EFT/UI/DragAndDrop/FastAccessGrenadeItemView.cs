namespace EFT.UI.DragAndDrop;

public class FastAccessGrenadeItemView : QuickSlotView, ISetInHandsHandler, IItemRelatedView, IRemoveFromHandsHandler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison <>9__9_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <OnItemAdded>b__9_1(ThrowWeap x, ThrowWeap y) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public RemoveItemEventArgs obj; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal bool <OnItemRemoved>b__0(Slot slot) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public AddItemEventArgs obj; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal bool <OnItemAdded>b__0(Slot slot) { }

	}

	private List _sortedGrenadeList; //Field offset: 0xE0
	private CompositeDisposable _unsubscribe; //Field offset: 0xE8

	private ThrowWeap TopPriorityGrenade
	{
		private get { } //Length: 54
		private set { } //Length: 123
	}

	public FastAccessGrenadeItemView() { }

	[CompilerGenerated]
	private void <Show>b__5_0() { }

	[CompilerGenerated]
	private void <Show>b__5_1() { }

	public virtual bool CanAccept(DragItemContext itemContext, ItemContext targetItemContext, out OperationResult operation) { }

	public virtual bool CanDrag(ItemContext itemContext) { }

	private override void EFT.IRemoveFromHandsHandler.OnRemoveFromHands(RemoveFromHandsEventArgs args) { }

	private override void EFT.ISetInHandsHandler.OnSetInHands(SetInHandsEventArgs args) { }

	private ThrowWeap get_TopPriorityGrenade() { }

	public virtual void Hide() { }

	public void OnItemAdded(AddItemEventArgs obj) { }

	public void OnItemRemoved(RemoveItemEventArgs obj) { }

	private void set_TopPriorityGrenade(ThrowWeap value) { }

	private void SetNewTopPriorityGrenade() { }

	public void Show(InventoryController inventoryController, ItemUiContext itemUiContext) { }

}

