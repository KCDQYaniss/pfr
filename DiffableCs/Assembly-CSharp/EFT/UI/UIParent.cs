namespace EFT.UI;

public sealed class UIParent : CompositeDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0`2
	{
		public TView template; //Field offset: 0x0
		public Transform container; //Field offset: 0x0

		public <>c__DisplayClass0_0`2() { }

		internal TView <AddViewList>b__0(TItem arg) { }

		internal Transform <AddViewList>b__1(TItem arg) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0`2
	{
		public TView template; //Field offset: 0x0
		public Transform container; //Field offset: 0x0

		public <>c__DisplayClass1_0`2() { }

		internal TView <AddViewListAsync>b__0(TItem arg) { }

		internal Transform <AddViewListAsync>b__1(TItem arg) { }

	}


	public UIParent() { }

	public ViewList AddViewList(IEnumerable items, TView template, Transform container, Action showAction) { }

	public AsyncViewList AddViewListAsync(IEnumerable items, TView template, Transform container, Action showAction) { }

}

