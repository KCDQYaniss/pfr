namespace EFT.UI;

public class ViewList`2 : TemplateList
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public Func templateFactory; //Field offset: 0x0
		public ViewList <>4__this; //Field offset: 0x0

		public <>c__DisplayClass0_0() { }

		internal TView <.ctor>g__ViewFactory|0(TItem item) { }

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

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public Transform container; //Field offset: 0x0

		public <>c__DisplayClass2_0() { }

		internal Transform <.ctor>b__0(TItem arg) { }

	}


	public ViewList`2(IEnumerable items, Func templateFactory, Func container, Action showAction) { }

	public ViewList`2(IEnumerable items, TView template, Transform container, Action showAction) { }

	public ViewList`2(IEnumerable items, Func viewFactory, Transform container, Action showAction) { }

	private void InitList(IEnumerable items, Func itemViewFactory, Func container, Action showAction, bool destroyOnKill) { }

}

