namespace Vuplex.WebView;

public class PointerOptions
{
	public MouseButton Button; //Field offset: 0x10
	public int ClickCount; //Field offset: 0x14
	public bool PreventStealingFocus; //Field offset: 0x18

	public PointerOptions() { }

	public virtual string ToString() { }

}

