namespace EFT.UI;

public sealed class HandoverHideoutAreaStashItemsWindow : PaginationWindow
{
	[CompilerGenerated]
	private sealed class <GetItemsToHandover>d__12 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Item <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public HandoverHideoutAreaStashItemsWindow <>4__this; //Field offset: 0x28
		private IEnumerator <>7__wrap1; //Field offset: 0x30

		private override Item System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Item>.Current
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
		public <GetItemsToHandover>d__12(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.Item>.GetEnumerator() { }

		[DebuggerHidden]
		private override Item System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Item>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[SerializeField]
	private Vector3 _showPosition; //Field offset: 0x148
	private InventoryController _inventoryController; //Field offset: 0x158
	private IContainer _container; //Field offset: 0x160
	private ItemContext _itemContext; //Field offset: 0x168

	public IContainer Container
	{
		 get { } //Length: 8
	}

	protected virtual int GridHeight
	{
		 get { } //Length: 6
	}

	protected virtual int GridWidth
	{
		 get { } //Length: 6
	}

	public HandoverHideoutAreaStashItemsWindow() { }

	[CompilerGenerated]
	private bool <CheckForUpdateItemsRequirement>b__11_0(ItemAddress location) { }

	[CompilerGenerated]
	private void <Show>b__10_0() { }

	protected virtual bool CheckForUpdateItemsRequirement(Item item, ItemAddress itemAddress) { }

	public virtual void Close() { }

	public IContainer get_Container() { }

	protected virtual int get_GridHeight() { }

	protected virtual int get_GridWidth() { }

	[IteratorStateMachine(typeof(<GetItemsToHandover>d__12))]
	protected virtual IEnumerable GetItemsToHandover() { }

	public WindowContext Show(IContainer container, InventoryController controller, string localizationKey) { }

}

