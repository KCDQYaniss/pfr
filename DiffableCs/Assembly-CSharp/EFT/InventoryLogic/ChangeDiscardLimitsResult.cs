namespace EFT.InventoryLogic;

public sealed class ChangeDiscardLimitsResult : IDestroyResult, IOperationResult, IRollable
{
	[CompilerGenerated]
	private sealed class <get_ItemsToDestroy>d__15 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private ItemsCount <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x28
		public ChangeDiscardLimitsResult <>4__this; //Field offset: 0x30

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
		public <get_ItemsToDestroy>d__15(int <>1__state) { }

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
	private readonly ItemsCount _itemsCount; //Field offset: 0x18
	[CanBeNull]
	private readonly IAntiRMTItemController _sourceLimitedController; //Field offset: 0x28
	[CanBeNull]
	private readonly IAntiRMTItemController _targetLimitedController; //Field offset: 0x30
	[CompilerGenerated]
	private readonly ItemAddress <From>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private readonly ItemAddress <To>k__BackingField; //Field offset: 0x40

	public override bool DestroysMainItem
	{
		 get { } //Length: 3
	}

	public ItemAddress From
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override bool ItemsDestroyRequired
	{
		 get { } //Length: 3
	}

	public override IEnumerable ItemsToDestroy
	{
		[IteratorStateMachine(typeof(<get_ItemsToDestroy>d__15))]
		 get { } //Length: 175
	}

	public ItemAddress To
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ChangeDiscardLimitsResult(Item item, int numberToTransfer, IAntiRMTItemController from, ItemAddress to) { }

	public override bool CanExecute(ItemController itemController) { }

	public override bool Contains(Item item, out ItemsCount numberToDestroy) { }

	public override bool get_DestroysMainItem() { }

	[CompilerGenerated]
	public ItemAddress get_From() { }

	public override bool get_ItemsDestroyRequired() { }

	[IteratorStateMachine(typeof(<get_ItemsToDestroy>d__15))]
	public override IEnumerable get_ItemsToDestroy() { }

	[CompilerGenerated]
	public ItemAddress get_To() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

}

