namespace Vuplex.WebView;

public interface IWithFind
{

	public void ClearFindMatches() { }

	public Task Find(string text, bool forward) { }

}

