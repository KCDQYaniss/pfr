//Type is in global namespace

[IsReadOnly]
public struct SearchQuery
{
	private const int PREFIX_SCORE = 300; //Field offset: 0x0
	private const int PHRASE_SCORE = 200; //Field offset: 0x0
	private const int TOKEN_SCORE = 100; //Field offset: 0x0
	private readonly string _text; //Field offset: 0x0
	private readonly int[] _tokenStarts; //Field offset: 0x8
	private readonly int[] _tokenEnds; //Field offset: 0x10

	public bool IsEmpty
	{
		 get { } //Length: 20
	}

	private SearchQuery(string text, int[] tokenStarts, int[] tokenEnds) { }

	private static int CountTokens(string text) { }

	public static SearchQuery Create(string text) { }

	private static void FillTokens(string text, int[] tokenStarts, int[] tokenEnds) { }

	public bool get_IsEmpty() { }

	public int MatchScore(string source) { }

	private static int SkipSeparators(string text, int index) { }

}

