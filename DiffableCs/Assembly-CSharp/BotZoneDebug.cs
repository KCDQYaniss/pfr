//Type is in global namespace

public class BotZoneDebug : MonoBehaviourSingleton
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public string groupName; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal bool <AddLine>b__0(BotZoneDebugLinesGroup p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public string groupName; //Field offset: 0x10

		public <>c__DisplayClass8_0() { }

		internal bool <Add>b__0(BotZoneDebugPointsGroup p) { }

	}

	[SerializeField]
	private List _points; //Field offset: 0x20
	[SerializeField]
	private List _lines; //Field offset: 0x28

	public List Lines
	{
		 get { } //Length: 5
	}

	public List Points
	{
		 get { } //Length: 5
	}

	public BotZoneDebug() { }

	public void Add(string groupName, Vector3 point) { }

	public void Add(string groupName, string label, Vector3 point) { }

	public void AddLine(string groupName, Vector3 pointA, Vector3 pointB) { }

	public void AddLine(string groupName, string label, Vector3 pointA, Vector3 pointB) { }

	public void Clear() { }

	public void DrawPoints(List points, Color color, float delta) { }

	public List get_Lines() { }

	public List get_Points() { }

	private void OnDrawGizmos() { }

}

