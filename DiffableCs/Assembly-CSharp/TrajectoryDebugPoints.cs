//Type is in global namespace

public class TrajectoryDebugPoints
{
	[SerializeField]
	private string _label; //Field offset: 0x10
	[SerializeField]
	private List Points; //Field offset: 0x18
	[SerializeField]
	private List Times; //Field offset: 0x20
	public int Count; //Field offset: 0x28

	public string Label
	{
		 get { } //Length: 5
	}

	public float MaxTime
	{
		 get { } //Length: 147
	}

	public float MinTime
	{
		 get { } //Length: 130
	}

	public TrajectoryDebugPoints(string label) { }

	public void AddPoint(Vector3 point, float time) { }

	public void Clear() { }

	public void Draw(bool isDraw, Color color, Vector3 offset, float radius, float minTime, float maxTime) { }

	public string get_Label() { }

	public float get_MaxTime() { }

	public float get_MinTime() { }

}

