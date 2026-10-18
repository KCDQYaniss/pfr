namespace Vuplex.WebView;

public class PointerEventArgs : EventArgs
{
	public MouseButton Button; //Field offset: 0x10
	public int ClickCount; //Field offset: 0x14
	public Vector2 Point; //Field offset: 0x18

	public PointerEventArgs() { }

	public PointerOptions ToPointerOptions(bool preventStealingFocus) { }

}

