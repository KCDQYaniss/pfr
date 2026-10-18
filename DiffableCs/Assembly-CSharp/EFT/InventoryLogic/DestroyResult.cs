namespace EFT.InventoryLogic;

public sealed class DestroyResult : ISyncOperation, IRollable, IDestroyResult, IOperationResult
{
	[CompilerGenerated]
	private sealed class <get_ItemsToDestroy>d__16 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private ItemsCount <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x28
		public DestroyResult <>4__this; //Field offset: 0x30
		private IEnumerator <>7__wrap1; //Field offset: 0x38

		private override ItemsCount System.Collections.Generic.IEnumerator<EFT.InventoryLogic.ItemsCount>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 74
		}

		[DebuggerHidden]
		public <get_ItemsToDestroy>d__16(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.ItemsCount>.GetEnumerator() { }

		[DebuggerHidden]
		private override ItemsCount System.Collections.Generic.IEnumerator<EFT.InventoryLogic.ItemsCount>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private readonly Item _item; //Field offset: 0x10
	private readonly IAntiRMTItemController _sourceLimitedController; //Field offset: 0x18
	[CanBeNull]
	private readonly IAntiRMTItemController _targetLimitedController; //Field offset: 0x20
	private readonly int _originalStackSize; //Field offset: 0x28
	private readonly ItemController _itemController; //Field offset: 0x30
	private readonly IReadOnlyList _destroyItemResults; //Field offset: 0x38
	[CompilerGenerated]
	private readonly bool <ItemsDestroyRequired>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private readonly ItemAddress <From>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private readonly ItemAddress <To>k__BackingField; //Field offset: 0x50

	public override bool DestroysMainItem
	{
		 get { } //Length: 87
	}

	public ItemAddress From
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override bool ItemsDestroyRequired
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override IEnumerable ItemsToDestroy
	{
		[IteratorStateMachine(typeof(<get_ItemsToDestroy>d__16))]
		 get { } //Length: 175
	}

	public ItemAddress To
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public DestroyResult(Item item, int originalStackSize, IAntiRMTItemController from, ItemAddress to, IReadOnlyList destroyItemResults, ItemController itemController) { }

	public override bool CanExecute(ItemController itemController) { }

	public override bool Contains(Item item, out ItemsCount numberToDestroy) { }

	public override OperationResult Execute() { }

	public override bool get_DestroysMainItem() { }

	[CompilerGenerated]
	public ItemAddress get_From() { }

	[CompilerGenerated]
	public override bool get_ItemsDestroyRequired() { }

	[IteratorStateMachine(typeof(<get_ItemsToDestroy>d__16))]
	public override IEnumerable get_ItemsToDestroy() { }

	[CompilerGenerated]
	public ItemAddress get_To() { }

	public override void RaiseEvents(IItemOwner itemController, CommandStatus status) { }

	public override void RollBack() { }

}

