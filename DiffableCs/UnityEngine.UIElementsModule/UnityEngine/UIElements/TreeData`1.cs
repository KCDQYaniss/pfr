namespace UnityEngine.UIElements;

[IsReadOnly]
internal struct TreeData`1
{
	private readonly IList m_RootItemIds; //Field offset: 0x0
	private readonly Dictionary m_Tree; //Field offset: 0x0
	private readonly Dictionary m_ParentIds; //Field offset: 0x0
	private readonly Dictionary m_ChildrenIds; //Field offset: 0x0

	public IEnumerable rootItemIds
	{
		 get { } //Length: 4
	}

	public TreeData`1(IList rootItems) { }

	private void AddItemToParent(TreeViewItemData item, int parentId, int childIndex) { }

	private void BuildTree(IEnumerable items, bool isRoot) { }

	public IEnumerable get_rootItemIds() { }

	public TreeViewItemData GetDataForId(int id) { }

	public int GetParentId(int id) { }

	public bool HasAncestor(int childId, int ancestorId) { }

	public void Move(int id, int newParentId, int childIndex) { }

	private void RefreshTree(IList rootItems) { }

	private void RemoveFromParent(int id, int parentId) { }

	private void UpdateParentTree(TreeViewItemData current) { }

}

