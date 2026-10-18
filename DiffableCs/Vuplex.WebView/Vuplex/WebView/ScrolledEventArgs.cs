namespace Vuplex.WebView;

public class ScrolledEventArgs : EventArgs
{
	public readonly Vector2 ScrollDelta; //Field offset: 0x10
	public readonly Vector2 Point; //Field offset: 0x18

	public ScrolledEventArgs(Vector2 scrollDelta, Vector2 point) { }

}

