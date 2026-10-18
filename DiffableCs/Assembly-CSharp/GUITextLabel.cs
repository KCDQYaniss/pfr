//Type is in global namespace

internal class GUITextLabel
{
	internal enum XAlignment
	{
		Left = 0,
		Center = 1,
		Right = 2,
	}

	internal enum YAlignment
	{
		Top = 0,
		Center = 1,
		Bottom = 2,
	}

	private GUIStyle _style; //Field offset: 0x10
	private XAlignment _xAlig; //Field offset: 0x18
	private YAlignment _yAlig; //Field offset: 0x1C
	private Vector2 _pos; //Field offset: 0x20
	private Vector2 _size; //Field offset: 0x28
	private Rect _rect; //Field offset: 0x30
	private bool _relatively; //Field offset: 0x40
	public string Text; //Field offset: 0x48

	public TextAnchor TextAnchor
	{
		 get { } //Length: 90
		 set { } //Length: 103
	}

	public GUITextLabel(XAlignment xAlig, YAlignment yAlig, Vector2 pos, Vector2 size, bool relatively = false) { }

	public void Draw() { }

	public TextAnchor get_TextAnchor() { }

	public void set_TextAnchor(TextAnchor value) { }

	private void UpdateSize() { }

}

