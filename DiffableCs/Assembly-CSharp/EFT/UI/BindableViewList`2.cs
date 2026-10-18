namespace EFT.UI;

public class BindableViewList`2 : ViewList
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public TView template; //Field offset: 0x0
		public Transform container; //Field offset: 0x0

		public <>c__DisplayClass4_0() { }

		internal TView <.ctor>b__0(TItem arg) { }

		internal Transform <.ctor>b__1(TItem arg) { }

	}

	[CompilerGenerated]
	private Action OnRemove; //Field offset: 0x0
	private readonly IBindableList _items; //Field offset: 0x0

	public event Action OnRemove
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public BindableViewList`2(IBindableList items, TView template, Transform container, Action showAction) { }

	protected BindableViewList`2(IBindableList items, Func templateFactory, Func container, Action showAction) { }

	[CompilerGenerated]
	public void add_OnRemove(Action value) { }

	protected override void AddItem(TItem item) { }

	protected override void AddItems(IEnumerable items) { }

	public virtual void Dispose() { }

	[CompilerGenerated]
	public void remove_OnRemove(Action value) { }

	protected override void RemoveAllItems() { }

	protected override void RemoveItem(TItem item) { }

}

