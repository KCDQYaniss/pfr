namespace EFT.HandBook;

public abstract class BaseHandbook`1 : IBaseHandbook
{

	protected abstract Dictionary AllNodes
	{
		 get { } //Length: 0
	}

	protected abstract TNode RootNode
	{
		 get { } //Length: 0
	}

	protected BaseHandbook`1() { }

	protected abstract Dictionary get_AllNodes() { }

	protected abstract TNode get_RootNode() { }

	public abstract bool IsCategory(string testId) { }

	public override bool IsChildOf(string testId, string parentId) { }

}

