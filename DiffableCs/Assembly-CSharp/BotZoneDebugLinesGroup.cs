//Type is in global namespace

public class BotZoneDebugLinesGroup
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public string label; //Field offset: 0x10

		public <>c__DisplayClass18_0() { }

		internal bool <AddLine>b__0(BotZoneDebugLines p) { }

	}

	private static int _colorIndex; //Field offset: 0x0
	[SerializeField]
	private string _label; //Field offset: 0x10
	public bool IsDraw; //Field offset: 0x18
	public Color Color; //Field offset: 0x1C
	public Vector3 Offset; //Field offset: 0x2C
	private List _colors; //Field offset: 0x38
	[SerializeField]
	private List _lines; //Field offset: 0x40
	public int ActiveLinesIndex; //Field offset: 0x48

	public string Label
	{
		 get { } //Length: 5
	}

	public List Lines
	{
		 get { } //Length: 5
	}

	public BotZoneDebugLines List
	{
		 get { } //Length: 141
	}

	public BotZoneDebugLinesGroup(string label) { }

	public void AddLine(string label, Vector3 pointA, Vector3 pointB) { }

	public void Draw() { }

	public string get_Label() { }

	public List get_Lines() { }

	public BotZoneDebugLines get_List() { }

	public string[] GetElementsList() { }

	private Color NextColor() { }

	public void Reset() { }

}

