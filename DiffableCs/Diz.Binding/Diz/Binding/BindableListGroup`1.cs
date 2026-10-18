namespace Diz.Binding;

public sealed class BindableListGroup`1 : IBindableList, IEnumerable, IEnumerable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__16_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal IEnumerable <.ctor>b__16_0(IBindableList x) { }

	}

	private readonly IEnumerable _items; //Field offset: 0x0
	[CompilerGenerated]
	private Action ItemAdded; //Field offset: 0x0
	[CompilerGenerated]
	private Action ItemRemoved; //Field offset: 0x0
	[CompilerGenerated]
	private Action ItemsAdded; //Field offset: 0x0
	[CompilerGenerated]
	private Action ItemsRemoved; //Field offset: 0x0
	[CompilerGenerated]
	private Action AllItemsRemoved; //Field offset: 0x0

	public override event Action AllItemsRemoved
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override event Action ItemAdded
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action ItemRemoved
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action ItemsAdded
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action ItemsRemoved
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public BindableListGroup`1(IEnumerable lists) { }

	[CompilerGenerated]
	private void <.ctor>b__16_1(TSource item) { }

	[CompilerGenerated]
	private void <.ctor>b__16_2(TSource item) { }

	[CompilerGenerated]
	private void <.ctor>b__16_3(IEnumerable items) { }

	[CompilerGenerated]
	private void <.ctor>b__16_4(IEnumerable items) { }

	[CompilerGenerated]
	public override void add_AllItemsRemoved(Action value) { }

	[CompilerGenerated]
	public override void add_ItemAdded(Action value) { }

	[CompilerGenerated]
	public override void add_ItemRemoved(Action value) { }

	[CompilerGenerated]
	public override void add_ItemsAdded(Action value) { }

	[CompilerGenerated]
	public override void add_ItemsRemoved(Action value) { }

	public override IEnumerator GetEnumerator() { }

	[CompilerGenerated]
	public override void remove_AllItemsRemoved(Action value) { }

	[CompilerGenerated]
	public override void remove_ItemAdded(Action value) { }

	[CompilerGenerated]
	public override void remove_ItemRemoved(Action value) { }

	[CompilerGenerated]
	public override void remove_ItemsAdded(Action value) { }

	[CompilerGenerated]
	public override void remove_ItemsRemoved(Action value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

