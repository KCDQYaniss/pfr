namespace EFT.InventoryLogic.Operations;

public abstract class PossibleDestroyOperation`1 : AbstractAsyncOperation, IPossibleDestroyOperation, IObservedOperation, IOperationInfo
{
	[CompilerGenerated]
	private sealed class <GetDif>d__12 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"UnexpectedItem", "ExpectedCount", "FoundCount"})]
		private ValueTuple <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IEnumerable itemsToSearch; //Field offset: 0x0
		public IEnumerable <>3__itemsToSearch; //Field offset: 0x0
		private IEnumerable searchIn; //Field offset: 0x0
		public IEnumerable <>3__searchIn; //Field offset: 0x0
		private IEnumerator <>7__wrap1; //Field offset: 0x0
		private Item <expectedItem>5__3; //Field offset: 0x0
		private int <expectedCount>5__4; //Field offset: 0x0
		private IEnumerator <>7__wrap4; //Field offset: 0x0

		private override ValueTuple System.Collections.Generic.IEnumerator<(EFT.InventoryLogic.ItemUnexpectedItem,System.Int32ExpectedCount,System.Int32FoundCount)>.Current
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
		public <GetDif>d__12(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<(EFT.InventoryLogic.ItemUnexpectedItem,System.Int32ExpectedCount,System.Int32FoundCount)>.GetEnumerator() { }

		[DebuggerHidden]
		private override ValueTuple System.Collections.Generic.IEnumerator<(EFT.InventoryLogic.ItemUnexpectedItem,System.Int32ExpectedCount,System.Int32FoundCount)>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private readonly IEnumerable _initialItemsToDestroy; //Field offset: 0x0
	private IEnumerable _realItemsToDestroy; //Field offset: 0x0

	protected abstract bool DestroysMainItem
	{
		 get { } //Length: 0
	}

	protected abstract ItemAddress From
	{
		 get { } //Length: 0
	}

	public abstract Item Item
	{
		 get { } //Length: 0
	}

	[CanBeNull]
	protected IEnumerable ItemsToDestroy
	{
		 get { } //Length: 14
	}

	protected PossibleDestroyOperation`1(ushort id, ItemController controller, TResult simulatedResult, IEnumerable itemsToDestroy) { }

	protected virtual OperationResult Execute() { }

	protected abstract bool get_DestroysMainItem() { }

	protected abstract ItemAddress get_From() { }

	public abstract Item get_Item() { }

	protected IEnumerable get_ItemsToDestroy() { }

	[IteratorStateMachine(typeof(<GetDif>d__12))]
	private static IEnumerable GetDif(IEnumerable searchIn, IEnumerable itemsToSearch) { }

}

