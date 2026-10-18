namespace Vuplex.WebView;

public class ProgressChangedEventArgs : EventArgs
{
	public readonly float Progress; //Field offset: 0x10
	public readonly ProgressChangeType Type; //Field offset: 0x14

	public ProgressChangedEventArgs(ProgressChangeType type, float progress) { }

	public virtual string ToString() { }

}

