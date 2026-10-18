namespace Vuplex.WebView;

public class AuthRequestedEventArgs : EventArgs
{
	public readonly string Host; //Field offset: 0x10
	public readonly bool IsProxy; //Field offset: 0x18
	private Action _cancelCallback; //Field offset: 0x20
	private Action _continueCallback; //Field offset: 0x28

	public AuthRequestedEventArgs(string host, bool isProxy, Action continueCallback, Action cancelCallback) { }

	public void Cancel() { }

	public void Continue(string username, string password) { }

}

