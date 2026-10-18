namespace Vuplex.WebView.Internal;

public class KeyboardEventArgs : EventArgs
{
	public readonly string Key; //Field offset: 0x10
	public readonly KeyModifier Modifiers; //Field offset: 0x18

	public KeyboardEventArgs(string key, KeyModifier modifiers) { }

	public virtual string ToString() { }

}

