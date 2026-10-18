namespace EFT.HandBook;

public interface IBaseHandbook
{

	public bool IsCategory(string testId) { }

	public bool IsChildOf(string testId, string parentId) { }

}

