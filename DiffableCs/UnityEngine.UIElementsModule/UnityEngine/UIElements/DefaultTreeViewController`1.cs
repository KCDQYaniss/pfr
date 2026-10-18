namespace UnityEngine.UIElements;

internal class DefaultTreeViewController`1 : TreeViewController
{
	private TreeDataController m_TreeDataController; //Field offset: 0x0

	public virtual IList itemsSource
	{
		 get { } //Length: 23
		 set { } //Length: 500
	}

	private TreeDataController treeDataController
	{
		private get { } //Length: 175
	}

	public DefaultTreeViewController`1() { }

	public virtual IList get_itemsSource() { }

	private TreeDataController get_treeDataController() { }

	public virtual IEnumerable GetAllItemIds(IEnumerable rootIds = null) { }

	public virtual IEnumerable GetChildrenIds(int id) { }

	public virtual object GetItemForIndex(int index) { }

	public virtual int GetParentId(int id) { }

	public virtual bool HasChildren(int id) { }

	private bool IsChildOf(int childId, int id) { }

	public virtual void Move(int id, int newParentId, int childIndex = -1, bool rebuildTree = true) { }

	public virtual void set_itemsSource(IList value) { }

	public override void SetRootItems(IList items) { }

}

