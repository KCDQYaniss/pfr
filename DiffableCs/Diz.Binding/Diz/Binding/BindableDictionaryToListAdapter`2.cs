namespace Diz.Binding;

public sealed class BindableDictionaryToListAdapter`2 : IBindableList, IEnumerable, IEnumerable
{
	private readonly BindableDictionary _dictionary; //Field offset: 0x0

	public override event Action AllItemsRemoved
	{
		 add { } //Length: 45
		 remove { } //Length: 45
	}

	public override event Action ItemAdded
	{
		 add { } //Length: 42
		 remove { } //Length: 42
	}

	public override event Action ItemRemoved
	{
		 add { } //Length: 42
		 remove { } //Length: 42
	}

	public override event Action ItemsAdded
	{
		 add { } //Length: 311
		 remove { } //Length: 311
	}

	public override event Action ItemsRemoved
	{
		 add { } //Length: 327
		 remove { } //Length: 327
	}

	public BindableDictionaryToListAdapter`2(BindableDictionary dictionary) { }

	public override void add_AllItemsRemoved(Action value) { }

	public override void add_ItemAdded(Action value) { }

	public override void add_ItemRemoved(Action value) { }

	public override void add_ItemsAdded(Action value) { }

	public override void add_ItemsRemoved(Action value) { }

	public override IEnumerator GetEnumerator() { }

	public override void remove_AllItemsRemoved(Action value) { }

	public override void remove_ItemAdded(Action value) { }

	public override void remove_ItemRemoved(Action value) { }

	public override void remove_ItemsAdded(Action value) { }

	public override void remove_ItemsRemoved(Action value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

