//Type is in global namespace

public class TrajectoryDebugPointsGroup
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public string label; //Field offset: 0x10

		public <>c__DisplayClass25_0() { }

		internal bool <Add>b__0(TrajectoryDebugPoints p) { }

	}

	private static int _colorIndex; //Field offset: 0x0
	[SerializeField]
	protected string _label; //Field offset: 0x10
	public bool IsDraw; //Field offset: 0x18
	public Color Color; //Field offset: 0x1C
	public Vector3 Offset; //Field offset: 0x2C
	public float Radius; //Field offset: 0x38
	private List _colors; //Field offset: 0x40
	[SerializeField]
	protected List _points; //Field offset: 0x48
	public int ActivePointsIndex; //Field offset: 0x50
	public float MinTime; //Field offset: 0x54
	public float MaxTime; //Field offset: 0x58

	public string Label
	{
		 get { } //Length: 5
	}

	public TrajectoryDebugPoints List
	{
		 get { } //Length: 141
	}

	public float MaxTimeLimit
	{
		 get { } //Length: 318
	}

	public float MinTimeLimit
	{
		 get { } //Length: 447
	}

	public List Points
	{
		 get { } //Length: 5
	}

	public TrajectoryDebugPointsGroup(string label) { }

	public override void Add(string label, Vector3 point, float time) { }

	public override void Draw() { }

	public string get_Label() { }

	public TrajectoryDebugPoints get_List() { }

	public float get_MaxTimeLimit() { }

	public float get_MinTimeLimit() { }

	public List get_Points() { }

	public string[] GetElementsList() { }

	protected Color NextColor() { }

	public void Reset() { }

}

