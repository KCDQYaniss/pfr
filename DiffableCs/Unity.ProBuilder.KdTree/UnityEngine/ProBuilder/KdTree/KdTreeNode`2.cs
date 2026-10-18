namespace UnityEngine.ProBuilder.KdTree;

[DefaultMember("Item")]
internal class KdTreeNode`2
{
	public TKey[] Point; //Field offset: 0x0
	public TValue Value; //Field offset: 0x0
	public List Duplicates; //Field offset: 0x0
	internal KdTreeNode LeftChild; //Field offset: 0x0
	internal KdTreeNode RightChild; //Field offset: 0x0

	public bool IsLeaf
	{
		 get { } //Length: 19
	}

	internal KdTreeNode Item
	{
		internal get { } //Length: 14
		internal set { } //Length: 186
	}

	public KdTreeNode`2() { }

	public KdTreeNode`2(TKey[] point, TValue value) { }

	public void AddDuplicate(TValue value) { }

	public bool get_IsLeaf() { }

	internal KdTreeNode get_Item(int compare) { }

	internal void set_Item(int compare, KdTreeNode value) { }

	public virtual string ToString() { }

}

