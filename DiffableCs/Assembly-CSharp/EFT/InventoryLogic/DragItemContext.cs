namespace EFT.InventoryLogic;

public sealed class DragItemContext : ItemContext
{
	public ItemRotation ItemRotation; //Field offset: 0x68
	public readonly ItemAddress ItemAddress; //Field offset: 0x70
	public readonly bool IgnoreLocation; //Field offset: 0x78
	[CompilerGenerated]
	private Vector2 <CursorPosition>k__BackingField; //Field offset: 0x7C
	[CompilerGenerated]
	private Vector2 <ItemPosition>k__BackingField; //Field offset: 0x84
	[CompilerGenerated]
	private bool <Cancelled>k__BackingField; //Field offset: 0x8C

	public private bool Cancelled
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private Vector2 CursorPosition
	{
		[CompilerGenerated]
		 get { } //Length: 22
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public virtual bool DragAvailable
	{
		 get { } //Length: 32
	}

	public private Vector2 ItemPosition
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public virtual bool MergeAvailable
	{
		 get { } //Length: 32
	}

	public virtual bool SplitAvailable
	{
		 get { } //Length: 32
	}

	public DragItemContext(DragItemContext source, Item newItem) { }

	public DragItemContext(ItemContext itemContext, ItemRotation rotation) { }

	[CompilerGenerated]
	private Option <CanAccept>g__CheckAction|24_0(Slot targetSlot) { }

	public bool CanAccept(Slot slot, ItemController itemController, out OperationResult operation, bool simulate = true) { }

	public virtual void CheckAccept(DragItemContext itemContext) { }

	public virtual void CloseDependentWindows() { }

	public virtual ItemContext CreateChild(Item item) { }

	public virtual void DragCancelled() { }

	public virtual void DragStarted() { }

	[CompilerGenerated]
	public bool get_Cancelled() { }

	[CompilerGenerated]
	public Vector2 get_CursorPosition() { }

	public virtual bool get_DragAvailable() { }

	[CompilerGenerated]
	public Vector2 get_ItemPosition() { }

	public virtual bool get_MergeAvailable() { }

	public virtual bool get_SplitAvailable() { }

	protected virtual void InventoryErrorHandler(InventoryError error) { }

	public virtual bool IsDropAvailable(DragItemContext itemContext) { }

	[CompilerGenerated]
	private void set_Cancelled(bool value) { }

	[CompilerGenerated]
	private void set_CursorPosition(Vector2 value) { }

	[CompilerGenerated]
	private void set_ItemPosition(Vector2 value) { }

	public void SetPosition(Vector2 globalPosition, Vector2 itemPosition) { }

	public virtual void UpdateView() { }

}

