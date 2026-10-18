namespace Vuplex.WebView;

public class TerminatedEventArgs : EventArgs
{
	public readonly TerminationType Type; //Field offset: 0x10

	public TerminatedEventArgs(TerminationType type) { }

	public virtual string ToString() { }

}

