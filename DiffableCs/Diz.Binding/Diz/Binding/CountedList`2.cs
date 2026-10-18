namespace Diz.Binding;

public sealed class CountedList`2 : IBindableList, IEnumerable, IEnumerable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public Func keySelector; //Field offset: 0x0
		public CountedList <>4__this; //Field offset: 0x0

		public <>c__DisplayClass16_0() { }

		internal void <.ctor>b__2(IEnumerable elements) { }

		internal void <.ctor>b__3(IEnumerable elements) { }

		internal void <.ctor>g__AddElement|0(TSource element) { }

		internal void <.ctor>g__RemoveElement|1(TSource element) { }

	}

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
	private readonly Dictionary _items; //Field offset: 0x0

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

	public CountedList`2(IBindableList source, Func keySelector) { }

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

