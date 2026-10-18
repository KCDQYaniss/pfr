namespace UnityEngine.UIElements;

public class TreeView : BaseTreeView
{
	internal class UxmlFactory : UxmlFactory
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : UxmlTraits
	{

		public UxmlTraits() { }

	}

	private Func m_MakeItem; //Field offset: 0x4C0
	private Action m_BindItem; //Field offset: 0x4C8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action <unbindItem>k__BackingField; //Field offset: 0x4D0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action <destroyItem>k__BackingField; //Field offset: 0x4D8

	public Action bindItem
	{
		 get { } //Length: 8
		 set { } //Length: 166
	}

	public Action destroyItem
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public Func makeItem
	{
		 get { } //Length: 8
		 set { } //Length: 166
	}

	public Action unbindItem
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public TreeView() { }

	public TreeView(Func makeItem, Action bindItem) { }

	protected virtual CollectionViewController CreateViewController() { }

	public Action get_bindItem() { }

	[CompilerGenerated]
	public Action get_destroyItem() { }

	public Func get_makeItem() { }

	[CompilerGenerated]
	public Action get_unbindItem() { }

	internal virtual bool HasValidDataAndBindings() { }

	public void set_bindItem(Action value) { }

	public void set_makeItem(Func value) { }

}

