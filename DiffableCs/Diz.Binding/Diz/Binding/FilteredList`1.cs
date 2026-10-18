namespace Diz.Binding;

public sealed class FilteredList`1 : IBindableList, IEnumerable, IEnumerable
{
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
	private readonly Predicate _predicate; //Field offset: 0x0
	private readonly IBindableList _source; //Field offset: 0x0

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

	public FilteredList`1(IBindableList source, Predicate predicate) { }

	[CompilerGenerated]
	private void <.ctor>b__17_0(TSource item) { }

	[CompilerGenerated]
	private void <.ctor>b__17_1(IEnumerable items) { }

	[CompilerGenerated]
	private void <.ctor>b__17_2(TSource item) { }

	[CompilerGenerated]
	private void <.ctor>b__17_3(IEnumerable items) { }

	[CompilerGenerated]
	private void <.ctor>b__17_4() { }

	[CompilerGenerated]
	private bool <.ctor>b__17_5(TSource item) { }

	[CompilerGenerated]
	private bool <.ctor>b__17_6(TSource item) { }

	[CompilerGenerated]
	private bool <GetEnumerator>b__18_0(TSource x) { }

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

