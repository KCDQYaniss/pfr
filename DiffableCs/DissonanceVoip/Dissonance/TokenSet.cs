namespace Dissonance;

public class TokenSet : IEnumerable, IEnumerable
{
	private static readonly IComparer SortOrder; //Field offset: 0x0
	[SerializeField]
	private List _tokens; //Field offset: 0x10
	[CompilerGenerated]
	private Action TokenRemoved; //Field offset: 0x18
	[CompilerGenerated]
	private Action TokenAdded; //Field offset: 0x20

	public event Action TokenAdded
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action TokenRemoved
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public int Count
	{
		 get { } //Length: 65
	}

	private static TokenSet() { }

	public TokenSet() { }

	[CompilerGenerated]
	public void add_TokenAdded(Action value) { }

	[CompilerGenerated]
	public void add_TokenRemoved(Action value) { }

	public bool AddToken(string token) { }

	public bool ContainsToken(string token) { }

	private int Find(string item) { }

	public int get_Count() { }

	public override IEnumerator GetEnumerator() { }

	public bool IntersectsWith(TokenSet other) { }

	[CompilerGenerated]
	public void remove_TokenAdded(Action value) { }

	[CompilerGenerated]
	public void remove_TokenRemoved(Action value) { }

	public bool RemoveToken(string token) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

