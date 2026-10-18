namespace Vuplex.WebView;

public class ClickedEventArgs : EventArgs
{
	public readonly Vector2 Point; //Field offset: 0x10

	public ClickedEventArgs(Vector2 point) { }

}

