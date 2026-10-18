//Type is in global namespace

public class BotZoneDebugPoints
{
	[SerializeField]
	private string _label; //Field offset: 0x10
	[SerializeField]
	private List Points; //Field offset: 0x18
	public int Count; //Field offset: 0x20

	public string Label
	{
		 get { } //Length: 5
	}

	public BotZoneDebugPoints(string label) { }

	public void AddPoint(Vector3 point) { }

	public void Clear() { }

	public void Draw(bool isDraw, Color color, Vector3 offset, float radius) { }

	public string get_Label() { }

}

