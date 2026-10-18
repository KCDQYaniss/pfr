namespace Diz.Binding;

public interface IBindableIndexed`2
{

	public event Action ItemAdded
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action ItemRemoved
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public IEnumerable Items
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_ItemAdded(Action value) { }

	[CompilerGenerated]
	public void add_ItemRemoved(Action value) { }

	public IEnumerable get_Items() { }

	[CompilerGenerated]
	public void remove_ItemAdded(Action value) { }

	[CompilerGenerated]
	public void remove_ItemRemoved(Action value) { }

}

