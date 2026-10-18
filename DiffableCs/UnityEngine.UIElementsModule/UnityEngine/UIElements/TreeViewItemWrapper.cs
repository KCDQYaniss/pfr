namespace UnityEngine.UIElements;

[IsReadOnly]
internal struct TreeViewItemWrapper
{
	public readonly TreeItem item; //Field offset: 0x0
	public readonly int depth; //Field offset: 0x10

	public IEnumerable childrenIds
	{
		 get { } //Length: 5
	}

	public bool hasChildren
	{
		 get { } //Length: 79
	}

	public int id
	{
		 get { } //Length: 3
	}

	public TreeViewItemWrapper(TreeItem item, int depth) { }

	public IEnumerable get_childrenIds() { }

	public bool get_hasChildren() { }

	public int get_id() { }

}

