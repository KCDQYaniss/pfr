namespace EFT.HandBook;

public interface IHandbookNode`1
{

	public ValueCollection Children
	{
		 get { } //Length: 0
	}

	public string Id
	{
		 get { } //Length: 0
	}

	public TNode Parent
	{
		 get { } //Length: 0
	}

	public ValueCollection get_Children() { }

	public string get_Id() { }

	public TNode get_Parent() { }

	public bool TryGetChildById(string id, out TNode child) { }

}

