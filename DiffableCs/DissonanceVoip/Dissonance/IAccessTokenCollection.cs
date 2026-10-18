namespace Dissonance;

public interface IAccessTokenCollection
{

	public IEnumerable Tokens
	{
		 get { } //Length: 0
	}

	public bool AddToken(string token) { }

	public bool ContainsToken(string token) { }

	public IEnumerable get_Tokens() { }

	public bool RemoveToken(string token) { }

}

