namespace EFT.UI;

public sealed class BindableOrderedViewList`2 : BindableViewList
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__7_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal TItem <OrderViewList>b__7_0(TItem x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public TView template; //Field offset: 0x0
		public Transform container; //Field offset: 0x0

		public <>c__DisplayClass1_0() { }

		internal TView <.ctor>b__0(TItem arg) { }

		internal Transform <.ctor>b__1(TItem arg) { }

	}

	private readonly IComparer _comparer; //Field offset: 0x0

	public BindableOrderedViewList`2(IBindableList items, IComparer comparer, TView template, Transform container, Action showAction) { }

	public BindableOrderedViewList`2(IBindableList items, IComparer comparer, Func templateFactory, Func container, Action showAction) { }

	protected virtual void AddItem(TItem item) { }

	protected virtual void AddItems(IEnumerable items) { }

	private void OrderViewList() { }

	protected virtual void RemoveAllItems() { }

	protected virtual void RemoveItem(TItem item) { }

}

