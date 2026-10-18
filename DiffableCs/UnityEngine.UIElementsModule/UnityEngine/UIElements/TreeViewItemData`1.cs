namespace UnityEngine.UIElements;

[IsReadOnly]
public struct TreeViewItemData`1
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly int <id>k__BackingField; //Field offset: 0x0
	private readonly T m_Data; //Field offset: 0x0
	private readonly IList m_Children; //Field offset: 0x0

	public IEnumerable children
	{
		 get { } //Length: 5
	}

	public T data
	{
		 get { } //Length: 5
	}

	public bool hasChildren
	{
		 get { } //Length: 107
	}

	public int id
	{
		[CompilerGenerated]
		 get { } //Length: 3
	}

	public IEnumerable get_children() { }

	public T get_data() { }

	public bool get_hasChildren() { }

	[CompilerGenerated]
	public int get_id() { }

	internal int GetChildIndex(int itemId) { }

	internal void InsertChild(TreeViewItemData child, int index) { }

	internal void RemoveChild(int childId) { }

	internal void ReplaceChild(TreeViewItemData newChild) { }

}

