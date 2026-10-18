//Type is in global namespace

[DefaultMember("Item")]
public class DebugGraph
{
	private class Value
	{
		public Color color; //Field offset: 0x10
		public float val; //Field offset: 0x20
		private int lastVal; //Field offset: 0x24

		public Value(Color color) { }

		public void Drawe(Color[] colors, DebugGraph G) { }

	}

	public Color BackGround; //Field offset: 0x10
	public Color CenterLine; //Field offset: 0x20
	public float Scale; //Field offset: 0x30
	public Rect Rect; //Field offset: 0x34
	public bool DrawCenterLine; //Field offset: 0x44
	private Texture2D _tex; //Field offset: 0x48
	private int _t; //Field offset: 0x50
	private int _h; //Field offset: 0x54
	private int _ch; //Field offset: 0x58
	private int _w; //Field offset: 0x5C
	private Value[] _vals; //Field offset: 0x60
	private bool _needToUpdate; //Field offset: 0x68

	public float Item
	{
		 get { } //Length: 53
		 set { } //Length: 57
	}

	public DebugGraph(Rect rect, float scale, Color[] colors) { }

	public float get_Item(int index) { }

	public void OnGUI() { }

	public void set_Item(int index, float value) { }

	private void Update() { }

	private int Val(float value) { }

}

