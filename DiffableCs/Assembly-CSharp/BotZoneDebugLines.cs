//Type is in global namespace

public class BotZoneDebugLines
{
	[SerializeField]
	private string _label; //Field offset: 0x10
	[SerializeField]
	private List lineA; //Field offset: 0x18
	[SerializeField]
	private List lineB; //Field offset: 0x20
	public int Count; //Field offset: 0x28

	public string Label
	{
		 get { } //Length: 5
	}

	public BotZoneDebugLines(string label) { }

	public void AddLine(Vector3 a, Vector3 b) { }

	public void Clear() { }

	public void Draw(bool isDraw, Color color, Vector3 offset) { }

	public string get_Label() { }

}

